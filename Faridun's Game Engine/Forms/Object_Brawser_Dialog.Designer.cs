﻿namespace GameEngine_Project
{
    partial class ObjectBrawserDialog
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Проект");
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Buttom = new System.Windows.Forms.Button();
            this.ObjectBtowserView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(197, 227);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 5;
            this.OK_Button.Text = "Выбрать";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Buttom
            // 
            this.Cancel_Buttom.Location = new System.Drawing.Point(12, 227);
            this.Cancel_Buttom.Name = "Cancel_Buttom";
            this.Cancel_Buttom.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Buttom.TabIndex = 4;
            this.Cancel_Buttom.Text = "Отмена";
            this.Cancel_Buttom.UseVisualStyleBackColor = true;
            this.Cancel_Buttom.Click += new System.EventHandler(this.Cancel_Buttom_Click);
            // 
            // ObjectBtowserView
            // 
            this.ObjectBtowserView.Location = new System.Drawing.Point(12, 12);
            this.ObjectBtowserView.Name = "ObjectBtowserView";
            treeNode3.Name = "Project";
            treeNode3.Text = "Проект";
            this.ObjectBtowserView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.ObjectBtowserView.ShowNodeToolTips = true;
            this.ObjectBtowserView.Size = new System.Drawing.Size(260, 199);
            this.ObjectBtowserView.TabIndex = 3;
            // 
            // ObjectBrawserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Cancel_Buttom);
            this.Controls.Add(this.ObjectBtowserView);
            this.Name = "ObjectBrawserDialog";
            this.Text = "Объекты";
            this.Load += new System.EventHandler(this.ObjectBrawserDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Buttom;
        private System.Windows.Forms.TreeView ObjectBtowserView;
    }
}