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
using FirebirdSql.Data.Client;
using System.IO;

namespace Datahive
{
    public partial class Form_Menu_Inicio : Form
    {
        public Form_Menu_Inicio()
        {
            InitializeComponent();
            
            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            ClassGlobales.ValidaOSVersion();
            ClassGlobales.ShowVariablesInMenuPrin();     
        }
        ClassBasesDeDatos objeto = new ClassBasesDeDatos();
        int numbases;

        public void Menu_Bases_botones()
        {
            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            ClassGlobales.ValidaOSVersion();
            ClassGlobales.ShowVariablesInMenuPrin();

            int ScrollV_Ancho = SystemInformation.VerticalScrollBarWidth;
            int x = 0;
            int y = 0;
            int cant = 0;
            int incremental = 4;

            string nombrebases;
            DataTable registros = objeto.EjecutarSQL_QUERY("SELECT * FROM BASESSDEDATOS ORDER BY IDBASE;");

            numbases = registros.Rows.Count;

            while (panel_central.Controls.Count > 0)
            {
                panel_central.Controls.RemoveAt(0);
            }

            Guna2TileButton button_createDB = new Guna2TileButton();
            panel_central.Controls.Add(button_createDB);
            button_createDB.Name = "button_createDB";
            button_createDB.Size = new Size((panel_central.Width / 4 - ScrollV_Ancho), panel_central.Height / 2);
            button_createDB.Location = new Point(x, y);
            button_createDB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            button_createDB.BorderThickness = 2;
            button_createDB.BorderColor = Color.FromArgb(216, 217, 226);
            button_createDB.FillColor = Color.Transparent;
            button_createDB.Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            button_createDB.ForeColor = Color.FromArgb(40, 44, 52);
            button_createDB.Text = "Add Database";
            button_createDB.Click += Button_createDB_Click;
            button_createDB.HoverState.ForeColor = Color.FromArgb(98, 74, 209);
            //button_createDB.Image = Properties.Resources.icon_más;
            //button_createDB.ImageSize = new Size(50, 50);
            //button_createDB.HoverState.Image = Properties.Resources.icon_más_60;


            Guna2TileButton button_importDB = new Guna2TileButton();
            panel_central.Controls.Add(button_importDB);
            button_importDB.Name = "button_importDB";
            button_importDB.Size = new Size((panel_central.Width / 4 - ScrollV_Ancho), panel_central.Height / 2);
            button_importDB.Location = new Point(x = panel_central.Width / 4 - ScrollV_Ancho / 3, y);
            button_importDB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            button_importDB.BorderThickness = 2;
            button_importDB.BorderColor = Color.FromArgb(216, 217, 226);
            button_importDB.FillColor = Color.Transparent; 
            button_importDB.Font = new Font("Bahnschrift Condensed", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            button_importDB.ForeColor = Color.FromArgb(40, 44, 52);
            button_importDB.Text = "Import Database";
            button_importDB.Click += Button_importDB_Click;
            button_importDB.HoverState.ForeColor = Color.FromArgb(98, 74, 209);

            for (int i = 0; i < numbases; i++)
            {
                cant++;
                if (panel_central.Controls.Count > 0)
                {
                    x = x + panel_central.Width / 4 - ScrollV_Ancho / 3;
                }

                if (panel_central.Controls.Count == 4)
                {
                    cant = 4;
                }

                if (cant == incremental)
                {
                    incremental = incremental + 4;
                    x = 0;
                    y = y + panel_central.Height / 2 + ScrollV_Ancho;//+ ScrollV_Ancho;
                }
                nombrebases = registros.Rows[i]["ALIAS"].ToString();

                Control_Databases Button_bases = new Control_Databases((panel_central.Width / 4 - ScrollV_Ancho), panel_central.Height / 2, nombrebases);
                panel_central.Controls.Add(Button_bases);
                Button_bases.Name = nombrebases;
                Button_bases.Size = new Size((panel_central.Width / 4 - ScrollV_Ancho), panel_central.Height / 2);
               
                Button_bases.Location = new Point(x, y);
            }
            ClassBasesDeDatos conexion = new ClassBasesDeDatos();
            conexion.cerrar_conexion();
        }

        private void Button_importDB_Click(object sender, EventArgs e)
        {
            Form_Import_Database abrir = Form_Import_Database.GetInstance(string.Empty);
            abrir.Show();
        }

        private void Button_createDB_Click(object sender, EventArgs e)
        {
            Form_Create_Database abrir = Form_Create_Database.GetInstance;
            abrir.Show();
            //Form_Create_Database abrir = new Form_Create_Database();
            //abrir.ShowDialog();
            //Menu_Bases_botones();
        }

        private void Form_Menu_Inicio_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper scroll = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel_central, gunaVScrollBar1, true);
            Menu_Bases_botones();
        }

        private void Form_Menu_Inicio_Resize(object sender, EventArgs e)
        {
            Menu_Bases_botones();
        }

        private void panel_central_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (archivos.Length == 1)
            {
                string archivo = archivos[0];
                string formato = Path.GetExtension(archivo);
                if (formato == ".FDB")
                {
                    Form_Import_Database abrir = Form_Import_Database.GetInstance(archivo);
                    abrir.ShowDialog();    
                }
                else
                {
                    MessageBox.Show("Solo se acpetan archivos con extencion .FDB");
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("Solo se admite un archivo a la vez");
            }
            //Form1 padre = this.Parent.Parent as Form1;
            //Menu_Bases_botones();
            //padre.treeview();
            
            //MessageBox.Show(this.Parent.Parent.ToString());
        }

        private void panel_central_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
