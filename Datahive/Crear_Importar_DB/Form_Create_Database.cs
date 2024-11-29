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
using System.IO;
using Microsoft.VisualBasic;

namespace Datahive
{
    public partial class Form_Create_Database : Form
    {
        //Patron Singleton
        private static Form_Create_Database instancia;
        public static Form_Create_Database GetInstance
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new Form_Create_Database();
                }
                else 
                {
                    if (!instancia.Visible)
                    {
                        instancia.Show();
                    }
                    else if (instancia.WindowState == FormWindowState.Minimized)
                    {
                        instancia.WindowState = FormWindowState.Normal;
                    }
                    instancia.BringToFront();
                }
                return instancia;
            }
        }
        private Form_Create_Database()
        {
            InitializeComponent();
            TextBox_Host.Text = "localhost";
            TextBox_Password.Text = "masterkey";
            TextBox_Puerto.Text = "3050";
            TextBox_User.Text = "SYSDBA";
        }

        ClassBasesDeDatos objeto = new ClassBasesDeDatos();
        
        private void Button_add_DB_Click(object sender, EventArgs e)
        {
            string user = TextBox_User.Text;
            string password = TextBox_Password.Text;
            string host = TextBox_Host.Text;
            string puerto = TextBox_Puerto.Text;
            string alias = TextBox_Alias.Text;
            string ruta = TextBox_RutaDB.Text;

            int insertar = objeto.AgregarBaseDeDatos(ruta, alias, host, user, password, puerto);
            switch (insertar)
            {
                case 0:
                    DataTable registros = objeto.EjecutarSQL_QUERY("SELECT * FROM BASESSDEDATOS;");
                    if (registros.Rows.Count > 0)
                    {
                        GenerarScript(alias + ".sql", saveFileDialog1.FileName);
                        EjecutarScriptSQL(alias + ".sql");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                    }
                    break;
                case 1:
                    break;
            }
            Form_Menu_Inicio ejecutar = Application.OpenForms.OfType<Form_Menu_Inicio>().FirstOrDefault();
            ejecutar.Menu_Bases_botones();
            this.Close();

            Form1 padre = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            padre.treeview();
        }
        private void GenerarScript(string vNombreSCRIPT, string vNombreDB)
        //Uno representa el nombre del archivo .sql y el otro el nombre de la base de datos nueva
        {
            string vSQLScript = Application.StartupPath + "\\SCRIPTS\\" + vNombreSCRIPT;

            string Folder = Application.StartupPath + "\\SCRIPTS";
            try
            {
                if (!System.IO.Directory.Exists(Application.StartupPath + "\\SCRIPTS"))
                {
                    //La carpeta no existe, Se debe de crear
                    System.IO.Directory.CreateDirectory(Folder);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return;
            }

            try
            {
                if (System.IO.File.Exists(vSQLScript))
                {
                    //La carpeta no existe, Se debe de crear
                    System.IO.File.Delete(vSQLScript);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return;
            }

            StreamWriter vObjStreamWriter = default(StreamWriter);

            try
            {
                vObjStreamWriter = File.AppendText(vSQLScript);

                String vComando = "CREATE DATABASE '" + vNombreDB + "' user 'SYSDBA' password 'masterkey';";


                vObjStreamWriter.WriteLine(vComando);


                vObjStreamWriter.Close();
            }
            catch (IOException ex)
            {
                string vMensaje = Convert.ToString(ex);
                MessageBox.Show(vMensaje);
            }
        }

        //Ejecuta un archivo .SQL
        private void EjecutarScriptSQL(string vNombreArchivoSQL)
        {
            StreamWriter vArchivoComandos = new StreamWriter(Application.StartupPath + "\\comandos.bat", false);
            string vArchivo = Application.StartupPath + "\\comandos.bat";

            vArchivoComandos.WriteLine("cd " + Application.StartupPath + "\\ISQL");
            vArchivoComandos.WriteLine("isql -q -i \"" + Application.StartupPath + "\\SCRIPTS\\" + vNombreArchivoSQL + "\"");

            vArchivoComandos.Flush();
            vArchivoComandos.Close();

            System.Diagnostics.Process vProcess = new System.Diagnostics.Process();
            vProcess.StartInfo.FileName = "cmd.exe";
            vProcess.StartInfo.Arguments = "/C \"" + Application.StartupPath + "\\comandos.bat\"";
            vProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            vProcess.Start();
            vProcess.WaitForExit();

        }

        private void TextBox_RutaDB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_RutaDB_Click(object sender, EventArgs e)
        {
            string RBArchive = string.Empty;
            saveFileDialog1.Filter = "FirebirdDataBase(*.FDB) | *.fdb";
            saveFileDialog1.DefaultExt = "FDB";
            saveFileDialog1.ShowDialog();
            TextBox_RutaDB.Text = saveFileDialog1.FileName;
        }

        private void Form_Create_Database_Load(object sender, EventArgs e)
        {
            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            ClassGlobales.ValidaOSVersion();
            ClassGlobales.ShowVariablesInMenuPrin();
        }
    }
}
