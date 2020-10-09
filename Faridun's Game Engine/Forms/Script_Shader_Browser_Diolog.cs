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
    public partial class Script_ShaderBrowserDiolog : Form
    {
        public Script_ShaderBrowserDiolog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Cancel_Buttom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Script_ShaderBrowserDiolog_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ShowIcon = false;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
