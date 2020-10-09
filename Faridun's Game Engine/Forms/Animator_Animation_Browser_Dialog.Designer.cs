namespace GameEngine_Project
{
    partial class Animator_Animation_Browser_Dialog
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
            this._CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.AnimBrowserTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // _CancelButton
            // 
            this._CancelButton.Location = new System.Drawing.Point(12, 227);
            this._CancelButton.Name = "_CancelButton";
            this._CancelButton.Size = new System.Drawing.Size(75, 23);
            this._CancelButton.TabIndex = 1;
            this._CancelButton.Text = "Отмена";
            this._CancelButton.UseVisualStyleBackColor = true;
            this._CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(197, 227);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Выбрать";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // AnimBrowserTreeView
            // 
            this.AnimBrowserTreeView.Location = new System.Drawing.Point(12, 12);
            this.AnimBrowserTreeView.Name = "AnimBrowserTreeView";
            treeNode1.Name = "ProjectTreeView";
            treeNode1.Text = "Проект";
            this.AnimBrowserTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.AnimBrowserTreeView.Size = new System.Drawing.Size(260, 200);
            this.AnimBrowserTreeView.TabIndex = 3;
            // 
            // Animator_Animation_Browser_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AnimBrowserTreeView);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this._CancelButton);
            this.Name = "Animator_Animation_Browser_Dialog";
            this.Text = "Анимация, Аниматоры";
            this.Load += new System.EventHandler(this.Animator_Animation_Browser_Dialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _CancelButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TreeView AnimBrowserTreeView;
    }
}