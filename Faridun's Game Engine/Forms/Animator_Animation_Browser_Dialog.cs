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

namespace GameEngine_Project
{
    public partial class Animator_Animation_Browser_Dialog : Form
    {
        public string _animName;

        public Animator_Animation_Browser_Dialog()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Animator_Animation_Browser_Dialog_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ShowIcon = false;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            _animName = AnimBrowserTreeView.SelectedNode.ToString();
            SelectButton.Update();
        }
    }
}
