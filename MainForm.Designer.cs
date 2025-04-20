partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.siticoneControlBox2 = new ns1.SiticoneControlBox();
            this.siticoneControlBox1 = new ns1.SiticoneControlBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.firefoxMainTabControl1 = new FirefoxMainTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.siticoneComboBox8 = new ns1.SiticoneComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gunaGradientButton5 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLineTextBox3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.siticoneCheckBox7 = new ns1.SiticoneCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLineTextBox2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.siticoneCheckBox6 = new ns1.SiticoneCheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.siticoneCheckBox3 = new ns1.SiticoneCheckBox();
            this.siticoneCheckBox5 = new ns1.SiticoneCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.siticoneCheckBox4 = new ns1.SiticoneCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siticoneCheckBox1 = new ns1.SiticoneCheckBox();
            this.siticoneCheckBox2 = new ns1.SiticoneCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaVSeparator3 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaVSeparator4 = new Guna.UI.WinForms.GunaVSeparator();
            this.metroLabel4 = new MetroSuite.MetroLabel();
            this.metroLabel5 = new MetroSuite.MetroLabel();
            this.metroLabel6 = new MetroSuite.MetroLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaVSeparator2 = new Guna.UI.WinForms.GunaVSeparator();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.metroLabel3 = new MetroSuite.MetroLabel();
            this.metroLabel2 = new MetroSuite.MetroLabel();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.firefoxMainTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = ns5.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneControlBox2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(711, 12);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(756, 12);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Wave audio file (*.wav)|*.wav";
            this.saveFileDialog1.Title = "Select your output directory";
            // 
            // firefoxMainTabControl1
            // 
            this.firefoxMainTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.firefoxMainTabControl1.Controls.Add(this.tabPage1);
            this.firefoxMainTabControl1.Controls.Add(this.tabPage2);
            this.firefoxMainTabControl1.Controls.Add(this.tabPage3);
            this.firefoxMainTabControl1.ItemSize = new System.Drawing.Size(43, 152);
            this.firefoxMainTabControl1.Location = new System.Drawing.Point(1, 42);
            this.firefoxMainTabControl1.Multiline = true;
            this.firefoxMainTabControl1.Name = "firefoxMainTabControl1";
            this.firefoxMainTabControl1.SelectedIndex = 0;
            this.firefoxMainTabControl1.Size = new System.Drawing.Size(806, 521);
            this.firefoxMainTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.firefoxMainTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabPage1.Location = new System.Drawing.Point(156, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rec Settings";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.siticoneComboBox8);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox7.Location = new System.Drawing.Point(344, 410);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(286, 82);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Audio Merging Method";
            // 
            // siticoneComboBox8
            // 
            this.siticoneComboBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneComboBox8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneComboBox8.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneComboBox8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox8.ForeColor = System.Drawing.Color.White;
            this.siticoneComboBox8.FormattingEnabled = true;
            this.siticoneComboBox8.HoveredState.Parent = this.siticoneComboBox8;
            this.siticoneComboBox8.ItemHeight = 30;
            this.siticoneComboBox8.Items.AddRange(new object[] {
            "FFMpeg"});
            this.siticoneComboBox8.ItemsAppearance.Parent = this.siticoneComboBox8;
            this.siticoneComboBox8.Location = new System.Drawing.Point(10, 26);
            this.siticoneComboBox8.Name = "siticoneComboBox8";
            this.siticoneComboBox8.ShadowDecoration.Parent = this.siticoneComboBox8;
            this.siticoneComboBox8.Size = new System.Drawing.Size(266, 36);
            this.siticoneComboBox8.TabIndex = 62;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gunaGradientButton5);
            this.groupBox6.Controls.Add(this.gunaLineTextBox3);
            this.groupBox6.Controls.Add(this.siticoneCheckBox7);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox6.Location = new System.Drawing.Point(16, 308);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(614, 96);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Output devices audio merging";
            // 
            // gunaGradientButton5
            // 
            this.gunaGradientButton5.Animated = true;
            this.gunaGradientButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton5.AnimationSpeed = 0.03F;
            this.gunaGradientButton5.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientButton5.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaGradientButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton5.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.Image = null;
            this.gunaGradientButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton5.Location = new System.Drawing.Point(553, 48);
            this.gunaGradientButton5.Name = "gunaGradientButton5";
            this.gunaGradientButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.gunaGradientButton5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.gunaGradientButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.OnHoverImage = null;
            this.gunaGradientButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Size = new System.Drawing.Size(49, 26);
            this.gunaGradientButton5.TabIndex = 30;
            this.gunaGradientButton5.Text = "...";
            this.gunaGradientButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton5.Click += new System.EventHandler(this.gunaGradientButton5_Click);
            // 
            // gunaLineTextBox3
            // 
            this.gunaLineTextBox3.Animated = true;
            this.gunaLineTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaLineTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox3.LineSize = 1;
            this.gunaLineTextBox3.Location = new System.Drawing.Point(13, 48);
            this.gunaLineTextBox3.Name = "gunaLineTextBox3";
            this.gunaLineTextBox3.PasswordChar = '\0';
            this.gunaLineTextBox3.Size = new System.Drawing.Size(534, 26);
            this.gunaLineTextBox3.TabIndex = 3;
            // 
            // siticoneCheckBox7
            // 
            this.siticoneCheckBox7.AutoSize = true;
            this.siticoneCheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox7.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox7.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox7.Location = new System.Drawing.Point(13, 23);
            this.siticoneCheckBox7.Name = "siticoneCheckBox7";
            this.siticoneCheckBox7.Size = new System.Drawing.Size(393, 19);
            this.siticoneCheckBox7.TabIndex = 29;
            this.siticoneCheckBox7.Text = "Merge all output devices\' audio files into a unique one after recording";
            this.siticoneCheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox7.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox7.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gunaGradientButton4);
            this.groupBox5.Controls.Add(this.gunaLineTextBox2);
            this.groupBox5.Controls.Add(this.siticoneCheckBox6);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox5.Location = new System.Drawing.Point(16, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(614, 96);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input devices audio merging";
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.Animated = true;
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = null;
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(553, 48);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(49, 26);
            this.gunaGradientButton4.TabIndex = 30;
            this.gunaGradientButton4.Text = "...";
            this.gunaGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click);
            // 
            // gunaLineTextBox2
            // 
            this.gunaLineTextBox2.Animated = true;
            this.gunaLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaLineTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox2.LineSize = 1;
            this.gunaLineTextBox2.Location = new System.Drawing.Point(13, 48);
            this.gunaLineTextBox2.Name = "gunaLineTextBox2";
            this.gunaLineTextBox2.PasswordChar = '\0';
            this.gunaLineTextBox2.Size = new System.Drawing.Size(534, 26);
            this.gunaLineTextBox2.TabIndex = 3;
            // 
            // siticoneCheckBox6
            // 
            this.siticoneCheckBox6.AutoSize = true;
            this.siticoneCheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox6.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox6.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox6.Location = new System.Drawing.Point(13, 23);
            this.siticoneCheckBox6.Name = "siticoneCheckBox6";
            this.siticoneCheckBox6.Size = new System.Drawing.Size(385, 19);
            this.siticoneCheckBox6.TabIndex = 29;
            this.siticoneCheckBox6.Text = "Merge all input devices\' audio files into a unique one after recording";
            this.siticoneCheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox6.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox6.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.siticoneCheckBox3);
            this.groupBox4.Controls.Add(this.siticoneCheckBox5);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox4.Location = new System.Drawing.Point(16, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 82);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Post Recording";
            // 
            // siticoneCheckBox3
            // 
            this.siticoneCheckBox3.AutoSize = true;
            this.siticoneCheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox3.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox3.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox3.Location = new System.Drawing.Point(13, 46);
            this.siticoneCheckBox3.Name = "siticoneCheckBox3";
            this.siticoneCheckBox3.Size = new System.Drawing.Size(296, 19);
            this.siticoneCheckBox3.TabIndex = 30;
            this.siticoneCheckBox3.Text = "Delete all output devices\' audio files after recording";
            this.siticoneCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox3.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox3.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox5
            // 
            this.siticoneCheckBox5.AutoSize = true;
            this.siticoneCheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox5.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox5.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox5.Location = new System.Drawing.Point(13, 23);
            this.siticoneCheckBox5.Name = "siticoneCheckBox5";
            this.siticoneCheckBox5.Size = new System.Drawing.Size(288, 19);
            this.siticoneCheckBox5.TabIndex = 29;
            this.siticoneCheckBox5.Text = "Delete all input devices\' audio files after recording";
            this.siticoneCheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox5.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox5.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gunaGradientButton3);
            this.groupBox3.Controls.Add(this.gunaLineTextBox1);
            this.groupBox3.Controls.Add(this.siticoneCheckBox4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(16, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Audio Merging";
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.Animated = true;
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = null;
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(553, 48);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(49, 26);
            this.gunaGradientButton3.TabIndex = 30;
            this.gunaGradientButton3.Text = "...";
            this.gunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.Animated = true;
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLineTextBox1.LineSize = 1;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(13, 48);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.Size = new System.Drawing.Size(534, 26);
            this.gunaLineTextBox1.TabIndex = 3;
            // 
            // siticoneCheckBox4
            // 
            this.siticoneCheckBox4.AutoSize = true;
            this.siticoneCheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox4.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox4.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox4.Location = new System.Drawing.Point(13, 23);
            this.siticoneCheckBox4.Name = "siticoneCheckBox4";
            this.siticoneCheckBox4.Size = new System.Drawing.Size(309, 19);
            this.siticoneCheckBox4.TabIndex = 29;
            this.siticoneCheckBox4.Text = "Merge all audio files into a unique one after recording";
            this.siticoneCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox4.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox4.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gunaGradientButton2);
            this.groupBox2.Controls.Add(this.gunaGradientButton1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(190, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registration Phase";
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.Animated = true;
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.Enabled = false;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = null;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(222, 23);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(206, 42);
            this.gunaGradientButton2.TabIndex = 3;
            this.gunaGradientButton2.Text = "Stop Recording";
            this.gunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(10, 23);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(206, 42);
            this.gunaGradientButton1.TabIndex = 2;
            this.gunaGradientButton1.Text = "Start Recording";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siticoneCheckBox1);
            this.groupBox1.Controls.Add(this.siticoneCheckBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Settings";
            // 
            // siticoneCheckBox1
            // 
            this.siticoneCheckBox1.AutoSize = true;
            this.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox1.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox1.Location = new System.Drawing.Point(13, 46);
            this.siticoneCheckBox1.Name = "siticoneCheckBox1";
            this.siticoneCheckBox1.Size = new System.Drawing.Size(144, 19);
            this.siticoneCheckBox1.TabIndex = 30;
            this.siticoneCheckBox1.Text = "Record output devices";
            this.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox1.UseVisualStyleBackColor = true;
            // 
            // siticoneCheckBox2
            // 
            this.siticoneCheckBox2.AutoSize = true;
            this.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox2.CheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.CheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.siticoneCheckBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCheckBox2.Location = new System.Drawing.Point(13, 23);
            this.siticoneCheckBox2.Name = "siticoneCheckBox2";
            this.siticoneCheckBox2.Size = new System.Drawing.Size(136, 19);
            this.siticoneCheckBox2.TabIndex = 29;
            this.siticoneCheckBox2.Text = "Record input devices";
            this.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UncheckedState.BorderRadius = 2;
            this.siticoneCheckBox2.UncheckedState.BorderThickness = 0;
            this.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneCheckBox2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabPage2.Location = new System.Drawing.Point(156, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input Devices";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gunaVSeparator3);
            this.panel1.Controls.Add(this.gunaVSeparator4);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 507);
            this.panel1.TabIndex = 7;
            // 
            // gunaVSeparator3
            // 
            this.gunaVSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator3.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator3.Location = new System.Drawing.Point(281, -1);
            this.gunaVSeparator3.Name = "gunaVSeparator3";
            this.gunaVSeparator3.Size = new System.Drawing.Size(10, 506);
            this.gunaVSeparator3.TabIndex = 7;
            // 
            // gunaVSeparator4
            // 
            this.gunaVSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator4.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator4.Location = new System.Drawing.Point(58, -1);
            this.gunaVSeparator4.Name = "gunaVSeparator4";
            this.gunaVSeparator4.Size = new System.Drawing.Size(10, 506);
            this.gunaVSeparator4.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(298, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(123, 15);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "OUTPUT DIRECTORY";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(77, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 15);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "DEVICE NAME";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(11, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 15);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "ACTIVE";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.tabPage3.Location = new System.Drawing.Point(156, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output Devices";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gunaVSeparator2);
            this.panel2.Controls.Add(this.gunaVSeparator1);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 507);
            this.panel2.TabIndex = 6;
            // 
            // gunaVSeparator2
            // 
            this.gunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator2.Location = new System.Drawing.Point(281, -1);
            this.gunaVSeparator2.Name = "gunaVSeparator2";
            this.gunaVSeparator2.Size = new System.Drawing.Size(10, 506);
            this.gunaVSeparator2.TabIndex = 7;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(58, -1);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 506);
            this.gunaVSeparator1.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(298, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 15);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "OUTPUT DIRECTORY";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(77, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 15);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "DEVICE NAME";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(11, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 15);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ACTIVE";
            // 
            // MainForm
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 570);
            this.Controls.Add(this.firefoxMainTabControl1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Normal;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "XRecorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.firefoxMainTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }

    private ns1.SiticoneControlBox siticoneControlBox2;
    private ns1.SiticoneControlBox siticoneControlBox1;
    private FirefoxMainTabControl firefoxMainTabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Panel panel2;
    private Guna.UI.WinForms.GunaVSeparator gunaVSeparator2;
    private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
    private MetroSuite.MetroLabel metroLabel3;
    private MetroSuite.MetroLabel metroLabel2;
    private MetroSuite.MetroLabel metroLabel1;
    private System.Windows.Forms.Panel panel1;
    private Guna.UI.WinForms.GunaVSeparator gunaVSeparator3;
    private Guna.UI.WinForms.GunaVSeparator gunaVSeparator4;
    private MetroSuite.MetroLabel metroLabel4;
    private MetroSuite.MetroLabel metroLabel5;
    private MetroSuite.MetroLabel metroLabel6;
    private System.Windows.Forms.GroupBox groupBox1;
    private ns1.SiticoneCheckBox siticoneCheckBox1;
    private ns1.SiticoneCheckBox siticoneCheckBox2;
    private System.Windows.Forms.GroupBox groupBox2;
    private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
    private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    private System.Windows.Forms.GroupBox groupBox3;
    private ns1.SiticoneCheckBox siticoneCheckBox4;
    private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
    private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
    private System.Windows.Forms.GroupBox groupBox4;
    private ns1.SiticoneCheckBox siticoneCheckBox3;
    private ns1.SiticoneCheckBox siticoneCheckBox5;
    private System.Windows.Forms.GroupBox groupBox6;
    private Guna.UI.WinForms.GunaGradientButton gunaGradientButton5;
    private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox3;
    private ns1.SiticoneCheckBox siticoneCheckBox7;
    private System.Windows.Forms.GroupBox groupBox5;
    private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
    private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox2;
    private ns1.SiticoneCheckBox siticoneCheckBox6;
    private System.Windows.Forms.GroupBox groupBox7;
    private ns1.SiticoneComboBox siticoneComboBox8;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
}