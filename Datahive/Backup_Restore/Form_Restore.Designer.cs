namespace Datahive
{
    partial class Form_Restore
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
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Select_Ruta = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Save_Ruta = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Restore = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_Save_Ruta = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Select_Ruta = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox2.Controls.Add(this.Button_Select_Ruta);
            this.guna2GroupBox2.Controls.Add(this.Button_Save_Ruta);
            this.guna2GroupBox2.Controls.Add(this.Button_Restore);
            this.guna2GroupBox2.Controls.Add(this.TextBox_Save_Ruta);
            this.guna2GroupBox2.Controls.Add(this.TextBox_Select_Ruta);
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(481, 266);
            this.guna2GroupBox2.TabIndex = 2;
            this.guna2GroupBox2.Text = "Restore";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(28, 126);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(238, 15);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Seleccione la ruta donde guardara la restauración";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(28, 66);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(237, 15);
            this.guna2HtmlLabel4.TabIndex = 5;
            this.guna2HtmlLabel4.Text = "Seleccione la ruta de la base de datos a restaurar";
            // 
            // Button_Select_Ruta
            // 
            this.Button_Select_Ruta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Select_Ruta.CheckedState.Parent = this.Button_Select_Ruta;
            this.Button_Select_Ruta.CustomImages.Parent = this.Button_Select_Ruta;
            this.Button_Select_Ruta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Select_Ruta.ForeColor = System.Drawing.Color.White;
            this.Button_Select_Ruta.HoverState.Parent = this.Button_Select_Ruta;
            this.Button_Select_Ruta.Location = new System.Drawing.Point(393, 89);
            this.Button_Select_Ruta.Name = "Button_Select_Ruta";
            this.Button_Select_Ruta.ShadowDecoration.Parent = this.Button_Select_Ruta;
            this.Button_Select_Ruta.Size = new System.Drawing.Size(59, 27);
            this.Button_Select_Ruta.TabIndex = 4;
            this.Button_Select_Ruta.Text = "...";
            this.Button_Select_Ruta.Click += new System.EventHandler(this.Button_Select_Ruta_Click);
            // 
            // Button_Save_Ruta
            // 
            this.Button_Save_Ruta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Save_Ruta.CheckedState.Parent = this.Button_Save_Ruta;
            this.Button_Save_Ruta.CustomImages.Parent = this.Button_Save_Ruta;
            this.Button_Save_Ruta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Save_Ruta.ForeColor = System.Drawing.Color.White;
            this.Button_Save_Ruta.HoverState.Parent = this.Button_Save_Ruta;
            this.Button_Save_Ruta.Location = new System.Drawing.Point(393, 147);
            this.Button_Save_Ruta.Name = "Button_Save_Ruta";
            this.Button_Save_Ruta.ShadowDecoration.Parent = this.Button_Save_Ruta;
            this.Button_Save_Ruta.Size = new System.Drawing.Size(59, 27);
            this.Button_Save_Ruta.TabIndex = 3;
            this.Button_Save_Ruta.Text = "...";
            this.Button_Save_Ruta.Click += new System.EventHandler(this.Button_Save_Ruta_Click);
            // 
            // Button_Restore
            // 
            this.Button_Restore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Restore.AutoRoundedCorners = true;
            this.Button_Restore.BorderRadius = 16;
            this.Button_Restore.CheckedState.Parent = this.Button_Restore;
            this.Button_Restore.CustomImages.Parent = this.Button_Restore;
            this.Button_Restore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Restore.ForeColor = System.Drawing.Color.White;
            this.Button_Restore.HoverState.Parent = this.Button_Restore;
            this.Button_Restore.Location = new System.Drawing.Point(151, 206);
            this.Button_Restore.Name = "Button_Restore";
            this.Button_Restore.ShadowDecoration.Parent = this.Button_Restore;
            this.Button_Restore.Size = new System.Drawing.Size(180, 35);
            this.Button_Restore.TabIndex = 2;
            this.Button_Restore.Text = "Restaurar";
            this.Button_Restore.Click += new System.EventHandler(this.Button_Restore_Click);
            // 
            // TextBox_Save_Ruta
            // 
            this.TextBox_Save_Ruta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Save_Ruta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Save_Ruta.DefaultText = "";
            this.TextBox_Save_Ruta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Save_Ruta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Save_Ruta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Save_Ruta.DisabledState.Parent = this.TextBox_Save_Ruta;
            this.TextBox_Save_Ruta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Save_Ruta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Save_Ruta.FocusedState.Parent = this.TextBox_Save_Ruta;
            this.TextBox_Save_Ruta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Save_Ruta.HoverState.Parent = this.TextBox_Save_Ruta;
            this.TextBox_Save_Ruta.Location = new System.Drawing.Point(28, 147);
            this.TextBox_Save_Ruta.Name = "TextBox_Save_Ruta";
            this.TextBox_Save_Ruta.PasswordChar = '\0';
            this.TextBox_Save_Ruta.PlaceholderText = "";
            this.TextBox_Save_Ruta.SelectedText = "";
            this.TextBox_Save_Ruta.ShadowDecoration.Parent = this.TextBox_Save_Ruta;
            this.TextBox_Save_Ruta.Size = new System.Drawing.Size(352, 27);
            this.TextBox_Save_Ruta.TabIndex = 1;
            // 
            // TextBox_Select_Ruta
            // 
            this.TextBox_Select_Ruta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Select_Ruta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Select_Ruta.DefaultText = "";
            this.TextBox_Select_Ruta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Select_Ruta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Select_Ruta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Select_Ruta.DisabledState.Parent = this.TextBox_Select_Ruta;
            this.TextBox_Select_Ruta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Select_Ruta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Select_Ruta.FocusedState.Parent = this.TextBox_Select_Ruta;
            this.TextBox_Select_Ruta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Select_Ruta.HoverState.Parent = this.TextBox_Select_Ruta;
            this.TextBox_Select_Ruta.Location = new System.Drawing.Point(28, 89);
            this.TextBox_Select_Ruta.Name = "TextBox_Select_Ruta";
            this.TextBox_Select_Ruta.PasswordChar = '\0';
            this.TextBox_Select_Ruta.PlaceholderText = "";
            this.TextBox_Select_Ruta.SelectedText = "";
            this.TextBox_Select_Ruta.ShadowDecoration.Parent = this.TextBox_Select_Ruta;
            this.TextBox_Select_Ruta.Size = new System.Drawing.Size(352, 27);
            this.TextBox_Select_Ruta.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 266);
            this.Controls.Add(this.guna2GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Restore";
            this.Text = "Form_Restore";
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button Button_Select_Ruta;
        private Guna.UI2.WinForms.Guna2Button Button_Save_Ruta;
        private Guna.UI2.WinForms.Guna2Button Button_Restore;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Save_Ruta;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Select_Ruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}