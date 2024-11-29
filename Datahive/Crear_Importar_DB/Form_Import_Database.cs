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
    public partial class Form_Import_Database : Form
    {
        //Patron Singleton
        private static Form_Import_Database instancia;

        public static Form_Import_Database GetInstance(string ruta)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Form_Import_Database(ruta);
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

        ClassBasesDeDatos objeto = new ClassBasesDeDatos();
        private string ruta;
        private Form_Import_Database(string ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
            if (ruta == string.Empty)
            {
                

                Button_Open_File.Text = "De clic o arrastre el archivo";
            }
            else
            {
                int indice = ruta.LastIndexOf('\\') + 1;
                string namebase = ruta.Substring(indice).Trim();

                Button_Open_File.Text = namebase;
                TextBox_RutaDB.Text = ruta;
                Button_Open_File.BackColor = Color.FromArgb(98, 74, 209);
                TextBox_Alias.Select();
            }
        }

        private void Button_Open_File_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (archivos.Length == 1)
            {
                string archivo = archivos[0];

                string name_base =  @archivo;
                int indice = name_base.LastIndexOf('\\') + 1;
                name_base = name_base.Substring(indice).Trim();

                string formato = Path.GetExtension(archivo);
                if (formato == ".FDB")
                {
                    TextBox_RutaDB.Text = archivo;
                    Button_Open_File.BackColor = Color.FromArgb(98, 74, 209);
                    Button_Open_File.Text = name_base;
                    TextBox_Alias.Select();
                }
                else
                {
                    MessageBox.Show("Solo se admiten archivos con extencion .FDB");
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("Solo se admite un archivo a la vez");
            }
        }

        private void Button_Open_File_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Button_Open_File_Click(object sender, EventArgs e)
        {
            string archivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "FirebirdDataBase(*.FDB) | *.fdb";
            openFileDialog.DefaultExt = "FDB";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = openFileDialog.FileName;
            }

            string name_base = @archivo;
            string formato = Path.GetExtension(archivo);

            if (archivo != string.Empty)
            {
                int indice = name_base.LastIndexOf('\\') + 1;
                name_base = name_base.Substring(indice).Trim();

                TextBox_RutaDB.Text = archivo;
                Button_Open_File.BackColor = Color.FromArgb(98, 74, 209);
                Button_Open_File.Text = name_base;
                TextBox_Alias.Select();  
            }   
        }

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
                        GenerarScript(alias + ".sql", alias);
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
            Form_Menu_Inicio padre2 = Application.OpenForms.OfType<Form_Menu_Inicio>().FirstOrDefault();
            padre2.Menu_Bases_botones();

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

        private void Form_Import_Database_Load(object sender, EventArgs e)
        {
            ClassGlobales.vConexionC = new DBLevel.ClassMaster();
            ClassGlobales.ValidaOSVersion();
            ClassGlobales.ShowVariablesInMenuPrin();
        }
    }
}
