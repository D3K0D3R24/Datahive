namespace Datahive
{
    partial class Form_BackUp
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Open_Ruta = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Select_Save = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Respaldar = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_Save_Ruta = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Open_Ruta = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.Button_Open_Ruta);
            this.guna2GroupBox1.Controls.Add(this.Button_Select_Save);
            this.guna2GroupBox1.Controls.Add(this.Button_Respaldar);
            this.guna2GroupBox1.Controls.Add(this.TextBox_Save_Ruta);
            this.guna2GroupBox1.Controls.Add(this.TextBox_Open_Ruta);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(486, 263);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Backup";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(31, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(220, 15);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Seleccione la ruta donde guardara el respaldo";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(31, 65);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(239, 15);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Seleccione la ruta de la base de datos a respaldar";
            // 
            // Button_Open_Ruta
            // 
            this.Button_Open_Ruta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Open_Ruta.CheckedState.Parent = this.Button_Open_Ruta;
            this.Button_Open_Ruta.CustomImages.Parent = this.Button_Open_Ruta;
            this.Button_Open_Ruta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Open_Ruta.ForeColor = System.Drawing.Color.White;
            this.Button_Open_Ruta.HoverState.Parent = this.Button_Open_Ruta;
            this.Button_Open_Ruta.Location = new System.Drawing.Point(396, 88);
            this.Button_Open_Ruta.Name = "Button_Open_Ruta";
            this.Button_Open_Ruta.ShadowDecoration.Parent = this.Button_Open_Ruta;
            this.Button_Open_Ruta.Size = new System.Drawing.Size(59, 27);
            this.Button_Open_Ruta.TabIndex = 4;
            this.Button_Open_Ruta.Text = "...";
            this.Button_Open_Ruta.Click += new System.EventHandler(this.Button_Open_Ruta_Click);
            // 
            // Button_Select_Save
            // 
            this.Button_Select_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Select_Save.CheckedState.Parent = this.Button_Select_Save;
            this.Button_Select_Save.CustomImages.Parent = this.Button_Select_Save;
            this.Button_Select_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Select_Save.ForeColor = System.Drawing.Color.White;
            this.Button_Select_Save.HoverState.Parent = this.Button_Select_Save;
            this.Button_Select_Save.Location = new System.Drawing.Point(396, 146);
            this.Button_Select_Save.Name = "Button_Select_Save";
            this.Button_Select_Save.ShadowDecoration.Parent = this.Button_Select_Save;
            this.Button_Select_Save.Size = new System.Drawing.Size(59, 27);
            this.Button_Select_Save.TabIndex = 3;
            this.Button_Select_Save.Text = "...";
            this.Button_Select_Save.Click += new System.EventHandler(this.Button_Select_Save_Click);
            // 
            // Button_Respaldar
            // 
            this.Button_Respaldar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Respaldar.AutoRoundedCorners = true;
            this.Button_Respaldar.BorderRadius = 16;
            this.Button_Respaldar.CheckedState.Parent = this.Button_Respaldar;
            this.Button_Respaldar.CustomImages.Parent = this.Button_Respaldar;
            this.Button_Respaldar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Respaldar.ForeColor = System.Drawing.Color.White;
            this.Button_Respaldar.HoverState.Parent = this.Button_Respaldar;
            this.Button_Respaldar.Location = new System.Drawing.Point(154, 205);
            this.Button_Respaldar.Name = "Button_Respaldar";
            this.Button_Respaldar.ShadowDecoration.Parent = this.Button_Respaldar;
            this.Button_Respaldar.Size = new System.Drawing.Size(180, 35);
            this.Button_Respaldar.TabIndex = 2;
            this.Button_Respaldar.Text = "Respaldar";
            this.Button_Respaldar.Click += new System.EventHandler(this.Button_Respaldar_Click);
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
            this.TextBox_Save_Ruta.Location = new System.Drawing.Point(31, 146);
            this.TextBox_Save_Ruta.Name = "TextBox_Save_Ruta";
            this.TextBox_Save_Ruta.PasswordChar = '\0';
            this.TextBox_Save_Ruta.PlaceholderText = "";
            this.TextBox_Save_Ruta.SelectedText = "";
            this.TextBox_Save_Ruta.ShadowDecoration.Parent = this.TextBox_Save_Ruta;
            this.TextBox_Save_Ruta.Size = new System.Drawing.Size(352, 27);
            this.TextBox_Save_Ruta.TabIndex = 1;
            // 
            // TextBox_Open_Ruta
            // 
            this.TextBox_Open_Ruta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Open_Ruta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Open_Ruta.DefaultText = "";
            this.TextBox_Open_Ruta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Open_Ruta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Open_Ruta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Open_Ruta.DisabledState.Parent = this.TextBox_Open_Ruta;
            this.TextBox_Open_Ruta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Open_Ruta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Open_Ruta.FocusedState.Parent = this.TextBox_Open_Ruta;
            this.TextBox_Open_Ruta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Open_Ruta.HoverState.Parent = this.TextBox_Open_Ruta;
            this.TextBox_Open_Ruta.Location = new System.Drawing.Point(31, 88);
            this.TextBox_Open_Ruta.Name = "TextBox_Open_Ruta";
            this.TextBox_Open_Ruta.PasswordChar = '\0';
            this.TextBox_Open_Ruta.PlaceholderText = "";
            this.TextBox_Open_Ruta.SelectedText = "";
            this.TextBox_Open_Ruta.ShadowDecoration.Parent = this.TextBox_Open_Ruta;
            this.TextBox_Open_Ruta.Size = new System.Drawing.Size(352, 27);
            this.TextBox_Open_Ruta.TabIndex = 0;
            // 
            // Form_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 263);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_BackUp";
            this.Text = "Form_BackUp";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button Button_Open_Ruta;
        private Guna.UI2.WinForms.Guna2Button Button_Select_Save;
        private Guna.UI2.WinForms.Guna2Button Button_Respaldar;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Save_Ruta;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Open_Ruta;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}