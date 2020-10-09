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
    public partial class inputSettingsForm : Form
    {
        private TreeNode PlayerInput = new TreeNode("PlayerInput");
        private TreeNode UserInput = new TreeNode("UserInput");

        public inputSettingsForm()
        {
            InitializeComponent();
        }

        private void inputSettingsForm_Load(object sender, EventArgs e)
        {
            PlayerInput.Text = "Стандарные оси";
            UserInput.Text = "Оси";
            InputList.Nodes.AddRange(new TreeNode[]
            {
                PlayerInput,
                UserInput
            
            });
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void ApllyButton_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Close();
        }
    }
}
