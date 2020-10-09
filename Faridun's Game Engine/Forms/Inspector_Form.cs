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
using WeifenLuo.WinFormsUI.Docking;

namespace GameEngine_Project
{
    public partial class InspectorForm : DockContent
    {
        #region Fields
        private Components_Form GameComponents = new Components_Form();

        private TreeNode treeNode1 = new TreeNode("FilesInProject");

        public GroupBox ObjectsGroupBox = new GroupBox();
        public GroupBox LightingGroupBox = new GroupBox();
        public GroupBox InputGroupBox = new GroupBox();
        public GroupBox FilesInProjectGroupBox = new GroupBox();
        public GroupBox SceneGroupBox = new GroupBox();
        public GroupBox PhysicsGroupBox = new GroupBox();
        public GroupBox ObjectsTransformGroupBox = new GroupBox();
        public GroupBox ObjectsSettingsGroupBox = new GroupBox();
        public GroupBox ComponentsSettingsGroupBox = new GroupBox();
        private GroupBox LightingSettingsGroupBox = new GroupBox();

        private Button sceneOpenButton = new Button();
        private Button ApplyButton = new Button();
        private Button sceneDeleteButton = new Button();

        private CheckBox sceneToBuildCheckBox = new CheckBox();

        private Label physicsLabel = new Label();
        private Label componentsLabel = new Label();
        private Label scriptsLabel = new Label();
        private Label LightingIntensivityLabel = new Label();
        private Label coordLabel = new Label();
        private Label positionLabel = new Label();
        private Label rotationLabel = new Label();
        private Label scaleLabel = new Label();
        private Label xLabel = new Label();
        private Label yLabel = new Label();
        private Label zLabel = new Label();
        private Label SceneSizeLabel = new Label();
        private Label ObjectsInSceneLabel = new Label();
        private Label numberOfSceneLabel = new Label();
        private Label sceneNameLabel = new Label();
        private Label createLabel = new Label();
        private Label editedLabel = new Label();

        private TextBox posXTxtBox = new TextBox();
        private TextBox posYTxtBox = new TextBox();
        private TextBox posZTxtBox = new TextBox();
        private TextBox rotXTxtBox = new TextBox();
        private TextBox rotYTxtBox = new TextBox();
        private TextBox rotZTxtBox = new TextBox();
        private TextBox sclXTxtBox = new TextBox();
        private TextBox sclYTxtBox = new TextBox();
        private TextBox sclZTxtBox = new TextBox();
        public TextBox LightingIntensivityTxtBox = new TextBox();
        public TextBox sceneNameTextBox = new TextBox();

        public NumericUpDown numericUpDown = new NumericUpDown();

        public ComboBox ambientSourceComboBox = new ComboBox();

        private double sceneSize = 0.0;
        
        private int objectsInScene = 0;
        private int numberOfScene = 0;

        private string sceneName = "NoName";
        private string scenePath = @"\\Project\\Files In Project\\Scenes";
        private string shadersPath = @"\\Project\\Files In Project\\Shaders";
        private string materialPath = @"\\Project\\Files In Project\\Material";
        private string cubeMapPath = @"\\Project\\Files In Project\\Cubemap(Skybox)";
        private string animationPath = @"\\Project\\Files In Project\\Animation";
        private string animatorPath = @"\\Project\\Files In Project\\Animator";
        private string prefabsPath = @"\\Project\\Files In Project\\Prefabs";
        private string proceduralSkyboxPath = @"\\Project\\Files In Project\\Procedural Skybox";
        private string csFilePath = @"\\Project\\Files In Project\\Scripts";
        String Path = @"\\Project\\Files In Project";

        public Color ambientColor;
        public ColorDialog ambientColorDialog = new ColorDialog();

        //ComboBox Items
        
        //

        //Gradient
        public Color gradientSkyColor;
        public Color gradientEquatorColor;
        public Color gradientGroundColor;

        public ColorDialog gradientSkyColorDialog = new ColorDialog();
        public ColorDialog gradientEquatorColorDialog = new ColorDialog();
        public ColorDialog gradientGroundColorDialog = new ColorDialog();

        private Panel gradientSkyColorPanel = new Panel();
        private Panel gradientEquatorColorPanel = new Panel();
        private Panel gradientGroundColorPanel = new Panel();
        //

        private TreeNode dragNode = null;
        private TreeNode tempDragNode = null;

        public double pX = 0;
        public double pY = 0;
        public double pZ = 0;
        public double rX = 0;
        public double rY = 0;
        public double rZ = 0;
        public double sX = 0;
        public double sY = 0;
        public double sZ = 0;

        #endregion

        public InspectorForm()
        {
            InitializeComponent();
			
			this.Hierarchy.ExpandAll();
			Timer.Interval = 200;
        }

        private void ObjectSettingsChildForm_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Path = System.Environment.CurrentDirectory + Path;
            scenePath = System.Environment.CurrentDirectory + scenePath;
            materialPath = System.Environment.CurrentDirectory + materialPath;
            animationPath = System.Environment.CurrentDirectory + animationPath;
            animatorPath = System.Environment.CurrentDirectory + animatorPath;
            cubeMapPath= System.Environment.CurrentDirectory + cubeMapPath;
            proceduralSkyboxPath = System.Environment.CurrentDirectory + proceduralSkyboxPath;
            csFilePath = System.Environment.CurrentDirectory + csFilePath;
            prefabsPath = System.Environment.CurrentDirectory + prefabsPath;
            shadersPath = System.Environment.CurrentDirectory + shadersPath;


            //Выключаем компоненты при загрузке формы
            numericUpDown.Enabled = false;
            ApplyButton.Enabled = false;
            sceneDeleteButton.Enabled = false;
            sceneOpenButton.Enabled = false;
            sceneToBuildCheckBox.Enabled = false;
            sceneNameTextBox.Enabled = false;

            //Выключаем GroupBox'ы при загрузке формы
            #region GroupBox
            ObjectsGroupBox.Visible = false;
            PhysicsGroupBox.Visible = false;
            LightingGroupBox.Visible = false;
            SceneGroupBox.Visible = false;
            FilesInProjectGroupBox.Visible = false;
            InputGroupBox.Visible = false;
            #endregion
        }

        private void Hierarchy_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Hierarchy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenuBar.Show(sender as Control, e.X, e.Y);      
            }
        }

        private void filesInProjectToolStripMenu_Click(object sender, EventArgs e)
        {
            Separator5.Visible = false;
            Add3DObjectChildStripMenuItem10.Visible = false;
            Add3DObjectStripMenuItem9.Visible = false;
            addComponentToolStripMenuItem.Visible = false;
            DirectoryInfo dinfo = new DirectoryInfo(Path);
            DirectoryInfo[] directory = dinfo.GetDirectories();
            treeNode1.Nodes.Clear();
            foreach (DirectoryInfo directoresnames in directory)
            {
                treeNode1.Nodes.Add(directoresnames.ToString());
            }
            #region TreeView
            this.Text = "Инспектор - Файлы в проекте";
            this.Hierarchy.Nodes.Clear();

            treeNode1.Name = "FilesInProject";
            treeNode1.Text = "Файлы в проекте";

            this.Hierarchy.Nodes.AddRange(new TreeNode[]{
            treeNode1
            });
            #endregion
            #region GroupBox
            //Disable
            LightingGroupBox.Dock = DockStyle.None;
            LightingGroupBox.Visible = false;

            InputGroupBox.Dock = DockStyle.None;
            InputGroupBox.Visible = false;

            PhysicsGroupBox.Dock = DockStyle.None;
            PhysicsGroupBox.Visible = false;

            ObjectsGroupBox.Dock = DockStyle.None;
            ObjectsGroupBox.Visible = false;

            SceneGroupBox.Dock = DockStyle.None;
            SceneGroupBox.Visible = false;

            //Enable
            InspectorContainer.Panel2.Controls.Add(FilesInProjectGroupBox);

            FilesInProjectGroupBox.Name = "FilesInProjectGroupBox";
            FilesInProjectGroupBox.Text = "Файлы в проекте";
            FilesInProjectGroupBox.Dock = DockStyle.Fill;
            FilesInProjectGroupBox.Visible = true;
            #endregion
        }

        private void InputStripMenuItem_Click(object sender, EventArgs e)
        {
            Separator5.Visible = false;
            Add3DObjectChildStripMenuItem10.Visible = false;
            Add3DObjectStripMenuItem9.Visible = false;
            addComponentToolStripMenuItem.Visible = false;
            #region TreeView
            this.Text = "Инспектор - Ввод";
            this.Hierarchy.Nodes.Clear();

            TreeNode treeNode2 = new TreeNode("Keyboard");
            TreeNode treeNode1 = new TreeNode("Input", new TreeNode[] {
                treeNode2
            });

            treeNode2.Name = "KeyboardNode";
            treeNode2.Text = "Клавиши";
            treeNode1.Name = "InputNode";
            treeNode1.Text = "Ввод";
            this.Hierarchy.Nodes.AddRange(new TreeNode[]{
                treeNode1
            });
            #endregion
            #region GroupBox
            //Disable
            FilesInProjectGroupBox.Dock = DockStyle.None;
            FilesInProjectGroupBox.Visible = false;

            LightingGroupBox.Dock = DockStyle.None;
            LightingGroupBox.Visible = false;

            PhysicsGroupBox.Dock = DockStyle.None;
            PhysicsGroupBox.Visible = false;

            ObjectsGroupBox.Dock = DockStyle.None;
            ObjectsGroupBox.Visible = false;

            SceneGroupBox.Dock = DockStyle.None;
            SceneGroupBox.Visible = false;

            //Enable
            InspectorContainer.Panel2.Controls.Add(InputGroupBox);
            InputGroupBox.Name = "InputGroupBox";
            InputGroupBox.Text = "Ввод";
            InputGroupBox.Dock = DockStyle.Fill;
            InputGroupBox.Visible = true;
            #endregion
        }

        private void physicsStripMenuItem_Click(object sender, EventArgs e)
        {
            Separator5.Visible = false;
            Add3DObjectChildStripMenuItem10.Visible = false;
            Add3DObjectStripMenuItem9.Visible = false;
            addComponentToolStripMenuItem.Visible = false;
            #region TreeView
            this.Text = "Инспектор - Физика";
            this.Hierarchy.Nodes.Clear();

            TreeNode treeNode2 = new TreeNode("3D Physics");
            TreeNode treeNode3 = new TreeNode("2D Physics");
            TreeNode treeNode1 = new TreeNode("Physics", new TreeNode[]{
            treeNode2,
            treeNode3
            });

            treeNode1.Name = "PhysicsNode";
            treeNode1.Text = "Физика";
            treeNode2.Name = "3DPhysicsNode";
            treeNode2.Text = "3D Физика";
            treeNode3.Name = "2DPhysicsNode";
            treeNode3.Text = "2D Физика";

            this.Hierarchy.Nodes.AddRange(new TreeNode[]{
                treeNode1
            });
            #endregion
            #region GroupBox
            //Disable
            ObjectsGroupBox.Dock = DockStyle.None;
            ObjectsGroupBox.Visible = false;

            SceneGroupBox.Dock = DockStyle.None;
            SceneGroupBox.Visible = false;

            InputGroupBox.Dock = DockStyle.None;
            InputGroupBox.Visible = false;

            LightingGroupBox.Dock = DockStyle.None;
            LightingGroupBox.Visible = false;

            FilesInProjectGroupBox.Dock = DockStyle.None;
            FilesInProjectGroupBox.Visible = false;

            //Enable
            InspectorContainer.Panel2.Controls.Add(PhysicsGroupBox);
            PhysicsGroupBox.Name = "PhysicsGroupBox";
            PhysicsGroupBox.Text = "Физика";
            PhysicsGroupBox.Dock = DockStyle.Fill;
            PhysicsGroupBox.Visible = true;
            #endregion
        }

        private void lightingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Separator5.Visible = false;
            Add3DObjectChildStripMenuItem10.Visible = false;
            Add3DObjectStripMenuItem9.Visible = false;
            addComponentToolStripMenuItem.Visible = false;
            #region TreeView
            this.Text = "Инспектор - Освещение";
            this.Hierarchy.Nodes.Clear();

            TreeNode treeNode1 = new TreeNode("Lighting");

            treeNode1.Name = "LightingNode";
            treeNode1.Text = "Освещение";

            this.Hierarchy.Nodes.AddRange(new TreeNode[] {
            treeNode1
            });
            #endregion
            #region GroupBox
            //Disable
            FilesInProjectGroupBox.Dock = DockStyle.None;
            FilesInProjectGroupBox.Visible = false;

            InputGroupBox.Dock = DockStyle.None;
            InputGroupBox.Visible = false;

            PhysicsGroupBox.Dock = DockStyle.None;
            PhysicsGroupBox.Visible = false;

            ObjectsGroupBox.Dock = DockStyle.None;
            ObjectsGroupBox.Visible = false;

            SceneGroupBox.Dock = DockStyle.None;
            SceneGroupBox.Visible = false;
            
            //Enable
            InspectorContainer.Panel2.Controls.Add(LightingGroupBox);
            LightingGroupBox.Controls.AddRange(new GroupBox[]{
            LightingSettingsGroupBox
            });

            LightingSettingsGroupBox.Dock = DockStyle.None;
            LightingSettingsGroupBox.Location = new Point(5, 20);
            LightingSettingsGroupBox.Size = new System.Drawing.Size(260, 150);
            LightingSettingsGroupBox.Text = "Настройки освещение";

            LightingSettingsGroupBox.Controls.AddRange(new TextBox[]{
            LightingIntensivityTxtBox
            });

            LightingIntensivityTxtBox.Location = new Point(154, 15);
            LightingIntensivityTxtBox.Size = new System.Drawing.Size(100, 20);
            LightingIntensivityTxtBox.ForeColor = Color.Black;
            LightingIntensivityTxtBox.Text = "1.0";

            LightingSettingsGroupBox.Controls.AddRange(new Label[]{
            LightingIntensivityLabel
            });

            LightingIntensivityLabel.Location = new Point(7, 17);
            LightingIntensivityLabel.Size = new System.Drawing.Size(149, 13);
            LightingIntensivityLabel.ForeColor = Color.Black;
            LightingIntensivityLabel.Text = "Интенсивность освещение:";

            LightingGroupBox.Name = "LightGroupBox";
            LightingGroupBox.Text = "Освещение";
            LightingGroupBox.Dock = DockStyle.Fill;
            LightingGroupBox.Visible = true;
            #endregion
        }

        private void objectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Separator5.Visible = true;
            Add3DObjectChildStripMenuItem10.Visible = true;
            Add3DObjectStripMenuItem9.Visible = true;
            addComponentToolStripMenuItem.Visible = true;
            #region TreeView
            this.Text = "Инспектор - Объекты";
            this.Hierarchy.Nodes.Clear();

            TreeNode treeNode1 = new TreeNode("SceneObjects");

            treeNode1.Name = "SceneObjectsNode";
            treeNode1.Text = "Объекты";

            this.Hierarchy.Nodes.AddRange(new TreeNode[] {
            treeNode1
            });
            #endregion
            #region GroupBox
            //Disable
            SceneGroupBox.Dock = DockStyle.None;
            SceneGroupBox.Visible = false;

            FilesInProjectGroupBox.Dock = DockStyle.None;
            FilesInProjectGroupBox.Visible = false;

            LightingGroupBox.Dock = DockStyle.None;
            LightingGroupBox.Visible = false;

            InputGroupBox.Dock = DockStyle.None;
            InputGroupBox.Visible = false;

            PhysicsGroupBox.Dock = DockStyle.None;
            PhysicsGroupBox.Visible = false;

            //Enable
            InspectorContainer.Panel2.Controls.Add(ObjectsGroupBox);
            ObjectsGroupBox.Controls.AddRange(new GroupBox[]{
            ObjectsTransformGroupBox
            });
            ObjectsGroupBox.Controls.AddRange(new GroupBox[]{
            ObjectsSettingsGroupBox   
            });

            ObjectsTransformGroupBox.Dock = DockStyle.Left;
            ObjectsTransformGroupBox.Location = new Point(5, 10);
            ObjectsTransformGroupBox.Size = new System.Drawing.Size(200, 200);
            ObjectsTransformGroupBox.Name = "ObjectsTransformGroupBox";
            ObjectsTransformGroupBox.Text = "Приоброзование";

            ObjectsTransformGroupBox.Controls.AddRange(new Label[] {
            xLabel,
            yLabel,
            zLabel,
            positionLabel,
            rotationLabel,
            scaleLabel,
            });

            ObjectsTransformGroupBox.Controls.AddRange(new TextBox[]{
            posXTxtBox,
            posYTxtBox,
            posZTxtBox,
            rotXTxtBox,
            rotYTxtBox,
            rotZTxtBox,
            sclXTxtBox,
            sclYTxtBox,
            sclZTxtBox
            });

            #region Transform Labels

            xLabel.Location = new Point(68, 15);
            xLabel.Size = new System.Drawing.Size(14, 13);
            xLabel.ForeColor = Color.Red;
            xLabel.Name = "xLabel";
            xLabel.Text = "X";

            yLabel.Location = new Point(110, 15);
            yLabel.Size = new Size(14, 13);
            yLabel.ForeColor = Color.Green;
            yLabel.Name = "yLabel";
            yLabel.Text = "Y";

            zLabel.Location = new Point(155, 15);
            zLabel.Size = new System.Drawing.Size(14, 13);
            zLabel.ForeColor = Color.Blue;
            zLabel.Name = "zLabel";
            zLabel.Text = "Z";

            positionLabel.Location = new Point(5, 37);
            positionLabel.Size = new Size(48, 13);
            positionLabel.ForeColor = Color.Black;
            positionLabel.Name = "posLabel";
            positionLabel.Text = "Position:";

            rotationLabel.Location = new Point(5, 65);
            rotationLabel.Size = new Size(50, 13);
            rotationLabel.ForeColor = Color.Black;
            rotationLabel.Name = "rotLabel";
            rotationLabel.Text = "Rotation:";

            scaleLabel.Location = new Point(5, 87);
            scaleLabel.Size = new Size(37, 13);
            scaleLabel.ForeColor = Color.Black;
            scaleLabel.Name = "sclLabel";
            scaleLabel.Text = "Scale:";

            #endregion

            #region Transform TextBox

            posXTxtBox.Location = new Point(55, 34);
            posXTxtBox.Size = new Size(41, 20);
            posXTxtBox.Name = "posXTxtBox";
            posXTxtBox.Text = pX.ToString();

            posYTxtBox.Location = new Point(100, 34);
            posYTxtBox.Size = new Size(41, 20);
            posYTxtBox.Name = "posYTxtBox";
            posYTxtBox.Text = pY.ToString();

            posZTxtBox.Location = new Point(145, 34);
            posZTxtBox.Size = new Size(41, 20);
            posZTxtBox.Name = "posZTxtBox";
            posZTxtBox.Text = pZ.ToString();

            rotXTxtBox.Location = new Point(55, 60);
            rotXTxtBox.Size = new Size(41, 20);
            rotXTxtBox.Name = "rotXTxtBox";
            rotXTxtBox.Text = rX.ToString();

            rotYTxtBox.Location = new Point(100, 60);
            rotYTxtBox.Size = new Size(41, 20);
            rotYTxtBox.Name = "rotYTxtBox";
            rotYTxtBox.Text = rY.ToString();

            rotZTxtBox.Location = new Point(145, 60);
            rotZTxtBox.Size = new Size(41, 20);
            rotZTxtBox.Name = "rotZTxtBox";
            rotZTxtBox.Text = rZ.ToString();

            sclXTxtBox.Location = new Point(55, 85);
            sclXTxtBox.Size = new Size(41, 20);
            sclXTxtBox.Name = "sclXTxtBox";
            sclXTxtBox.Text = sX.ToString();

            sclYTxtBox.Location = new Point(100, 85);
            sclYTxtBox.Size = new Size(41, 20);
            sclYTxtBox.Name = "sclYTxtBox";
            sclYTxtBox.Text = sY.ToString();

            sclZTxtBox.Location = new Point(145, 85);
            sclZTxtBox.Size = new Size(41, 20);
            sclZTxtBox.Name = "sclZTxtBox";
            sclZTxtBox.Text = sZ.ToString();

            #endregion


            ObjectsSettingsGroupBox.Dock = DockStyle.None;
            ObjectsSettingsGroupBox.Location = new Point(203, 16);
            ObjectsSettingsGroupBox.Size = new System.Drawing.Size(400, 340);
            ObjectsSettingsGroupBox.Name = "ObjectsComponentsGroupBox";
            ObjectsSettingsGroupBox.Text = "Компоненты";
            ObjectsSettingsGroupBox.Controls.AddRange(new GroupBox[]{
            ComponentsSettingsGroupBox
            });

            ComponentsSettingsGroupBox.Dock = DockStyle.Bottom;
            ComponentsSettingsGroupBox.Size = new Size(0, 150);
            ComponentsSettingsGroupBox.Name = "ComponentsSettingsGroupBox";
            ComponentsSettingsGroupBox.Text = "Настройки компонента";

            ObjectsGroupBox.Name = "ObjectsGroupBox";
            ObjectsGroupBox.Text = "Объекты";
            ObjectsGroupBox.Dock = DockStyle.Fill;
            ObjectsGroupBox.Visible = true;
            #endregion
        }

        private void sceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Separator5.Visible = false;
            Add3DObjectChildStripMenuItem10.Visible = false;
            Add3DObjectStripMenuItem9.Visible = false;
            addComponentToolStripMenuItem.Visible = false;
            #region TreeView
            this.Text = "Инспектор - Сцена";
            this.Hierarchy.Nodes.Clear();

            TreeNode sceneTreeNode1 = new TreeNode("Scene");

            DirectoryInfo dinfo = new DirectoryInfo(@"\\Project\\Files\\Scenes");
            FileInfo[] files = dinfo.GetFiles("*.fgescene");
            foreach (FileInfo filenames in files)
            {
                sceneTreeNode1.Nodes.Add(filenames.ToString());
            }

            sceneTreeNode1.Name = "SceneNode";
            sceneTreeNode1.Text = "Сцены";

            this.Hierarchy.Nodes.AddRange(new TreeNode[] {
            sceneTreeNode1
            });
            #endregion
            #region GroupBox
            //Disable
            FilesInProjectGroupBox.Dock = DockStyle.None;
            FilesInProjectGroupBox.Visible = false;

            LightingGroupBox.Dock = DockStyle.None;
            LightingGroupBox.Visible = false;

            InputGroupBox.Dock = DockStyle.None;
            InputGroupBox.Visible = false;

            PhysicsGroupBox.Dock = DockStyle.None;
            PhysicsGroupBox.Visible = false;

            ObjectsGroupBox.Dock = DockStyle.None;
            ObjectsGroupBox.Visible = false;

            //Enable
            InspectorContainer.Panel2.Controls.Add(SceneGroupBox);
            SceneGroupBox.Name = "SceneGroupBox";
            SceneGroupBox.Text = "Сцена";
            SceneGroupBox.Dock = DockStyle.Fill;
            SceneGroupBox.Visible = true;

            SceneGroupBox.Controls.AddRange(new Button[]{
            sceneDeleteButton,
            ApplyButton,
            sceneOpenButton
            });

            SceneGroupBox.Controls.AddRange(new NumericUpDown[]{
            numericUpDown
            });

            SceneGroupBox.Controls.AddRange(new Label[]{
            sceneNameLabel,
            SceneSizeLabel,
            ObjectsInSceneLabel,
            numberOfSceneLabel,
            editedLabel,
            createLabel
            });

            SceneGroupBox.Controls.AddRange(new CheckBox[]{
            sceneToBuildCheckBox
            });

            SceneGroupBox.Controls.AddRange(new TextBox[]{
            sceneNameTextBox
            });

            #region Buttons
            sceneOpenButton.Location = new Point(525, 330);
            sceneOpenButton.Size = new Size(75, 23);
            sceneOpenButton.Text = "Открыть";
            sceneOpenButton.Click += new EventHandler(sceneOpenButton_Click);

            sceneDeleteButton.Location = new Point(445, 330);
            sceneDeleteButton.Size = new Size(75, 23);
            sceneDeleteButton.Text = "Удалить";

            ApplyButton.Location = new Point(365, 330);
            ApplyButton.Size = new Size(75, 23);
            ApplyButton.Text = "Применить";
            #endregion

            sceneNameTextBox.Location = new Point(42, 18);
            sceneNameTextBox.ForeColor = Color.Black;
            sceneNameTextBox.Text = sceneName.ToString();

            numericUpDown.Location = new Point(55, 42);
            numericUpDown.Size = new Size(56, 80);

            sceneToBuildCheckBox.Location = new Point(465, 10);
            sceneToBuildCheckBox.Size = new Size(140, 17);
            sceneToBuildCheckBox.Checked = false;
            sceneToBuildCheckBox.Text = "Компилировать сцену";

            #region Labels
            sceneNameLabel.Location = new Point(7, 20);
            sceneNameLabel.Size = new Size(35, 13); ;
            sceneNameLabel.ForeColor = Color.Black;
            sceneNameLabel.Text = "Имя: ";

            SceneSizeLabel.Location = new Point(7, 84);
            SceneSizeLabel.Size = new Size(85, 13);
            SceneSizeLabel.ForeColor = Color.Black;
            SceneSizeLabel.Text = String.Format("Объём: {0}", sceneSize + " Мб");

            ObjectsInSceneLabel.Location = new Point(7, 64);
            ObjectsInSceneLabel.Size = new Size(85, 13);
            ObjectsInSceneLabel.ForeColor = Color.Black;
            ObjectsInSceneLabel.Text = String.Format("Объектов: {0}", objectsInScene);

            numberOfSceneLabel.Location = new Point(7, 45);
            numberOfSceneLabel.Size = new Size(85, 13);
            numberOfSceneLabel.ForeColor = Color.Black;
            numberOfSceneLabel.Text = "Номер: ";

            createLabel.Location = new Point(7, 104);
            createLabel.Size = new System.Drawing.Size(100, 13);
            createLabel.ForeColor = Color.Black;
            createLabel.Text = "Созданно: ";

            editedLabel.Location = new Point(7, 124);
            editedLabel.Size = new Size(100, 13);
            editedLabel.ForeColor = Color.Black;
            editedLabel.Text = "Изменено: ";
            #endregion

            #endregion
        }

        private void sceneOpenButton_Click(object sender, EventArgs e)
        {
            //Открытие сцены
        }

        private void CSharpScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewCSharpScript");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewCSharpScript";
            _treeNode1.Text = "NewCSharpScript";
            _treeNode1.BeginEdit();
            File.Create(csFilePath + "\\" + _treeNode1.Name);
        }

        private void shaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewShader");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewShader";
            _treeNode1.Text = "NewShader";
            _treeNode1.BeginEdit();

            File.Create(shadersPath + "\\" + _treeNode1.Name);
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewMaterial");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewMaterial";
            _treeNode1.Text = "NewMaterial";
            _treeNode1.BeginEdit();
            File.Create(materialPath + "\\" + _treeNode1.Name);
        }

        private void prefabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewPrefab");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewPrefab";
            _treeNode1.Text = "NewPrefab";
            _treeNode1.BeginEdit();
            File.Create(prefabsPath + "\\" + _treeNode1.Name);
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewAnimation");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewAnimation";
            _treeNode1.Text = "NewAnimation";
            _treeNode1.BeginEdit();
            File.Create(animationPath + "\\" + _treeNode1.Name);
        }

        private void animatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewAnimator");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewAnimators";
            _treeNode1.Text = "NewAnimator";
            _treeNode1.BeginEdit();
            File.Create(animatorPath + "\\" + _treeNode1.Name);
        }

        private void CubemapStripMenuItem1_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewCubmap");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewCubmap";
            _treeNode1.Text = "NewCubmap";
            _treeNode1.BeginEdit();
            File.Create(cubeMapPath + "\\" + _treeNode1.Name);
        }

        private void ProceduralStripMenuItem1_Click(object sender, EventArgs e)
        {
            filesInProjectToolStripMenu.PerformClick();
            TreeNode _treeNode1 = new TreeNode("NewProceduralSkybox");

            treeNode1.Nodes.AddRange(new TreeNode[]{
            _treeNode1
            });

            treeNode1.Expand();

            _treeNode1.Name = "NewProceduralSkybox";
            _treeNode1.Text = "NewProceduralSkybox";
            _treeNode1.BeginEdit();
            File.Create(proceduralSkyboxPath + "\\" + _treeNode1.Name);
        }

        private void DeleteStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Hierarchy.SelectedNode == null)
                return;
            else
               Hierarchy.SelectedNode.Remove();
        }

        private void RenameStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Hierarchy.SelectedNode == null)
                return;
            else
                Hierarchy.SelectedNode.BeginEdit();
        }

        private void DublicateStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (Hierarchy.SelectedNode == null)
                return;
            else
               Hierarchy.SelectedNode.Clone();
        }

        private void FindTextBoxToolBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hierarchy.Nodes.Find(FindTextBoxToolBar.Text, true);
            }
        }

        private void openFileToolStripButton_Click(object sender, EventArgs e)
        {
            String TreeNodeName = Hierarchy.SelectedNode.ToString().Replace("TreeNode: ", String.Empty);
            if (Hierarchy.SelectedNode == null)
                return;
            else
            Process.Start(Path + "\\" + TreeNodeName);
        }

        private void Hierarchy_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.dragNode = (TreeNode)e.Item;
            this.Hierarchy.SelectedNode = this.dragNode;

            this.Hierarchy.ImageList.Images.Clear();
            this.Hierarchy.ImageList.ImageSize = new Size(this.dragNode.Bounds.Size.Width + this.Hierarchy.Indent, this.dragNode.Bounds.Height);
            Bitmap bmp = new Bitmap(this.dragNode.Bounds.Width + this.Hierarchy.Indent, this.dragNode.Bounds.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.DrawImage(this.ImageListHierarchy.Images[1], 0, 0);
            gfx.DrawString(this.dragNode.Text, this.Hierarchy.Font, new SolidBrush(this.Hierarchy.ForeColor), (float)this.Hierarchy.Indent, 1.0f);
            this.Hierarchy.ImageList.Images.Add(bmp);
            Point p = this.Hierarchy.PointToClient(Control.MousePosition);
            int dx = p.X + this.Hierarchy.Indent - this.dragNode.Bounds.Left;
            int dy = p.Y - this.dragNode.Bounds.Top;
            if(DragHelper.ImageList_BeginDrag(this.Hierarchy.ImageList.Handle, 0, dx, dy))
            {
                this.Hierarchy.DoDragDrop(bmp, DragDropEffects.Move);
                DragHelper.ImageList_EndDrag();
            }
        }

        private void Hierarchy_DragOver(object sender, DragEventArgs e)
        {
            Point formP = this.PointToClient(new Point(e.X, e.Y));
            DragHelper.ImageList_DragMove(formP.X - this.Hierarchy.Left, formP.Y - this.Hierarchy.Top);

            TreeNode dropNode = this.Hierarchy.GetNodeAt(this.Hierarchy.PointToClient(new Point(e.X, e.Y)));
            if (dropNode == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Move;

            if (this.tempDragNode != dropNode)
            {
                DragHelper.ImageList_DragShowNolock(false);
                this.Hierarchy.SelectedNode = dropNode;
                DragHelper.ImageList_DragShowNolock(true);
                tempDragNode = dropNode;
            }

            TreeNode tmpNode = dropNode;
            while(tmpNode.Parent != null)
            {
                if (tmpNode.Parent == this.dragNode) e.Effect = DragDropEffects.None;
                tmpNode = tmpNode.Parent;
            }
        }

        private void Hierarchy_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                e.UseDefaultCursors = false;
                this.Hierarchy.Cursor = Cursors.Default;
            }
            else
                e.UseDefaultCursors = true;
        }

        private void Hierarchy_DragDrop(object sender, DragEventArgs e)
        {
            DragHelper.ImageList_DragLeave(this.Hierarchy.Handle);

            TreeNode dropNode = this.Hierarchy.GetNodeAt(this.Hierarchy.PointToClient(new Point(e.X, e.Y)));

			if(this.dragNode != dropNode)
			{
				
		    if (this.dragNode.Parent == null)
            {
                this.Hierarchy.Nodes.Remove(this.dragNode);
            }
            else
            {
                this.dragNode.Parent.Nodes.Remove(this.dragNode);
            }
			
			}

            dropNode.Nodes.Add(dragNode);
            dropNode.ExpandAll();

            this.dragNode = null;
            this.Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point pt = PointToClient(Control.MousePosition);
            TreeNode node = this.Hierarchy.GetNodeAt(pt);

            if (node == null)
                return;

            if (pt.Y < 30)
            {
                if (node.PrevVisibleNode != null)
                {
                    node = node.PrevVisibleNode;
                    DragHelper.ImageList_DragShowNolock(false);
                    node.EnsureVisible();
                    this.Hierarchy.Refresh();
                    DragHelper.ImageList_DragShowNolock(true);
                }
            }
            else if (pt.Y > this.Hierarchy.Size.Height - 30)
            {
                if (node.NextVisibleNode != null)
                {
                    node = node.NextVisibleNode;

                    DragHelper.ImageList_DragShowNolock(false);
                    node.EnsureVisible();
                    this.Hierarchy.Refresh();
                    DragHelper.ImageList_DragShowNolock(true);
                }
            }
        }

        private void Hierarchy_DragEnter(object sender, DragEventArgs e)
        {
            DragHelper.ImageList_DragEnter(this.Hierarchy.Handle, e.X - this.Hierarchy.Left, e.Y - this.Hierarchy.Top);
            this.Timer.Enabled = true;
        }

        private void Hierarchy_DragLeave(object sender, EventArgs e)
        {
            DragHelper.ImageList_DragLeave(this.Hierarchy.Handle);

            this.Timer.Enabled = false;
        }

        private void addComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Hierarchy.SelectedNode == null)
                return;
            else
            GameComponents.Show();
        }
    }
}