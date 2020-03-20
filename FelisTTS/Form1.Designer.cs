namespace FelisTTS
{
    partial class Form1
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
            this.voiceTextBox = new System.Windows.Forms.TextBox();
            this.TTSButton = new System.Windows.Forms.Button();
            this.deviceButton = new System.Windows.Forms.Button();
            this.voicesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // voiceTextBox
            // 
            this.voiceTextBox.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.voiceTextBox.Location = new System.Drawing.Point(12, 12);
            this.voiceTextBox.Multiline = true;
            this.voiceTextBox.Name = "voiceTextBox";
            this.voiceTextBox.Size = new System.Drawing.Size(750, 176);
            this.voiceTextBox.TabIndex = 0;
            this.voiceTextBox.Text = "TTS in here";
            // 
            // TTSButton
            // 
            this.TTSButton.Location = new System.Drawing.Point(648, 233);
            this.TTSButton.Name = "TTSButton";
            this.TTSButton.Size = new System.Drawing.Size(114, 49);
            this.TTSButton.TabIndex = 1;
            this.TTSButton.Text = "TTS";
            this.TTSButton.UseVisualStyleBackColor = true;
            this.TTSButton.Click += new System.EventHandler(this.TTSButton_Click);
            // 
            // deviceButton
            // 
            this.deviceButton.Location = new System.Drawing.Point(12, 233);
            this.deviceButton.Name = "deviceButton";
            this.deviceButton.Size = new System.Drawing.Size(128, 49);
            this.deviceButton.TabIndex = 2;
            this.deviceButton.Text = "Audio Device";
            this.deviceButton.UseVisualStyleBackColor = true;
            this.deviceButton.Click += new System.EventHandler(this.deviceButton_Click);
            // 
            // voicesBox
            // 
            this.voicesBox.FormattingEnabled = true;
            this.voicesBox.Location = new System.Drawing.Point(185, 241);
            this.voicesBox.Name = "voicesBox";
            this.voicesBox.Size = new System.Drawing.Size(403, 23);
            this.voicesBox.TabIndex = 3;
            this.voicesBox.SelectedIndexChanged += new System.EventHandler(this.voicesBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 294);
            this.Controls.Add(this.voicesBox);
            this.Controls.Add(this.deviceButton);
            this.Controls.Add(this.TTSButton);
            this.Controls.Add(this.voiceTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voiceTextBox;
        private System.Windows.Forms.Button TTSButton;
        private System.Windows.Forms.Button deviceButton;
        private System.Windows.Forms.ComboBox voicesBox;
    }
}

