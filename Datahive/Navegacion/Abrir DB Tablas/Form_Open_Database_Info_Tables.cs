using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datahive
{
    public partial class Form_Open_Database_Info_Tables : Form
    {
        private Form_Open_Database form_padre;
        private DataTable tablas;
        private Image imagen_original;
        private string ruta;
        ClassBasesDeDatos consultas = new ClassBasesDeDatos();
        public Form_Open_Database_Info_Tables(Form_Open_Database padre, DataTable tablas, string ruta)
        {
            InitializeComponent();
            this.tablas = tablas;
            this.ruta = ruta;
            form_padre = padre;
            obtener_tablas();
            Button_Propiedades.Checked = true;

            TextBox_SQL.SelectionIndent = 20;
            
        }
        
        public void obtener_tablas()
        {
            tablas = consultas.EjecutarSQL_QUERY("SELECT RDB$RELATION_NAME AS TABLA FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 ORDER BY TABLA ASC;");
            DataGridView_Tablas.Rows.Clear();
            foreach (DataRow datos in tablas.Rows)
            {
                string Name_Tablas = datos["TABLA"].ToString().Trim();
                DataTable info_tablas = consultas.EjecutarSQL_QUERY("SELECT * FROM \"" + Name_Tablas + "\";");
                DataGridView_Tablas.Rows.Add(false, Name_Tablas, info_tablas.Rows.Count.ToString(), info_tablas.Columns.Count.ToString());
            }
            if (tablas.Rows.Count == 0)
            {
                DataGridView_Tablas.Visible = false;

            }
            else
            {
                DataGridView_Tablas.Visible = true;

            }
        }
        private void DataGridView_Tablas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice_row = e.RowIndex;
            int indice_column = e.ColumnIndex;
            if (e.ColumnIndex != 0 && e.ColumnIndex != 4 && e.ColumnIndex != 5)
            {
                string nameTable = DataGridView_Tablas.Rows[indice_row].Cells[1].Value.ToString();
                form_padre.agregarCombobox(nameTable);
            }
        }

        private void DataGridView_Tablas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                DataGridViewCell celda = DataGridView_Tablas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string consulta_drop = "DROP TABLE \"" + DataGridView_Tablas.Rows[e.RowIndex].Cells[1].Value + "\";";
                consultas.EjecutarSQL_QUERY(consulta_drop);
                obtener_tablas();
            }
        }

        private void DataGridView_Tablas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0 || e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DataGridViewCell celda = DataGridView_Tablas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Image obtener_imagen = (Image)celda.Value;
                int ancho = 32;
                int alto = 32;
                Image imagen_ajustada = new Bitmap(obtener_imagen, ancho, alto);
                celda.Value = imagen_original;
                DataGridView_Tablas.Cursor = Cursors.Arrow;
            }
        }

        private void DataGridView_Tablas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0 || e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DataGridViewCell celda = DataGridView_Tablas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Image obtener_imagen = (Image)celda.Value;
                imagen_original = obtener_imagen;
                int ancho = 35;
                int alto = 35;

                Image imagen_ajustada = new Bitmap(obtener_imagen, ancho, alto);
                celda.Value = imagen_ajustada;
                DataGridView_Tablas.Cursor = Cursors.Hand;
            }

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridView_Tablas.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                DataGridView_Tablas.Cursor = Cursors.Hand;
            }
        }

        private void Form_Open_Database_Info_Tables_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper scroll = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView_Tablas, VScrollBar_Datagrid, false);
        }

        private void Button_Propiedades_Click(object sender, EventArgs e)
        {
            DataGridView_Tablas.BringToFront();
            VScrollBar_Datagrid.BringToFront();
            
        }

        private void Button_SQL_Click(object sender, EventArgs e)
        {
            TextBox_SQL.BringToFront();
            
            VScrollBar_Datagrid.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
