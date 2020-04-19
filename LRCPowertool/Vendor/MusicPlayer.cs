using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// CSCore MusicPlayer, modified version for better volume support. The original license of CSCore:
/// 
/// ## Microsoft Public License (Ms-PL) ##
/// 
/// Microsoft Public License (Ms-PL)
/// 
/// This license governs use of the accompanying software. If you use the software, you accept this license. If you do not accept the license, do not use the software.
/// 
/// #### 1. Definitions ####
/// 
/// The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same meaning here as under U.S. copyright law.
/// 
/// A "contribution" is the original software, or any additions or changes to the software.
/// 
/// A "contributor" is any person that distributes its contribution under this license.
/// 
/// "Licensed patents" are a contributor's patent claims that read directly on its contribution.
/// 
/// #### 2. Grant of Rights ####
/// 
/// (A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.
/// 
/// (B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.
/// 
/// #### 3. Conditions and Limitations ####
/// 
/// (A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.
/// 
/// (B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, your patent license from such contributor to the software ends automatically.
/// 
/// (C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution notices that are present in the software.
/// 
/// (D) If you distribute any portion of the software in source code form, you may do so only under this license by including a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object code form, you may only do so under a license that complies with this license.
/// 
/// (E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a particular purpose and non-infringement.
/// 
namespace AudioPlayerSample
{
    class MusicPlayer
    {
        private ISoundOut _soundOut;
        private IWaveSource _waveSource;
        private int volume = 100;

        public event EventHandler<PlaybackStoppedEventArgs> PlaybackStopped;

        public PlaybackState PlaybackState
        {
            get
            {
                if (_soundOut != null)
                    return _soundOut.PlaybackState;
                return PlaybackState.Stopped;
            }
        }

        public TimeSpan Position
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetPosition();
                return TimeSpan.Zero;
            }
            set
            {
                if (_waveSource != null)
                    _waveSource.SetPosition(value);
            }
        }

        public TimeSpan Length
        {
            get
            {
                if (_waveSource != null)
                    return _waveSource.GetLength();
                return TimeSpan.Zero;
            }
        }

        public bool HasMedia
        {
            get
            {
                return _soundOut != null;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
                if (_soundOut != null)
                {
                    _soundOut.Volume = Math.Min(1.0f, Math.Max(value / 100f, 0f));
                }
            }
        }

        public void Open(string filename)
        {
            Close();

            _waveSource =
                CodecFactory.Instance.GetCodec(filename)
                    .ToSampleSource()
                    .ToStereo()
                    .ToWaveSource();
            _soundOut = new WasapiOut() { Latency = 15, Device = MMDeviceEnumerator.DefaultAudioEndpoint(DataFlow.Render, Role.Multimedia) };
            _soundOut.Initialize(_waveSource);
            _soundOut.Volume = Math.Min(1.0f, Math.Max(volume / 100f, 0f));
            if (PlaybackStopped != null) _soundOut.Stopped += PlaybackStopped;
        }

        public void Play()
        {
            if (_soundOut != null)
                _soundOut.Play();
        }

        public void Pause()
        {
            if (_soundOut != null)
                _soundOut.Pause();
        }

        public void Stop()
        {
            if (_soundOut != null)
                _soundOut.Stop();
        }

        public void Close()
        {
            Stop();
            if (_soundOut != null)
            {
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_waveSource != null)
            {
                _waveSource.Dispose();
                _waveSource = null;
            }
        }
    }
}
