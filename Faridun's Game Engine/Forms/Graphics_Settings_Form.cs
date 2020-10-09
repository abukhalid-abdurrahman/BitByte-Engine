using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GameEngine_Project
{
    public partial class graphicsSettingsForm : Form
    {
        private VideoMode.DEVMODE vDevMode = new VideoMode.DEVMODE();

        public graphicsSettingsForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (VideoModeList.SelectedItem == null)
                return;
            else
                VideoModeList.SelectedItems.Remove(VideoModeList.SelectedItem);
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

        private void graphicsSettingsForm_Load(object sender, EventArgs e)
        {
            int i = 0;

            while (VideoMode.EnumDisplaySettings(null, i, ref vDevMode))
            {
                VideoModeList.Items.Add(String.Format("Width:{0} Height:{1}", vDevMode.dmPelsWidth, vDevMode.dmPelsHeight));
                i++;
            }
        }
    }
}
