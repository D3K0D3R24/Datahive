namespace Datahive
{
    partial class Form_Backup_and_Restore
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Panel_central = new Guna.UI2.WinForms.Guna2Panel();
            this.Button_backup = new Guna.UI2.WinForms.Guna2Button();
            this.Button_restore = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Panel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Panel_central
            // 
            this.Panel_central.BackColor = System.Drawing.Color.Transparent;
            this.Panel_central.Controls.Add(this.guna2HtmlLabel1);
            this.Panel_central.Location = new System.Drawing.Point(12, 60);
            this.Panel_central.Name = "Panel_central";
            this.Panel_central.ShadowDecoration.Parent = this.Panel_central;
            this.Panel_central.Size = new System.Drawing.Size(486, 263);
            this.Panel_central.TabIndex = 0;
            // 
            // Button_backup
            // 
            this.Button_backup.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_backup.CheckedState.Parent = this.Button_backup;
            this.Button_backup.CustomImages.Parent = this.Button_backup;
            this.Button_backup.FillColor = System.Drawing.Color.Transparent;
            this.Button_backup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_backup.ForeColor = System.Drawing.Color.DimGray;
            this.Button_backup.HoverState.Parent = this.Button_backup;
            this.Button_backup.Location = new System.Drawing.Point(12, 15);
            this.Button_backup.Name = "Button_backup";
            this.Button_backup.ShadowDecoration.Parent = this.Button_backup;
            this.Button_backup.Size = new System.Drawing.Size(243, 45);
            this.Button_backup.TabIndex = 1;
            this.Button_backup.Text = "BackUp";
            this.Button_backup.Click += new System.EventHandler(this.Button_backup_Click);
            // 
            // Button_restore
            // 
            this.Button_restore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_restore.CheckedState.Parent = this.Button_restore;
            this.Button_restore.CustomImages.Parent = this.Button_restore;
            this.Button_restore.FillColor = System.Drawing.Color.Transparent;
            this.Button_restore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_restore.ForeColor = System.Drawing.Color.DimGray;
            this.Button_restore.HoverState.Parent = this.Button_restore;
            this.Button_restore.Location = new System.Drawing.Point(255, 15);
            this.Button_restore.Name = "Button_restore";
            this.Button_restore.ShadowDecoration.Parent = this.Button_restore;
            this.Button_restore.Size = new System.Drawing.Size(243, 45);
            this.Button_restore.TabIndex = 2;
            this.Button_restore.Text = "Restore";
            this.Button_restore.Click += new System.EventHandler(this.Button_restore_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(144, 118);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(198, 26);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Seleccione una opción ";
            // 
            // Form_Backup_and_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 336);
            this.Controls.Add(this.Button_restore);
            this.Controls.Add(this.Button_backup);
            this.Controls.Add(this.Panel_central);
            this.Name = "Form_Backup_and_Restore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Backup_and_Restore";
            this.Panel_central.ResumeLayout(false);
            this.Panel_central.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Panel Panel_central;
        private Guna.UI2.WinForms.Guna2Button Button_backup;
        private Guna.UI2.WinForms.Guna2Button Button_restore;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}