using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI.WinForms;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;

namespace Datahive
{
    public partial class Form_Open_Database : Form
    {
        private DataTable data;
        private string ruta;
        string nombre_form;

        private Image imagen_original;
        ClassBasesDeDatos consultas = new ClassBasesDeDatos();
        public Form_Open_Database(DataTable data, string ruta)
        {
            InitializeComponent();
            this.data = data;
            this.ruta = ruta;

            int indice = ruta.LastIndexOf('\\') + 1;
            nombre_form = ruta.Substring(indice).Trim();
            nombre_form = nombre_form.Replace(".FDB", string.Empty);
        }
        string ControlsAdd = "";
        public void Open_Tables(DataTable tabla, string ruta, string nombre)
        {  
            Form_Open_Database_Info_Tables abrir = new Form_Open_Database_Info_Tables(this,tabla, ruta);
            
            foreach (Control controles in Panel1_Central.Controls)
            {
                ControlsAdd += " " + controles.Text;
            }
            if (ControlsAdd.Contains(nombre))
            {
                foreach (Control controles in Panel1_Central.Controls)
                {
                    string abrir_base = controles.Name.ToString();
                    if (abrir_base.Contains(nombre))
                    {
                        controles.BringToFront();
                    }
                }
            }
            else
            {
                abrir.TopLevel = false;
                abrir.Name = nombre;
                abrir.Text = nombre;
                abrir.Dock = DockStyle.Fill;
                abrir.Size = Panel1_Central.Size;
                abrir.FormBorderStyle = FormBorderStyle.None;
                Panel1_Central.Controls.Add(abrir);
                abrir.BringToFront();
                abrir.Show();
            }
        }
        private void Button_Add_Table_Click(object sender, EventArgs e)
        {
            Form_Add_Table abrir = new Form_Add_Table(ruta, nombre_form);
            //abrir.Text = nombre_form;
            abrir.ShowDialog();
            
            
            //Form background = new Form();
            //using (Form_Add_Table abrir = new Form_Add_Table(ruta))
            //{
            //    background.StartPosition = FormStartPosition.CenterScreen;
            //    background.FormBorderStyle = FormBorderStyle.None;
            //    background.Opacity = .70d;
            //    background.BackColor = Color.Black;
            //    background.WindowState = FormWindowState.Maximized;
            //    background.TopMost = true;
            //    //background.Location = this.Location;
            //    background.ShowInTaskbar = false;
            //    background.Show();

            //    abrir.Owner = background;
            //    abrir.TopMost = true;
            //    abrir.ShowDialog();

            //    background.Dispose();
            //}
            //Form_Add_Table add_tables = new Form_Add_Table();
            //add_tables.Show();
            //add_tables.TopLevel = false;
            //add_tables.Dock = DockStyle.Fill;

            //Panel_Edition.Controls.Add(add_tables);
            //add_tables.Show();
        }

        private void Button_opciones_Click(object sender, EventArgs e)
        {
            ContextMenuStrip_Opciones.Show(Button_opciones, new Point(10, Button_opciones.Height));
        }

        private void Form_Open_Database_Load(object sender, EventArgs e)
        {
            
            Form_Open_Database_Info_Tables abrir = new Form_Open_Database_Info_Tables(this,data, ruta);

            while (Panel1_Central.Controls.Count > 0)
            {
                Panel1_Central.Controls.RemoveAt(0);
            }
            abrir.TopLevel = false;
            abrir.Name = "Inicio";
            abrir.Text = nombre_form;
            abrir.Dock = DockStyle.Fill;
            abrir.Size = Panel1_Central.Size;
            abrir.FormBorderStyle = FormBorderStyle.None;
            Panel1_Central.Controls.Add(abrir);
            abrir.BringToFront();
            abrir.Show();
        }
        public void agregarCombobox(String nameTable)
        {
            if (ComboBox_Open_Tables.Items.Contains(nameTable))
            {
                ComboBox_Open_Tables.SelectedItem = nameTable;
                Select_item_combo();
            }
            else
            {
                ComboBox_Open_Tables.Items.Add(nameTable);
                ComboBox_Open_Tables.SelectedItem = nameTable;
                Form_Open_Atributos abrir = new Form_Open_Atributos(this,nameTable);
                abrir.Name = nameTable;
                abrir.TopLevel = false;
                abrir.Dock = DockStyle.Fill;
                abrir.Size = Panel1_Central.Size;
                Panel1_Central.Controls.Add(abrir);
                abrir.BringToFront();
                abrir.Show();
            }
        }
        public void eliminarCombobox(String nameTable)
        {
            ComboBox_Open_Tables.Items.Remove(nameTable);
        }

        private void ComboBox_Open_Tables_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
        public void Select_item_combo()
        {
            foreach (Control control in Panel1_Central.Controls)
            {
                if (control.Name == ComboBox_Open_Tables.Text)
                {
                    control.BringToFront();
                }
            }
        }

        private void toolStripMenuItem_Backup_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_Open_Tables_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Select_item_combo();
        }

        private void Button_Del_Tables_Click(object sender, EventArgs e)
        {
            Mensaje_Eliminar_Tablas abrir = new Mensaje_Eliminar_Tablas(nombre_form);
            abrir.ShowDialog();
        }
        public void delete_tablas()
        {
            Form_Open_Database_Info_Tables form = Application.OpenForms.OfType<Form_Open_Database_Info_Tables>().FirstOrDefault(formulario => formulario.Text == nombre_form);
            foreach (Control controles in form.Controls)
            {
                if (controles.Name == "Panel_Contenedor")
                {
                    foreach (Control ctrl in controles.Controls)
                    {
                        if (ctrl is GunaDataGridView)
                        {
                            GunaDataGridView data = ctrl as GunaDataGridView;
                            for (int filas = 0; filas < data.Rows.Count; filas++)
                            {
                                if (data.Rows[filas].Cells[0].Value.ToString() == "True")
                                {
                                    //MessageBox.Show(data.Rows[filas].Cells[0].Value.ToString());
                                    string nombre_Tabla = data.Rows[filas].Cells[1].Value.ToString().Trim();
                                    consultas.consultas("DROP TABLE \"" + nombre_Tabla + "\";");
                                }
                            }
                        }
                    }
                }
            }
            form.obtener_tablas();
        }

        private void Button_Permisos_Click(object sender, EventArgs e)
        {
            //string usuario = "SYSDBA";
            //string permisos = "SELECT RDB$USER as USUARIO, RDB$PRIVILEGE as PERMISO, RDB$RELATION_NAME as TABLA FROM RDB$USER_PRIVILEGES WHERE RDB$USER = '" + usuario + "' AND RDB$RELATION_NAME NOT IN ('RDB$ROLES', 'RDB$PAGES','RDB$FORMATS');";
            //DataTable Consulta = consultas.EjecutarSQL_QUERY(permisos);
            //Form_Permisos_Tablas abrir = new Form_Permisos_Tablas(Consulta);
            //abrir.Name = "Permisos";
            //abrir.TopLevel = false;
            //abrir.Dock = DockStyle.Fill;
            //abrir.Size = Panel1_Central.Size;
            //Panel1_Central.Controls.Add(abrir);
            //abrir.BringToFront();
            //abrir.Show();
            //string sql = "SELECT RDB$USER as USUARIO,RDB$GRANTOR as AUTORIZA,RDB$PRIVILEGE as PERMISO,RDB$RELATION_NAME as TABLA FROM RDB$USER_PRIVILEGES WHERE RDB$USER = '" + guna2ComboBox1.Text + "'; ";
            //DataTable Consulta = obj.EjecutarSQL_QUERY(sql);
        }
    }
}
