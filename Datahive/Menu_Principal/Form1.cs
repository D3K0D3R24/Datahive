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
using Guna.UI.Animation;

namespace Datahive
{
    public partial class Form1 : Form
    {
        Form_Menu_Inicio MenuBases = new Form_Menu_Inicio();
        ClassBasesDeDatos objeto = new ClassBasesDeDatos();
        public string nombre;
        public Form1()
        {
            InitializeComponent();


            //hScrollBar1.Maximum = flowLayoutPanel1.Width - this.ClientSize.Width;
            GradientPanel_Izquierdo.Width = this.Width / 4;

            //ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            //ClassGlobales.ValidaOSVersion();
            //ClassGlobales.ShowVariablesInMenuPrin();
            
        }


        private void BotonMenu_Click(object sender, EventArgs e)
        {

            MenuBases.BringToFront();
            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            ClassGlobales.ValidaOSVersion();
            ClassGlobales.ShowVariablesInMenuPrin();

        }
        string cadena = "";

        private void abrir_si_existe(string boton)
        {
            foreach (Control control in GradientPanel_Central.Controls)
            {
                string nombre = control.Name;
                if (nombre.Contains(boton))
                {
                    control.BringToFront();
                }
            }
        }
        private Guna2Button boton_check = null;
        string ControlsAdd = "";
        public void Open_Databases(DataTable tabla, string ruta, string nombre)
        {
            //gunaTransition1.HideSync(GradientPanel_Central);
            //gunaTransition1.AnimationType = AnimationType.ScaleAndHorizSlide;
            //gunaTransition1.ShowSync(GradientPanel_Central);
            Guna2Button botonPestaña = new Guna2Button();
            Guna2Button boton_cerrar = new Guna2Button();
            
            foreach (Control controles in GradientPanel_Central.Controls)
            {
                ControlsAdd += " " + controles.Text;
            }
            if (ControlsAdd.Contains(nombre))
            {
                foreach (Control controles in GradientPanel_Central.Controls)
                {
                    string abrir_base = controles.Name.ToString();
                    if (abrir_base.Contains(nombre))
                    {
                        controles.BringToFront();
                        foreach (Guna2Button boton_tab in flowLayoutPanel1.Controls)
                        {
                            if (boton_tab.Text == nombre)
                            {
                                boton_tab.Checked = true;
                            }
                        }
                    }
                }
            }
            else
            {
                botonMenu.Checked = false;

                botonPestaña.Name = "";
                botonPestaña.Width = flowLayoutPanel1.Width / 4;
                botonPestaña.Height = flowLayoutPanel1.Height;
                botonPestaña.Text = nombre;
                botonPestaña.Padding = new Padding(0);
                botonPestaña.Margin = new Padding(0);
                botonPestaña.Click += Boton_Click;
                botonPestaña.Image = null;
                botonPestaña.TextAlign = HorizontalAlignment.Center;
                botonPestaña.ForeColor = Color.DimGray;
                botonPestaña.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                botonPestaña.FillColor = Color.FromArgb(19, 21, 26);
                botonPestaña.CheckedState.FillColor = Color.FromArgb(54, 56, 60);
                botonPestaña.CheckedState.ForeColor = Color.White;
                botonPestaña.Checked = true;

                boton_cerrar.Parent = botonPestaña;
                boton_cerrar.BackColor = Color.Transparent;
                boton_cerrar.UseTransparentBackground = true;
                boton_cerrar.FillColor = Color.Transparent;

                boton_cerrar.Width = 24;
                boton_cerrar.ForeColor = Color.Black;
                boton_cerrar.HoverState.ForeColor = Color.White;

                boton_cerrar.Name = nombre;
                boton_cerrar.Text = "×";
                boton_cerrar.Height = 24;
                boton_cerrar.Padding = new Padding(0);
                boton_cerrar.Margin = new Padding(0);
                boton_cerrar.Image = null;
                boton_cerrar.TextAlign = HorizontalAlignment.Center;
                boton_cerrar.Location = new Point((botonPestaña.Width / 2 - boton_cerrar.Width / 2) + botonPestaña.Width / 4 + botonPestaña.Width / 6, botonPestaña.Height / 2 - boton_cerrar.Height / 2);
                boton_cerrar.Click += Boton_cerrar_Click;

                if (cadena.Contains(nombre) != true)
                {
                    cadena += nombre + " ";
                    botonPestaña.Controls.Add(boton_cerrar);
                    flowLayoutPanel1.Controls.Add(botonPestaña);
                    if (flowLayoutPanel1.Controls.Count > 4)
                    {
                        foreach (Control control in flowLayoutPanel1.Controls)
                        {
                            control.Width = flowLayoutPanel1.Width / flowLayoutPanel1.Controls.Count;
                            foreach (Control subcontroles in control.Controls)
                            {
                                subcontroles.Location = new Point((control.Width / 2 - subcontroles.Width / 2) + control.Width / 4 + control.Width / 7, control.Height / 2 - subcontroles.Height / 2);
                            }
                        }
                    }
                }
                else
                {
                    cadena += "";
                }
                Form_Open_Database abrir = new Form_Open_Database(tabla, ruta);
                abrir.TopLevel = false;
                abrir.Name = nombre;
                abrir.Text = nombre;
                abrir.Dock = DockStyle.Fill;
                abrir.Size = GradientPanel_Central.Size;
                abrir.FormBorderStyle = FormBorderStyle.None;
                GradientPanel_Central.Controls.Add(abrir);
                abrir.BringToFront();
                abrir.Show();
            }
        }

        public void Boton_cerrar_Click(object sender, EventArgs e)
        {
            Guna2Button boton_cerrar = (Guna2Button)sender;
            botonMenu.Checked = true;
            
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                string name = control.Text;
                if (name.Contains(boton_cerrar.Name))
                {
                    flowLayoutPanel1.Controls.Remove(control);
                    control.Dispose();

                    foreach (Control CTRL in GradientPanel_Central.Controls)
                    {
                        if (name == CTRL.Name)
                        {
                            GradientPanel_Central.Controls.Remove(CTRL);
                            CTRL.Dispose();
                            ControlsAdd = ControlsAdd.Replace(CTRL.Name, "");
                            cadena = cadena.Replace(CTRL.Name, "");
                            

                            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                            ClassGlobales.ValidaOSVersion();
                            ClassGlobales.ShowVariablesInMenuPrin();
                        }
                        if (name == nombre)
                        {
                            ControlsAdd = ControlsAdd.Replace(nombre, "");
                            cadena = cadena.Replace(nombre, "");


                            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                            ClassGlobales.ValidaOSVersion();
                            ClassGlobales.ShowVariablesInMenuPrin();
                        }
                    }
                }
            }
            ajustar_botones_pestaña();
            nombre = string.Empty;
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            ClassGlobales.ValidaOSVersion();
            ClassGlobales.ShowVariablesInMenuPrin();
            
            Guna2Button boton = (Guna2Button)sender;
            
            foreach (Control control in GradientPanel_Central.Controls)
            {
                string nombre = control.Name;
                if (nombre.Contains(boton.Text))
                {
                    control.BringToFront();  
                }
            }
            string RUTADB = "";
            string HOST = "";
            string USUARIO = "";
            string PASS = "";
            string PUERTO = "";

            DataTable Cbases = objeto.EjecutarSQL_QUERY("SELECT RUTADB, HOST, USUARIO, PASS, PUERTO FROM BASESSDEDATOS WHERE ALIAS = '" + boton.Text + "';");
            USUARIO = Cbases.Rows[0]["USUARIO"].ToString();
            RUTADB = Cbases.Rows[0]["RUTADB"].ToString();
            PASS = Cbases.Rows[0]["PASS"].ToString();
            HOST = Cbases.Rows[0]["HOST"].ToString();
            PUERTO = Cbases.Rows[0]["PUERTO"].ToString();

            ClassGlobales.vCadenaConexionDataBase = "User=sysdba; Password=masterkey;" + " Database=" + RUTADB + "; " + " DataSource=" + HOST + "; Port=" + PUERTO + "; Dialect=3; Charset=NONE; Role=;" + "Connection lifetime=15; Pooling=true; MinPoolSize=0; MaxPoolSize=50;" + "Packet Size=8192;ServerType=0;lc_ctype=ISO8859_1";
            DataTable tab = objeto.EjecutarSQL_QUERY("SELECT RDB$RELATION_NAME AS TABLA FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 ORDER BY TABLA ASC;");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }
        public void ajustar_botones_pestaña()
        {
            if (flowLayoutPanel1.Controls.Count > 4)
            {
                foreach (Control controles in flowLayoutPanel1.Controls)
                {
                    controles.Width = flowLayoutPanel1.Width / flowLayoutPanel1.Controls.Count;
                    foreach (Control sub_control in controles.Controls)
                    {
                        sub_control.Location = new Point((controles.Width / 2 - sub_control.Width / 2) + controles.Width / 4 + controles.Width / 6, controles.Height / 2 - sub_control.Height / 2);
                    }
                }
            }
            else
            {
                foreach (Control controles in flowLayoutPanel1.Controls)
                {
                    controles.Width = flowLayoutPanel1.Width / 4;
                    foreach (Control sub_control in controles.Controls)
                    {
                        sub_control.Location = new Point((controles.Width / 2 - sub_control.Width / 2) + controles.Width / 4 + controles.Width / 6, controles.Height / 2 - sub_control.Height / 2);
                    }
                }
            }

            if (flowLayoutPanel1.Controls.Count <= 0)
            {
                ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                ClassGlobales.ValidaOSVersion();
                ClassGlobales.ShowVariablesInMenuPrin();

                botonMenu.Name = "botonInicio";
                botonMenu.Text = "Inicio";
                botonMenu.Margin = new Padding(0);
                botonMenu.Padding = new Padding(0);
                botonMenu.Width = flowLayoutPanel1.Width / 4;
                botonMenu.Height = flowLayoutPanel1.Height;
                flowLayoutPanel1.Controls.Add(botonMenu);
                botonMenu.Click += BotonMenu_Click;
                botonMenu.ForeColor = Color.DimGray;
                botonMenu.FillColor = Color.FromArgb(19, 21, 26);
                botonMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                botonMenu.CheckedState.FillColor = Color.FromArgb(54, 56, 60);
                botonMenu.CheckedState.ForeColor = Color.White;
                botonMenu.Checked = true;

                MenuBases.TopLevel = false;
                MenuBases.Dock = DockStyle.Fill;
                MenuBases.FormBorderStyle = FormBorderStyle.None;
                MenuBases.Text = "Menu";
                MenuBases.Size = GradientPanel_Central.Size;
                GradientPanel_Central.Controls.Add(MenuBases);
                MenuBases.Show();
            }
        }
        Guna2Button botonMenu = new Guna2Button();
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 4)
            {
                foreach (Control controles in flowLayoutPanel1.Controls)
                {
                    controles.Width = flowLayoutPanel1.Width / flowLayoutPanel1.Controls.Count;
                    foreach (Control sub_control in controles.Controls)
                    {
                        sub_control.Location = new Point((controles.Width / 2 - sub_control.Width / 2) + controles.Width / 4 + controles.Width / 6, controles.Height / 2 - sub_control.Height / 2);
                    }
                }
            }
            else
            {
                foreach (Control controles in flowLayoutPanel1.Controls)
                {
                    controles.Width = flowLayoutPanel1.Width / 4;
                    foreach (Control sub_control in controles.Controls)
                    {
                        sub_control.Location = new Point((controles.Width / 2 - sub_control.Width / 2) + controles.Width / 4 + controles.Width / 6, controles.Height / 2 - sub_control.Height / 2);
                    }
                }
            }
            
            if (flowLayoutPanel1.Controls.Count <= 0)
            {
                ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                ClassGlobales.ValidaOSVersion();
                ClassGlobales.ShowVariablesInMenuPrin();
                
                botonMenu.Name = "botonInicio";
                botonMenu.Text = "Inicio";
                botonMenu.Margin = new Padding(0);
                botonMenu.Padding = new Padding(0);
                botonMenu.Width = flowLayoutPanel1.Width / 4;
                botonMenu.Height = flowLayoutPanel1.Height;
                flowLayoutPanel1.Controls.Add(botonMenu);
                botonMenu.Click += BotonMenu_Click;
                botonMenu.ForeColor = Color.DimGray;
                botonMenu.FillColor = Color.FromArgb(19, 21, 26);
                botonMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                botonMenu.CheckedState.FillColor = Color.FromArgb(54, 56, 60);
                botonMenu.CheckedState.ForeColor = Color.White;
                botonMenu.Checked = true;

                MenuBases.TopLevel = false;
                MenuBases.Dock = DockStyle.Fill;
                MenuBases.FormBorderStyle = FormBorderStyle.None;
                MenuBases.Text = "Menu";
                MenuBases.Size = GradientPanel_Central.Size;
                GradientPanel_Central.Controls.Add(MenuBases);
                MenuBases.Show();
            }            
        }

        private void Button_Restore_Backup_Click(object sender, EventArgs e)
        {
            Form_Backup_and_Restore backup_restore = new Form_Backup_and_Restore();
            backup_restore.Show();
        }

        //private void migraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Form_Migración_DB abrir = new Form_Migración_DB();
        //    abrir.Show();
        //}


        private void ContextMenuStrip_Databases_MouseLeave(object sender, EventArgs e)
        {
            //ContextMenuStrip_Databases.Hide();
        }

        private void Button_Database_MouseEnter(object sender, EventArgs e)
        {
            //ContextMenuStrip_Databases.Show(Button_Database, new Point(10, Button_Database.Height));
        }

        private void Button_Herramientas_Click(object sender, EventArgs e)
        {

        }

        private void Button_Database_Click(object sender, EventArgs e)
        {
            ContextMenuStrip_Databases.Show(Button_Database, new Point(10, Button_Database.Height));
        }

        private void Button_Herramientas_Click_1(object sender, EventArgs e)
        {
            ContextMenuStrip_Herramientas.Show(Button_Herramientas, new Point(10, Button_Herramientas.Height));
        }

        private void Button_Herramientas_MouseEnter(object sender, EventArgs e)
        {
            //ContextMenuStrip_Herramientas.Show(Button_Herramientas, new Point(10, Button_Herramientas.Height));
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            treeview();
            
        }

        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                e.Node.Toggle();
            }
        }

        public void treeview()
        {
            string RUTADB = "";
            string HOST = "";
            string USUARIO = "";
            string PASS = "";
            string PUERTO = "";
            ClassBasesDeDatos objeto = new ClassBasesDeDatos();
            treeView1.Nodes.Clear();

            DataTable bases = objeto.EjecutarSQL_QUERY("SELECT * FROM BASESSDEDATOS");

            TreeNode Tables = new TreeNode("BASES DE DATOS");
            Tables.ImageIndex = 2;
            Tables.SelectedImageIndex = 2;
            treeView1.Nodes.Add(Tables);
            //EXTRAER LAS BASES DE DATOS
            for (int b = 0; b < bases.Rows.Count; b++)
            {
               
                ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                ClassGlobales.ValidaOSVersion();
                ClassGlobales.ShowVariablesInMenuPrin();

                treeView1.SelectedNode = treeView1.Nodes[0];
                
                TreeNode BD = new TreeNode(bases.Rows[b]["ALIAS"].ToString());
                
                BD.ImageIndex = 1;
                BD.SelectedImageIndex = 1;
                treeView1.SelectedNode.Nodes.Add(BD);
                

                string NameBase = bases.Rows[b]["ALIAS"].ToString();
                DataTable Cbases = objeto.EjecutarSQL_QUERY("SELECT RUTADB, HOST, USUARIO, PASS, PUERTO FROM BASESSDEDATOS WHERE ALIAS = '" + NameBase + "';");

                //CONECTAR A OTRA BASE DE DATOS
                for (int t = 0; t < Cbases.Rows.Count; t++)
                {
                      
                    ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                    ClassGlobales.ValidaOSVersion();
                    ClassGlobales.ShowVariablesInMenuPrin();

                    
                    treeView1.SelectedNode = treeView1.Nodes[0].Nodes[b];
                    TreeNode Textablas = new TreeNode("TABLAS");
                    treeView1.SelectedNode.Nodes.Add(Textablas);
                    

                    USUARIO = Cbases.Rows[t]["USUARIO"].ToString();
                    RUTADB = Cbases.Rows[t]["RUTADB"].ToString();
                    PASS = Cbases.Rows[t]["PASS"].ToString();
                    HOST = Cbases.Rows[t]["HOST"].ToString();
                    PUERTO = Cbases.Rows[t]["PUERTO"].ToString();

                    ClassGlobales.vCadenaConexionDataBase = "User=" + USUARIO + "; Password=" + PASS + "; Database=" + RUTADB + "; " + "DataSource=" + HOST + "; Port=" + PUERTO + "; Dialect=3; Charset=NONE; Role=;" + "Connection lifetime=15; Pooling=true; MinPoolSize=0; MaxPoolSize=50;" + "Packet Size=8192;ServerType=0;lc_ctype=ISO8859_1";
                    DataTable tab = objeto.EjecutarSQL_QUERY("SELECT RDB$RELATION_NAME AS TABLA FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 ORDER BY TABLA ASC;");

                    //EXTRAER LAS TABLAS DE LA BASE DE DATOS
                    for (int tables = 0; tables < tab.Rows.Count; tables++)
                    {
                        treeView1.SelectedNode = treeView1.Nodes[0].Nodes[b].Nodes[0];
                        TreeNode gettables = new TreeNode(tab.Rows[tables]["TABLA"].ToString());
                        treeView1.SelectedNode.Nodes.Add(gettables);
                        
                        DataTable atrib = objeto.EjecutarSQL_QUERY("SELECT * FROM \"" + tab.Rows[tables]["TABLA"].ToString() + "\";");
                        for (int atributos = 0; atributos < atrib.Columns.Count; atributos++)
                        {
                            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[b].Nodes[t].Nodes[tables];
                            TreeNode Atributos = new TreeNode(atrib.Columns[atributos].ToString());
                            
                            treeView1.SelectedNode.Nodes.Add(Atributos);
                        }
                        
                    }
                    BD.Collapse();
                    
                }
               
                ClassGlobales.vConexionC = new DBLevel.ClassMaster();
                ClassGlobales.ValidaOSVersion();
                ClassGlobales.ShowVariablesInMenuPrin();
                
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_Migración_DB abrir = new Form_Migración_DB();
            abrir.Show();
        }

        private void ToolStripMenuItem_Create_DB_Click(object sender, EventArgs e)
        {
            Form_Create_Database abrir = Form_Create_Database.GetInstance;   
            if (abrir.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void toolStripMenuItem_import_DB_Click(object sender, EventArgs e)
        {
            Form_Import_Database abrir = Form_Import_Database.GetInstance(string.Empty);
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                //MenuBases.Menu_Bases_botones();
                //treeview();
            }
        }

        private void Button_Usuarios_Click(object sender, EventArgs e)
        {
            Form_Creación_Usuarios abrir = new Form_Creación_Usuarios();
            abrir.ShowDialog();
        }

        private void Button_Avanzados_Click(object sender, EventArgs e)
        {
            ContextMenuStrip_Avanzados.Show(Button_Avanzados, new Point(10, Button_Avanzados.Height));
        }

        private void toolStripMenuItem_Gestionar_usuarios_Click(object sender, EventArgs e)
        {
            Form_Creación_Usuarios abrir = new Form_Creación_Usuarios();
            abrir.ShowDialog();
        }

        private void toolStripMenuItem_FDB_MySQL_Click(object sender, EventArgs e)
        {
            Form_Migración_DB abrir = new Form_Migración_DB();
            abrir.Show();
        }

        private void toolStripMenuItem_MySQL_FDB_Click(object sender, EventArgs e)
        {
            Form_Migracion_MYSQL_FDB abrir = new Form_Migracion_MYSQL_FDB();
            abrir.Show();
        }
    }
}
