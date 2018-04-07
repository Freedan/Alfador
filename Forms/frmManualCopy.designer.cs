namespace Alfador.Forms
{
    partial class frmManualCopy
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
            this.listUnknownRoms = new System.Windows.Forms.ListBox();
            this.btnCopyRom = new MetroFramework.Controls.MetroButton();
            this.btnAddExtension = new MetroFramework.Controls.MetroButton();
            this.btnFixExtension = new MetroFramework.Controls.MetroButton();
            this.btnIgnoreFile = new MetroFramework.Controls.MetroButton();
            this.btnIgnoreFileType = new MetroFramework.Controls.MetroButton();
            this.btnExtractRom = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmboSystem = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmboCore = new MetroFramework.Controls.MetroComboBox();
            this.lblCopiedFile = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // listUnknownRoms
            // 
            this.listUnknownRoms.BackColor = System.Drawing.Color.Black;
            this.listUnknownRoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUnknownRoms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUnknownRoms.ForeColor = System.Drawing.Color.White;
            this.listUnknownRoms.FormattingEnabled = true;
            this.listUnknownRoms.ItemHeight = 21;
            this.listUnknownRoms.Location = new System.Drawing.Point(216, 63);
            this.listUnknownRoms.Name = "listUnknownRoms";
            this.listUnknownRoms.Size = new System.Drawing.Size(561, 294);
            this.listUnknownRoms.TabIndex = 1;
            this.listUnknownRoms.SelectedIndexChanged += new System.EventHandler(this.listUnknownRoms_SelectedIndexChanged);
            // 
            // btnCopyRom
            // 
            this.btnCopyRom.Location = new System.Drawing.Point(23, 63);
            this.btnCopyRom.Name = "btnCopyRom";
            this.btnCopyRom.Size = new System.Drawing.Size(175, 25);
            this.btnCopyRom.TabIndex = 18;
            this.btnCopyRom.Text = "Copy ROM File";
            this.btnCopyRom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCopyRom.UseSelectable = true;
            this.btnCopyRom.Click += new System.EventHandler(this.btnCopyRom_Click);
            // 
            // btnAddExtension
            // 
            this.btnAddExtension.Location = new System.Drawing.Point(23, 94);
            this.btnAddExtension.Name = "btnAddExtension";
            this.btnAddExtension.Size = new System.Drawing.Size(175, 25);
            this.btnAddExtension.TabIndex = 19;
            this.btnAddExtension.Text = "Copy ROM / Add Extension";
            this.btnAddExtension.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddExtension.UseSelectable = true;
            this.btnAddExtension.Click += new System.EventHandler(this.btnAddExtension_Click);
            // 
            // btnFixExtension
            // 
            this.btnFixExtension.Enabled = false;
            this.btnFixExtension.Location = new System.Drawing.Point(23, 125);
            this.btnFixExtension.Name = "btnFixExtension";
            this.btnFixExtension.Size = new System.Drawing.Size(175, 25);
            this.btnFixExtension.TabIndex = 20;
            this.btnFixExtension.Text = "Copy ROM / Fix Extension";
            this.btnFixExtension.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFixExtension.UseSelectable = true;
            this.btnFixExtension.Click += new System.EventHandler(this.btnFixExtension_Click);
            // 
            // btnIgnoreFile
            // 
            this.btnIgnoreFile.Location = new System.Drawing.Point(23, 156);
            this.btnIgnoreFile.Name = "btnIgnoreFile";
            this.btnIgnoreFile.Size = new System.Drawing.Size(175, 25);
            this.btnIgnoreFile.TabIndex = 21;
            this.btnIgnoreFile.Text = "Ignore File";
            this.btnIgnoreFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIgnoreFile.UseSelectable = true;
            this.btnIgnoreFile.Click += new System.EventHandler(this.btnIgnoreFile_Click);
            // 
            // btnIgnoreFileType
            // 
            this.btnIgnoreFileType.Location = new System.Drawing.Point(23, 187);
            this.btnIgnoreFileType.Name = "btnIgnoreFileType";
            this.btnIgnoreFileType.Size = new System.Drawing.Size(175, 25);
            this.btnIgnoreFileType.TabIndex = 22;
            this.btnIgnoreFileType.Text = "Ignore File Type";
            this.btnIgnoreFileType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIgnoreFileType.UseSelectable = true;
            this.btnIgnoreFileType.Click += new System.EventHandler(this.btnIgnoreFileType_Click);
            // 
            // btnExtractRom
            // 
            this.btnExtractRom.Location = new System.Drawing.Point(23, 218);
            this.btnExtractRom.Name = "btnExtractRom";
            this.btnExtractRom.Size = new System.Drawing.Size(175, 25);
            this.btnExtractRom.TabIndex = 23;
            this.btnExtractRom.Text = "Extract ROM from File";
            this.btnExtractRom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnExtractRom.UseSelectable = true;
            this.btnExtractRom.Click += new System.EventHandler(this.btnExtractRom_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 250);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Target System";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmboSystem
            // 
            this.cmboSystem.FormattingEnabled = true;
            this.cmboSystem.ItemHeight = 23;
            this.cmboSystem.Location = new System.Drawing.Point(24, 273);
            this.cmboSystem.Name = "cmboSystem";
            this.cmboSystem.Size = new System.Drawing.Size(174, 29);
            this.cmboSystem.TabIndex = 25;
            this.cmboSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmboSystem.UseSelectable = true;
            this.cmboSystem.SelectedIndexChanged += new System.EventHandler(this.cmboSystem_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 305);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Target Core";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmboCore
            // 
            this.cmboCore.FormattingEnabled = true;
            this.cmboCore.ItemHeight = 23;
            this.cmboCore.Location = new System.Drawing.Point(24, 327);
            this.cmboCore.Name = "cmboCore";
            this.cmboCore.Size = new System.Drawing.Size(174, 29);
            this.cmboCore.TabIndex = 27;
            this.cmboCore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmboCore.UseSelectable = true;
            // 
            // lblCopiedFile
            // 
            this.lblCopiedFile.AutoSize = true;
            this.lblCopiedFile.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCopiedFile.Location = new System.Drawing.Point(27, 507);
            this.lblCopiedFile.Name = "lblCopiedFile";
            this.lblCopiedFile.Size = new System.Drawing.Size(0, 0);
            this.lblCopiedFile.TabIndex = 29;
            this.lblCopiedFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(27, 535);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(746, 23);
            this.metroProgressBar1.TabIndex = 28;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmManualCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblCopiedFile);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.cmboCore);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmboSystem);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExtractRom);
            this.Controls.Add(this.btnIgnoreFileType);
            this.Controls.Add(this.btnIgnoreFile);
            this.Controls.Add(this.btnFixExtension);
            this.Controls.Add(this.btnAddExtension);
            this.Controls.Add(this.btnCopyRom);
            this.Controls.Add(this.listUnknownRoms);
            this.Name = "frmManualCopy";
            this.Text = "The Following Unknown File Types Were Found";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmManualCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUnknownRoms;
        private MetroFramework.Controls.MetroButton btnCopyRom;
        private MetroFramework.Controls.MetroButton btnAddExtension;
        private MetroFramework.Controls.MetroButton btnFixExtension;
        private MetroFramework.Controls.MetroButton btnIgnoreFile;
        private MetroFramework.Controls.MetroButton btnIgnoreFileType;
        private MetroFramework.Controls.MetroButton btnExtractRom;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmboSystem;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmboCore;
        private MetroFramework.Controls.MetroLabel lblCopiedFile;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}