namespace Datahive
{
    partial class Form_open_database_propiedades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_open_database_propiedades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.VScrollBar_Datagrid = new Guna.UI.WinForms.GunaVScrollBar();
            this.DataGridView_Tablas = new Guna.UI.WinForms.GunaDataGridView();
            this.Column_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Tablas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Filas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Columnas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 152;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 152;
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
            this.VScrollBar_Datagrid.TabIndex = 17;
            this.VScrollBar_Datagrid.ThumbColor = System.Drawing.Color.DimGray;
            this.VScrollBar_Datagrid.ThumbHoverColor = System.Drawing.Color.Gray;
            this.VScrollBar_Datagrid.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // DataGridView_Tablas
            // 
            this.DataGridView_Tablas.AllowUserToAddRows = false;
            this.DataGridView_Tablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Tablas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Tablas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Tablas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Tablas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Tablas.ColumnHeadersHeight = 35;
            this.DataGridView_Tablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Check,
            this.Column_Tablas,
            this.Column_Filas,
            this.Column_Columnas,
            this.Column_Eliminar,
            this.Column_Editar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Tablas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_Tablas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Tablas.EnableHeadersVisualStyles = false;
            this.DataGridView_Tablas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Tablas.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Tablas.MultiSelect = false;
            this.DataGridView_Tablas.Name = "DataGridView_Tablas";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Tablas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_Tablas.RowHeadersVisible = false;
            this.DataGridView_Tablas.RowTemplate.Height = 40;
            this.DataGridView_Tablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Tablas.Size = new System.Drawing.Size(747, 364);
            this.DataGridView_Tablas.TabIndex = 16;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.Column_Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_Eliminar.HeaderText = "Eliminar";
            this.Column_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Eliminar.Image")));
            this.Column_Eliminar.Name = "Column_Eliminar";
            this.Column_Eliminar.ReadOnly = true;
            this.Column_Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_Editar
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.Column_Editar.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column_Editar.HeaderText = "Editar";
            this.Column_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Editar.Image")));
            this.Column_Editar.Name = "Column_Editar";
            this.Column_Editar.ReadOnly = true;
            this.Column_Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_open_database_propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(747, 364);
            this.Controls.Add(this.VScrollBar_Datagrid);
            this.Controls.Add(this.DataGridView_Tablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_open_database_propiedades";
            this.Text = "Form_open_database_propiedades";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Tablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaVScrollBar VScrollBar_Datagrid;
        private Guna.UI.WinForms.GunaDataGridView DataGridView_Tablas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Tablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Filas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Columnas;
        private System.Windows.Forms.DataGridViewImageColumn Column_Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Editar;
    }
}