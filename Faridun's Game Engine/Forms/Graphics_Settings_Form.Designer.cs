namespace GameEngine_Project
{
    partial class graphicsSettingsForm
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
            this.VideoModeList = new System.Windows.Forms.ListBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.VMLabel = new System.Windows.Forms.Label();
            this.GraphicsListLabel = new System.Windows.Forms.Label();
            this.GraphicsListListBox = new System.Windows.Forms.ListBox();
            this.GraphicsInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VideoModeList
            // 
            this.VideoModeList.FormattingEnabled = true;
            this.VideoModeList.HorizontalScrollbar = true;
            this.VideoModeList.Location = new System.Drawing.Point(12, 25);
            this.VideoModeList.Name = "VideoModeList";
            this.VideoModeList.Size = new System.Drawing.Size(390, 82);
            this.VideoModeList.TabIndex = 0;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(327, 230);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // VMLabel
            // 
            this.VMLabel.AutoSize = true;
            this.VMLabel.Location = new System.Drawing.Point(12, 9);
            this.VMLabel.Name = "VMLabel";
            this.VMLabel.Size = new System.Drawing.Size(204, 13);
            this.VMLabel.TabIndex = 4;
            this.VMLabel.Text = "Список разрешений вашего монитора:";
            // 
            // GraphicsListLabel
            // 
            this.GraphicsListLabel.AutoSize = true;
            this.GraphicsListLabel.Location = new System.Drawing.Point(12, 113);
            this.GraphicsListLabel.Name = "GraphicsListLabel";
            this.GraphicsListLabel.Size = new System.Drawing.Size(159, 13);
            this.GraphicsListLabel.TabIndex = 6;
            this.GraphicsListLabel.Text = "Список графических уровней:";
            // 
            // GraphicsListListBox
            // 
            this.GraphicsListListBox.FormattingEnabled = true;
            this.GraphicsListListBox.HorizontalScrollbar = true;
            this.GraphicsListListBox.Location = new System.Drawing.Point(12, 129);
            this.GraphicsListListBox.Name = "GraphicsListListBox";
            this.GraphicsListListBox.Size = new System.Drawing.Size(390, 82);
            this.GraphicsListListBox.TabIndex = 5;
            // 
            // GraphicsInfo
            // 
            this.GraphicsInfo.AutoSize = true;
            this.GraphicsInfo.Location = new System.Drawing.Point(12, 214);
            this.GraphicsInfo.Name = "GraphicsInfo";
            this.GraphicsInfo.Size = new System.Drawing.Size(401, 13);
            this.GraphicsInfo.TabIndex = 7;
            this.GraphicsInfo.Text = "Редоктировать или создовать графические уровни вы можете в инспекторе.";
            // 
            // graphicsSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.GraphicsInfo);
            this.Controls.Add(this.GraphicsListLabel);
            this.Controls.Add(this.GraphicsListListBox);
            this.Controls.Add(this.VMLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.VideoModeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "graphicsSettingsForm";
            this.Text = "Настройки графики";
            this.Load += new System.EventHandler(this.graphicsSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox VideoModeList;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label VMLabel;
        private System.Windows.Forms.Label GraphicsListLabel;
        private System.Windows.Forms.ListBox GraphicsListListBox;
        private System.Windows.Forms.Label GraphicsInfo;
    }
}