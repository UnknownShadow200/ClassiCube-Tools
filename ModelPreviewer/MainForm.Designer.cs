﻿
namespace ModelPreviewer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.renderer = new OpenTK.GLControl();
			this.gbCamera = new System.Windows.Forms.GroupBox();
			this.numDistance = new System.Windows.Forms.NumericUpDown();
			this.numZ = new System.Windows.Forms.NumericUpDown();
			this.numY = new System.Windows.Forms.NumericUpDown();
			this.numX = new System.Windows.Forms.NumericUpDown();
			this.numFov = new System.Windows.Forms.NumericUpDown();
			this.lblDistance = new System.Windows.Forms.Label();
			this.lblFov = new System.Windows.Forms.Label();
			this.lblTarget = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnImport = new System.Windows.Forms.ToolStripButton();
			this.btnExport = new System.Windows.Forms.ToolStripButton();
			this.btnExportCode = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnModelTex = new System.Windows.Forms.ToolStripButton();
			this.btnGridTex = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnXGrid = new System.Windows.Forms.ToolStripButton();
			this.btnYGrid = new System.Windows.Forms.ToolStripButton();
			this.btnZGrid = new System.Windows.Forms.ToolStripButton();
			this.gbModel = new System.Windows.Forms.GroupBox();
			this.numPitch = new System.Windows.Forms.NumericUpDown();
			this.lblPitch = new System.Windows.Forms.Label();
			this.numYaw = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.cbState = new System.Windows.Forms.ComboBox();
			this.gbPart = new System.Windows.Forms.GroupBox();
			this.cbAxisLines = new System.Windows.Forms.CheckBox();
			this.txtZAnim = new System.Windows.Forms.TextBox();
			this.lblZAnim = new System.Windows.Forms.Label();
			this.txtYAnim = new System.Windows.Forms.TextBox();
			this.lblYAnim = new System.Windows.Forms.Label();
			this.txtXAnim = new System.Windows.Forms.TextBox();
			this.lblXAnim = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.cbWireframe = new System.Windows.Forms.CheckBox();
			this.cbAlphaTesting = new System.Windows.Forms.CheckBox();
			this.cbRotate = new System.Windows.Forms.CheckBox();
			this.numTexY = new System.Windows.Forms.NumericUpDown();
			this.numTexX = new System.Windows.Forms.NumericUpDown();
			this.lblTex = new System.Windows.Forms.Label();
			this.lblRot = new System.Windows.Forms.Label();
			this.numRotZ = new System.Windows.Forms.NumericUpDown();
			this.numRotY = new System.Windows.Forms.NumericUpDown();
			this.numRotX = new System.Windows.Forms.NumericUpDown();
			this.lblP2 = new System.Windows.Forms.Label();
			this.numP2_Z = new System.Windows.Forms.NumericUpDown();
			this.numP2_Y = new System.Windows.Forms.NumericUpDown();
			this.numP2_X = new System.Windows.Forms.NumericUpDown();
			this.numP1_Z = new System.Windows.Forms.NumericUpDown();
			this.numP1_Y = new System.Windows.Forms.NumericUpDown();
			this.numP1_X = new System.Windows.Forms.NumericUpDown();
			this.lblP1 = new System.Windows.Forms.Label();
			this.lbModels = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.gbCamera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFov)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.gbModel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numYaw)).BeginInit();
			this.gbPart.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTexY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTexX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numP2_Z)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numP2_Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numP2_X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numP1_Z)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numP1_Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numP1_X)).BeginInit();
			this.SuspendLayout();
			// 
			// renderer
			// 
			this.renderer.BackColor = System.Drawing.Color.Black;
			this.renderer.Location = new System.Drawing.Point(210, 12);
			this.renderer.Name = "renderer";
			this.renderer.Size = new System.Drawing.Size(640, 480);
			this.renderer.TabIndex = 1;
			this.renderer.VSync = false;
			this.renderer.Load += new System.EventHandler(this.RendererLoad);
			this.renderer.Paint += new System.Windows.Forms.PaintEventHandler(this.RendererPaint);
			this.renderer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouseDown);
			this.renderer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouseMove);
			this.renderer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HandleMouseUp);
			this.renderer.Resize += new System.EventHandler(this.HandleResize);
			// 
			// gbCamera
			// 
			this.gbCamera.Controls.Add(this.numDistance);
			this.gbCamera.Controls.Add(this.numZ);
			this.gbCamera.Controls.Add(this.numY);
			this.gbCamera.Controls.Add(this.numX);
			this.gbCamera.Controls.Add(this.numFov);
			this.gbCamera.Controls.Add(this.lblDistance);
			this.gbCamera.Controls.Add(this.lblFov);
			this.gbCamera.Controls.Add(this.lblTarget);
			this.gbCamera.Location = new System.Drawing.Point(4, 31);
			this.gbCamera.Name = "gbCamera";
			this.gbCamera.Size = new System.Drawing.Size(200, 100);
			this.gbCamera.TabIndex = 11;
			this.gbCamera.TabStop = false;
			this.gbCamera.Text = "Camera settings";
			// 
			// numDistance
			// 
			this.numDistance.DecimalPlaces = 3;
			this.numDistance.Increment = new decimal(new int[] {
									625,
									0,
									0,
									262144});
			this.numDistance.Location = new System.Drawing.Point(62, 71);
			this.numDistance.Maximum = new decimal(new int[] {
									300,
									0,
									0,
									0});
			this.numDistance.Name = "numDistance";
			this.numDistance.Size = new System.Drawing.Size(131, 20);
			this.numDistance.TabIndex = 11;
			this.numDistance.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			this.numDistance.ValueChanged += new System.EventHandler(this.NumDistanceValueChanged);
			// 
			// numZ
			// 
			this.numZ.Location = new System.Drawing.Point(153, 19);
			this.numZ.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numZ.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numZ.Name = "numZ";
			this.numZ.Size = new System.Drawing.Size(40, 20);
			this.numZ.TabIndex = 10;
			this.numZ.ValueChanged += new System.EventHandler(this.NumZValueChanged);
			// 
			// numY
			// 
			this.numY.Location = new System.Drawing.Point(107, 19);
			this.numY.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numY.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numY.Name = "numY";
			this.numY.Size = new System.Drawing.Size(40, 20);
			this.numY.TabIndex = 9;
			this.numY.ValueChanged += new System.EventHandler(this.NumYValueChanged);
			// 
			// numX
			// 
			this.numX.Location = new System.Drawing.Point(62, 19);
			this.numX.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numX.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numX.Name = "numX";
			this.numX.Size = new System.Drawing.Size(40, 20);
			this.numX.TabIndex = 8;
			this.numX.ValueChanged += new System.EventHandler(this.NumXValueChanged);
			// 
			// numFov
			// 
			this.numFov.Location = new System.Drawing.Point(62, 45);
			this.numFov.Maximum = new decimal(new int[] {
									180,
									0,
									0,
									0});
			this.numFov.Name = "numFov";
			this.numFov.Size = new System.Drawing.Size(131, 20);
			this.numFov.TabIndex = 6;
			this.numFov.Value = new decimal(new int[] {
									70,
									0,
									0,
									0});
			this.numFov.ValueChanged += new System.EventHandler(this.NumFovValueChanged);
			// 
			// lblDistance
			// 
			this.lblDistance.AutoSize = true;
			this.lblDistance.Location = new System.Drawing.Point(8, 73);
			this.lblDistance.Name = "lblDistance";
			this.lblDistance.Size = new System.Drawing.Size(49, 13);
			this.lblDistance.TabIndex = 7;
			this.lblDistance.Text = "Distance";
			// 
			// lblFov
			// 
			this.lblFov.AutoSize = true;
			this.lblFov.Location = new System.Drawing.Point(8, 47);
			this.lblFov.Name = "lblFov";
			this.lblFov.Size = new System.Drawing.Size(28, 13);
			this.lblFov.TabIndex = 6;
			this.lblFov.Text = "FOV";
			// 
			// lblTarget
			// 
			this.lblTarget.AutoSize = true;
			this.lblTarget.Location = new System.Drawing.Point(8, 21);
			this.lblTarget.Name = "lblTarget";
			this.lblTarget.Size = new System.Drawing.Size(38, 13);
			this.lblTarget.TabIndex = 6;
			this.lblTarget.Text = "Target";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.btnImport,
									this.btnExport,
									this.btnExportCode,
									this.toolStripSeparator1,
									this.btnModelTex,
									this.btnGridTex,
									this.toolStripSeparator2,
									this.btnXGrid,
									this.btnYGrid,
									this.btnZGrid});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(982, 25);
			this.toolStrip1.TabIndex = 12;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnImport
			// 
			this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(43, 22);
			this.btnImport.Text = "Import";
			this.btnImport.Click += new System.EventHandler(this.BtnImportClick);
			// 
			// btnExport
			// 
			this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(43, 22);
			this.btnExport.Text = "Export";
			this.btnExport.Click += new System.EventHandler(this.BtnExportClick);
			// 
			// btnExportCode
			// 
			this.btnExportCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnExportCode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExportCode.Name = "btnExportCode";
			this.btnExportCode.Size = new System.Drawing.Size(69, 22);
			this.btnExportCode.Text = "Export code";
			this.btnExportCode.Click += new System.EventHandler(this.BtnExportCodeClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnModelTex
			// 
			this.btnModelTex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnModelTex.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnModelTex.Name = "btnModelTex";
			this.btnModelTex.Size = new System.Drawing.Size(78, 22);
			this.btnModelTex.Text = "Model texture";
			this.btnModelTex.Click += new System.EventHandler(this.BtnModelTexClick);
			// 
			// btnGridTex
			// 
			this.btnGridTex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnGridTex.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGridTex.Name = "btnGridTex";
			this.btnGridTex.Size = new System.Drawing.Size(74, 22);
			this.btnGridTex.Text = "Floor texture";
			this.btnGridTex.Click += new System.EventHandler(this.BtnGridTexClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnXGrid
			// 
			this.btnXGrid.Checked = true;
			this.btnXGrid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btnXGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnXGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXGrid.Name = "btnXGrid";
			this.btnXGrid.Size = new System.Drawing.Size(59, 22);
			this.btnXGrid.Text = "X gridlines";
			this.btnXGrid.Click += new System.EventHandler(this.BtnXGridClick);
			// 
			// btnYGrid
			// 
			this.btnYGrid.Checked = true;
			this.btnYGrid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btnYGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnYGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnYGrid.Name = "btnYGrid";
			this.btnYGrid.Size = new System.Drawing.Size(59, 22);
			this.btnYGrid.Text = "Y gridlines";
			this.btnYGrid.Click += new System.EventHandler(this.BtnYGridClick);
			// 
			// btnZGrid
			// 
			this.btnZGrid.Checked = true;
			this.btnZGrid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.btnZGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnZGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnZGrid.Name = "btnZGrid";
			this.btnZGrid.Size = new System.Drawing.Size(59, 22);
			this.btnZGrid.Text = "Z gridlines";
			this.btnZGrid.Click += new System.EventHandler(this.BtnZGridClick);
			// 
			// gbModel
			// 
			this.gbModel.Controls.Add(this.numPitch);
			this.gbModel.Controls.Add(this.lblPitch);
			this.gbModel.Controls.Add(this.numYaw);
			this.gbModel.Controls.Add(this.label1);
			this.gbModel.Controls.Add(this.lblState);
			this.gbModel.Controls.Add(this.cbState);
			this.gbModel.Location = new System.Drawing.Point(856, 28);
			this.gbModel.Name = "gbModel";
			this.gbModel.Size = new System.Drawing.Size(120, 103);
			this.gbModel.TabIndex = 12;
			this.gbModel.TabStop = false;
			this.gbModel.Text = "Model settings";
			// 
			// numPitch
			// 
			this.numPitch.Location = new System.Drawing.Point(46, 74);
			this.numPitch.Maximum = new decimal(new int[] {
									36000,
									0,
									0,
									0});
			this.numPitch.Minimum = new decimal(new int[] {
									36000,
									0,
									0,
									-2147483648});
			this.numPitch.Name = "numPitch";
			this.numPitch.Size = new System.Drawing.Size(68, 20);
			this.numPitch.TabIndex = 5;
			this.numPitch.ValueChanged += new System.EventHandler(this.NumPitchValueChanged);
			// 
			// lblPitch
			// 
			this.lblPitch.AutoSize = true;
			this.lblPitch.Location = new System.Drawing.Point(8, 74);
			this.lblPitch.Name = "lblPitch";
			this.lblPitch.Size = new System.Drawing.Size(31, 13);
			this.lblPitch.TabIndex = 4;
			this.lblPitch.Text = "Pitch";
			// 
			// numYaw
			// 
			this.numYaw.Location = new System.Drawing.Point(46, 47);
			this.numYaw.Maximum = new decimal(new int[] {
									36000,
									0,
									0,
									0});
			this.numYaw.Minimum = new decimal(new int[] {
									36000,
									0,
									0,
									-2147483648});
			this.numYaw.Name = "numYaw";
			this.numYaw.Size = new System.Drawing.Size(68, 20);
			this.numYaw.TabIndex = 3;
			this.numYaw.ValueChanged += new System.EventHandler(this.NumYawValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Yaw";
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(8, 22);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(32, 13);
			this.lblState.TabIndex = 1;
			this.lblState.Text = "State";
			// 
			// cbState
			// 
			this.cbState.FormattingEnabled = true;
			this.cbState.Items.AddRange(new object[] {
									"Still",
									"Idle",
									"Walk",
									"Run",
									"WalkNod",
									"RunNod"});
			this.cbState.Location = new System.Drawing.Point(46, 19);
			this.cbState.Name = "cbState";
			this.cbState.Size = new System.Drawing.Size(68, 21);
			this.cbState.TabIndex = 0;
			this.cbState.SelectedIndexChanged += new System.EventHandler(this.CbStateSelectedIndexChanged);
			// 
			// gbPart
			// 
			this.gbPart.Controls.Add(this.cbAxisLines);
			this.gbPart.Controls.Add(this.txtZAnim);
			this.gbPart.Controls.Add(this.lblZAnim);
			this.gbPart.Controls.Add(this.txtYAnim);
			this.gbPart.Controls.Add(this.lblYAnim);
			this.gbPart.Controls.Add(this.txtXAnim);
			this.gbPart.Controls.Add(this.lblXAnim);
			this.gbPart.Controls.Add(this.txtName);
			this.gbPart.Controls.Add(this.lblName);
			this.gbPart.Controls.Add(this.cbWireframe);
			this.gbPart.Controls.Add(this.cbAlphaTesting);
			this.gbPart.Controls.Add(this.cbRotate);
			this.gbPart.Controls.Add(this.numTexY);
			this.gbPart.Controls.Add(this.numTexX);
			this.gbPart.Controls.Add(this.lblTex);
			this.gbPart.Controls.Add(this.lblRot);
			this.gbPart.Controls.Add(this.numRotZ);
			this.gbPart.Controls.Add(this.numRotY);
			this.gbPart.Controls.Add(this.numRotX);
			this.gbPart.Controls.Add(this.lblP2);
			this.gbPart.Controls.Add(this.numP2_Z);
			this.gbPart.Controls.Add(this.numP2_Y);
			this.gbPart.Controls.Add(this.numP2_X);
			this.gbPart.Controls.Add(this.numP1_Z);
			this.gbPart.Controls.Add(this.numP1_Y);
			this.gbPart.Controls.Add(this.numP1_X);
			this.gbPart.Controls.Add(this.lblP1);
			this.gbPart.Location = new System.Drawing.Point(4, 137);
			this.gbPart.Name = "gbPart";
			this.gbPart.Size = new System.Drawing.Size(200, 347);
			this.gbPart.TabIndex = 12;
			this.gbPart.TabStop = false;
			this.gbPart.Text = "Model part data";
			// 
			// cbAxisLines
			// 
			this.cbAxisLines.Location = new System.Drawing.Point(8, 321);
			this.cbAxisLines.Name = "cbAxisLines";
			this.cbAxisLines.Size = new System.Drawing.Size(175, 24);
			this.cbAxisLines.TabIndex = 39;
			this.cbAxisLines.Text = "Axis lines";
			this.cbAxisLines.UseVisualStyleBackColor = true;
			this.cbAxisLines.CheckedChanged += new System.EventHandler(this.CbAxisLinesCheckedChanged);
			// 
			// txtZAnim
			// 
			this.txtZAnim.Location = new System.Drawing.Point(61, 189);
			this.txtZAnim.MaxLength = 32;
			this.txtZAnim.Name = "txtZAnim";
			this.txtZAnim.Size = new System.Drawing.Size(100, 20);
			this.txtZAnim.TabIndex = 38;
			this.txtZAnim.TextChanged += new System.EventHandler(this.TxtZAnimTextChanged);
			// 
			// lblZAnim
			// 
			this.lblZAnim.AutoSize = true;
			this.lblZAnim.Location = new System.Drawing.Point(8, 192);
			this.lblZAnim.Name = "lblZAnim";
			this.lblZAnim.Size = new System.Drawing.Size(39, 13);
			this.lblZAnim.TabIndex = 37;
			this.lblZAnim.Text = "Z anim";
			// 
			// txtYAnim
			// 
			this.txtYAnim.Location = new System.Drawing.Point(61, 163);
			this.txtYAnim.MaxLength = 32;
			this.txtYAnim.Name = "txtYAnim";
			this.txtYAnim.Size = new System.Drawing.Size(100, 20);
			this.txtYAnim.TabIndex = 36;
			this.txtYAnim.TextChanged += new System.EventHandler(this.TxtYAnimTextChanged);
			// 
			// lblYAnim
			// 
			this.lblYAnim.AutoSize = true;
			this.lblYAnim.Location = new System.Drawing.Point(8, 166);
			this.lblYAnim.Name = "lblYAnim";
			this.lblYAnim.Size = new System.Drawing.Size(39, 13);
			this.lblYAnim.TabIndex = 35;
			this.lblYAnim.Text = "Y anim";
			// 
			// txtXAnim
			// 
			this.txtXAnim.Location = new System.Drawing.Point(61, 137);
			this.txtXAnim.MaxLength = 32;
			this.txtXAnim.Name = "txtXAnim";
			this.txtXAnim.Size = new System.Drawing.Size(100, 20);
			this.txtXAnim.TabIndex = 34;
			this.txtXAnim.TextChanged += new System.EventHandler(this.TxtXAnimTextChanged);
			// 
			// lblXAnim
			// 
			this.lblXAnim.AutoSize = true;
			this.lblXAnim.Location = new System.Drawing.Point(8, 140);
			this.lblXAnim.Name = "lblXAnim";
			this.lblXAnim.Size = new System.Drawing.Size(39, 13);
			this.lblXAnim.TabIndex = 33;
			this.lblXAnim.Text = "X anim";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(61, 231);
			this.txtName.MaxLength = 32;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 32;
			this.txtName.TextChanged += new System.EventHandler(this.TxtNameTextChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(8, 234);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 31;
			this.lblName.Text = "Name";
			// 
			// cbWireframe
			// 
			this.cbWireframe.Location = new System.Drawing.Point(8, 299);
			this.cbWireframe.Name = "cbWireframe";
			this.cbWireframe.Size = new System.Drawing.Size(175, 24);
			this.cbWireframe.TabIndex = 30;
			this.cbWireframe.Text = "Wireframe mode";
			this.cbWireframe.UseVisualStyleBackColor = true;
			this.cbWireframe.CheckedChanged += new System.EventHandler(this.CbWireframeCheckedChanged);
			// 
			// cbAlphaTesting
			// 
			this.cbAlphaTesting.Location = new System.Drawing.Point(8, 277);
			this.cbAlphaTesting.Name = "cbAlphaTesting";
			this.cbAlphaTesting.Size = new System.Drawing.Size(175, 24);
			this.cbAlphaTesting.TabIndex = 29;
			this.cbAlphaTesting.Text = "Alpha test (e.g. for player hat)";
			this.cbAlphaTesting.UseVisualStyleBackColor = true;
			this.cbAlphaTesting.CheckedChanged += new System.EventHandler(this.CbAlphaTestingCheckedChanged);
			// 
			// cbRotate
			// 
			this.cbRotate.Location = new System.Drawing.Point(8, 254);
			this.cbRotate.Name = "cbRotate";
			this.cbRotate.Size = new System.Drawing.Size(173, 24);
			this.cbRotate.TabIndex = 28;
			this.cbRotate.Text = "Rotate part (e.g. for pig body)";
			this.cbRotate.UseVisualStyleBackColor = true;
			this.cbRotate.CheckedChanged += new System.EventHandler(this.CbRotateCheckedChanged);
			// 
			// numTexY
			// 
			this.numTexY.Location = new System.Drawing.Point(107, 70);
			this.numTexY.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numTexY.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numTexY.Name = "numTexY";
			this.numTexY.Size = new System.Drawing.Size(40, 20);
			this.numTexY.TabIndex = 27;
			this.numTexY.ValueChanged += new System.EventHandler(this.NumTexYValueChanged);
			// 
			// numTexX
			// 
			this.numTexX.Location = new System.Drawing.Point(61, 70);
			this.numTexX.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numTexX.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numTexX.Name = "numTexX";
			this.numTexX.Size = new System.Drawing.Size(40, 20);
			this.numTexX.TabIndex = 26;
			this.numTexX.ValueChanged += new System.EventHandler(this.NumTexXValueChanged);
			// 
			// lblTex
			// 
			this.lblTex.AutoSize = true;
			this.lblTex.Location = new System.Drawing.Point(8, 72);
			this.lblTex.Name = "lblTex";
			this.lblTex.Size = new System.Drawing.Size(53, 13);
			this.lblTex.TabIndex = 25;
			this.lblTex.Text = "Tex origin";
			// 
			// lblRot
			// 
			this.lblRot.AutoSize = true;
			this.lblRot.Location = new System.Drawing.Point(8, 113);
			this.lblRot.Name = "lblRot";
			this.lblRot.Size = new System.Drawing.Size(52, 13);
			this.lblRot.TabIndex = 24;
			this.lblRot.Text = "Rot origin";
			// 
			// numRotZ
			// 
			this.numRotZ.Location = new System.Drawing.Point(153, 111);
			this.numRotZ.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numRotZ.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numRotZ.Name = "numRotZ";
			this.numRotZ.Size = new System.Drawing.Size(40, 20);
			this.numRotZ.TabIndex = 23;
			this.numRotZ.ValueChanged += new System.EventHandler(this.NumRotZValueChanged);
			// 
			// numRotY
			// 
			this.numRotY.Location = new System.Drawing.Point(107, 111);
			this.numRotY.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numRotY.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numRotY.Name = "numRotY";
			this.numRotY.Size = new System.Drawing.Size(40, 20);
			this.numRotY.TabIndex = 22;
			this.numRotY.ValueChanged += new System.EventHandler(this.NumRotYValueChanged);
			// 
			// numRotX
			// 
			this.numRotX.Location = new System.Drawing.Point(62, 111);
			this.numRotX.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numRotX.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numRotX.Name = "numRotX";
			this.numRotX.Size = new System.Drawing.Size(40, 20);
			this.numRotX.TabIndex = 21;
			this.numRotX.ValueChanged += new System.EventHandler(this.NumRotXValueChanged);
			// 
			// lblP2
			// 
			this.lblP2.AutoSize = true;
			this.lblP2.Location = new System.Drawing.Point(8, 46);
			this.lblP2.Name = "lblP2";
			this.lblP2.Size = new System.Drawing.Size(47, 13);
			this.lblP2.TabIndex = 20;
			this.lblP2.Text = "Point #2";
			// 
			// numP2_Z
			// 
			this.numP2_Z.Location = new System.Drawing.Point(154, 44);
			this.numP2_Z.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numP2_Z.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numP2_Z.Name = "numP2_Z";
			this.numP2_Z.Size = new System.Drawing.Size(40, 20);
			this.numP2_Z.TabIndex = 19;
			this.numP2_Z.ValueChanged += new System.EventHandler(this.NumP2_ZValueChanged);
			// 
			// numP2_Y
			// 
			this.numP2_Y.Location = new System.Drawing.Point(107, 44);
			this.numP2_Y.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numP2_Y.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numP2_Y.Name = "numP2_Y";
			this.numP2_Y.Size = new System.Drawing.Size(40, 20);
			this.numP2_Y.TabIndex = 18;
			this.numP2_Y.ValueChanged += new System.EventHandler(this.NumP2_YValueChanged);
			// 
			// numP2_X
			// 
			this.numP2_X.Location = new System.Drawing.Point(62, 44);
			this.numP2_X.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numP2_X.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numP2_X.Name = "numP2_X";
			this.numP2_X.Size = new System.Drawing.Size(40, 20);
			this.numP2_X.TabIndex = 17;
			this.numP2_X.ValueChanged += new System.EventHandler(this.NumP2_XValueChanged);
			// 
			// numP1_Z
			// 
			this.numP1_Z.Location = new System.Drawing.Point(153, 18);
			this.numP1_Z.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numP1_Z.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numP1_Z.Name = "numP1_Z";
			this.numP1_Z.Size = new System.Drawing.Size(40, 20);
			this.numP1_Z.TabIndex = 16;
			this.numP1_Z.ValueChanged += new System.EventHandler(this.Num_p1ZValueChanged);
			// 
			// numP1_Y
			// 
			this.numP1_Y.Location = new System.Drawing.Point(107, 18);
			this.numP1_Y.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numP1_Y.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numP1_Y.Name = "numP1_Y";
			this.numP1_Y.Size = new System.Drawing.Size(40, 20);
			this.numP1_Y.TabIndex = 15;
			this.numP1_Y.ValueChanged += new System.EventHandler(this.NumP1_YValueChanged);
			// 
			// numP1_X
			// 
			this.numP1_X.Location = new System.Drawing.Point(62, 18);
			this.numP1_X.Maximum = new decimal(new int[] {
									3600,
									0,
									0,
									0});
			this.numP1_X.Minimum = new decimal(new int[] {
									3600,
									0,
									0,
									-2147483648});
			this.numP1_X.Name = "numP1_X";
			this.numP1_X.Size = new System.Drawing.Size(40, 20);
			this.numP1_X.TabIndex = 14;
			this.numP1_X.ValueChanged += new System.EventHandler(this.NumP1_XValueChanged);
			// 
			// lblP1
			// 
			this.lblP1.AutoSize = true;
			this.lblP1.Location = new System.Drawing.Point(8, 20);
			this.lblP1.Name = "lblP1";
			this.lblP1.Size = new System.Drawing.Size(47, 13);
			this.lblP1.TabIndex = 13;
			this.lblP1.Text = "Point #1";
			// 
			// lbModels
			// 
			this.lbModels.FormattingEnabled = true;
			this.lbModels.Location = new System.Drawing.Point(856, 134);
			this.lbModels.Name = "lbModels";
			this.lbModels.Size = new System.Drawing.Size(120, 329);
			this.lbModels.TabIndex = 13;
			this.lbModels.SelectedIndexChanged += new System.EventHandler(this.LbModelsSelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(856, 469);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(53, 23);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(923, 469);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(53, 23);
			this.btnDel.TabIndex = 15;
			this.btnDel.Text = "Del";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 496);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbModels);
			this.Controls.Add(this.gbPart);
			this.Controls.Add(this.gbModel);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.gbCamera);
			this.Controls.Add(this.renderer);
			this.Name = "MainForm";
			this.Text = "ClassicalSharp Model Previewer";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.gbCamera.ResumeLayout(false);
			this.gbCamera.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFov)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.gbModel.ResumeLayout(false);
			this.gbModel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numYaw)).EndInit();
			this.gbPart.ResumeLayout(false);
			this.gbPart.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTexY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTexX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRotX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numP2_Z)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numP2_Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numP2_X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numP1_Z)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numP1_Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numP1_X)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox cbAxisLines;
		private System.Windows.Forms.ToolStripButton btnZGrid;
		private System.Windows.Forms.ToolStripButton btnYGrid;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Label lblZAnim;
		private System.Windows.Forms.TextBox txtZAnim;
		private System.Windows.Forms.Label lblXAnim;
		private System.Windows.Forms.TextBox txtXAnim;
		private System.Windows.Forms.Label lblYAnim;
		private System.Windows.Forms.TextBox txtYAnim;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.CheckBox cbRotate;
		private System.Windows.Forms.CheckBox cbAlphaTesting;
		private System.Windows.Forms.CheckBox cbWireframe;
		private System.Windows.Forms.NumericUpDown numRotX;
		private System.Windows.Forms.NumericUpDown numRotY;
		private System.Windows.Forms.NumericUpDown numRotZ;
		private System.Windows.Forms.Label lblTex;
		private System.Windows.Forms.NumericUpDown numTexX;
		private System.Windows.Forms.NumericUpDown numTexY;
		private System.Windows.Forms.Label lblP1;
		private System.Windows.Forms.NumericUpDown numP1_X;
		private System.Windows.Forms.NumericUpDown numP1_Y;
		private System.Windows.Forms.NumericUpDown numP1_Z;
		private System.Windows.Forms.NumericUpDown numP2_X;
		private System.Windows.Forms.NumericUpDown numP2_Y;
		private System.Windows.Forms.NumericUpDown numP2_Z;
		private System.Windows.Forms.Label lblP2;
		private System.Windows.Forms.Label lblRot;
		private System.Windows.Forms.Label lblTarget;
		private System.Windows.Forms.Label lblFov;
		private System.Windows.Forms.Label lblDistance;
		private System.Windows.Forms.NumericUpDown numFov;
		private System.Windows.Forms.NumericUpDown numX;
		private System.Windows.Forms.NumericUpDown numY;
		private System.Windows.Forms.NumericUpDown numZ;
		private System.Windows.Forms.NumericUpDown numDistance;
		private System.Windows.Forms.ListBox lbModels;
		private System.Windows.Forms.GroupBox gbPart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numYaw;
		private System.Windows.Forms.NumericUpDown numPitch;
		private System.Windows.Forms.ComboBox cbState;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.GroupBox gbModel;
		private System.Windows.Forms.ToolStripButton btnXGrid;
		private System.Windows.Forms.ToolStripButton btnGridTex;
		private System.Windows.Forms.ToolStripButton btnModelTex;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnExportCode;
		private System.Windows.Forms.ToolStripButton btnExport;
		private System.Windows.Forms.ToolStripButton btnImport;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.GroupBox gbCamera;
		private System.Windows.Forms.Label lblPitch;
		private OpenTK.GLControl renderer;
	}
}
