namespace Alfador.Forms
{
    partial class frmCoreEdit
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
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.cmboSystem = new System.Windows.Forms.ComboBox();
            this.cmboCore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyCore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(12, 12);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(53, 20);
            this.txtExtension.TabIndex = 42;
            // 
            // cmboSystem
            // 
            this.cmboSystem.FormattingEnabled = true;
            this.cmboSystem.Location = new System.Drawing.Point(71, 12);
            this.cmboSystem.Name = "cmboSystem";
            this.cmboSystem.Size = new System.Drawing.Size(88, 21);
            this.cmboSystem.TabIndex = 40;
            // 
            // cmboCore
            // 
            this.cmboCore.FormattingEnabled = true;
            this.cmboCore.Location = new System.Drawing.Point(165, 11);
            this.cmboCore.Name = "cmboCore";
            this.cmboCore.Size = new System.Drawing.Size(159, 21);
            this.cmboCore.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "Core";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 45;
            this.label3.Text = "Extension";
            // 
            // btnApplyCore
            // 
            this.btnApplyCore.Location = new System.Drawing.Point(330, 9);
            this.btnApplyCore.Name = "btnApplyCore";
            this.btnApplyCore.Size = new System.Drawing.Size(75, 25);
            this.btnApplyCore.TabIndex = 46;
            this.btnApplyCore.Text = "Apply";
            this.btnApplyCore.UseVisualStyleBackColor = true;
            this.btnApplyCore.Click += new System.EventHandler(this.btnApplyCore_Click);
            // 
            // frmCoreEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 61);
            this.Controls.Add(this.btnApplyCore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.cmboSystem);
            this.Controls.Add(this.cmboCore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCoreEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add / Modify Core";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCoreEdit_FormClosed);
            this.Load += new System.EventHandler(this.frmCoreEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.ComboBox cmboSystem;
        private System.Windows.Forms.ComboBox cmboCore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyCore;
    }
}