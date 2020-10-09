namespace GameEngine_Project
{
    partial class CompileForm
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
            this.Compilebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.choosFolderButton = new System.Windows.Forms.Button();
            this.projectRoadTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconRoadTextBox = new System.Windows.Forms.TextBox();
            this.chooseIconbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.valueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Compilebutton
            // 
            this.Compilebutton.Location = new System.Drawing.Point(264, 129);
            this.Compilebutton.Name = "Compilebutton";
            this.Compilebutton.Size = new System.Drawing.Size(107, 23);
            this.Compilebutton.TabIndex = 0;
            this.Compilebutton.Text = "Компилировать";
            this.Compilebutton.UseVisualStyleBackColor = true;
            this.Compilebutton.Click += new System.EventHandler(this.Compilebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(12, 129);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 1;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь:";
            // 
            // choosFolderButton
            // 
            this.choosFolderButton.Location = new System.Drawing.Point(296, 38);
            this.choosFolderButton.Name = "choosFolderButton";
            this.choosFolderButton.Size = new System.Drawing.Size(75, 23);
            this.choosFolderButton.TabIndex = 3;
            this.choosFolderButton.Text = "Выбрать...";
            this.choosFolderButton.UseVisualStyleBackColor = true;
            this.choosFolderButton.Click += new System.EventHandler(this.choosFolderButton_Click);
            // 
            // projectRoadTextBox
            // 
            this.projectRoadTextBox.Location = new System.Drawing.Point(52, 39);
            this.projectRoadTextBox.Name = "projectRoadTextBox";
            this.projectRoadTextBox.Size = new System.Drawing.Size(238, 20);
            this.projectRoadTextBox.TabIndex = 4;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(52, 65);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(319, 20);
            this.projectNameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя:";
            // 
            // iconRoadTextBox
            // 
            this.iconRoadTextBox.Location = new System.Drawing.Point(127, 13);
            this.iconRoadTextBox.Name = "iconRoadTextBox";
            this.iconRoadTextBox.Size = new System.Drawing.Size(163, 20);
            this.iconRoadTextBox.TabIndex = 9;
            // 
            // chooseIconbutton
            // 
            this.chooseIconbutton.Location = new System.Drawing.Point(296, 12);
            this.chooseIconbutton.Name = "chooseIconbutton";
            this.chooseIconbutton.Size = new System.Drawing.Size(75, 23);
            this.chooseIconbutton.TabIndex = 8;
            this.chooseIconbutton.Text = "Выбрать...";
            this.chooseIconbutton.UseVisualStyleBackColor = true;
            this.chooseIconbutton.Click += new System.EventHandler(this.chooseIconbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Иконка (.exe) файла:\r\n";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(50, 179);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(319, 23);
            this.progressBar.TabIndex = 10;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(7, 183);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(15, 13);
            this.valueLabel.TabIndex = 11;
            this.valueLabel.Text = "%";
            // 
            // CompileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 223);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.iconRoadTextBox);
            this.Controls.Add(this.chooseIconbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectRoadTextBox);
            this.Controls.Add(this.choosFolderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Compilebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompileForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Компилировать";
            this.Load += new System.EventHandler(this.CompileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Compilebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choosFolderButton;
        private System.Windows.Forms.TextBox projectRoadTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iconRoadTextBox;
        private System.Windows.Forms.Button chooseIconbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label valueLabel;
    }
}