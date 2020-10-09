namespace GameEngine_Project
{
    partial class openGLEditorSettingsForm
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
            this.GLColorButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.FogCheckBox = new System.Windows.Forms.CheckBox();
            this.VSync = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GLColorButton
            // 
            this.GLColorButton.Location = new System.Drawing.Point(12, 12);
            this.GLColorButton.Name = "GLColorButton";
            this.GLColorButton.Size = new System.Drawing.Size(116, 23);
            this.GLColorButton.TabIndex = 0;
            this.GLColorButton.Text = "Выбрать цвет фона";
            this.GLColorButton.UseVisualStyleBackColor = true;
            this.GLColorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(197, 227);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Применить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // FogCheckBox
            // 
            this.FogCheckBox.AutoSize = true;
            this.FogCheckBox.Location = new System.Drawing.Point(12, 41);
            this.FogCheckBox.Name = "FogCheckBox";
            this.FogCheckBox.Size = new System.Drawing.Size(120, 17);
            this.FogCheckBox.TabIndex = 4;
            this.FogCheckBox.Text = "Туманный эффект";
            this.FogCheckBox.UseVisualStyleBackColor = true;
            // 
            // VSync
            // 
            this.VSync.AutoSize = true;
            this.VSync.Location = new System.Drawing.Point(12, 64);
            this.VSync.Name = "VSync";
            this.VSync.Size = new System.Drawing.Size(57, 17);
            this.VSync.TabIndex = 5;
            this.VSync.Text = "VSync";
            this.VSync.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // openGLEditorSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.VSync);
            this.Controls.Add(this.FogCheckBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.GLColorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "openGLEditorSettingsForm";
            this.Text = "Настройки OpenGL редактора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GLColorButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.CheckBox FogCheckBox;
        private System.Windows.Forms.CheckBox VSync;
        private System.Windows.Forms.Timer Timer;
    }
}