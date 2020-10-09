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
    public partial class physicsSettingsForm : Form
    {
        public double GravityX = 0;
        public double GravityY = 9.81;
        public double GravityZ = 0;

        public physicsSettingsForm()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Close();
        }

        private void physicsSettingsForm_Load(object sender, EventArgs e)
        {
            GXTxtBox.Text = GravityX.ToString();
            GYTxtBox.Text = GravityY.ToString();
            GZTxtBox.Text = GravityZ.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GravityX = GXTxtBox.Text.CompareTo(GXTxtBox.Text);
            GravityY = GYTxtBox.Text.CompareTo(GYTxtBox.Text);
            GravityZ = GZTxtBox.Text.CompareTo(GZTxtBox.Text);
            this.Invalidate();
        }
    }
}
