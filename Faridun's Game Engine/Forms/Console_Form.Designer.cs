namespace GameEngine_Project
{
    partial class ConsoleForm
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
            this.ConsoleMessageBox = new System.Windows.Forms.RichTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ConsoleMessageBox
            // 
            this.ConsoleMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleMessageBox.Enabled = false;
            this.ConsoleMessageBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleMessageBox.Name = "ConsoleMessageBox";
            this.ConsoleMessageBox.Size = new System.Drawing.Size(584, 362);
            this.ConsoleMessageBox.TabIndex = 0;
            this.ConsoleMessageBox.Text = "";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.ConsoleMessageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleForm";
            this.ShowIcon = false;
            this.Text = "Console";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ConsoleMessageBox;
        private System.Windows.Forms.Timer Timer;



    }
}