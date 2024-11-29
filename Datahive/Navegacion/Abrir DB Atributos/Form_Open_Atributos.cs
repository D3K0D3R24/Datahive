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
    public partial class Form_Open_Atributos : Form
    {
        private Form_Open_Database form_padre;
        private String tabla;
        public Form_Open_Atributos(Form_Open_Database padre, String tabla)
        {
            InitializeComponent();
            form_padre = padre;
            this.tabla = tabla;
        }

        private void ControlBox_Cerrar_Click(object sender, EventArgs e)
        {
            int indice = form_padre.ComboBox_Open_Tables.Items.IndexOf(this.Name);
            
            form_padre.eliminarCombobox(this.Name);
            form_padre.ComboBox_Open_Tables.SelectedIndex = indice - 1;
            form_padre.Select_item_combo();
            this.Close();
            this.Dispose();
            
        }
        private void obtener_atributos()
        {
            DataGridView_Atributos.Rows.Clear();
            ClassBasesDeDatos obtener = new ClassBasesDeDatos();
            DataTable describe = obtener.DescribeTabla(tabla);
            for (int filas = 0; filas < describe.Rows.Count; filas++)
            {
                string name = describe.Rows[filas][0].ToString().Trim();
                string tipo = describe.Rows[filas][1].ToString().Trim();
                string longitud = describe.Rows[filas][2].ToString().Trim();
                string P_key = describe.Rows[filas][4].ToString().Trim();
                string N_Null = describe.Rows[filas][3].ToString().Trim();

                bool Primary_Key = (P_key == "PRIMARY KEY") ? true : false;
                bool Not_Null = (N_Null == "NOT NULL") ? true : false;
                
                DataGridView_Atributos.Rows.Add(false, name, tipo + longitud, Primary_Key, Not_Null);
            }
        }

        private void Form_Open_Atributos_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper scroll = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView_Atributos, VScrollBar_Datagrid, true);
            obtener_atributos();
        }
        ClassBasesDeDatos consultas = new ClassBasesDeDatos();
        private void Button_Permisos_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT RDB$USER AS USUARIO, " +
                              "MAX(CASE WHEN RDB$PRIVILEGE = 'S' THEN 'S' ELSE '' END) AS \"Select\", " +
                              "MAX(CASE WHEN RDB$PRIVILEGE = 'I' THEN 'I' ELSE '' END) AS \"Insert\", " +
                              "MAX(CASE WHEN RDB$PRIVILEGE = 'U' THEN 'U' ELSE '' END) AS \"Update\", " +
                              "MAX(CASE WHEN RDB$PRIVILEGE = 'D' THEN 'D' ELSE '' END) AS \"Delete\", " +
                              "MAX(CASE WHEN RDB$PRIVILEGE = 'R' THEN 'R' ELSE '' END) AS \"References\", " +
                              "RDB$RELATION_NAME AS TABLA " +
                              "FROM RDB$USER_PRIVILEGES WHERE RDB$RELATION_NAME = '" + tabla + "' GROUP BY RDB$USER, RDB$RELATION_NAME;";
            
            DataTable permisos = consultas.EjecutarSQL_QUERY(consulta);
            Form_Permisos_Tabla abrir = new Form_Permisos_Tabla(permisos);
            foreach (Control controles in guna2Panel2.Controls)
            {
                if (controles.Text == "PERMISOS " + tabla)
                {
                    controles.BringToFront();
                    break;
                }
                else
                {
                    abrir.TopLevel = false;
                    abrir.Text = "PERMISOS " + tabla;
                    abrir.Dock = DockStyle.Fill;
                    abrir.Size = Panel_Central.Size;
                    guna2Panel2.Controls.Add(abrir);
                    abrir.Show();
                    abrir.BringToFront();
                }
            }
        }

        private void Button_Propiedades_Click(object sender, EventArgs e)
        {
            foreach(Control controles in guna2Panel2.Controls)
            {
                if (controles.Name == "DataGridView_Atributos")
                {
                    controles.BringToFront();
                    break;
                }
            }
        }
    }
}
