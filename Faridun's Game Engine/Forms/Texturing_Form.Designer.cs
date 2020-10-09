namespace GameEngine_Project
{
    partial class TexturingForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButtom = new System.Windows.Forms.Button();
            this.ImageModeListBox = new System.Windows.Forms.CheckedListBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.FileRoadTextBox = new System.Windows.Forms.TextBox();
            this.ImageRoadTextBox = new System.Windows.Forms.TextBox();
            this.SelectFromProject = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SizeImage = new System.Windows.Forms.Label();
            this.FormatImage = new System.Windows.Forms.Label();
            this.ByteImage = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SelectShaderBox = new System.Windows.Forms.GroupBox();
            this.AddShaderButton = new System.Windows.Forms.Button();
            this.SelectShaderTextBox = new System.Windows.Forms.TextBox();
            this.SelectShaderButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SelectShaderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(497, 327);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButtom
            // 
            this.CancelButtom.Location = new System.Drawing.Point(12, 327);
            this.CancelButtom.Name = "CancelButtom";
            this.CancelButtom.Size = new System.Drawing.Size(75, 23);
            this.CancelButtom.TabIndex = 1;
            this.CancelButtom.Text = "Отмена";
            this.CancelButtom.UseVisualStyleBackColor = true;
            this.CancelButtom.Click += new System.EventHandler(this.CancelButtom_Click);
            // 
            // ImageModeListBox
            // 
            this.ImageModeListBox.FormattingEnabled = true;
            this.ImageModeListBox.Location = new System.Drawing.Point(317, 12);
            this.ImageModeListBox.Name = "ImageModeListBox";
            this.ImageModeListBox.Size = new System.Drawing.Size(255, 79);
            this.ImageModeListBox.TabIndex = 2;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(206, 11);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(105, 23);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Импортировать";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // FileRoadTextBox
            // 
            this.FileRoadTextBox.Location = new System.Drawing.Point(12, 13);
            this.FileRoadTextBox.Name = "FileRoadTextBox";
            this.FileRoadTextBox.Size = new System.Drawing.Size(188, 20);
            this.FileRoadTextBox.TabIndex = 4;
            // 
            // ImageRoadTextBox
            // 
            this.ImageRoadTextBox.Location = new System.Drawing.Point(12, 42);
            this.ImageRoadTextBox.Name = "ImageRoadTextBox";
            this.ImageRoadTextBox.Size = new System.Drawing.Size(188, 20);
            this.ImageRoadTextBox.TabIndex = 6;
            // 
            // SelectFromProject
            // 
            this.SelectFromProject.Location = new System.Drawing.Point(206, 40);
            this.SelectFromProject.Name = "SelectFromProject";
            this.SelectFromProject.Size = new System.Drawing.Size(105, 23);
            this.SelectFromProject.TabIndex = 5;
            this.SelectFromProject.Text = "Выбрать";
            this.SelectFromProject.UseVisualStyleBackColor = true;
            this.SelectFromProject.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(12, 68);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(106, 23);
            this.ViewButton.TabIndex = 9;
            this.ViewButton.Text = "Просмотреть";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // SizeImage
            // 
            this.SizeImage.AutoSize = true;
            this.SizeImage.Location = new System.Drawing.Point(9, 111);
            this.SizeImage.Name = "SizeImage";
            this.SizeImage.Size = new System.Drawing.Size(33, 13);
            this.SizeImage.TabIndex = 10;
            this.SizeImage.Text = "Label";
            // 
            // FormatImage
            // 
            this.FormatImage.AutoSize = true;
            this.FormatImage.Location = new System.Drawing.Point(9, 197);
            this.FormatImage.Name = "FormatImage";
            this.FormatImage.Size = new System.Drawing.Size(33, 13);
            this.FormatImage.TabIndex = 11;
            this.FormatImage.Text = "Label";
            // 
            // ByteImage
            // 
            this.ByteImage.AutoSize = true;
            this.ByteImage.Location = new System.Drawing.Point(9, 155);
            this.ByteImage.Name = "ByteImage";
            this.ByteImage.Size = new System.Drawing.Size(33, 13);
            this.ByteImage.TabIndex = 12;
            this.ByteImage.Text = "Label";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 237);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 13);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Label";
            // 
            // SelectShaderBox
            // 
            this.SelectShaderBox.Controls.Add(this.AddShaderButton);
            this.SelectShaderBox.Controls.Add(this.SelectShaderTextBox);
            this.SelectShaderBox.Controls.Add(this.SelectShaderButton);
            this.SelectShaderBox.Location = new System.Drawing.Point(317, 97);
            this.SelectShaderBox.Name = "SelectShaderBox";
            this.SelectShaderBox.Size = new System.Drawing.Size(253, 77);
            this.SelectShaderBox.TabIndex = 27;
            this.SelectShaderBox.TabStop = false;
            this.SelectShaderBox.Text = "Выбрать и добавить Shader";
            // 
            // AddShaderButton
            // 
            this.AddShaderButton.Location = new System.Drawing.Point(6, 48);
            this.AddShaderButton.Name = "AddShaderButton";
            this.AddShaderButton.Size = new System.Drawing.Size(241, 23);
            this.AddShaderButton.TabIndex = 6;
            this.AddShaderButton.Text = "Добавить Shader\r\n\r\n";
            this.AddShaderButton.UseVisualStyleBackColor = true;
            // 
            // SelectShaderTextBox
            // 
            this.SelectShaderTextBox.Location = new System.Drawing.Point(90, 21);
            this.SelectShaderTextBox.Name = "SelectShaderTextBox";
            this.SelectShaderTextBox.Size = new System.Drawing.Size(157, 20);
            this.SelectShaderTextBox.TabIndex = 5;
            // 
            // SelectShaderButton
            // 
            this.SelectShaderButton.Location = new System.Drawing.Point(9, 19);
            this.SelectShaderButton.Name = "SelectShaderButton";
            this.SelectShaderButton.Size = new System.Drawing.Size(75, 23);
            this.SelectShaderButton.TabIndex = 0;
            this.SelectShaderButton.Text = "Выбрать";
            this.SelectShaderButton.UseVisualStyleBackColor = true;
            this.SelectShaderButton.Click += new System.EventHandler(this.SelectShaderButton_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TexturingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.SelectShaderBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ByteImage);
            this.Controls.Add(this.FormatImage);
            this.Controls.Add(this.SizeImage);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ImageRoadTextBox);
            this.Controls.Add(this.SelectFromProject);
            this.Controls.Add(this.FileRoadTextBox);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ImageModeListBox);
            this.Controls.Add(this.CancelButtom);
            this.Controls.Add(this.AddButton);
            this.Name = "TexturingForm";
            this.Text = "Текстурирование";
            this.Load += new System.EventHandler(this.TexturingForm_Load);
            this.SelectShaderBox.ResumeLayout(false);
            this.SelectShaderBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButtom;
        private System.Windows.Forms.CheckedListBox ImageModeListBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox FileRoadTextBox;
        private System.Windows.Forms.TextBox ImageRoadTextBox;
        private System.Windows.Forms.Button SelectFromProject;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label SizeImage;
        private System.Windows.Forms.Label FormatImage;
        private System.Windows.Forms.Label ByteImage;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox SelectShaderBox;
        private System.Windows.Forms.Button AddShaderButton;
        private System.Windows.Forms.TextBox SelectShaderTextBox;
        private System.Windows.Forms.Button SelectShaderButton;
        private System.Windows.Forms.Timer Timer;
    }
}