﻿using Concentus.Oggfile;
using Concentus.Structs;
using CSCore.Opus.Memory;
using System;
using System.Buffers;
using System.IO;
using System.Threading;

/// CSCore.Opus
///  https://www.nuget.org/packages/CSCore.Opus/
///  https://github.com/StefH/WebDAV-AudioPlayer
/// 
/// MIT License
/// 
/// Copyright(c) 2017 Stef Heyenrath
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
/// 
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
/// 

namespace CSCore.Codecs.OPUS
{
    /// <seealso cref="IWaveSource" />
    public sealed class OpusSource : IWaveSource
    {
        private const int BitsPerSample = 16;
        private const int BytesPerSample = BitsPerSample / 8;

        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly CircularByteQueue _circularByteQueue = new CircularByteQueue(1024 * 1024);
        private readonly ArrayPool<byte> _buffer = ArrayPool<byte>.Shared;
        private readonly Stream _stream;
        private readonly OpusOggReadStream _opusReadStream;

        private long _position;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpusSource"/> class.
        /// </summary>
        /// <param name="stream">The stream.</param>
        /// <param name="sampleRate">The sample rate.</param>
        /// <param name="channels">The channels.</param>
        public OpusSource(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            if (!stream.CanRead)
            {
                throw new ArgumentException("Stream is not readable.", nameof(stream));
            }

            _stream = stream;
            
            WaveFormat = new WaveFormat(48000, BitsPerSample, 2);
            
            var decoder = new OpusDecoder(WaveFormat.SampleRate, WaveFormat.Channels);
            _opusReadStream = new OpusOggReadStream(decoder, stream);

            _cts.Token.Register(() =>
            {
                decoder.ResetState();
            });
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            int pos = 0;
            while (!_cts.IsCancellationRequested && _opusReadStream.HasNextPacket && pos < count)
            {
                short[] packets = _opusReadStream.DecodeNextPacket();
                if (packets != null && packets.Length > 0)
                {
                    int length = packets.Length * 2;
                    byte[] temp = _buffer.Rent(length);
                    try
                    {
                        Buffer.BlockCopy(packets, 0, temp, 0, length);

                        pos += temp.Length;

                        _circularByteQueue.Enqueue(temp, 0, length);
                    }
                    finally
                    {
                        _buffer.Return(temp);
                    }
                }
            }

            int bytesReadFromBuffer = _circularByteQueue.Dequeue(buffer, offset, count);

            _position += bytesReadFromBuffer;

            return bytesReadFromBuffer;
        }

        public WaveFormat WaveFormat { get; }

        public bool CanSeek => _stream.CanSeek;

        public long Position
        {
            get => _position;

            set
            {
                if (!CanSeek)
                {
                    throw new InvalidOperationException("Stream is not seekable.");
                }

                if (value < 0 || value > Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                // Clear the queue to remove pending samples
                _circularByteQueue.Clear();

                // Jump to the new position in the stream
                var playtime = TimeSpan.FromSeconds((double)value / (WaveFormat.SampleRate * WaveFormat.Channels * BytesPerSample));
                _opusReadStream.SeekTo(playtime);

                // Update the position to the seek position
                _position = Convert.ToInt64(_opusReadStream.CurrentTime.TotalSeconds * WaveFormat.SampleRate * WaveFormat.Channels * BytesPerSample);
            }
        }

        public long Length => CanSeek ? Convert.ToInt64(_opusReadStream.TotalTime.TotalSeconds * WaveFormat.SampleRate * WaveFormat.Channels * BytesPerSample) : 0;

        public void Dispose()
        {
            _cts?.Dispose();
        }
    }
}