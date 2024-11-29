namespace Datahive
{
    partial class Form_Migración_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Migración_DB));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextBox_Base = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Ruta_save = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ControlBox_Cerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.TextBox_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Open_DB = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Save_DB = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Migrar = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Label_Indicador = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextBox_Base
            // 
            this.TextBox_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Base.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Base.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Base.DefaultText = "";
            this.TextBox_Base.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Base.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Base.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Base.DisabledState.Parent = this.TextBox_Base;
            this.TextBox_Base.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Base.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Base.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Base.FocusedState.Parent = this.TextBox_Base;
            this.TextBox_Base.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Base.HoverState.Parent = this.TextBox_Base;
            this.TextBox_Base.Location = new System.Drawing.Point(227, 335);
            this.TextBox_Base.Name = "TextBox_Base";
            this.TextBox_Base.PasswordChar = '\0';
            this.TextBox_Base.PlaceholderText = "";
            this.TextBox_Base.SelectedText = "";
            this.TextBox_Base.ShadowDecoration.Parent = this.TextBox_Base;
            this.TextBox_Base.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Base.TabIndex = 2;
            // 
            // TextBox_Ruta_save
            // 
            this.TextBox_Ruta_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Ruta_save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Ruta_save.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Ruta_save.DefaultText = "";
            this.TextBox_Ruta_save.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Ruta_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Ruta_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Ruta_save.DisabledState.Parent = this.TextBox_Ruta_save;
            this.TextBox_Ruta_save.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Ruta_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Ruta_save.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Ruta_save.FocusedState.Parent = this.TextBox_Ruta_save;
            this.TextBox_Ruta_save.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Ruta_save.HoverState.Parent = this.TextBox_Ruta_save;
            this.TextBox_Ruta_save.Location = new System.Drawing.Point(227, 425);
            this.TextBox_Ruta_save.Name = "TextBox_Ruta_save";
            this.TextBox_Ruta_save.PasswordChar = '\0';
            this.TextBox_Ruta_save.PlaceholderText = "";
            this.TextBox_Ruta_save.SelectedText = "";
            this.TextBox_Ruta_save.ShadowDecoration.Parent = this.TextBox_Ruta_save;
            this.TextBox_Ruta_save.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Ruta_save.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Controls.Add(this.ControlBox_Cerrar);
            this.guna2Panel1.Controls.Add(this.guna2Panel6);
            this.guna2Panel1.Controls.Add(this.guna2Panel5);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(706, 43);
            this.guna2Panel1.TabIndex = 38;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(244, 11);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(225, 21);
            this.guna2HtmlLabel7.TabIndex = 22;
            this.guna2HtmlLabel7.Text = "Migración de Firebird a MySQL";
            // 
            // ControlBox_Cerrar
            // 
            this.ControlBox_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlBox_Cerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ControlBox_Cerrar.HoverState.Parent = this.ControlBox_Cerrar;
            this.ControlBox_Cerrar.IconColor = System.Drawing.Color.White;
            this.ControlBox_Cerrar.Location = new System.Drawing.Point(660, 1);
            this.ControlBox_Cerrar.Name = "ControlBox_Cerrar";
            this.ControlBox_Cerrar.ShadowDecoration.Parent = this.ControlBox_Cerrar;
            this.ControlBox_Cerrar.Size = new System.Drawing.Size(45, 42);
            this.ControlBox_Cerrar.TabIndex = 21;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(704, 1);
            this.guna2Panel6.TabIndex = 20;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel5.Location = new System.Drawing.Point(705, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(1, 43);
            this.guna2Panel5.TabIndex = 19;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1, 43);
            this.guna2Panel4.TabIndex = 18;
            // 
            // TextBox_User
            // 
            this.TextBox_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_User.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_User.DefaultText = "SYSDBA";
            this.TextBox_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_User.DisabledState.Parent = this.TextBox_User;
            this.TextBox_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_User.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_User.FocusedState.Parent = this.TextBox_User;
            this.TextBox_User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_User.HoverState.Parent = this.TextBox_User;
            this.TextBox_User.Location = new System.Drawing.Point(227, 170);
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.PasswordChar = '\0';
            this.TextBox_User.PlaceholderText = "";
            this.TextBox_User.SelectedText = "";
            this.TextBox_User.SelectionStart = 6;
            this.TextBox_User.ShadowDecoration.Parent = this.TextBox_User;
            this.TextBox_User.Size = new System.Drawing.Size(253, 36);
            this.TextBox_User.TabIndex = 39;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.DefaultText = "masterkey";
            this.TextBox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.DisabledState.Parent = this.TextBox_Password;
            this.TextBox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.FocusedState.Parent = this.TextBox_Password;
            this.TextBox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Password.HoverState.Parent = this.TextBox_Password;
            this.TextBox_Password.Location = new System.Drawing.Point(227, 250);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.PlaceholderText = "";
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.SelectionStart = 9;
            this.TextBox_Password.ShadowDecoration.Parent = this.TextBox_Password;
            this.TextBox_Password.Size = new System.Drawing.Size(253, 36);
            this.TextBox_Password.TabIndex = 40;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(227, 144);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(58, 20);
            this.guna2HtmlLabel2.TabIndex = 41;
            this.guna2HtmlLabel2.Text = "Usuario:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(227, 224);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(73, 20);
            this.guna2HtmlLabel1.TabIndex = 42;
            this.guna2HtmlLabel1.Text = "Password:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(227, 311);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(101, 20);
            this.guna2HtmlLabel3.TabIndex = 43;
            this.guna2HtmlLabel3.Text = "Base de datos:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(227, 399);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(105, 20);
            this.guna2HtmlLabel4.TabIndex = 44;
            this.guna2HtmlLabel4.Text = "Ruta a guardar:";
            // 
            // Button_Open_DB
            // 
            this.Button_Open_DB.Animated = true;
            this.Button_Open_DB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Button_Open_DB.CheckedState.Parent = this.Button_Open_DB;
            this.Button_Open_DB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Open_DB.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Button_Open_DB.CustomImages.Parent = this.Button_Open_DB;
            this.Button_Open_DB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Button_Open_DB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Open_DB.ForeColor = System.Drawing.Color.White;
            this.Button_Open_DB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Open_DB.HoverState.Parent = this.Button_Open_DB;
            this.Button_Open_DB.Location = new System.Drawing.Point(433, 335);
            this.Button_Open_DB.Name = "Button_Open_DB";
            this.Button_Open_DB.ShadowDecoration.Parent = this.Button_Open_DB;
            this.Button_Open_DB.Size = new System.Drawing.Size(47, 36);
            this.Button_Open_DB.TabIndex = 45;
            this.Button_Open_DB.Text = "...";
            this.Button_Open_DB.TextOffset = new System.Drawing.Point(0, -3);
            this.Button_Open_DB.Click += new System.EventHandler(this.Button_Open_DB_Click);
            // 
            // Button_Save_DB
            // 
            this.Button_Save_DB.Animated = true;
            this.Button_Save_DB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Button_Save_DB.CheckedState.Parent = this.Button_Save_DB;
            this.Button_Save_DB.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Save_DB.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Button_Save_DB.CustomImages.Parent = this.Button_Save_DB;
            this.Button_Save_DB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Button_Save_DB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Save_DB.ForeColor = System.Drawing.Color.White;
            this.Button_Save_DB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Save_DB.HoverState.Parent = this.Button_Save_DB;
            this.Button_Save_DB.Location = new System.Drawing.Point(433, 425);
            this.Button_Save_DB.Name = "Button_Save_DB";
            this.Button_Save_DB.ShadowDecoration.Parent = this.Button_Save_DB;
            this.Button_Save_DB.Size = new System.Drawing.Size(47, 36);
            this.Button_Save_DB.TabIndex = 46;
            this.Button_Save_DB.Text = "...";
            this.Button_Save_DB.TextOffset = new System.Drawing.Point(0, -3);
            this.Button_Save_DB.Click += new System.EventHandler(this.Button_Save_DB_Click);
            // 
            // Button_Migrar
            // 
            this.Button_Migrar.Animated = true;
            this.Button_Migrar.CheckedState.Parent = this.Button_Migrar;
            this.Button_Migrar.CustomImages.Parent = this.Button_Migrar;
            this.Button_Migrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Migrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.Button_Migrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Button_Migrar.ForeColor = System.Drawing.Color.White;
            this.Button_Migrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Migrar.HoverState.Parent = this.Button_Migrar;
            this.Button_Migrar.Location = new System.Drawing.Point(0, 528);
            this.Button_Migrar.Name = "Button_Migrar";
            this.Button_Migrar.ShadowDecoration.Parent = this.Button_Migrar;
            this.Button_Migrar.Size = new System.Drawing.Size(706, 45);
            this.Button_Migrar.TabIndex = 47;
            this.Button_Migrar.Text = "Migrar →";
            this.Button_Migrar.Click += new System.EventHandler(this.Button_Migrar_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(705, 43);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1, 485);
            this.guna2Panel3.TabIndex = 49;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 43);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1, 485);
            this.guna2Panel2.TabIndex = 50;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ProgressBar1.Location = new System.Drawing.Point(1, 510);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.ProgressBar1.ShadowDecoration.Parent = this.ProgressBar1;
            this.ProgressBar1.ShowPercentage = true;
            this.ProgressBar1.Size = new System.Drawing.Size(704, 18);
            this.ProgressBar1.TabIndex = 51;
            this.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Label_Indicador
            // 
            this.Label_Indicador.BackColor = System.Drawing.Color.Transparent;
            this.Label_Indicador.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Indicador.ForeColor = System.Drawing.Color.White;
            this.Label_Indicador.Location = new System.Drawing.Point(306, 488);
            this.Label_Indicador.Name = "Label_Indicador";
            this.Label_Indicador.Size = new System.Drawing.Size(94, 16);
            this.Label_Indicador.TabIndex = 53;
            this.Label_Indicador.Text = "Creando tablas ...";
            this.Label_Indicador.Visible = false;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientTileButton1.Image")));
            this.guna2GradientTileButton1.ImageSize = new System.Drawing.Size(200, 60);
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(108, 49);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(242, 67);
            this.guna2GradientTileButton1.TabIndex = 56;
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.CheckedState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.CustomImages.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.HoverState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientTileButton2.Image")));
            this.guna2GradientTileButton2.ImageOffset = new System.Drawing.Point(0, -6);
            this.guna2GradientTileButton2.ImageSize = new System.Drawing.Size(155, 50);
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(356, 49);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.ShadowDecoration.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(242, 67);
            this.guna2GradientTileButton2.TabIndex = 57;
            // 
            // Form_Migración_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(706, 573);
            this.Controls.Add(this.guna2GradientTileButton2);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.Label_Indicador);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.Button_Migrar);
            this.Controls.Add(this.Button_Save_DB);
            this.Controls.Add(this.Button_Open_DB);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.TextBox_User);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.TextBox_Ruta_save);
            this.Controls.Add(this.TextBox_Base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Migración_DB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Migración_DB";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Base;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Ruta_save;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox_Cerrar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_User;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button Button_Open_DB;
        private Guna.UI2.WinForms.Guna2Button Button_Save_DB;
        private Guna.UI2.WinForms.Guna2Button Button_Migrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Indicador;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
    }
}