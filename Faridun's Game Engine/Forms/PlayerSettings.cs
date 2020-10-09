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
    public partial class PlayerSettings : Form
    {
        public PlayerSettings()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
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
