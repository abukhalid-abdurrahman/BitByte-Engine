namespace GameEngine_Project
{
    partial class TextureBrowserDiolog
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Проект");
            this.TextureBtowserView = new System.Windows.Forms.TreeView();
            this.Cancel_Buttom = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextureBtowserView
            // 
            this.TextureBtowserView.Location = new System.Drawing.Point(12, 12);
            this.TextureBtowserView.Name = "TextureBtowserView";
            treeNode1.Name = "Project";
            treeNode1.Text = "Проект";
            this.TextureBtowserView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.TextureBtowserView.ShowNodeToolTips = true;
            this.TextureBtowserView.Size = new System.Drawing.Size(260, 200);
            this.TextureBtowserView.TabIndex = 0;
            // 
            // Cancel_Buttom
            // 
            this.Cancel_Buttom.Location = new System.Drawing.Point(12, 227);
            this.Cancel_Buttom.Name = "Cancel_Buttom";
            this.Cancel_Buttom.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Buttom.TabIndex = 1;
            this.Cancel_Buttom.Text = "Отмена";
            this.Cancel_Buttom.UseVisualStyleBackColor = true;
            this.Cancel_Buttom.Click += new System.EventHandler(this.Cancel_Buttom_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(197, 227);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.Text = "Выбрать";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // TextureBrowserDiolog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Cancel_Buttom);
            this.Controls.Add(this.TextureBtowserView);
            this.Name = "TextureBrowserDiolog";
            this.Text = "Текстуры, материалы и нормалы";
            this.Load += new System.EventHandler(this.TextureBrowserDiolog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TextureBtowserView;
        private System.Windows.Forms.Button Cancel_Buttom;
        private System.Windows.Forms.Button OK_Button;
    }
}