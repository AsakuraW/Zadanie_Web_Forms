namespace SpeechControl
{
    partial class SpeechControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speech = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.voice = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // speech
            // 
            this.speech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speech.ForeColor = System.Drawing.Color.Red;
            this.speech.Location = new System.Drawing.Point(295, 10);
            this.speech.Name = "speech";
            this.speech.Size = new System.Drawing.Size(110, 29);
            this.speech.TabIndex = 0;
            this.speech.Text = "Speech";
            this.speech.UseVisualStyleBackColor = true;
            this.speech.Click += new System.EventHandler(this.speech_Click);
            // 
            // pause
            // 
            this.pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pause.Location = new System.Drawing.Point(411, 10);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(37, 29);
            this.pause.TabIndex = 1;
            this.pause.Text = "||";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // resume
            // 
            this.resume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resume.Location = new System.Drawing.Point(454, 10);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(37, 29);
            this.resume.TabIndex = 2;
            this.resume.Text = ">";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // stop
            // 
            this.stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop.Location = new System.Drawing.Point(497, 10);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 29);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // voice
            // 
            this.voice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.voice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.voice.ForeColor = System.Drawing.Color.White;
            this.voice.FormattingEnabled = true;
            this.voice.Location = new System.Drawing.Point(13, 10);
            this.voice.Name = "voice";
            this.voice.Size = new System.Drawing.Size(267, 32);
            this.voice.TabIndex = 5;
            this.voice.SelectedIndexChanged += new System.EventHandler(this.voice_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(13, 49);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(594, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = " ";
            // 
            // SpeechControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.voice);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.speech);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pause);
            this.Name = "SpeechControl";
            this.Size = new System.Drawing.Size(639, 94);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speech;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ComboBox voice;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}
