using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Datahive
{
    public partial class Form_Migracion_MYSQL_FDB : Form
    {
        public Form_Migracion_MYSQL_FDB()
        {
            InitializeComponent();
        }

        private void Form_Migracion_MYSQL_FDB_Load(object sender, EventArgs e)
        {
            string conexion = "server=localhost;port=3306;user=root;password=;";
            ClaseConexion consultar = new ClaseConexion();
            DataTable resultado = consultar.Consultas("SHOW DATABASES", conexion);
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                guna2ComboBox1.Items.Add(resultado.Rows[i][0].ToString());
            }
        }
        bool activador;
        private void GenerarScript(string vCadena)
        {
            string vSQLScript = TextBox_Ruta_save.Text;
            try
            {
                StreamWriter vObjStreamWriter = default(StreamWriter);
                if (!System.IO.File.Exists(vSQLScript))
                {
                    //El script no existe, se debe de crear
                    try
                    {
                        vObjStreamWriter = File.AppendText(vSQLScript);
                        //vObjStreamWriter.WriteLine(vCadena);
                        vObjStreamWriter.Close();
                    }
                    catch (IOException ex)
                    {
                        string vMensaje = Convert.ToString(ex);
                        MessageBox.Show(vMensaje);
                    }
                }
            }
            catch (IOException ex)
            {
                string vMensaje = Convert.ToString(ex);
                MessageBox.Show(vMensaje);
            }
            try
            {
                //El archivo existe, se debe modificar
                if (File.Exists(vSQLScript))
                {
                    if (activador == true)
                    {
                        //File.AppendAllText(vSQLScript, string.Empty);
                        File.WriteAllText(vSQLScript, string.Empty);
                        activador = false;
                        File.AppendAllText(vSQLScript, vCadena);
                        File.AppendAllText(vSQLScript, Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(vSQLScript, vCadena);
                        File.AppendAllText(vSQLScript, Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void EjecutarScriptSQL(string vNombreArchivoSQL)
        {
            StreamWriter vArchivoComandos = new StreamWriter(Application.StartupPath + "\\comandos.bat", false);
            string vArchivo = Application.StartupPath + "\\comandos.bat";

            vArchivoComandos.WriteLine("cd " + Application.StartupPath + "\\ISQL");
            vArchivoComandos.WriteLine("isql -q -i \"" + @vNombreArchivoSQL);

            vArchivoComandos.Flush();
            vArchivoComandos.Close();

            System.Diagnostics.Process vProcess = new System.Diagnostics.Process();
            vProcess.StartInfo.FileName = "cmd.exe";
            vProcess.StartInfo.Arguments = "/C \"" + Application.StartupPath + "\\comandos.bat\"";
            vProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            vProcess.Start();
            vProcess.WaitForExit();

        }
        

        private void Button_Migrar_Click(object sender, EventArgs e)
        {
            Button_Migrar.Enabled = false;
            activador = true;
            Label_Indicador.Visible = true;
            backgroundWorker1.RunWorkerAsync();

        }

        private void Button_Save_DB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string RBArchive = string.Empty;
            saveFileDialog1.Filter = "Archivos SQL (*.sql) |*.sql";
            saveFileDialog1.DefaultExt = "sql";
            saveFileDialog1.FileName = guna2ComboBox1.Text;
            saveFileDialog1.ShowDialog();
            TextBox_Ruta_save.Text = saveFileDialog1.FileName;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Formar_Consulta(worker);
            
        }
        private void Formar_Consulta(BackgroundWorker worker)
        {
            ProgressBar1.ForeColor = Color.White;

            ClaseConexion conexion = new ClaseConexion();
            conexion.vUsuario = "root";
            conexion.vServidor = "localhost";
            conexion.vPassword = "";

            //conexion.vBaseDeDatos = guna2ComboBox1.Text;
            string name_base;
            guna2ComboBox1.Invoke((MethodInvoker)(() =>
            {
                conexion.vBaseDeDatos = guna2ComboBox1.Text;
                name_base = guna2ComboBox1.Text;
            }));



            string remplace = TextBox_Ruta_save.Text.Replace(".sql", ".fdb");
            string crear_db = "CREATE DATABASE '" + remplace + "' user '" + TextBox_User.Text + "' password '" + TextBox_Password.Text + "';";
            string conect_db = "CONNECT '" + remplace + "' user '" + TextBox_User.Text + "' password '" + TextBox_Password.Text + "';";

            GenerarScript(crear_db);
            GenerarScript(conect_db);

            string atributo_Line;
            int resultado = conexion.ABRIR_CONEXION_DB_MYSQL(conexion);
            switch (resultado)
            {
                case 0:
                    DataTable Tablas = Tablas = conexion.QUERY("SHOW TABLES");

                    for (int i = 0; i < Tablas.Rows.Count; i++)
                    {
                        int tablas_Num = (100 / Tablas.Rows.Count) + 1;
                        worker.ReportProgress(tablas_Num * (i + 1));

                        string crear_tabla = "CREATE TABLE " + Tablas.Rows[i][0].ToString().Trim() + "(";
                        GenerarScript(crear_tabla);

                        DataTable describe_tabla = null;

                        guna2ComboBox1.Invoke((MethodInvoker)(() => 
                        {
                            describe_tabla = conexion.DescribeTabla(guna2ComboBox1.Text, Tablas.Rows[i][0].ToString());
                        }
                        ));

                        for (int fila = 0; fila < describe_tabla.Rows.Count; fila++)
                        {
                            string nombre = "    " + describe_tabla.Rows[fila][0].ToString().Trim();
                            string tipo = " " + describe_tabla.Rows[fila][1].ToString().Trim();
                            string longitud = describe_tabla.Rows[fila][2].ToString().Trim();
                            string Not_Null = " " + describe_tabla.Rows[fila][3].ToString().Trim();
                            string P_Key = " " + describe_tabla.Rows[fila][4].ToString().Trim();

                            if (longitud != string.Empty)
                            {
                                longitud = "(" + longitud + ")";
                            }
                            if (P_Key.Trim() == "MUL")
                            {
                                P_Key = string.Empty;
                            }

                            if (fila == describe_tabla.Rows.Count - 1)
                            {
                                atributo_Line = nombre + tipo + longitud + Not_Null + P_Key;
                                GenerarScript(atributo_Line + "\n);");
                            }
                            else
                            {
                                atributo_Line = nombre + tipo + longitud + Not_Null + P_Key + ",";
                                GenerarScript(atributo_Line);
                            }
                        }
                    }
                    worker.ReportProgress(0);
                    string columnas = string.Empty;
                    string values = string.Empty;
                    for (int i = 0; i < Tablas.Rows.Count; i++)
                    {
                        int numero_datos = (100 / Tablas.Rows.Count) + 1;

                        DataTable registros = conexion.QUERY("SELECT * FROM " + Tablas.Rows[i][0] + ";");

                        Label_Indicador.Invoke((MethodInvoker)(() =>
                        {
                            int ancho_label = Label_Indicador.Size.Width / 2;
                            Label_Indicador.Text = "Insertando registros ...";
                            Label_Indicador.Location = new Point((this.Width / 2) - ancho_label, 488);
                        }));

                        if (registros.Rows.Count > 0)
                        {
                            for (int colum = 0; colum < registros.Columns.Count; colum++)
                            {
                                if (colum == registros.Columns.Count - 1)
                                {
                                    columnas = columnas + registros.Columns[colum].ToString();
                                }
                                else
                                {
                                    columnas = columnas + registros.Columns[colum].ToString() + ", ";
                                }
                            }
                            for (int filas = 0; filas < registros.Rows.Count; filas++)
                            {
                                values = "";
                                for (int colum = 0;  colum < registros.Columns.Count; colum++)
                                {
                                    if (colum == registros.Columns.Count - 1)
                                    {
                                        values = values + "'" + registros.Rows[filas][colum].ToString() + "'";
                                    }
                                    else
                                    {
                                        values = values + "'" + registros.Rows[filas][colum].ToString() + "', ";
                                    }
                                }
                                string linea = "INSERT INTO " + Tablas.Rows[i][0].ToString().Trim() + "(" + columnas + ")" + "VALUES (" + values + ");";
                                GenerarScript(linea);
                            }
                            columnas = string.Empty;
                        }
                        worker.ReportProgress(numero_datos * (i + 1));
                    }
                    EjecutarScriptSQL(TextBox_Ruta_save.Text);

                    Label_Indicador.Invoke((MethodInvoker)(() =>
                    {
                        Label_Indicador.Text = "Migración completada";
                        int ancho_label = Label_Indicador.Size.Width / 2;
                        Label_Indicador.Location = new Point((this.Width / 2) - ancho_label, 488);
                    }));
                    MessageBox.Show("Migracion exitosa");
                    Button_Migrar.Invoke((MethodInvoker)(() =>
                    {
                        Button_Migrar.Enabled = true;
                    }
                    ));
                    break;
                case 1:
                    MessageBox.Show("Fallo");
                    break;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }
    }
}
