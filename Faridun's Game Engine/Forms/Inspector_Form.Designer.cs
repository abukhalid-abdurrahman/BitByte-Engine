namespace GameEngine_Project
{
    partial class InspectorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectorForm));
            this.InspectorContainer = new System.Windows.Forms.SplitContainer();
            this.Hierarchy = new System.Windows.Forms.TreeView();
            this.HierarchyToolBar = new System.Windows.Forms.MenuStrip();
            this.FindTextBoxToolBar = new System.Windows.Forms.ToolStripTextBox();
            this.ImageListHierarchy = new System.Windows.Forms.ImageList(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.ToolStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesInProjectToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.InputStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CSharpScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkyboxStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CubemapStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProceduralStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prefabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.animationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.DublicateStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Add3DObjectStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.Add3DObjectChildStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.addComponentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InspectorContainer)).BeginInit();
            this.InspectorContainer.Panel1.SuspendLayout();
            this.InspectorContainer.SuspendLayout();
            this.HierarchyToolBar.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.ContextMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // InspectorContainer
            // 
            this.InspectorContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InspectorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InspectorContainer.IsSplitterFixed = true;
            this.InspectorContainer.Location = new System.Drawing.Point(0, 0);
            this.InspectorContainer.Name = "InspectorContainer";
            // 
            // InspectorContainer.Panel1
            // 
            this.InspectorContainer.Panel1.Controls.Add(this.Hierarchy);
            this.InspectorContainer.Panel1.Controls.Add(this.HierarchyToolBar);
            this.InspectorContainer.Panel1MinSize = 240;
            this.InspectorContainer.Size = new System.Drawing.Size(789, 438);
            this.InspectorContainer.SplitterDistance = 240;
            this.InspectorContainer.TabIndex = 1;
            // 
            // Hierarchy
            // 
            this.Hierarchy.AllowDrop = true;
            this.Hierarchy.BackColor = System.Drawing.SystemColors.Window;
            this.Hierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hierarchy.LabelEdit = true;
            this.Hierarchy.Location = new System.Drawing.Point(0, 27);
            this.Hierarchy.Name = "Hierarchy";
            this.Hierarchy.Size = new System.Drawing.Size(236, 407);
            this.Hierarchy.TabIndex = 0;
            this.Hierarchy.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Hierarchy_ItemDrag);
            this.Hierarchy.DragDrop += new System.Windows.Forms.DragEventHandler(this.Hierarchy_DragDrop);
            this.Hierarchy.DragEnter += new System.Windows.Forms.DragEventHandler(this.Hierarchy_DragEnter);
            this.Hierarchy.DragOver += new System.Windows.Forms.DragEventHandler(this.Hierarchy_DragOver);
            this.Hierarchy.DragLeave += new System.EventHandler(this.Hierarchy_DragLeave);
            this.Hierarchy.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.Hierarchy_GiveFeedback);
            this.Hierarchy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hierarchy_KeyDown);
            this.Hierarchy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hierarchy_MouseDown);
            // 
            // HierarchyToolBar
            // 
            this.HierarchyToolBar.AllowMerge = false;
            this.HierarchyToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindTextBoxToolBar});
            this.HierarchyToolBar.Location = new System.Drawing.Point(0, 0);
            this.HierarchyToolBar.Name = "HierarchyToolBar";
            this.HierarchyToolBar.Size = new System.Drawing.Size(236, 27);
            this.HierarchyToolBar.TabIndex = 1;
            // 
            // FindTextBoxToolBar
            // 
            this.FindTextBoxToolBar.Name = "FindTextBoxToolBar";
            this.FindTextBoxToolBar.Size = new System.Drawing.Size(100, 23);
            this.FindTextBoxToolBar.Text = "Поиск";
            this.FindTextBoxToolBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindTextBoxToolBar_KeyDown);
            // 
            // ImageListHierarchy
            // 
            this.ImageListHierarchy.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageListHierarchy.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageListHierarchy.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Action-file-new-icon.png");
            // 
            // ToolStrip
            // 
            this.ToolStrip.AllowMerge = false;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.ToolStrip.Location = new System.Drawing.Point(0, 438);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(789, 24);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "ToolBar";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesInProjectToolStripMenu,
            this.Separator2,
            this.InputStripMenuItem,
            this.physicsStripMenuItem,
            this.lightingToolStripMenuItem,
            this.objectsToolStripMenuItem,
            this.Separator1,
            this.sceneToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.editToolStripMenuItem.Text = "Редактировать";
            // 
            // filesInProjectToolStripMenu
            // 
            this.filesInProjectToolStripMenu.Name = "filesInProjectToolStripMenu";
            this.filesInProjectToolStripMenu.Size = new System.Drawing.Size(168, 22);
            this.filesInProjectToolStripMenu.Text = "Файлы в проекте";
            this.filesInProjectToolStripMenu.Click += new System.EventHandler(this.filesInProjectToolStripMenu_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(165, 6);
            // 
            // InputStripMenuItem
            // 
            this.InputStripMenuItem.Name = "InputStripMenuItem";
            this.InputStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.InputStripMenuItem.Text = "Ввод";
            this.InputStripMenuItem.Click += new System.EventHandler(this.InputStripMenuItem_Click);
            // 
            // physicsStripMenuItem
            // 
            this.physicsStripMenuItem.Name = "physicsStripMenuItem";
            this.physicsStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.physicsStripMenuItem.Text = "Физика";
            this.physicsStripMenuItem.Click += new System.EventHandler(this.physicsStripMenuItem_Click);
            // 
            // lightingToolStripMenuItem
            // 
            this.lightingToolStripMenuItem.Name = "lightingToolStripMenuItem";
            this.lightingToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.lightingToolStripMenuItem.Text = "Освещение";
            this.lightingToolStripMenuItem.Click += new System.EventHandler(this.lightingToolStripMenuItem_Click);
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.objectsToolStripMenuItem.Text = "Объекты";
            this.objectsToolStripMenuItem.Click += new System.EventHandler(this.objectsToolStripMenuItem_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(165, 6);
            // 
            // sceneToolStripMenuItem
            // 
            this.sceneToolStripMenuItem.Name = "sceneToolStripMenuItem";
            this.sceneToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sceneToolStripMenuItem.Text = "Сцена";
            this.sceneToolStripMenuItem.Click += new System.EventHandler(this.sceneToolStripMenuItem_Click);
            // 
            // ContextMenuBar
            // 
            this.ContextMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreataToolStripMenuItem,
            this.Separator6,
            this.openFileToolStripButton,
            this.PasteToolStripMenuItem,
            this.DeleteStripMenuItem6,
            this.RenameStripMenuItem7,
            this.DublicateStripMenuItem8,
            this.Separator5,
            this.Add3DObjectStripMenuItem9,
            this.Add3DObjectChildStripMenuItem10,
            this.addComponentToolStripMenuItem});
            this.ContextMenuBar.Name = "ContextMenuBar";
            this.ContextMenuBar.Size = new System.Drawing.Size(242, 214);
            // 
            // CreataToolStripMenuItem
            // 
            this.CreataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSharpScriptToolStripMenuItem,
            this.shaderToolStripMenuItem,
            this.Separator4,
            this.materialToolStripMenuItem,
            this.SkyboxStripMenuItem1,
            this.prefabToolStripMenuItem,
            this.Separator3,
            this.animationToolStripMenuItem,
            this.animatorToolStripMenuItem});
            this.CreataToolStripMenuItem.Name = "CreataToolStripMenuItem";
            this.CreataToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.CreataToolStripMenuItem.Text = "Создать";
            // 
            // CSharpScriptToolStripMenuItem
            // 
            this.CSharpScriptToolStripMenuItem.Name = "CSharpScriptToolStripMenuItem";
            this.CSharpScriptToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.CSharpScriptToolStripMenuItem.Text = "CSharp Сценарий";
            this.CSharpScriptToolStripMenuItem.Click += new System.EventHandler(this.CSharpScriptToolStripMenuItem_Click);
            // 
            // shaderToolStripMenuItem
            // 
            this.shaderToolStripMenuItem.Name = "shaderToolStripMenuItem";
            this.shaderToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.shaderToolStripMenuItem.Text = "Shader";
            this.shaderToolStripMenuItem.Click += new System.EventHandler(this.shaderToolStripMenuItem_Click);
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(167, 6);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.materialToolStripMenuItem.Text = "Материал";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // SkyboxStripMenuItem1
            // 
            this.SkyboxStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CubemapStripMenuItem1,
            this.ProceduralStripMenuItem1});
            this.SkyboxStripMenuItem1.Name = "SkyboxStripMenuItem1";
            this.SkyboxStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.SkyboxStripMenuItem1.Text = "Skybox";
            // 
            // CubemapStripMenuItem1
            // 
            this.CubemapStripMenuItem1.Name = "CubemapStripMenuItem1";
            this.CubemapStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.CubemapStripMenuItem1.Text = "Cubemap";
            this.CubemapStripMenuItem1.Click += new System.EventHandler(this.CubemapStripMenuItem1_Click);
            // 
            // ProceduralStripMenuItem1
            // 
            this.ProceduralStripMenuItem1.Name = "ProceduralStripMenuItem1";
            this.ProceduralStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.ProceduralStripMenuItem1.Text = "Procedural";
            this.ProceduralStripMenuItem1.Click += new System.EventHandler(this.ProceduralStripMenuItem1_Click);
            // 
            // prefabToolStripMenuItem
            // 
            this.prefabToolStripMenuItem.Name = "prefabToolStripMenuItem";
            this.prefabToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.prefabToolStripMenuItem.Text = "Префаб";
            this.prefabToolStripMenuItem.Click += new System.EventHandler(this.prefabToolStripMenuItem_Click);
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(167, 6);
            // 
            // animationToolStripMenuItem
            // 
            this.animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            this.animationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.animationToolStripMenuItem.Text = "Анимацию";
            this.animationToolStripMenuItem.Click += new System.EventHandler(this.animationToolStripMenuItem_Click);
            // 
            // animatorToolStripMenuItem
            // 
            this.animatorToolStripMenuItem.Name = "animatorToolStripMenuItem";
            this.animatorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.animatorToolStripMenuItem.Text = "Аниматор";
            this.animatorToolStripMenuItem.Click += new System.EventHandler(this.animatorToolStripMenuItem_Click);
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(238, 6);
            // 
            // openFileToolStripButton
            // 
            this.openFileToolStripButton.Name = "openFileToolStripButton";
            this.openFileToolStripButton.Size = new System.Drawing.Size(241, 22);
            this.openFileToolStripButton.Text = "Открыть";
            this.openFileToolStripButton.Click += new System.EventHandler(this.openFileToolStripButton_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            // 
            // DeleteStripMenuItem6
            // 
            this.DeleteStripMenuItem6.Name = "DeleteStripMenuItem6";
            this.DeleteStripMenuItem6.Size = new System.Drawing.Size(241, 22);
            this.DeleteStripMenuItem6.Text = "Удалить";
            this.DeleteStripMenuItem6.Click += new System.EventHandler(this.DeleteStripMenuItem6_Click);
            // 
            // RenameStripMenuItem7
            // 
            this.RenameStripMenuItem7.Name = "RenameStripMenuItem7";
            this.RenameStripMenuItem7.Size = new System.Drawing.Size(241, 22);
            this.RenameStripMenuItem7.Text = "Переименовать";
            this.RenameStripMenuItem7.Click += new System.EventHandler(this.RenameStripMenuItem7_Click);
            // 
            // DublicateStripMenuItem8
            // 
            this.DublicateStripMenuItem8.Name = "DublicateStripMenuItem8";
            this.DublicateStripMenuItem8.Size = new System.Drawing.Size(241, 22);
            this.DublicateStripMenuItem8.Text = "Дублировать";
            this.DublicateStripMenuItem8.Click += new System.EventHandler(this.DublicateStripMenuItem8_Click);
            // 
            // Separator5
            // 
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(238, 6);
            this.Separator5.Visible = false;
            // 
            // Add3DObjectStripMenuItem9
            // 
            this.Add3DObjectStripMenuItem9.Name = "Add3DObjectStripMenuItem9";
            this.Add3DObjectStripMenuItem9.Size = new System.Drawing.Size(241, 22);
            this.Add3DObjectStripMenuItem9.Text = "Добавить 3D объект";
            this.Add3DObjectStripMenuItem9.Visible = false;
            // 
            // Add3DObjectChildStripMenuItem10
            // 
            this.Add3DObjectChildStripMenuItem10.Name = "Add3DObjectChildStripMenuItem10";
            this.Add3DObjectChildStripMenuItem10.Size = new System.Drawing.Size(241, 22);
            this.Add3DObjectChildStripMenuItem10.Text = "Добавить дочерний 3D объект";
            this.Add3DObjectChildStripMenuItem10.Visible = false;
            // 
            // addComponentToolStripMenuItem
            // 
            this.addComponentToolStripMenuItem.Name = "addComponentToolStripMenuItem";
            this.addComponentToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.addComponentToolStripMenuItem.Text = "Добавить компонент";
            this.addComponentToolStripMenuItem.Visible = false;
            this.addComponentToolStripMenuItem.Click += new System.EventHandler(this.addComponentToolStripMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 200;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // InspectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.InspectorContainer);
            this.Controls.Add(this.ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.HierarchyToolBar;
            this.Name = "InspectorForm";
            this.Text = "Инспектор";
            this.Load += new System.EventHandler(this.ObjectSettingsChildForm_Load);
            this.InspectorContainer.Panel1.ResumeLayout(false);
            this.InspectorContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorContainer)).EndInit();
            this.InspectorContainer.ResumeLayout(false);
            this.HierarchyToolBar.ResumeLayout(false);
            this.HierarchyToolBar.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ContextMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer InspectorContainer;
        private System.Windows.Forms.MenuStrip ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filesInProjectToolStripMenu;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem InputStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripMenuItem sceneToolStripMenuItem;
        private System.Windows.Forms.TreeView Hierarchy;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ImageList ImageListHierarchy;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBar;
        private System.Windows.Forms.ToolStripMenuItem CreataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip HierarchyToolBar;
        private System.Windows.Forms.ToolStripTextBox FindTextBoxToolBar;
        private System.Windows.Forms.ToolStripMenuItem CSharpScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripMenuItem SkyboxStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripMenuItem CubemapStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ProceduralStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem RenameStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem DublicateStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem Add3DObjectStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem Add3DObjectChildStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator Separator6;
        private System.Windows.Forms.ToolStripSeparator Separator5;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem addComponentToolStripMenuItem;




    }
}