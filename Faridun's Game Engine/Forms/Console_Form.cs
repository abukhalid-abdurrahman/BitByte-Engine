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
    public partial class ConsoleForm : Form
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string[] consoleLines = {             
            "Mouse Position[X: " + Cursor.Position.X.ToString() + ", " + "Y:" + Cursor.Position.Y.ToString() + "]",
            "Camera, Position[X: Y: Z:], Rotation[X: Y: Z:]" 
                                    };
            this.ConsoleMessageBox.Lines = consoleLines;

            this.Text = "Faridun's Game Engine. Conslole[Errors: 0, Warnigs: 0, Massage: 0]";
        }
    }
}
