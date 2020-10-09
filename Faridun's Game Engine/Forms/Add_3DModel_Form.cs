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
    public partial class Add3DModelForm : Form
    {
        OpenFileDialog openFileDiolog = new OpenFileDialog();

        private string fileName = @"";
        private string extension;

        public Add3DModelForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add3DModelForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SizeImage.Text = "Объём : ";
            FormatImage.Text = "Формат : ";
            NameLabel.Text = "Имя : ";
            MaterialNameLabel.Text = "Имя :";
            this.ShowIcon = false;
        }

        private void CancelButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            openFileDiolog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDiolog.Filter = "FBX (*.fbx)|*.fbx|Motion Capture (*.bvh)|*.bvh|3D Studio (*.3ds)|*.3ds";
            if (openFileDiolog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string FileName = openFileDiolog.FileName;
                NameLabel.Text = "Имя : " + openFileDiolog.FileName;
                FileRoadTextBox.Text = openFileDiolog.FileName;
            }
        }

        private void SelectFromProject_Click(object sender, EventArgs e)
        {
            ObjectBrawserDialog OBD = new ObjectBrawserDialog();
            OBD.ShowDialog();
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            ColorPanel.BackColor = colorDialog.Color;
            NameMaterialTextBox.Text = colorDialog.Color.ToString();
        }

        private void SelectMaterialButton_Click(object sender, EventArgs e)
        {
            TextureBrowserDiolog TBD = new TextureBrowserDiolog();
            TBD.ShowDialog();
        }

        private void SelectScriptButton_Click(object sender, EventArgs e)
        {
            Script_ShaderBrowserDiolog SSBD = new Script_ShaderBrowserDiolog();
            SSBD.ShowDialog();
        }

        private void NameMaterialTextBox_Click(object sender, EventArgs e)
        {
            NameMaterialTextBox.SelectAll();
        }

        private void NameMaterialTextBox_DoubleClick(object sender, EventArgs e)
        {
            NameMaterialTextBox.DeselectAll();
        }

        private void Add3DModelForm_Click(object sender, EventArgs e)
        {
            NameMaterialTextBox.DeselectAll();
            SelectScriptTextBox.DeselectAll();
            SelectMaterialTextBox.DeselectAll();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            fileName = openFileDiolog.FileName;
            extension = Path.GetExtension(fileName);
            FormatImage.Text = "Формат: " + extension;

            this.Invalidate();
        }
    }
}
