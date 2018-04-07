namespace Alfador.Forms
{
    partial class frmRetroArchConfig
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
            this.listboxCoreSettings = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prgUpdate = new System.Windows.Forms.ProgressBar();
            this.btnApplyCore = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnUpdateAllCores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxCoreSettings
            // 
            this.listboxCoreSettings.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxCoreSettings.FormattingEnabled = true;
            this.listboxCoreSettings.ItemHeight = 16;
            this.listboxCoreSettings.Location = new System.Drawing.Point(12, 30);
            this.listboxCoreSettings.Name = "listboxCoreSettings";
            this.listboxCoreSettings.Size = new System.Drawing.Size(265, 292);
            this.listboxCoreSettings.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(101, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 25);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "Extension | System | Core";
            // 
            // prgUpdate
            // 
            this.prgUpdate.Location = new System.Drawing.Point(12, 388);
            this.prgUpdate.Name = "prgUpdate";
            this.prgUpdate.Size = new System.Drawing.Size(265, 23);
            this.prgUpdate.TabIndex = 43;
            this.prgUpdate.Visible = false;
            // 
            // btnApplyCore
            // 
            this.btnApplyCore.Location = new System.Drawing.Point(12, 328);
            this.btnApplyCore.Name = "btnApplyCore";
            this.btnApplyCore.Size = new System.Drawing.Size(85, 25);
            this.btnApplyCore.TabIndex = 29;
            this.btnApplyCore.Text = "Add / Edit";
            this.btnApplyCore.UseVisualStyleBackColor = true;
            this.btnApplyCore.Click += new System.EventHandler(this.btnApplyCore_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(192, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 25);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(12, 414);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 16);
            this.lblVersion.TabIndex = 44;
            // 
            // btnUpdateAllCores
            // 
            this.btnUpdateAllCores.Location = new System.Drawing.Point(12, 359);
            this.btnUpdateAllCores.Name = "btnUpdateAllCores";
            this.btnUpdateAllCores.Size = new System.Drawing.Size(265, 23);
            this.btnUpdateAllCores.TabIndex = 45;
            this.btnUpdateAllCores.Text = "Update All Cores";
            this.btnUpdateAllCores.UseVisualStyleBackColor = true;
            this.btnUpdateAllCores.Click += new System.EventHandler(this.btnUpdateAllCores_Click);
            // 
            // frmRetroArchConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 441);
            this.Controls.Add(this.btnUpdateAllCores);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnApplyCore);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.prgUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxCoreSettings);
            this.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRetroArchConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroArch Config";
            this.Load += new System.EventHandler(this.frmRetroArchConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listboxCoreSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ProgressBar prgUpdate;
        private System.Windows.Forms.Button btnApplyCore;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnUpdateAllCores;
    }
}