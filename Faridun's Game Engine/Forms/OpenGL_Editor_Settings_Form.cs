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
    public partial class openGLEditorSettingsForm : Form
    {
        public ColorDialog colorDialog = new ColorDialog();

        public openGLEditorSettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
