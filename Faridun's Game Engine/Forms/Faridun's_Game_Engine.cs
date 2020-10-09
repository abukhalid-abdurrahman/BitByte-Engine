#region System
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace GameEngine_Project
{
    public partial class GameEngine_Form : Form
    {
        #region Fields
        TitleForm title_Form = new TitleForm();

        public int errorsCount = 0;
        public int warnigsCount = 0;
        public int messageCount = 0;

        public bool gameMode = true;

        public bool SceneButton = true;

        private bool showRunProjectForm = true;

        public bool ShowGrid = false;

        bool SaveChanges = false;
        #endregion

        public GameEngine_Form()
        {
            InitializeComponent();
            this.dockPanel1.Theme = new VS2015LightTheme();
            this.Text = "Faridun's Game Engine. " + title_Form.projectName;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow aboutWin = new aboutWindow();
            aboutWin.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiolog = new OpenFileDialog();
            openFileDiolog.ShowDialog();
        }

        private void сохранитьПроектКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDiolog = new SaveFileDialog();
            saveFileDiolog.ShowDialog();  
        }

        private void OpenWindowtoolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiolog = new OpenFileDialog();
            openFileDiolog.ShowDialog();
        }

        private void создатьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewProjectForm cnpf = new CreateNewProjectForm();
            cnpf.Show();
        }

        private void GameEngine_Form_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Scenes"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Scenes");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Shaders"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Shaders");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Material"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Material");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Cubemap(Skybox)"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Cubemap(Skybox)");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Animation"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Animation");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Animator"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Animator");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Prefabs"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Prefabs");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Procedural Skybox"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Procedural Skybox");

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Project\\Files In Project\\Scripts"))
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Project\\Files In Project\\Scripts");

            this.MaximizeBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimumSize = new System.Drawing.Size(900, 550);

            IsMdiContainer = true;

            InspectorForm Inspector = new InspectorForm();
            Inspector.MdiParent = this;
            Inspector.WindowState = FormWindowState.Maximized;
            Inspector.Show(dockPanel1, DockState.Document);

            gameModeToolStripMenuItem.Checked = true;
            switchTo3DToolStripMenuItem.Checked = true;
            showGridToolStripMenuItem.Checked = true;

            if (SceneButton)
            {
                EditorWindowToolStripMenuItem.Enabled = true;
                newWindowToolStripButton.Enabled = true;
            }
            else if (!SceneButton)
            {
                EditorWindowToolStripMenuItem.Enabled = false;
                newWindowToolStripButton.Enabled = false;
            }
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputSettingsForm inputSettings = new inputSettingsForm();
            inputSettings.StartPosition = FormStartPosition.CenterParent;
            inputSettings.ShowDialog();
        }

        private void physicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            physicsSettingsForm physicsSettings = new physicsSettingsForm();
            physicsSettings.StartPosition = FormStartPosition.CenterParent;
            physicsSettings.ShowDialog();
        }

        private void graphicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicsSettingsForm graphicsSettings = new graphicsSettingsForm();
            graphicsSettings.StartPosition = FormStartPosition.CenterParent;
            graphicsSettings.ShowDialog();
        }

        private void audioSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioSettingsForm audioSettings = new audioSettingsForm();
            audioSettings.StartPosition = FormStartPosition.CenterParent;
            audioSettings.ShowDialog();
        }

        private void showGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showGridToolStripMenuItem.Checked = !showGridToolStripMenuItem.Checked;
        }

        private void GLSettingsStripMenuItem_Click(object sender, EventArgs e)
        {
            openGLEditorSettingsForm openGLSettings = new openGLEditorSettingsForm();
            openGLSettings.StartPosition = FormStartPosition.CenterParent;
            openGLSettings.ShowDialog();
        }

        private void compileProject_Click(object sender, EventArgs e)
        {
            CompileForm compileForm = new CompileForm();
            compileForm.StartPosition = FormStartPosition.CenterParent;
            compileForm.ShowDialog();
        }

        private void addTextureTo3DModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TexturingForm texturing3dModel = new TexturingForm();
            texturing3dModel.ShowDialog();
        }

        private void addTextureToPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TexturingForm texturingPolygon = new TexturingForm();
            texturingPolygon.ShowDialog();
        }

        private void inportTextureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiolog = new OpenFileDialog();
            openFileDiolog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDiolog.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|JPE (*.jpe)|*.jpe|Icon Windows (*.ico)|*.ico|Cursor (*.cur)|*.cur";
            if (openFileDiolog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string FileName = openFileDiolog.FileName;
            }
        }

        private void SaveAsToolButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDiolog = new SaveFileDialog();
            saveFileDiolog.ShowDialog();                    
        }

        private void SaveProjectToolButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDiolog = new SaveFileDialog();
            saveFileDiolog.ShowDialog();  
        }

        private void ExportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDiolog = new SaveFileDialog();
            saveFileDiolog.ShowDialog();  
        }

        private void изображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiolog = new OpenFileDialog();
            openFileDiolog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDiolog.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg|JPG (*.jpg)|*.jpg|JPE (*.jpe)|*.jpe|Icon Windows (*.ico)|*.ico|Cursor (*.cur)|*.cur";
            if (openFileDiolog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string FileName = openFileDiolog.FileName;
            }
        }

        private void ModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add3DModelForm importModel = new Add3DModelForm();
            importModel.StartPosition = FormStartPosition.CenterParent;
            importModel.ShowDialog();
        }

        private void inspectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InspectorForm Inspector = new InspectorForm();
            Inspector.MdiParent = this;
            Inspector.WindowState = FormWindowState.Maximized;
            Inspector.Show(dockPanel1, DockState.Document);
        }

        private void developerModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameModeToolStripMenuItem.Checked == true)
            {
                gameModeToolStripMenuItem.Checked = false;
                developerModeToolStripMenuItem.Checked = true;
            }
            else
            {
                developerModeToolStripMenuItem.Checked = true;
            }
        }

        private void gameModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (developerModeToolStripMenuItem.Checked == true)
            {
                developerModeToolStripMenuItem.Checked = false;
                gameModeToolStripMenuItem.CheckOnClick = true;
            }
            else
            {
                gameModeToolStripMenuItem.CheckOnClick = true;
            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (switchTo2DToolStripMenuItem.Checked == true)
            {
                switchTo2DToolStripMenuItem.Checked = false;
            }
            if (switchTo3DToolStripMenuItem.Checked == true)
            {
                switchTo3DToolStripMenuItem.Checked = false;
            }
        }

        private void GameEngine_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SaveChanges)
            {
                DialogResult result = MessageBox.Show("Внимание!!! Сохранить все изменения? Все несахранёные данные и изменения будят утеряны!!!", "Выход из Faridun's Game Engine", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                    Application.ExitThread();
                }

                if (result == System.Windows.Forms.DialogResult.No)
                {
                    Application.Exit();
                    Application.ExitThread();

                }

                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Application.Run();
                }
            }
        }

        private void posirionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rotationToolStripMenuItem.Checked == true)
            {
                rotationToolStripMenuItem.Checked = false;
                positionToolStripMenuItem.Checked = true;
            }
            else
            {
                positionToolStripMenuItem.Checked = true;
            }

            if (scaleToolStripMenuItem.Checked == true)
            {
                scaleToolStripMenuItem.Checked = false;
                positionToolStripMenuItem.Checked = true;
            }
            else
            {
                positionToolStripMenuItem.Checked = true;
            }
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (positionToolStripMenuItem.Checked == true)
            {
                positionToolStripMenuItem.Checked = false;
                rotationToolStripMenuItem.Checked = true;
            }
            else
            {
                rotationToolStripMenuItem.Checked = true;
            }

            if (scaleToolStripMenuItem.Checked == true)
            {
                scaleToolStripMenuItem.Checked = false;
                rotationToolStripMenuItem.Checked = true;
            }
            else
            {
                rotationToolStripMenuItem.Checked = true;
            }
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rotationToolStripMenuItem.Checked == true)
            {
                rotationToolStripMenuItem.Checked = false;
                scaleToolStripMenuItem.Checked = true;
            }
            else
            {
                scaleToolStripMenuItem.Checked = true;
            }

            if (positionToolStripMenuItem.Checked == true)
            {
                positionToolStripMenuItem.Checked = false;
                scaleToolStripMenuItem.Checked = true;
            }
            else
            {
                scaleToolStripMenuItem.Checked = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.mousePosLabel.Text = "Mouse Position[X: " + Cursor.Position.X.ToString() + ", " + "Y:" + Cursor.Position.Y.ToString() + "]";
            this.Invalidate();
        }

        private void GameEngine_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void switchTo3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo3DToolStripMenuItem.Checked = true;
            switchTo2DToolStripMenuItem.Checked = false;
        }

        private void switchTo2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchTo2DToolStripMenuItem.Checked = true;
            switchTo3DToolStripMenuItem.Checked = false;
        }

        private void playerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerSettings playerSettings = new PlayerSettings();
            playerSettings.StartPosition = FormStartPosition.CenterParent;
            playerSettings.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            ConsoleForm cons = new ConsoleForm();
            cons.StartPosition = FormStartPosition.CenterScreen;
            cons.Show();
        }

        private void VirtualRealityStripMenuItem1_Click(object sender, EventArgs e)
        {
            VRMenuItem1.Checked = !VRMenuItem1.Checked;
        }

        private void NVStripMenuItem1_Click(object sender, EventArgs e)
        {
            NVStripMenuItem1.Checked = !NVStripMenuItem1.Checked;
        }
    }

}