using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine_Project
{
    public partial class CreateNewProjectForm : Form
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public CreateNewProjectForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateNewProjectForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectRoad_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }
    }
}
