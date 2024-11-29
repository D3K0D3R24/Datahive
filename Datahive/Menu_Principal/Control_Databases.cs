using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Diagnostics;

namespace Datahive
{
    public partial class Control_Databases : UserControl
    {
        public Control_Databases(int Ancho, int Alto, string Name)
        {
            InitializeComponent();
            this.Width = Ancho;
            this.Height = Alto;
            Button_Text.Text = Name;
            //guna2Panel1.Name = Name;
            //Transparentar botones
            Button_delete.Parent = Button_Text;
            Button_Text.BackColor = Color.Transparent;

            Button_Rename.Parent = Button_Text;
            Button_Rename.BackColor = Color.Transparent;

            Button_open_file.Parent = Button_Text;
            Button_open_file.BackColor = Color.Transparent;
            int anchoControl = this.Width;

            int x = Button_Text.Height / 7;
            
            Button_open_file.Size = new Size(x, x);
            Button_Rename.Size = new Size(x, x);
            Button_delete.Size = new Size(x, x);
            Button_Rename.Location = new Point(Button_Text.Width / 4 - Button_open_file.Width / 2, Button_Text.Height / 4 * 3);
            Button_open_file.Location = new Point(Button_Text.Width / 2 - Button_open_file.Width / 2, Button_Text.Height / 4 * 3);
            Button_delete.Location = new Point(Button_Text.Width / 4 * 3 - Button_open_file.Width / 2, Button_Text.Height / 4 * 3);
        }

        ClassBasesDeDatos objeto = new ClassBasesDeDatos();
        string ruta;
        private void Button_Text_Click(object sender, EventArgs e)
        {
            Form1 padre = this.Parent.Parent.Parent.Parent as Form1;

            string RUTADB = "";
            string HOST = "";
            string USUARIO = "";
            string PASS = "";
            string PUERTO = "";
            DataTable Cbases = objeto.EjecutarSQL_QUERY("SELECT RUTADB, HOST, USUARIO, PASS, PUERTO FROM BASESSDEDATOS WHERE ALIAS = '" + Button_Text.Text + "';");
            USUARIO = Cbases.Rows[0]["USUARIO"].ToString();
            RUTADB = Cbases.Rows[0]["RUTADB"].ToString();
            PASS = Cbases.Rows[0]["PASS"].ToString();
            HOST = Cbases.Rows[0]["HOST"].ToString();
            PUERTO = Cbases.Rows[0]["PUERTO"].ToString();
            ruta = RUTADB;
            ClassGlobales.vCadenaConexionDataBase = "User=sysdba; Password=masterkey;" + " Database=" + RUTADB + "; " + " DataSource=" + HOST + "; Port=" + PUERTO + "; Dialect=3; Charset=NONE; Role=;" + "Connection lifetime=15; Pooling=true; MinPoolSize=0; MaxPoolSize=50;" + "Packet Size=8192;ServerType=0;lc_ctype=ISO8859_1";
            DataTable tab = objeto.EjecutarSQL_QUERY("SELECT RDB$RELATION_NAME AS TABLA FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 ORDER BY TABLA ASC;");
            padre.Open_Databases(tab, RUTADB, Button_Text.Text);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            Mensaje_Eliminar abrir = new Mensaje_Eliminar(Button_Text.Text);
            abrir.ShowDialog();
            //int eliminar = objeto.EliminarBaseDeDatos(Button_Text.Text);
            //switch (eliminar)
            //{
            //    case 0:
            //        break;

            //    case 1:
            //        MessageBox.Show("No se pudo eliminar la base de datos");
            //        break;
            //}
            //Form1 padre2 = this.Parent.Parent.Parent.Parent as Form1;
            //padre2.treeview();

            //Form_Menu_Inicio padre = this.Parent.Parent as Form_Menu_Inicio;
            //padre.Menu_Bases_botones();

        }

        private void Button_open_file_Click(object sender, EventArgs e)
        {
            ClassBasesDeDatos consulta = new ClassBasesDeDatos();
            DataTable result = consulta.EjecutarSQL_QUERY("SELECT RUTADB FROM BASESSDEDATOS WHERE ALIAS = '" + Button_Text.Text + "';");
            string ruta = result.Rows[0][0].ToString();
            Process.Start("explorer.exe", "/select, " + ruta);
        }

        private void Button_Rename_Click(object sender, EventArgs e)
        {
            Form_Renombrar_DB abrir = new Form_Renombrar_DB(Button_Text.Text);
            abrir.ShowDialog();
        }
    }
}
