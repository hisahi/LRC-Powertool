namespace LRCPowertool
{
    partial class AboutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelDependencies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(222, 114);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(50, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(200, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "LRC Powertool";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Location = new System.Drawing.Point(50, 38);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(200, 20);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "by Sampo Hippeläinen (hisahi) 2020";
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(9, 114);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(200, 20);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "program version ";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 16);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelDependencies
            // 
            this.labelDependencies.Location = new System.Drawing.Point(9, 69);
            this.labelDependencies.Name = "labelDependencies";
            this.labelDependencies.Size = new System.Drawing.Size(288, 40);
            this.labelDependencies.TabIndex = 5;
            this.labelDependencies.Text = "Used libraries: Concentus, CSCore, NVorbis, TagLibSharp.\r\nPlease see their licens" +
    "es in the LICENSE.TXT file included with this executable.";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 149);
            this.Controls.Add(this.labelDependencies);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelDependencies;
    }
}