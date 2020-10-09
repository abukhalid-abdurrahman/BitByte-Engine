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
using System.Diagnostics;

namespace GameEngine_Project
{
    public partial class TexturingForm : Form
    {
        OpenFileDialog openFileDiolog = new OpenFileDialog();

        private string fileName = @"";
        private string extension;

        public TexturingForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TexturingForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 600;
            this.Height = 400;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            SizeImage.Text = "Размер : ";
            ByteImage.Text = "Объём : ";
            FormatImage.Text = "Формат : ";
            NameLabel.Text = "Имя : ";
            ImageModeListBox.Items.Add("Sprite(2D and UI)");
            ImageModeListBox.Items.Add("Texture");
            ImageModeListBox.Items.Add("Normal map");
            ImageModeListBox.Items.Add("Cubemap");
            ImageModeListBox.Items.Add("Cookie");
            this.ShowIcon = false;
        }

        private void CancelButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            openFileDiolog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDiolog.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|JPE (*.jpe)|*.jpe|Icon Windows (*.ico)|*.ico|Cursor (*.cur)|*.cur";
            if (openFileDiolog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string FileName = openFileDiolog.FileName;
                NameLabel.Text = "Имя : " + openFileDiolog.FileName;
                FileRoadTextBox.Text = openFileDiolog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextureBrowserDiolog TBD = new TextureBrowserDiolog();
            ImageModeListBox.Enabled = false;
            TBD.Show();
        }

        private void SelectShaderButton_Click(object sender, EventArgs e)
        {
            Script_ShaderBrowserDiolog SSBD = new Script_ShaderBrowserDiolog();
            SSBD.ShowDialog();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Process.Start(openFileDiolog.FileName);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (NameLabel.Text.Length == 30)
            {
                NameLabel.Text = NameLabel.Text + "...";
                NameLabel.Size = new Size(30, NameLabel.Height);
            }

            fileName = openFileDiolog.FileName;
            extension = Path.GetExtension(fileName);

            DirectoryInfo di = new DirectoryInfo(@openFileDiolog.FileName);
            FileInfo[] fileInfo = di.GetFiles();

            FormatImage.Text = "Формат: " + extension;
            foreach (FileInfo f in fileInfo)
            {
                SizeImage.Text = "Объём: " + f.Length;
            }

            this.Invalidate();
        }
    }
}
