namespace GameEngine_Project
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.RoadLabel = new System.Windows.Forms.Label();
            this.RoadProjectOpenTextBox = new System.Windows.Forms.TextBox();
            this.ButtonChoos = new System.Windows.Forms.Button();
            this.ButtonSelectFolder = new System.Windows.Forms.Button();
            this.CreatProjectTextBoxRoad = new System.Windows.Forms.TextBox();
            this.RoadLabel2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.OpenProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.ProjectsGroupBox = new System.Windows.Forms.GroupBox();
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.OpenProjectGroupBox.SuspendLayout();
            this.CreateProjectGroupBox.SuspendLayout();
            this.ProjectsGroupBox.SuspendLayout();
            this.AccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoadLabel
            // 
            this.RoadLabel.AutoSize = true;
            this.RoadLabel.Location = new System.Drawing.Point(9, 37);
            this.RoadLabel.Name = "RoadLabel";
            this.RoadLabel.Size = new System.Drawing.Size(34, 13);
            this.RoadLabel.TabIndex = 7;
            this.RoadLabel.Text = "Путь:";
            this.RoadLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // RoadProjectOpenTextBox
            // 
            this.RoadProjectOpenTextBox.Location = new System.Drawing.Point(49, 34);
            this.RoadProjectOpenTextBox.Name = "RoadProjectOpenTextBox";
            this.RoadProjectOpenTextBox.Size = new System.Drawing.Size(213, 20);
            this.RoadProjectOpenTextBox.TabIndex = 6;
            this.RoadProjectOpenTextBox.TextChanged += new System.EventHandler(this.roadProjectOpenTextBox_TextChanged);
            // 
            // ButtonChoos
            // 
            this.ButtonChoos.Location = new System.Drawing.Point(268, 32);
            this.ButtonChoos.Name = "ButtonChoos";
            this.ButtonChoos.Size = new System.Drawing.Size(106, 23);
            this.ButtonChoos.TabIndex = 5;
            this.ButtonChoos.Text = "Выбрать...";
            this.ButtonChoos.UseVisualStyleBackColor = true;
            this.ButtonChoos.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonSelectFolder
            // 
            this.ButtonSelectFolder.Location = new System.Drawing.Point(263, 19);
            this.ButtonSelectFolder.Name = "ButtonSelectFolder";
            this.ButtonSelectFolder.Size = new System.Drawing.Size(97, 23);
            this.ButtonSelectFolder.TabIndex = 0;
            this.ButtonSelectFolder.Text = "Выбор...";
            this.ButtonSelectFolder.UseVisualStyleBackColor = true;
            this.ButtonSelectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatProjectTextBoxRoad
            // 
            this.CreatProjectTextBoxRoad.Location = new System.Drawing.Point(49, 21);
            this.CreatProjectTextBoxRoad.Name = "CreatProjectTextBoxRoad";
            this.CreatProjectTextBoxRoad.Size = new System.Drawing.Size(208, 20);
            this.CreatProjectTextBoxRoad.TabIndex = 1;
            // 
            // RoadLabel2
            // 
            this.RoadLabel2.AutoSize = true;
            this.RoadLabel2.Location = new System.Drawing.Point(9, 24);
            this.RoadLabel2.Name = "RoadLabel2";
            this.RoadLabel2.Size = new System.Drawing.Size(34, 13);
            this.RoadLabel2.TabIndex = 2;
            this.RoadLabel2.Text = "Путь:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 59);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(32, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Имя:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(49, 56);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(208, 20);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(6, 82);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(368, 23);
            this.ButtonCreate.TabIndex = 11;
            this.ButtonCreate.Text = "Создать проект!!!";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(6, 17);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(223, 186);
            this.ProjectListBox.TabIndex = 12;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(136, 256);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(93, 23);
            this.OK_Button.TabIndex = 13;
            this.OK_Button.Text = "ОК";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // OpenProjectGroupBox
            // 
            this.OpenProjectGroupBox.Controls.Add(this.ButtonChoos);
            this.OpenProjectGroupBox.Controls.Add(this.RoadProjectOpenTextBox);
            this.OpenProjectGroupBox.Controls.Add(this.RoadLabel);
            this.OpenProjectGroupBox.Location = new System.Drawing.Point(12, 125);
            this.OpenProjectGroupBox.Name = "OpenProjectGroupBox";
            this.OpenProjectGroupBox.Size = new System.Drawing.Size(383, 78);
            this.OpenProjectGroupBox.TabIndex = 14;
            this.OpenProjectGroupBox.TabStop = false;
            this.OpenProjectGroupBox.Text = "Открыть проект";
            // 
            // CreateProjectGroupBox
            // 
            this.CreateProjectGroupBox.Controls.Add(this.ButtonCreate);
            this.CreateProjectGroupBox.Controls.Add(this.RoadLabel2);
            this.CreateProjectGroupBox.Controls.Add(this.CreatProjectTextBoxRoad);
            this.CreateProjectGroupBox.Controls.Add(this.NameTextBox);
            this.CreateProjectGroupBox.Controls.Add(this.NameLabel);
            this.CreateProjectGroupBox.Controls.Add(this.ButtonSelectFolder);
            this.CreateProjectGroupBox.Location = new System.Drawing.Point(12, 7);
            this.CreateProjectGroupBox.Name = "CreateProjectGroupBox";
            this.CreateProjectGroupBox.Size = new System.Drawing.Size(383, 112);
            this.CreateProjectGroupBox.TabIndex = 8;
            this.CreateProjectGroupBox.TabStop = false;
            this.CreateProjectGroupBox.Text = "Создать проект";
            // 
            // ProjectsGroupBox
            // 
            this.ProjectsGroupBox.Controls.Add(this.OK_Button);
            this.ProjectsGroupBox.Controls.Add(this.ProjectListBox);
            this.ProjectsGroupBox.Location = new System.Drawing.Point(401, 7);
            this.ProjectsGroupBox.Name = "ProjectsGroupBox";
            this.ProjectsGroupBox.Size = new System.Drawing.Size(237, 290);
            this.ProjectsGroupBox.TabIndex = 9;
            this.ProjectsGroupBox.TabStop = false;
            this.ProjectsGroupBox.Text = "Проекты";
            // 
            // AccountGroupBox
            // 
            this.AccountGroupBox.Controls.Add(this.PasswordTextBox);
            this.AccountGroupBox.Controls.Add(this.PasswordLabel);
            this.AccountGroupBox.Controls.Add(this.LoginTextBox);
            this.AccountGroupBox.Controls.Add(this.LoginLabel);
            this.AccountGroupBox.Controls.Add(this.AddAccountButton);
            this.AccountGroupBox.Controls.Add(this.RegisterButton);
            this.AccountGroupBox.Enabled = false;
            this.AccountGroupBox.Location = new System.Drawing.Point(12, 209);
            this.AccountGroupBox.Name = "AccountGroupBox";
            this.AccountGroupBox.Size = new System.Drawing.Size(383, 88);
            this.AccountGroupBox.TabIndex = 15;
            this.AccountGroupBox.TabStop = false;
            this.AccountGroupBox.Text = "Вход в аккаунт";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(240, 28);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(134, 20);
            this.PasswordTextBox.TabIndex = 15;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(186, 31);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(49, 28);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(131, 20);
            this.LoginTextBox.TabIndex = 12;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(9, 31);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 13);
            this.LoginLabel.TabIndex = 13;
            this.LoginLabel.Text = "Логин:";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(6, 54);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(93, 23);
            this.AddAccountButton.TabIndex = 14;
            this.AddAccountButton.Text = "Войти";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(268, 54);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(106, 23);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Регистрация";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 305);
            this.Controls.Add(this.AccountGroupBox);
            this.Controls.Add(this.CreateProjectGroupBox);
            this.Controls.Add(this.ProjectsGroupBox);
            this.Controls.Add(this.OpenProjectGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TitleForm";
            this.Text = "Faridun\'s Game Engine";
            this.Load += new System.EventHandler(this.TitleForm_Load);
            this.OpenProjectGroupBox.ResumeLayout(false);
            this.OpenProjectGroupBox.PerformLayout();
            this.CreateProjectGroupBox.ResumeLayout(false);
            this.CreateProjectGroupBox.PerformLayout();
            this.ProjectsGroupBox.ResumeLayout(false);
            this.AccountGroupBox.ResumeLayout(false);
            this.AccountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RoadLabel;
        private System.Windows.Forms.TextBox RoadProjectOpenTextBox;
        private System.Windows.Forms.Button ButtonChoos;
        private System.Windows.Forms.Button ButtonSelectFolder;
        private System.Windows.Forms.TextBox CreatProjectTextBoxRoad;
        private System.Windows.Forms.Label RoadLabel2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.GroupBox OpenProjectGroupBox;
        private System.Windows.Forms.GroupBox CreateProjectGroupBox;
        private System.Windows.Forms.GroupBox ProjectsGroupBox;
        private System.Windows.Forms.GroupBox AccountGroupBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
    }
}