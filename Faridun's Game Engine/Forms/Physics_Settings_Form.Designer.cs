namespace GameEngine_Project
{
    partial class physicsSettingsForm
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
            this.GravityLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.GZTxtBox = new System.Windows.Forms.TextBox();
            this.GYTxtBox = new System.Windows.Forms.TextBox();
            this.GXTxtBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.PhysicsMaterialButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GravityLabel
            // 
            this.GravityLabel.AutoSize = true;
            this.GravityLabel.Location = new System.Drawing.Point(12, 9);
            this.GravityLabel.Name = "GravityLabel";
            this.GravityLabel.Size = new System.Drawing.Size(66, 13);
            this.GravityLabel.TabIndex = 0;
            this.GravityLabel.Text = "Гравитация";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.ForeColor = System.Drawing.Color.Blue;
            this.ZLabel.Location = new System.Drawing.Point(191, 35);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(14, 13);
            this.ZLabel.TabIndex = 1;
            this.ZLabel.Text = "Z";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.ForeColor = System.Drawing.Color.Green;
            this.Ylabel.Location = new System.Drawing.Point(101, 35);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(14, 13);
            this.Ylabel.TabIndex = 2;
            this.Ylabel.Text = "Y";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.ForeColor = System.Drawing.Color.Red;
            this.XLabel.Location = new System.Drawing.Point(12, 35);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(14, 13);
            this.XLabel.TabIndex = 3;
            this.XLabel.Text = "X";
            // 
            // GZTxtBox
            // 
            this.GZTxtBox.Location = new System.Drawing.Point(211, 32);
            this.GZTxtBox.Name = "GZTxtBox";
            this.GZTxtBox.Size = new System.Drawing.Size(61, 20);
            this.GZTxtBox.TabIndex = 6;
            // 
            // GYTxtBox
            // 
            this.GYTxtBox.Location = new System.Drawing.Point(121, 32);
            this.GYTxtBox.Name = "GYTxtBox";
            this.GYTxtBox.Size = new System.Drawing.Size(64, 20);
            this.GYTxtBox.TabIndex = 7;
            // 
            // GXTxtBox
            // 
            this.GXTxtBox.Location = new System.Drawing.Point(32, 32);
            this.GXTxtBox.Name = "GXTxtBox";
            this.GXTxtBox.Size = new System.Drawing.Size(63, 20);
            this.GXTxtBox.TabIndex = 8;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(198, 227);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // PhysicsMaterialButton
            // 
            this.PhysicsMaterialButton.Location = new System.Drawing.Point(12, 58);
            this.PhysicsMaterialButton.Name = "PhysicsMaterialButton";
            this.PhysicsMaterialButton.Size = new System.Drawing.Size(261, 23);
            this.PhysicsMaterialButton.TabIndex = 10;
            this.PhysicsMaterialButton.Text = "Выбрать стандартный физический материал";
            this.PhysicsMaterialButton.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // physicsSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PhysicsMaterialButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.GXTxtBox);
            this.Controls.Add(this.GYTxtBox);
            this.Controls.Add(this.GZTxtBox);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.GravityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "physicsSettingsForm";
            this.Text = "Настроки физики";
            this.Load += new System.EventHandler(this.physicsSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GravityLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox GZTxtBox;
        private System.Windows.Forms.TextBox GYTxtBox;
        private System.Windows.Forms.TextBox GXTxtBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button PhysicsMaterialButton;
        private System.Windows.Forms.Timer Timer;
    }
}