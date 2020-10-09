namespace GameEngine_Project
{
    partial class audioSettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.SpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PlaySpeedLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.AudioPlayButton = new System.Windows.Forms.Button();
            this.AudioValue = new System.Windows.Forms.Label();
            this.AudioValueNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioValueNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeedNumericUpDown
            // 
            this.SpeedNumericUpDown.Location = new System.Drawing.Point(144, 12);
            this.SpeedNumericUpDown.Name = "SpeedNumericUpDown";
            this.SpeedNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.SpeedNumericUpDown.TabIndex = 0;
            this.SpeedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PlaySpeedLabel
            // 
            this.PlaySpeedLabel.AutoSize = true;
            this.PlaySpeedLabel.Location = new System.Drawing.Point(12, 14);
            this.PlaySpeedLabel.Name = "PlaySpeedLabel";
            this.PlaySpeedLabel.Size = new System.Drawing.Size(126, 13);
            this.PlaySpeedLabel.TabIndex = 1;
            this.PlaySpeedLabel.Text = "Скорость пригрование:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // AudioPlayButton
            // 
            this.AudioPlayButton.Location = new System.Drawing.Point(12, 64);
            this.AudioPlayButton.Name = "AudioPlayButton";
            this.AudioPlayButton.Size = new System.Drawing.Size(154, 23);
            this.AudioPlayButton.TabIndex = 3;
            this.AudioPlayButton.Text = "Музыка для проигрование";
            this.AudioPlayButton.UseVisualStyleBackColor = true;
            // 
            // AudioValue
            // 
            this.AudioValue.AutoSize = true;
            this.AudioValue.Location = new System.Drawing.Point(12, 40);
            this.AudioValue.Name = "AudioValue";
            this.AudioValue.Size = new System.Drawing.Size(139, 13);
            this.AudioValue.TabIndex = 5;
            this.AudioValue.Text = "Громкость проигрование:";
            // 
            // AudioValueNUD
            // 
            this.AudioValueNUD.Location = new System.Drawing.Point(157, 38);
            this.AudioValueNUD.Name = "AudioValueNUD";
            this.AudioValueNUD.Size = new System.Drawing.Size(62, 20);
            this.AudioValueNUD.TabIndex = 4;
            this.AudioValueNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // audioSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AudioValue);
            this.Controls.Add(this.AudioValueNUD);
            this.Controls.Add(this.AudioPlayButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlaySpeedLabel);
            this.Controls.Add(this.SpeedNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "audioSettingsForm";
            this.Text = "Настройки звука";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AudioValueNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SpeedNumericUpDown;
        private System.Windows.Forms.Label PlaySpeedLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button AudioPlayButton;
        private System.Windows.Forms.Label AudioValue;
        private System.Windows.Forms.NumericUpDown AudioValueNUD;
    }
}