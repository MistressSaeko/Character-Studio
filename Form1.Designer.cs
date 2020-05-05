namespace CharacterStudio
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importClothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportEngineReadyMeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gLTransmissionFormatGLTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autodeskFBXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colladaDAEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SceneView = new OpenTK.GLControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HeadMorphsTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.FaceMorphsTab = new System.Windows.Forms.TabPage();
            this.UpperBodyMorphsTab = new System.Windows.Forms.TabPage();
            this.LowerBodyMorphsTab = new System.Windows.Forms.TabPage();
            this.HandMorphsTab = new System.Windows.Forms.TabPage();
            this.FeetMorphsTab = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.HeadMorphsTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.saveCharacterToolStripMenuItem,
            this.loadCharacterToolStripMenuItem,
            this.toolStripSeparator1,
            this.importClothingToolStripMenuItem,
            this.exportEngineReadyMeshToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            // 
            // saveCharacterToolStripMenuItem
            // 
            this.saveCharacterToolStripMenuItem.Name = "saveCharacterToolStripMenuItem";
            this.saveCharacterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveCharacterToolStripMenuItem.Text = "Save Character";
            // 
            // loadCharacterToolStripMenuItem
            // 
            this.loadCharacterToolStripMenuItem.Name = "loadCharacterToolStripMenuItem";
            this.loadCharacterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.loadCharacterToolStripMenuItem.Text = "Load Character";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // importClothingToolStripMenuItem
            // 
            this.importClothingToolStripMenuItem.Name = "importClothingToolStripMenuItem";
            this.importClothingToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.importClothingToolStripMenuItem.Text = "Import Clothing";
            // 
            // exportEngineReadyMeshToolStripMenuItem
            // 
            this.exportEngineReadyMeshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gLTransmissionFormatGLTFToolStripMenuItem,
            this.autodeskFBXToolStripMenuItem,
            this.colladaDAEToolStripMenuItem});
            this.exportEngineReadyMeshToolStripMenuItem.Name = "exportEngineReadyMeshToolStripMenuItem";
            this.exportEngineReadyMeshToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exportEngineReadyMeshToolStripMenuItem.Text = "Export Engine Ready Mesh";
            // 
            // gLTransmissionFormatGLTFToolStripMenuItem
            // 
            this.gLTransmissionFormatGLTFToolStripMenuItem.Name = "gLTransmissionFormatGLTFToolStripMenuItem";
            this.gLTransmissionFormatGLTFToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.gLTransmissionFormatGLTFToolStripMenuItem.Text = "GL Transmission Format GLTF";
            // 
            // autodeskFBXToolStripMenuItem
            // 
            this.autodeskFBXToolStripMenuItem.Name = "autodeskFBXToolStripMenuItem";
            this.autodeskFBXToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.autodeskFBXToolStripMenuItem.Text = "Autodesk FBX";
            // 
            // colladaDAEToolStripMenuItem
            // 
            this.colladaDAEToolStripMenuItem.Name = "colladaDAEToolStripMenuItem";
            this.colladaDAEToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.colladaDAEToolStripMenuItem.Text = "Collada DAE";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68354F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.78481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.61076F));
            this.tableLayoutPanel1.Controls.Add(this.SceneView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 635);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SceneView
            // 
            this.SceneView.BackColor = System.Drawing.Color.Black;
            this.SceneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SceneView.Location = new System.Drawing.Point(314, 3);
            this.SceneView.Name = "SceneView";
            this.SceneView.Size = new System.Drawing.Size(597, 629);
            this.SceneView.TabIndex = 0;
            this.SceneView.VSync = false;
            this.SceneView.Load += new System.EventHandler(this.SceneView_Load);
            this.SceneView.Paint += new System.Windows.Forms.PaintEventHandler(this.SceneView_Paint);
            this.SceneView.Resize += new System.EventHandler(this.SceneView_Resize);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView2);
            this.splitContainer1.Size = new System.Drawing.Size(305, 629);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(305, 262);
            this.treeView1.TabIndex = 0;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(305, 363);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HeadMorphsTab);
            this.tabControl1.Controls.Add(this.FaceMorphsTab);
            this.tabControl1.Controls.Add(this.UpperBodyMorphsTab);
            this.tabControl1.Controls.Add(this.LowerBodyMorphsTab);
            this.tabControl1.Controls.Add(this.HandMorphsTab);
            this.tabControl1.Controls.Add(this.FeetMorphsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(917, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 629);
            this.tabControl1.TabIndex = 2;
            // 
            // HeadMorphsTab
            // 
            this.HeadMorphsTab.Controls.Add(this.flowLayoutPanel1);
            this.HeadMorphsTab.Location = new System.Drawing.Point(4, 22);
            this.HeadMorphsTab.Name = "HeadMorphsTab";
            this.HeadMorphsTab.Padding = new System.Windows.Forms.Padding(3);
            this.HeadMorphsTab.Size = new System.Drawing.Size(336, 603);
            this.HeadMorphsTab.TabIndex = 0;
            this.HeadMorphsTab.Text = "Head Morphs";
            this.HeadMorphsTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 597);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(254, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(242, 25);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(3, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(254, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(6, 19);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(242, 25);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // FaceMorphsTab
            // 
            this.FaceMorphsTab.Location = new System.Drawing.Point(4, 22);
            this.FaceMorphsTab.Name = "FaceMorphsTab";
            this.FaceMorphsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FaceMorphsTab.Size = new System.Drawing.Size(336, 603);
            this.FaceMorphsTab.TabIndex = 1;
            this.FaceMorphsTab.Text = "Face Morphs";
            this.FaceMorphsTab.UseVisualStyleBackColor = true;
            // 
            // UpperBodyMorphsTab
            // 
            this.UpperBodyMorphsTab.Location = new System.Drawing.Point(4, 22);
            this.UpperBodyMorphsTab.Name = "UpperBodyMorphsTab";
            this.UpperBodyMorphsTab.Size = new System.Drawing.Size(336, 603);
            this.UpperBodyMorphsTab.TabIndex = 2;
            this.UpperBodyMorphsTab.Text = "Upper Body Morphs";
            this.UpperBodyMorphsTab.UseVisualStyleBackColor = true;
            // 
            // LowerBodyMorphsTab
            // 
            this.LowerBodyMorphsTab.Location = new System.Drawing.Point(4, 22);
            this.LowerBodyMorphsTab.Name = "LowerBodyMorphsTab";
            this.LowerBodyMorphsTab.Size = new System.Drawing.Size(336, 603);
            this.LowerBodyMorphsTab.TabIndex = 3;
            this.LowerBodyMorphsTab.Text = "Lower Body Morphs";
            this.LowerBodyMorphsTab.UseVisualStyleBackColor = true;
            // 
            // HandMorphsTab
            // 
            this.HandMorphsTab.Location = new System.Drawing.Point(4, 22);
            this.HandMorphsTab.Name = "HandMorphsTab";
            this.HandMorphsTab.Size = new System.Drawing.Size(336, 603);
            this.HandMorphsTab.TabIndex = 4;
            this.HandMorphsTab.Text = "Hand Morphs";
            this.HandMorphsTab.UseVisualStyleBackColor = true;
            // 
            // FeetMorphsTab
            // 
            this.FeetMorphsTab.Location = new System.Drawing.Point(4, 22);
            this.FeetMorphsTab.Name = "FeetMorphsTab";
            this.FeetMorphsTab.Size = new System.Drawing.Size(336, 603);
            this.FeetMorphsTab.TabIndex = 5;
            this.FeetMorphsTab.Text = "Feet Morphs";
            this.FeetMorphsTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.HeadMorphsTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importClothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportEngineReadyMeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gLTransmissionFormatGLTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autodeskFBXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colladaDAEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private OpenTK.GLControl SceneView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HeadMorphsTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TabPage FaceMorphsTab;
        private System.Windows.Forms.TabPage UpperBodyMorphsTab;
        private System.Windows.Forms.TabPage LowerBodyMorphsTab;
        private System.Windows.Forms.TabPage HandMorphsTab;
        private System.Windows.Forms.TabPage FeetMorphsTab;
    }
}

