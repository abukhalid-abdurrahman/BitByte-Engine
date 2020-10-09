namespace GameEngine_Project
{
    partial class Add3DModelForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.FormatImage = new System.Windows.Forms.Label();
            this.SizeImage = new System.Windows.Forms.Label();
            this.ImageRoadTextBox = new System.Windows.Forms.TextBox();
            this.SelectFromProject = new System.Windows.Forms.Button();
            this.FileRoadTextBox = new System.Windows.Forms.TextBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.CancelButtom = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MaterialBox = new System.Windows.Forms.GroupBox();
            this.AddMaterialButton = new System.Windows.Forms.Button();
            this.SelectMaterialTextBox = new System.Windows.Forms.TextBox();
            this.SelectMaterialButton = new System.Windows.Forms.Button();
            this.Creat_AddMaterialButton = new System.Windows.Forms.Button();
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.CreatMaterialBox = new System.Windows.Forms.GroupBox();
            this.NameMaterialTextBox = new System.Windows.Forms.TextBox();
            this.MaterialNameLabel = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.SelectScriptBox = new System.Windows.Forms.GroupBox();
            this.AddScriptButton = new System.Windows.Forms.Button();
            this.SelectScriptTextBox = new System.Windows.Forms.TextBox();
            this.SelectScriptButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.MaterialBox.SuspendLayout();
            this.CreatMaterialBox.SuspendLayout();
            this.SelectScriptBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 183);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(33, 13);
            this.NameLabel.TabIndex = 24;
            this.NameLabel.Text = "Label";
            // 
            // FormatImage
            // 
            this.FormatImage.AutoSize = true;
            this.FormatImage.Location = new System.Drawing.Point(11, 143);
            this.FormatImage.Name = "FormatImage";
            this.FormatImage.Size = new System.Drawing.Size(33, 13);
            this.FormatImage.TabIndex = 22;
            this.FormatImage.Text = "Label";
            // 
            // SizeImage
            // 
            this.SizeImage.AutoSize = true;
            this.SizeImage.Location = new System.Drawing.Point(11, 115);
            this.SizeImage.Name = "SizeImage";
            this.SizeImage.Size = new System.Drawing.Size(33, 13);
            this.SizeImage.TabIndex = 21;
            this.SizeImage.Text = "Label";
            // 
            // ImageRoadTextBox
            // 
            this.ImageRoadTextBox.Location = new System.Drawing.Point(14, 43);
            this.ImageRoadTextBox.Name = "ImageRoadTextBox";
            this.ImageRoadTextBox.Size = new System.Drawing.Size(188, 20);
            this.ImageRoadTextBox.TabIndex = 19;
            // 
            // SelectFromProject
            // 
            this.SelectFromProject.Location = new System.Drawing.Point(208, 41);
            this.SelectFromProject.Name = "SelectFromProject";
            this.SelectFromProject.Size = new System.Drawing.Size(105, 23);
            this.SelectFromProject.TabIndex = 18;
            this.SelectFromProject.Text = "Выбрать";
            this.SelectFromProject.UseVisualStyleBackColor = true;
            this.SelectFromProject.Click += new System.EventHandler(this.SelectFromProject_Click);
            // 
            // FileRoadTextBox
            // 
            this.FileRoadTextBox.Location = new System.Drawing.Point(14, 14);
            this.FileRoadTextBox.Name = "FileRoadTextBox";
            this.FileRoadTextBox.Size = new System.Drawing.Size(188, 20);
            this.FileRoadTextBox.TabIndex = 17;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(208, 12);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(105, 23);
            this.ImportButton.TabIndex = 16;
            this.ImportButton.Text = "Импортировать";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // CancelButtom
            // 
            this.CancelButtom.Location = new System.Drawing.Point(14, 328);
            this.CancelButtom.Name = "CancelButtom";
            this.CancelButtom.Size = new System.Drawing.Size(75, 23);
            this.CancelButtom.TabIndex = 15;
            this.CancelButtom.Text = "Отмена";
            this.CancelButtom.UseVisualStyleBackColor = true;
            this.CancelButtom.Click += new System.EventHandler(this.CancelButtom_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(499, 328);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // MaterialBox
            // 
            this.MaterialBox.Controls.Add(this.AddMaterialButton);
            this.MaterialBox.Controls.Add(this.SelectMaterialTextBox);
            this.MaterialBox.Controls.Add(this.SelectMaterialButton);
            this.MaterialBox.Location = new System.Drawing.Point(319, 124);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(253, 77);
            this.MaterialBox.TabIndex = 25;
            this.MaterialBox.TabStop = false;
            this.MaterialBox.Text = "Выбрать и добавить материал";
            // 
            // AddMaterialButton
            // 
            this.AddMaterialButton.Location = new System.Drawing.Point(6, 48);
            this.AddMaterialButton.Name = "AddMaterialButton";
            this.AddMaterialButton.Size = new System.Drawing.Size(241, 23);
            this.AddMaterialButton.TabIndex = 6;
            this.AddMaterialButton.Text = "Добавить материал";
            this.AddMaterialButton.UseVisualStyleBackColor = true;
            // 
            // SelectMaterialTextBox
            // 
            this.SelectMaterialTextBox.Location = new System.Drawing.Point(90, 21);
            this.SelectMaterialTextBox.Name = "SelectMaterialTextBox";
            this.SelectMaterialTextBox.Size = new System.Drawing.Size(157, 20);
            this.SelectMaterialTextBox.TabIndex = 5;
            // 
            // SelectMaterialButton
            // 
            this.SelectMaterialButton.Location = new System.Drawing.Point(9, 19);
            this.SelectMaterialButton.Name = "SelectMaterialButton";
            this.SelectMaterialButton.Size = new System.Drawing.Size(75, 23);
            this.SelectMaterialButton.TabIndex = 0;
            this.SelectMaterialButton.Text = "Выбрать";
            this.SelectMaterialButton.UseVisualStyleBackColor = true;
            this.SelectMaterialButton.Click += new System.EventHandler(this.SelectMaterialButton_Click);
            // 
            // Creat_AddMaterialButton
            // 
            this.Creat_AddMaterialButton.Location = new System.Drawing.Point(6, 75);
            this.Creat_AddMaterialButton.Name = "Creat_AddMaterialButton";
            this.Creat_AddMaterialButton.Size = new System.Drawing.Size(241, 23);
            this.Creat_AddMaterialButton.TabIndex = 0;
            this.Creat_AddMaterialButton.Text = "Создать и добавить материал";
            this.Creat_AddMaterialButton.UseVisualStyleBackColor = true;
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.Location = new System.Drawing.Point(6, 19);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(95, 23);
            this.SelectColorButton.TabIndex = 1;
            this.SelectColorButton.Text = "Выбрать цвет";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // CreatMaterialBox
            // 
            this.CreatMaterialBox.Controls.Add(this.NameMaterialTextBox);
            this.CreatMaterialBox.Controls.Add(this.MaterialNameLabel);
            this.CreatMaterialBox.Controls.Add(this.ColorPanel);
            this.CreatMaterialBox.Controls.Add(this.Creat_AddMaterialButton);
            this.CreatMaterialBox.Controls.Add(this.SelectColorButton);
            this.CreatMaterialBox.Location = new System.Drawing.Point(319, 14);
            this.CreatMaterialBox.Name = "CreatMaterialBox";
            this.CreatMaterialBox.Size = new System.Drawing.Size(253, 104);
            this.CreatMaterialBox.TabIndex = 26;
            this.CreatMaterialBox.TabStop = false;
            this.CreatMaterialBox.Text = "Создать материал";
            // 
            // NameMaterialTextBox
            // 
            this.NameMaterialTextBox.Location = new System.Drawing.Point(60, 48);
            this.NameMaterialTextBox.Name = "NameMaterialTextBox";
            this.NameMaterialTextBox.Size = new System.Drawing.Size(187, 20);
            this.NameMaterialTextBox.TabIndex = 4;
            this.NameMaterialTextBox.Click += new System.EventHandler(this.NameMaterialTextBox_Click);
            this.NameMaterialTextBox.DoubleClick += new System.EventHandler(this.NameMaterialTextBox_DoubleClick);
            // 
            // MaterialNameLabel
            // 
            this.MaterialNameLabel.AutoSize = true;
            this.MaterialNameLabel.Location = new System.Drawing.Point(6, 55);
            this.MaterialNameLabel.Name = "MaterialNameLabel";
            this.MaterialNameLabel.Size = new System.Drawing.Size(33, 13);
            this.MaterialNameLabel.TabIndex = 3;
            this.MaterialNameLabel.Text = "Label";
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.White;
            this.ColorPanel.Location = new System.Drawing.Point(107, 19);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(140, 23);
            this.ColorPanel.TabIndex = 2;
            // 
            // SelectScriptBox
            // 
            this.SelectScriptBox.Controls.Add(this.AddScriptButton);
            this.SelectScriptBox.Controls.Add(this.SelectScriptTextBox);
            this.SelectScriptBox.Controls.Add(this.SelectScriptButton);
            this.SelectScriptBox.Location = new System.Drawing.Point(321, 207);
            this.SelectScriptBox.Name = "SelectScriptBox";
            this.SelectScriptBox.Size = new System.Drawing.Size(253, 77);
            this.SelectScriptBox.TabIndex = 26;
            this.SelectScriptBox.TabStop = false;
            this.SelectScriptBox.Text = "Выбрать и добавить скрипт";
            // 
            // AddScriptButton
            // 
            this.AddScriptButton.Location = new System.Drawing.Point(6, 48);
            this.AddScriptButton.Name = "AddScriptButton";
            this.AddScriptButton.Size = new System.Drawing.Size(241, 23);
            this.AddScriptButton.TabIndex = 6;
            this.AddScriptButton.Text = "Добавить скрипт\r\n";
            this.AddScriptButton.UseVisualStyleBackColor = true;
            // 
            // SelectScriptTextBox
            // 
            this.SelectScriptTextBox.Location = new System.Drawing.Point(90, 21);
            this.SelectScriptTextBox.Name = "SelectScriptTextBox";
            this.SelectScriptTextBox.Size = new System.Drawing.Size(157, 20);
            this.SelectScriptTextBox.TabIndex = 5;
            // 
            // SelectScriptButton
            // 
            this.SelectScriptButton.Location = new System.Drawing.Point(9, 19);
            this.SelectScriptButton.Name = "SelectScriptButton";
            this.SelectScriptButton.Size = new System.Drawing.Size(75, 23);
            this.SelectScriptButton.TabIndex = 0;
            this.SelectScriptButton.Text = "Выбрать";
            this.SelectScriptButton.UseVisualStyleBackColor = true;
            this.SelectScriptButton.Click += new System.EventHandler(this.SelectScriptButton_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Add3DModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.SelectScriptBox);
            this.Controls.Add(this.CreatMaterialBox);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FormatImage);
            this.Controls.Add(this.SizeImage);
            this.Controls.Add(this.ImageRoadTextBox);
            this.Controls.Add(this.SelectFromProject);
            this.Controls.Add(this.FileRoadTextBox);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.CancelButtom);
            this.Controls.Add(this.AddButton);
            this.Name = "Add3DModelForm";
            this.Text = "Добавление 3D Модели";
            this.Load += new System.EventHandler(this.Add3DModelForm_Load);
            this.Click += new System.EventHandler(this.Add3DModelForm_Click);
            this.MaterialBox.ResumeLayout(false);
            this.MaterialBox.PerformLayout();
            this.CreatMaterialBox.ResumeLayout(false);
            this.CreatMaterialBox.PerformLayout();
            this.SelectScriptBox.ResumeLayout(false);
            this.SelectScriptBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FormatImage;
        private System.Windows.Forms.Label SizeImage;
        private System.Windows.Forms.TextBox ImageRoadTextBox;
        private System.Windows.Forms.Button SelectFromProject;
        private System.Windows.Forms.TextBox FileRoadTextBox;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button CancelButtom;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox MaterialBox;
        private System.Windows.Forms.Button Creat_AddMaterialButton;
        private System.Windows.Forms.Button SelectColorButton;
        private System.Windows.Forms.GroupBox CreatMaterialBox;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Label MaterialNameLabel;
        private System.Windows.Forms.TextBox NameMaterialTextBox;
        private System.Windows.Forms.Button SelectMaterialButton;
        private System.Windows.Forms.TextBox SelectMaterialTextBox;
        private System.Windows.Forms.Button AddMaterialButton;
        private System.Windows.Forms.GroupBox SelectScriptBox;
        private System.Windows.Forms.Button AddScriptButton;
        private System.Windows.Forms.TextBox SelectScriptTextBox;
        private System.Windows.Forms.Button SelectScriptButton;
        private System.Windows.Forms.Timer Timer;
    }
}