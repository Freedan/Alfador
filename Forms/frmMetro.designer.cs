namespace Alfador.Forms
{
    partial class frmMetro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetro));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabHomePage = new MetroFramework.Controls.MetroTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbRecent = new MetroFramework.Controls.MetroComboBox();
            this.cmbFavorites = new MetroFramework.Controls.MetroComboBox();
            this.btnPlay = new MetroFramework.Controls.MetroButton();
            this.tabOptions = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Core = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtInstallDirectory = new MetroFramework.Controls.MetroTextBox();
            this.chkRetroArchIntegrated = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.xbtnWriteConfig = new MetroFramework.Controls.MetroButton();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.lblCopiedFile = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.btnClearLogFile = new MetroFramework.Controls.MetroButton();
            this.btnCleanBackupFiles = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.btnCreateCueSheet = new MetroFramework.Controls.MetroButton();
            this.btnCreateM3uPlaylist = new MetroFramework.Controls.MetroButton();
            this.btnImportBIOS = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.btnExportSaveRam = new MetroFramework.Controls.MetroButton();
            this.btnImportSaveRam = new MetroFramework.Controls.MetroButton();
            this.btnExportRomLibrary = new MetroFramework.Controls.MetroButton();
            this.btnImportLibrary = new MetroFramework.Controls.MetroButton();
            this.tabLogView = new MetroFramework.Controls.MetroTabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabHomePage.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.tabLogView.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabHomePage);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.tabOptions);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.tabLogView);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 4;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 520);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Click += new System.EventHandler(this.metroTabControl1_Click);
            // 
            // tabHomePage
            // 
            this.tabHomePage.Controls.Add(this.textBox1);
            this.tabHomePage.Controls.Add(this.metroLabel2);
            this.tabHomePage.Controls.Add(this.metroLabel3);
            this.tabHomePage.HorizontalScrollbarBarColor = true;
            this.tabHomePage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabHomePage.HorizontalScrollbarSize = 10;
            this.tabHomePage.Location = new System.Drawing.Point(4, 44);
            this.tabHomePage.Name = "tabHomePage";
            this.tabHomePage.Size = new System.Drawing.Size(752, 472);
            this.tabHomePage.TabIndex = 6;
            this.tabHomePage.Text = "Home";
            this.tabHomePage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabHomePage.VerticalScrollbarBarColor = true;
            this.tabHomePage.VerticalScrollbarHighlightOnWheel = false;
            this.tabHomePage.VerticalScrollbarSize = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(752, 396);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "[1] Converted forms over to the MetroUI Framework\r\n[2] Deprecated stuff\r\n[3] Fixe" +
    "d Stuff";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "v.0.5.0.56";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(0, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 25);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "ChangeLog";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroGrid2);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.cmbRecent);
            this.metroTabPage1.Controls.Add(this.cmbFavorites);
            this.metroTabPage1.Controls.Add(this.btnPlay);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(752, 472);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Library";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeColumns = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid2.Location = new System.Drawing.Point(0, 85);
            this.metroGrid2.MultiSelect = false;
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid2.RowHeadersWidth = 25;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(752, 388);
            this.metroGrid2.TabIndex = 8;
            this.metroGrid2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ROM";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Core";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "System";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Location";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Launch String";
            this.Column5.Name = "Column5";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(154, 22);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 25);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Recent";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(-1, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 25);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Favorites";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbRecent
            // 
            this.cmbRecent.FormattingEnabled = true;
            this.cmbRecent.ItemHeight = 23;
            this.cmbRecent.Location = new System.Drawing.Point(154, 50);
            this.cmbRecent.Name = "cmbRecent";
            this.cmbRecent.Size = new System.Drawing.Size(145, 29);
            this.cmbRecent.TabIndex = 5;
            this.cmbRecent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbRecent.UseSelectable = true;
            // 
            // cmbFavorites
            // 
            this.cmbFavorites.FormattingEnabled = true;
            this.cmbFavorites.ItemHeight = 23;
            this.cmbFavorites.Location = new System.Drawing.Point(0, 50);
            this.cmbFavorites.Name = "cmbFavorites";
            this.cmbFavorites.Size = new System.Drawing.Size(148, 29);
            this.cmbFavorites.TabIndex = 4;
            this.cmbFavorites.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbFavorites.UseSelectable = true;
            // 
            // btnPlay
            // 
            this.btnPlay.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPlay.Location = new System.Drawing.Point(305, 50);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(447, 29);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPlay.UseSelectable = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.metroGrid1);
            this.tabOptions.Controls.Add(this.metroLabel1);
            this.tabOptions.Controls.Add(this.txtInstallDirectory);
            this.tabOptions.Controls.Add(this.chkRetroArchIntegrated);
            this.tabOptions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOptions.HorizontalScrollbarBarColor = true;
            this.tabOptions.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOptions.HorizontalScrollbarSize = 10;
            this.tabOptions.Location = new System.Drawing.Point(4, 44);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(752, 472);
            this.tabOptions.TabIndex = 3;
            this.tabOptions.Text = "Options";
            this.tabOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabOptions.VerticalScrollbar = true;
            this.tabOptions.VerticalScrollbarBarColor = true;
            this.tabOptions.VerticalScrollbarHighlightOnWheel = false;
            this.tabOptions.VerticalScrollbarSize = 10;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extension,
            this.Core});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 357);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(658, 128);
            this.metroGrid1.TabIndex = 5;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            // 
            // Core
            // 
            this.Core.HeaderText = "Core";
            this.Core.Name = "Core";
            this.Core.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Core.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(31, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Installation Directory";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtInstallDirectory
            // 
            // 
            // 
            // 
            this.txtInstallDirectory.CustomButton.Image = null;
            this.txtInstallDirectory.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.txtInstallDirectory.CustomButton.Name = "";
            this.txtInstallDirectory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInstallDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInstallDirectory.CustomButton.TabIndex = 1;
            this.txtInstallDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInstallDirectory.CustomButton.UseSelectable = true;
            this.txtInstallDirectory.CustomButton.Visible = false;
            this.txtInstallDirectory.Lines = new string[0];
            this.txtInstallDirectory.Location = new System.Drawing.Point(31, 59);
            this.txtInstallDirectory.MaxLength = 32767;
            this.txtInstallDirectory.Name = "txtInstallDirectory";
            this.txtInstallDirectory.PasswordChar = '\0';
            this.txtInstallDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInstallDirectory.SelectedText = "";
            this.txtInstallDirectory.SelectionLength = 0;
            this.txtInstallDirectory.SelectionStart = 0;
            this.txtInstallDirectory.ShortcutsEnabled = true;
            this.txtInstallDirectory.Size = new System.Drawing.Size(392, 23);
            this.txtInstallDirectory.TabIndex = 3;
            this.txtInstallDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtInstallDirectory.UseSelectable = true;
            this.txtInstallDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInstallDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkRetroArchIntegrated
            // 
            this.chkRetroArchIntegrated.AutoSize = true;
            this.chkRetroArchIntegrated.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chkRetroArchIntegrated.Location = new System.Drawing.Point(31, 268);
            this.chkRetroArchIntegrated.Name = "chkRetroArchIntegrated";
            this.chkRetroArchIntegrated.Size = new System.Drawing.Size(360, 25);
            this.chkRetroArchIntegrated.TabIndex = 2;
            this.chkRetroArchIntegrated.Text = "Enable RetroArch Integration (32-bit Only)";
            this.chkRetroArchIntegrated.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkRetroArchIntegrated.UseSelectable = true;
            this.chkRetroArchIntegrated.CheckedChanged += new System.EventHandler(this.chkRetroArchIntegrated_CheckedChanged);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.xbtnWriteConfig);
            this.metroTabPage3.Controls.Add(this.btnTest);
            this.metroTabPage3.Controls.Add(this.lblCopiedFile);
            this.metroTabPage3.Controls.Add(this.metroProgressBar1);
            this.metroTabPage3.Controls.Add(this.btnClearLogFile);
            this.metroTabPage3.Controls.Add(this.btnCleanBackupFiles);
            this.metroTabPage3.Controls.Add(this.metroButton9);
            this.metroTabPage3.Controls.Add(this.btnCreateCueSheet);
            this.metroTabPage3.Controls.Add(this.btnCreateM3uPlaylist);
            this.metroTabPage3.Controls.Add(this.btnImportBIOS);
            this.metroTabPage3.Controls.Add(this.metroButton5);
            this.metroTabPage3.Controls.Add(this.btnExportSaveRam);
            this.metroTabPage3.Controls.Add(this.btnImportSaveRam);
            this.metroTabPage3.Controls.Add(this.btnExportRomLibrary);
            this.metroTabPage3.Controls.Add(this.btnImportLibrary);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(752, 472);
            this.metroTabPage3.TabIndex = 4;
            this.metroTabPage3.Text = "Tools";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(292, 284);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "metroLabel6";
            // 
            // xbtnWriteConfig
            // 
            this.xbtnWriteConfig.Location = new System.Drawing.Point(19, 91);
            this.xbtnWriteConfig.Name = "xbtnWriteConfig";
            this.xbtnWriteConfig.Size = new System.Drawing.Size(175, 25);
            this.xbtnWriteConfig.Style = MetroFramework.MetroColorStyle.Blue;
            this.xbtnWriteConfig.TabIndex = 18;
            this.xbtnWriteConfig.Text = "Write Config File";
            this.xbtnWriteConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xbtnWriteConfig.UseSelectable = true;
            this.xbtnWriteConfig.Click += new System.EventHandler(this.xbtnWriteConfig_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(19, 60);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(175, 25);
            this.btnTest.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test";
            this.btnTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblCopiedFile
            // 
            this.lblCopiedFile.AutoSize = true;
            this.lblCopiedFile.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCopiedFile.Location = new System.Drawing.Point(3, 403);
            this.lblCopiedFile.Name = "lblCopiedFile";
            this.lblCopiedFile.Size = new System.Drawing.Size(106, 25);
            this.lblCopiedFile.TabIndex = 15;
            this.lblCopiedFile.Text = "metroLabel6";
            this.lblCopiedFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(3, 431);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(746, 23);
            this.metroProgressBar1.TabIndex = 14;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClearLogFile
            // 
            this.btnClearLogFile.Location = new System.Drawing.Point(381, 215);
            this.btnClearLogFile.Name = "btnClearLogFile";
            this.btnClearLogFile.Size = new System.Drawing.Size(175, 25);
            this.btnClearLogFile.TabIndex = 13;
            this.btnClearLogFile.Text = "Clear Log File";
            this.btnClearLogFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearLogFile.UseSelectable = true;
            this.btnClearLogFile.Click += new System.EventHandler(this.btnClearLogFile_Click);
            // 
            // btnCleanBackupFiles
            // 
            this.btnCleanBackupFiles.Enabled = false;
            this.btnCleanBackupFiles.Location = new System.Drawing.Point(381, 184);
            this.btnCleanBackupFiles.Name = "btnCleanBackupFiles";
            this.btnCleanBackupFiles.Size = new System.Drawing.Size(175, 25);
            this.btnCleanBackupFiles.TabIndex = 11;
            this.btnCleanBackupFiles.Text = "Clean Backup Files";
            this.btnCleanBackupFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCleanBackupFiles.UseSelectable = true;
            this.btnCleanBackupFiles.Click += new System.EventHandler(this.btnCleanBackupFiles_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Enabled = false;
            this.metroButton9.Location = new System.Drawing.Point(200, 184);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(175, 25);
            this.metroButton9.TabIndex = 10;
            this.metroButton9.Text = "Create Backup Package";
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton9.UseSelectable = true;
            // 
            // btnCreateCueSheet
            // 
            this.btnCreateCueSheet.Enabled = false;
            this.btnCreateCueSheet.Location = new System.Drawing.Point(381, 153);
            this.btnCreateCueSheet.Name = "btnCreateCueSheet";
            this.btnCreateCueSheet.Size = new System.Drawing.Size(175, 25);
            this.btnCreateCueSheet.TabIndex = 9;
            this.btnCreateCueSheet.Text = "Create Cue Sheet";
            this.btnCreateCueSheet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreateCueSheet.UseSelectable = true;
            this.btnCreateCueSheet.Click += new System.EventHandler(this.btnCreateCueSheet_Click);
            // 
            // btnCreateM3uPlaylist
            // 
            this.btnCreateM3uPlaylist.Enabled = false;
            this.btnCreateM3uPlaylist.Location = new System.Drawing.Point(381, 278);
            this.btnCreateM3uPlaylist.Name = "btnCreateM3uPlaylist";
            this.btnCreateM3uPlaylist.Size = new System.Drawing.Size(175, 25);
            this.btnCreateM3uPlaylist.TabIndex = 8;
            this.btnCreateM3uPlaylist.Text = "Create m3u Playlist";
            this.btnCreateM3uPlaylist.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreateM3uPlaylist.UseSelectable = true;
            this.btnCreateM3uPlaylist.Click += new System.EventHandler(this.btnCreateM3uPlaylist_Click);
            // 
            // btnImportBIOS
            // 
            this.btnImportBIOS.Enabled = false;
            this.btnImportBIOS.Location = new System.Drawing.Point(200, 122);
            this.btnImportBIOS.Name = "btnImportBIOS";
            this.btnImportBIOS.Size = new System.Drawing.Size(175, 25);
            this.btnImportBIOS.TabIndex = 7;
            this.btnImportBIOS.Text = "Import BIOS";
            this.btnImportBIOS.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImportBIOS.UseSelectable = true;
            this.btnImportBIOS.Click += new System.EventHandler(this.btnImportBIOS_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Enabled = false;
            this.metroButton5.Location = new System.Drawing.Point(381, 122);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(175, 25);
            this.metroButton5.TabIndex = 6;
            this.metroButton5.Text = "Export BIOS";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            // 
            // btnExportSaveRam
            // 
            this.btnExportSaveRam.Enabled = false;
            this.btnExportSaveRam.Location = new System.Drawing.Point(381, 91);
            this.btnExportSaveRam.Name = "btnExportSaveRam";
            this.btnExportSaveRam.Size = new System.Drawing.Size(175, 25);
            this.btnExportSaveRam.TabIndex = 5;
            this.btnExportSaveRam.Text = "Export SaveRAM";
            this.btnExportSaveRam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExportSaveRam.UseSelectable = true;
            this.btnExportSaveRam.Click += new System.EventHandler(this.btnExportSaveRam_Click);
            // 
            // btnImportSaveRam
            // 
            this.btnImportSaveRam.Enabled = false;
            this.btnImportSaveRam.Location = new System.Drawing.Point(200, 91);
            this.btnImportSaveRam.Name = "btnImportSaveRam";
            this.btnImportSaveRam.Size = new System.Drawing.Size(175, 25);
            this.btnImportSaveRam.TabIndex = 4;
            this.btnImportSaveRam.Text = "Import SaveRAM";
            this.btnImportSaveRam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImportSaveRam.UseSelectable = true;
            this.btnImportSaveRam.Click += new System.EventHandler(this.btnImportSaveRam_Click);
            // 
            // btnExportRomLibrary
            // 
            this.btnExportRomLibrary.Enabled = false;
            this.btnExportRomLibrary.Location = new System.Drawing.Point(381, 60);
            this.btnExportRomLibrary.Name = "btnExportRomLibrary";
            this.btnExportRomLibrary.Size = new System.Drawing.Size(175, 25);
            this.btnExportRomLibrary.TabIndex = 3;
            this.btnExportRomLibrary.Text = "Export Library";
            this.btnExportRomLibrary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExportRomLibrary.UseSelectable = true;
            this.btnExportRomLibrary.Click += new System.EventHandler(this.btnExportRomLibrary_Click);
            // 
            // btnImportLibrary
            // 
            this.btnImportLibrary.Location = new System.Drawing.Point(200, 60);
            this.btnImportLibrary.Name = "btnImportLibrary";
            this.btnImportLibrary.Size = new System.Drawing.Size(175, 25);
            this.btnImportLibrary.TabIndex = 2;
            this.btnImportLibrary.Text = "Import Library";
            this.btnImportLibrary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImportLibrary.UseSelectable = true;
            this.btnImportLibrary.Click += new System.EventHandler(this.btnImportLibrary_Click);
            // 
            // tabLogView
            // 
            this.tabLogView.Controls.Add(this.txtLog);
            this.tabLogView.HorizontalScrollbarBarColor = true;
            this.tabLogView.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLogView.HorizontalScrollbarSize = 10;
            this.tabLogView.Location = new System.Drawing.Point(4, 44);
            this.tabLogView.Name = "tabLogView";
            this.tabLogView.Size = new System.Drawing.Size(752, 472);
            this.tabLogView.TabIndex = 5;
            this.tabLogView.Text = "Logs";
            this.tabLogView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabLogView.VerticalScrollbarBarColor = true;
            this.tabLogView.VerticalScrollbarHighlightOnWheel = false;
            this.tabLogView.VerticalScrollbarSize = 10;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(752, 472);
            this.txtLog.TabIndex = 2;
            this.txtLog.WordWrap = false;
            // 
            // frmMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMetro";
            this.Text = "Emulator Configurator";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMetro_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabHomePage.ResumeLayout(false);
            this.tabHomePage.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.tabLogView.ResumeLayout(false);
            this.tabLogView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage tabOptions;
        private MetroFramework.Controls.MetroCheckBox chkRetroArchIntegrated;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtInstallDirectory;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnImportLibrary;
        private MetroFramework.Controls.MetroButton btnExportRomLibrary;
        private MetroFramework.Controls.MetroButton btnExportSaveRam;
        private MetroFramework.Controls.MetroButton btnImportSaveRam;
        private MetroFramework.Controls.MetroButton btnImportBIOS;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton btnCreateM3uPlaylist;
        private MetroFramework.Controls.MetroButton btnCreateCueSheet;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton btnCleanBackupFiles;
        private MetroFramework.Controls.MetroButton btnPlay;
        private MetroFramework.Controls.MetroTabPage tabLogView;
        private System.Windows.Forms.TextBox txtLog;
        private MetroFramework.Controls.MetroTabPage tabHomePage;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton btnClearLogFile;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbRecent;
        private MetroFramework.Controls.MetroComboBox cmbFavorites;
        private MetroFramework.Controls.MetroLabel lblCopiedFile;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewComboBoxColumn Core;
        private MetroFramework.Controls.MetroButton btnTest;
        private MetroFramework.Controls.MetroButton xbtnWriteConfig;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}