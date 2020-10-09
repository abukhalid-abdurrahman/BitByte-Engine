using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GameEngine_Project
{
    public partial class CompileForm : Form
    {
        OpenFileDialog openIcon = new OpenFileDialog();
        FolderBrowserDialog roadBrowser = new FolderBrowserDialog();

        public CompileForm()
        {
            InitializeComponent();
        }

        private void chooseIconbutton_Click(object sender, EventArgs e)
        {
        }
        
        private void Compilebutton_Click(object sender, EventArgs e)
        {
        }

        private void choosFolderButton_Click(object sender, EventArgs e)
        {
            roadBrowser.ShowDialog();
            projectRoadTextBox.Text = roadBrowser.SelectedPath.ToString(); 
        }

        private void CompileForm_Load(object sender, EventArgs e)
        {
        }
    }
}
