namespace GameEngine_Project
{
    partial class PlayerSettings
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ShowMouseArrow = new System.Windows.Forms.CheckBox();
            this.ChangeImageCursorButton = new System.Windows.Forms.Button();
            this.ChangeIconButton = new System.Windows.Forms.Button();
            this.NameOfCompanyTxtBox = new System.Windows.Forms.TextBox();
            this.ProductNameTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(197, 227);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
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
            // ShowMouseArrow
            // 
            this.ShowMouseArrow.AutoSize = true;
            this.ShowMouseArrow.Location = new System.Drawing.Point(12, 64);
            this.ShowMouseArrow.Name = "ShowMouseArrow";
            this.ShowMouseArrow.Size = new System.Drawing.Size(113, 17);
            this.ShowMouseArrow.TabIndex = 1;
            this.ShowMouseArrow.Text = "Показать курсор";
            this.ShowMouseArrow.UseVisualStyleBackColor = true;
            // 
            // ChangeImageCursorButton
            // 
            this.ChangeImageCursorButton.Location = new System.Drawing.Point(12, 87);
            this.ChangeImageCursorButton.Name = "ChangeImageCursorButton";
            this.ChangeImageCursorButton.Size = new System.Drawing.Size(189, 23);
            this.ChangeImageCursorButton.TabIndex = 2;
            this.ChangeImageCursorButton.Text = "Изменить изображения курсора";
            this.ChangeImageCursorButton.UseVisualStyleBackColor = true;
            // 
            // ChangeIconButton
            // 
            this.ChangeIconButton.Location = new System.Drawing.Point(12, 116);
            this.ChangeIconButton.Name = "ChangeIconButton";
            this.ChangeIconButton.Size = new System.Drawing.Size(129, 23);
            this.ChangeIconButton.TabIndex = 3;
            this.ChangeIconButton.Text = "Выбрать иконку окна";
            this.ChangeIconButton.UseVisualStyleBackColor = true;
            // 
            // NameOfCompanyTxtBox
            // 
            this.NameOfCompanyTxtBox.Location = new System.Drawing.Point(12, 12);
            this.NameOfCompanyTxtBox.Name = "NameOfCompanyTxtBox";
            this.NameOfCompanyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NameOfCompanyTxtBox.TabIndex = 4;
            this.NameOfCompanyTxtBox.Text = "Имя компании...";
            // 
            // ProductNameTxtBox
            // 
            this.ProductNameTxtBox.Location = new System.Drawing.Point(12, 38);
            this.ProductNameTxtBox.Name = "ProductNameTxtBox";
            this.ProductNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTxtBox.TabIndex = 5;
            this.ProductNameTxtBox.Text = "Имя продукта...";
            // 
            // PlayerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ProductNameTxtBox);
            this.Controls.Add(this.NameOfCompanyTxtBox);
            this.Controls.Add(this.ChangeIconButton);
            this.Controls.Add(this.ChangeImageCursorButton);
            this.Controls.Add(this.ShowMouseArrow);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Игрок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox ShowMouseArrow;
        private System.Windows.Forms.Button ChangeImageCursorButton;
        private System.Windows.Forms.Button ChangeIconButton;
        private System.Windows.Forms.TextBox NameOfCompanyTxtBox;
        private System.Windows.Forms.TextBox ProductNameTxtBox;
    }
}