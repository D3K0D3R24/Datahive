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
using System.Diagnostics;

namespace Datahive
{
    public partial class Form_Migración_DB : Form
    {
        public Form_Migración_DB()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Migrar_Click(object sender, EventArgs e)
        {
            
            
            //Cabeceras
                        
        }
        public void Formar_Consultas(BackgroundWorker worker)
        {
            ProgressBar1.ForeColor = Color.White;
            
            ClassBasesDeDatos objeto = new ClassBasesDeDatos();
            string user = TextBox_User.Text;
            string password = TextBox_Password.Text;
            string database = TextBox_Base.Text;
            string datasource = "Localhost";
            string port = "3050";
            string crear_tabla;

            string name_base = @database;
            int indice = name_base.LastIndexOf('\\') + 1;
            name_base = name_base.Substring(indice).Trim();
            name_base = name_base.Replace(".FDB", string.Empty);

            string crear_db = "CREATE DATABASE " + name_base + ";";
            string use_db = "USE " + name_base + ";";
            string atributo_Line;
            GenerarScript(crear_db);
            GenerarScript(use_db);


            //for (int i = 0; i <= 100; i++)
            //{
            //    // Realiza el trabajo de la tarea aquí...

            //    // Informa el progreso al BackgroundWorker
            //    worker.ReportProgress(i);

            //    // Agrega una pausa para simular el tiempo de ejecución de la tarea
            //    System.Threading.Thread.Sleep(100);
            //}

            ClassGlobales.vCadenaConexionDataBase = "User=" + user + "; Password=" + password + "; Database=" + database + "; " + "DataSource=" + datasource + "; Port=" + port + "; Dialect=3; Charset=NONE; Role=;" + "Connection lifetime=15; Pooling=true; MinPoolSize=0; MaxPoolSize=50;" + "Packet Size=8192;ServerType=0;lc_ctype=ISO8859_1";

            DataTable tablas = objeto.EjecutarSQL_QUERY("SELECT RDB$RELATION_NAME AS TABLA FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG=0 ORDER BY TABLA ASC;");
            for (int i = 0; i < tablas.Rows.Count; i++)
            {
                int tablas_Num = (100 / tablas.Rows.Count)+1;
                worker.ReportProgress(tablas_Num * (i + 1));
                crear_tabla = "CREATE TABLE " + tablas.Rows[i][0].ToString().Trim() + "(";
                GenerarScript(crear_tabla);
                DataTable des_tabla = DescribeTabla(tablas, i);
                for (int fila = 0; fila < des_tabla.Rows.Count; fila++)
                {
                    string nombre = "    " + des_tabla.Rows[fila][0].ToString().Trim();
                    string tipo = " " + des_tabla.Rows[fila][1].ToString().Trim();
                    string longitud = des_tabla.Rows[fila][2].ToString().Trim();
                    string Not_Null = " " + des_tabla.Rows[fila][3].ToString().Trim();
                    string P_Key = " " + des_tabla.Rows[fila][4].ToString().Trim();

                    if (fila == des_tabla.Rows.Count - 1)
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
            for (int i = 0; i < tablas.Rows.Count; i++)
            {
                int numero_datos = (100 / tablas.Rows.Count) + 1;
                DataTable registros = objeto.EjecutarSQL_QUERY("SELECT * FROM " + tablas.Rows[i][0] + ";");

                Label_Indicador.Invoke((MethodInvoker)(()=>
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
                        for (int colum = 0; colum < registros.Columns.Count; colum++)
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

                        string linea = "INSERT INTO " + tablas.Rows[i][0].ToString().Trim() + "(" + columnas + ")" + "VALUES (" + values + ");";
                        GenerarScript(linea);
                    }

                    columnas = string.Empty;
                   
                }
                worker.ReportProgress(numero_datos * (i + 1));
            }
            Label_Indicador.Invoke((MethodInvoker)(() =>
            {   
                Label_Indicador.Text = "Migración completada";
                int ancho_label = Label_Indicador.Size.Width / 2;
                Label_Indicador.Location = new Point((this.Width / 2) - ancho_label, 488);
            }));
            MessageBox.Show("Migracion exitosa");
            Button_Migrar.Invoke((MethodInvoker)(()=>
            {
                Button_Migrar.Enabled = true;
            }
            ));
        }
        public DataTable DescribeTabla(DataTable tablas,int fila)
        {
            ClassBasesDeDatos objeto = new ClassBasesDeDatos();
            DataTable describe_tablas = objeto.EjecutarSQL_QUERY("\r\n" +
                "SELECT r.RDB$FIELD_NAME AS NOMBRE_CAMPO, \r\n " +
                "CASE f.RDB$FIELD_TYPE  " +
                "WHEN 261 THEN 'TEXT'  " +// CUANDO EL IDENTIFICADOR ES 261=BLOB SERA TEXT EN MYSQL
                "WHEN 14 THEN 'CHAR' " +
                "WHEN 40 THEN 'VARCHAR'  " +//CUANDO EL IDENTIFICADOR 40=CSTRING NO TIENE EQUIVALENCIA POR LO QUE LO PASAMOS A VARCHAR
                "WHEN 27 THEN 'DOUBLE' " + //CUANDO EL IDENTIFICADOR ES 27=DOUBLE PRESICION ES EQUIVALENTE A DOUBLE
                "WHEN 10 THEN 'FLOAT'  " +
                "WHEN 16 THEN 'BIGINT'  " +//CUANDO EL IDENTIFICADOR ES 16=INT64 ES EQUIVALENTE A BIGINT EN MYSQL
                "WHEN 8 THEN 'INT'   " +
                "WHEN 9 THEN 'BIGINT' " + //no tiene equivalencia a mysql POR LO QUE LO PASAMOS A DECIMAL O BIGINT
                "WHEN 7 THEN 'SMALLINT' " +
                "WHEN 12 THEN 'DATE'  " +
                "WHEN 13 THEN 'TIME'    " +
                "WHEN 35 THEN 'TIMESTAMP'    " +
                "WHEN 37 THEN 'VARCHAR'   " +
                "ELSE 'UNKNOWN'  " +
                "END AS TIPO_DE_DATO,\r\n" +

                //Extrae la longitud de los tipos de datos
                "CASE f.RDB$FIELD_TYPE  " +
                "WHEN 14 THEN '(' || f.RDB$FIELD_LENGTH || ')'   " +
                "WHEN 37 THEN '(' || f.RDB$FIELD_LENGTH || ')'   " +
                "WHEN 8 THEN ''   " +
                "WHEN 9 THEN '(' || f.RDB$FIELD_LENGTH || ')'   " +
                "WHEN 35 THEN '(' || f.RDB$FIELD_LENGTH || ')'   " +
                "WHEN 10 THEN '(' || f.RDB$FIELD_PRECISION || ',' || f.RDB$FIELD_SCALE || ')'   " +
                "WHEN 11 THEN '(' || f.RDB$FIELD_PRECISION || ',' || f.RDB$FIELD_SCALE || ')'   " +
                "ELSE ''  " +
                "END AS LONGITUD,\r\n" +

                "CASE WHEN r.RDB$NULL_FLAG = 1 THEN 'NOT NULL' ELSE '' END AS NOT_NULL,\r\n" + //SI EL TIPO DE VARIABLE ACEPTA NULLOS O NO

                "CASE WHEN s.RDB$FIELD_NAME IS NOT NULL THEN 'PRIMARY KEY' ELSE '' END AS PRIMARY_KEY\n" +
                "FROM RDB$RELATION_FIELDS r\r\n" +
                "LEFT JOIN RDB$FIELDS f ON r.RDB$FIELD_SOURCE = f.RDB$FIELD_NAME\r\n" +
                //"LEFT JOIN RDB$COLLATIONS coll ON f.RDB$COLLATION_ID = coll.RDB$COLLATION_ID\r\n" +
                //"LEFT JOIN RDB$CHARACTER_SETS cset ON f.RDB$CHARACTER_SET_ID = cset.RDB$CHARACTER_SET_ID\r\n" +
                "LEFT JOIN RDB$RELATION_CONSTRAINTS rc ON r.RDB$RELATION_NAME = rc.RDB$RELATION_NAME AND rc.RDB$CONSTRAINT_TYPE = 'PRIMARY KEY'\r\n" +
                "LEFT JOIN RDB$INDEX_SEGMENTS s ON rc.RDB$INDEX_NAME = s.RDB$INDEX_NAME AND r.RDB$FIELD_NAME = s.RDB$FIELD_NAME\r\n" +
                "WHERE r.RDB$RELATION_NAME='" + tablas.Rows[fila]["TABLA"] + "'" +
                "ORDER BY r.RDB$FIELD_POSITION;");
            return describe_tablas;
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


        private void Button_Open_DB_Click(object sender, EventArgs e)
        {
            string vRutBackup = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "FirebirdDataBase(*.FDB) | *.fdb";
            openFileDialog.DefaultExt = "FDB";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                vRutBackup = openFileDialog.FileName;
            }
            TextBox_Base.Text = vRutBackup;
        }

        private void Button_Save_DB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string RBArchive = string.Empty;
            saveFileDialog1.Filter = "Archivos SQL (*.sql) |*.sql";
            saveFileDialog1.DefaultExt = "sql";
            saveFileDialog1.ShowDialog();
            TextBox_Ruta_save.Text = saveFileDialog1.FileName;
        }

        private void Button_Migrar_Click_1(object sender, EventArgs e)
        {
            Button_Migrar.Enabled = false;
            activador = true;
            Label_Indicador.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            //Task tarea = new Task(Formar_Consultas);
            //tarea.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Formar_Consultas(worker);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }
    }
}
