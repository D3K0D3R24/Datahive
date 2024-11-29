namespace Datahive
{
    partial class Form_Open_Database_Info_Tables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Open_Database_Info_Tables));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Propiedades = new Guna.UI2.WinForms.Guna2Button();
            this.Button_SQL = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView_Tablas = new Guna.UI.WinForms.GunaDataGridView();
            this.Column_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Tablas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Filas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Columnas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel_Contenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.VScrollBar_Datagrid = new Guna.UI.WinForms.GunaVScrollBar();
            this.TextBox_SQL = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tablas)).BeginInit();
            this.Panel_Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(747, 27);
            this.guna2Panel1.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.flowLayoutPanel1.Controls.Add(this.Button_Propiedades);
            this.flowLayoutPanel1.Controls.Add(this.Button_SQL);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(747, 27);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Button_Propiedades
            // 
            this.Button_Propiedades.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_Propiedades.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Propiedades.CheckedState.Parent = this.Button_Propiedades;
            this.Button_Propiedades.CustomImages.Parent = this.Button_Propiedades;
            this.Button_Propiedades.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Button_Propiedades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Propiedades.ForeColor = System.Drawing.Color.White;
            this.Button_Propiedades.HoverState.Parent = this.Button_Propiedades;
            this.Button_Propiedades.Location = new System.Drawing.Point(0, 0);
            this.Button_Propiedades.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Propiedades.Name = "Button_Propiedades";
            this.Button_Propiedades.ShadowDecoration.Parent = this.Button_Propiedades;
            this.Button_Propiedades.Size = new System.Drawing.Size(118, 27);
            this.Button_Propiedades.TabIndex = 0;
            this.Button_Propiedades.Text = "Propiedades";
            this.Button_Propiedades.Click += new System.EventHandler(this.Button_Propiedades_Click);
            // 
            // Button_SQL
            // 
            this.Button_SQL.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button_SQL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_SQL.CheckedState.Parent = this.Button_SQL;
            this.Button_SQL.CustomImages.Parent = this.Button_SQL;
            this.Button_SQL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.Button_SQL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_SQL.ForeColor = System.Drawing.Color.White;
            this.Button_SQL.HoverState.Parent = this.Button_SQL;
            this.Button_SQL.Location = new System.Drawing.Point(118, 0);
            this.Button_SQL.Margin = new System.Windows.Forms.Padding(0);
            this.Button_SQL.Name = "Button_SQL";
            this.Button_SQL.ShadowDecoration.Parent = this.Button_SQL;
            this.Button_SQL.Size = new System.Drawing.Size(118, 27);
            this.Button_SQL.TabIndex = 1;
            this.Button_SQL.Text = "SQL";
            this.Button_SQL.Click += new System.EventHandler(this.Button_SQL_Click);
            // 
            // DataGridView_Tablas
            // 
            this.DataGridView_Tablas.AllowUserToAddRows = false;
            this.DataGridView_Tablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Tablas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Tablas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Tablas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Tablas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Tablas.ColumnHeadersHeight = 35;
            this.DataGridView_Tablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Check,
            this.Column_Tablas,
            this.Column_Filas,
            this.Column_Columnas,
            this.Column_Eliminar,
            this.Column_Editar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Tablas.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Tablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Tablas.EnableHeadersVisualStyles = false;
            this.DataGridView_Tablas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Tablas.MultiSelect = false;
            this.DataGridView_Tablas.Name = "DataGridView_Tablas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Tablas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_Tablas.RowHeadersVisible = false;
            this.DataGridView_Tablas.RowTemplate.Height = 40;
            this.DataGridView_Tablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tablas.Size = new System.Drawing.Size(747, 364);
            this.DataGridView_Tablas.TabIndex = 14;
            this.DataGridView_Tablas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridView_Tablas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.DataGridView_Tablas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Tablas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Tablas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Tablas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Tablas.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.DataGridView_Tablas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Tablas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Tablas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Tablas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Tablas.ThemeStyle.HeaderStyle.Height = 35;
            this.DataGridView_Tablas.ThemeStyle.ReadOnly = false;
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.DataGridView_Tablas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.DataGridView_Tablas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Tablas_CellClick);
            this.DataGridView_Tablas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Tablas_CellDoubleClick);
            this.DataGridView_Tablas.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Tablas_CellMouseEnter);
            this.DataGridView_Tablas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Tablas_CellMouseLeave);
            // 
            // Column_Check
            // 
            this.Column_Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Check.HeaderText = "     🔳";
            this.Column_Check.Name = "Column_Check";
            this.Column_Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Check.Width = 69;
            // 
            // Column_Tablas
            // 
            this.Column_Tablas.HeaderText = "Tablas";
            this.Column_Tablas.Name = "Column_Tablas";
            this.Column_Tablas.ReadOnly = true;
            // 
            // Column_Filas
            // 
            this.Column_Filas.HeaderText = "Filas";
            this.Column_Filas.Name = "Column_Filas";
            this.Column_Filas.ReadOnly = true;
            // 
            // Column_Columnas
            // 
            this.Column_Columnas.HeaderText = "Columnas";
            this.Column_Columnas.Name = "Column_Columnas";
            this.Column_Columnas.ReadOnly = true;
            // 
            // Column_Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Column_Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_Eliminar.HeaderText = "Eliminar";
            this.Column_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Eliminar.Image")));
            this.Column_Eliminar.Name = "Column_Eliminar";
            this.Column_Eliminar.ReadOnly = true;
            this.Column_Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_Editar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Column_Editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_Editar.HeaderText = "Editar";
            this.Column_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Editar.Image")));
            this.Column_Editar.Name = "Column_Editar";
            this.Column_Editar.ReadOnly = true;
            this.Column_Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 135;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 136;
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Controls.Add(this.VScrollBar_Datagrid);
            this.Panel_Contenedor.Controls.Add(this.DataGridView_Tablas);
            this.Panel_Contenedor.Controls.Add(this.TextBox_SQL);
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(0, 27);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.ShadowDecoration.Parent = this.Panel_Contenedor;
            this.Panel_Contenedor.Size = new System.Drawing.Size(747, 364);
            this.Panel_Contenedor.TabIndex = 16;
            // 
            // VScrollBar_Datagrid
            // 
            this.VScrollBar_Datagrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.VScrollBar_Datagrid.LargeChange = 10;
            this.VScrollBar_Datagrid.Location = new System.Drawing.Point(726, 0);
            this.VScrollBar_Datagrid.Maximum = 100;
            this.VScrollBar_Datagrid.Name = "VScrollBar_Datagrid";
            this.VScrollBar_Datagrid.ScrollIdleColor = System.Drawing.Color.Silver;
            this.VScrollBar_Datagrid.Size = new System.Drawing.Size(21, 364);
            this.VScrollBar_Datagrid.TabIndex = 16;
            this.VScrollBar_Datagrid.ThumbColor = System.Drawing.Color.DimGray;
            this.VScrollBar_Datagrid.ThumbHoverColor = System.Drawing.Color.Gray;
            this.VScrollBar_Datagrid.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // TextBox_SQL
            // 
            this.TextBox_SQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_SQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_SQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_SQL.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_SQL.ForeColor = System.Drawing.Color.White;
            this.TextBox_SQL.Location = new System.Drawing.Point(0, 0);
            this.TextBox_SQL.Name = "TextBox_SQL";
            this.TextBox_SQL.Size = new System.Drawing.Size(747, 364);
            this.TextBox_SQL.TabIndex = 17;
            this.TextBox_SQL.Text = "";
            // 
            // Form_Open_Database_Info_Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(747, 391);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Open_Database_Info_Tables";
            this.Text = "Form_Open_Database_Info_Tables";
            this.Load += new System.EventHandler(this.Form_Open_Database_Info_Tables_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tablas)).EndInit();
            this.Panel_Contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Button_Propiedades;
        private Guna.UI2.WinForms.Guna2Button Button_SQL;
        private Guna.UI.WinForms.GunaDataGridView DataGridView_Tablas;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Panel Panel_Contenedor;
        private Guna.UI.WinForms.GunaVScrollBar VScrollBar_Datagrid;
        private System.Windows.Forms.RichTextBox TextBox_SQL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Tablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Filas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Columnas;
        private System.Windows.Forms.DataGridViewImageColumn Column_Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Editar;
    }
}