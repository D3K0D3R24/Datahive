using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.IO;
using System.Collections;

using System.Data;
using System.Diagnostics;
using FirebirdSql.Data.FirebirdClient;
using DBLevel;
using System.Windows.Forms;


namespace Datahive
{
   public  class ClassGlobales
    {

        //Nos permite crear un SCRIPT.sql

        public const string FormatoFecha = "dd-MMMM-yyyy";
        //Variables de Conexion con la DLL DBLevel
        public static string vIniFileG = "";
        public static string vCadenaConexionDataBase = "";
        public static string vUbicacionBase = "";

        //public static string vServer;

        ////Variables a Cargar en Busquedas
        //public static int vIDaLeer;
        //public static string vNombreAleer;
        //public static string vNickaLeer;

        //public static string vPerfilAleer;

        public static string vNuevaUnidad = "";

        public static string vNOMBREBASE_CONFIG = "";
        public static string vIPSERVER_CONFIG = "";
        public static string vPUERTO_CONFIG = "";
        public static string vUSER_CONFIG = "";

        public static string vPASS_CONFIG = "";


        public static string vGLobalesOPERACION_DB = "";
        public static string vGlobalesVALOR_OP_DB = "";
        public static string vGLobalesSTATUS_OP_DB = "";
        public static string vGLobalesERROR_OP_DB = "";


        public void GenerarScript_PermisoUsuario(string vNombreSCRIPT, string vRutaBase, string vUsuario)
        {
            string vSQLScript = Application.StartupPath + "\\SCRIPTS\\" + vNombreSCRIPT + ".sql";

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

                String vComando = "CONNECT '" + vRutaBase + "' user 'SYSDBA' password 'masterkey';";
                String vComando2 = "GRANT SELECT, INSERT, DELETE ON BASESDEDATOS TO " + vUsuario + ";";

                vObjStreamWriter.WriteLine(vComando);
                vObjStreamWriter.WriteLine(vComando2);


                vObjStreamWriter.Close();
            }
            catch (IOException ex)
            {
                string vMensaje = Convert.ToString(ex);
                MessageBox.Show(vMensaje);
            }
        }

        public void GenerarScript_test(string vNombreSCRIPT, string vRutaGuardar)
        {
            string vSQLScript = Application.StartupPath + "\\SCRIPTS\\" + vNombreSCRIPT + ".sql";

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

                String vComando = "CREATE DATABASE '" + vRutaGuardar + "' user 'SYSDBA' password 'masterkey';";


                vObjStreamWriter.WriteLine(vComando);


                vObjStreamWriter.Close();
            }
            catch (IOException ex)
            {
                string vMensaje = Convert.ToString(ex);
                MessageBox.Show(vMensaje);
            }
        }

        public void GenerarScript(string vNombreSCRIPT, string vRutaGuardar)
        {
            string vSQLScript = Application.StartupPath + "\\SCRIPTS\\" + vNombreSCRIPT + ".sql";

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

                string vCadena = "";
                int i = 0;

                for (i = 0; i <= 99; i++) {
                    vCadena = vCadena + "Linea no. " + i + "";
                }
                //String vComando = "CREATE DATABASE '" + vRutaGuardar + "' user 'SYSDBA' password 'masterkey';";


                vObjStreamWriter.WriteLine(vCadena);


                vObjStreamWriter.Close();
            }
            catch (IOException ex)
            {
                string vMensaje = Convert.ToString(ex);
                MessageBox.Show(vMensaje);
            }
        }

        //Ejecuta un archivo .SQL
        public void EjecutarScriptSQL(string vNombreArchivoSQL)
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





        public static DBLevel.ClassMaster vConexionC;


        public static ArrayList vPara = new ArrayList();

        public static void ShowVariablesInMenuPrin()
        {

            try
            {
                vPara = vConexionC.CargarConexion(vIniFileG);
                if (vPara.Count > 0)
                {
                    
                    vCadenaConexionDataBase = "User=" + vPara[0] + "; Password=" + vPara[1] + "; Database=" + vPara[4] + "; " + "DataSource=" + vPara[2] + "; Port=" + vPara[3] + "; Dialect=3; Charset=NONE; Role=;" + "Connection lifetime=15; Pooling=true; MinPoolSize=0; MaxPoolSize=50;" + "Packet Size=8192;ServerType=0;lc_ctype=ISO8859_1";

                    vNOMBREBASE_CONFIG = Convert.ToString(vPara[4]);
                    vIPSERVER_CONFIG = Convert.ToString(vPara[2]);
                    vPUERTO_CONFIG = Convert.ToString(vPara[3]);
                    vUSER_CONFIG = Convert.ToString(vPara[0]);
                    vPASS_CONFIG = Convert.ToString(vPara[1]);
                }
                else
                {

                    vNOMBREBASE_CONFIG = "C:\\Users\\J.A. Santamaria\\Documents\\Visual Studio 2010\\Projects\\CableMas\\DB\\CABLEVISION.FDB";

                    vIPSERVER_CONFIG = "localhost";
                    vPUERTO_CONFIG = "3050";
                    vUSER_CONFIG = "SYSDBA";
                    vPASS_CONFIG = "masrkey";

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show("No se pudo realizar la conexion, favor de verificar los parametros de conexion. Fallo al conectarse a la Base de Datos", "Conexión a la Base de Datos");
            }


        }

        public static string vPlataformaDeWindows = "";
        public static string vArchivoIniDeArranque = "";
        //Este metodo es importante ya que con esto nuestro sistema puede ser robusto y podra validar en que sistema Operativo esta corriendo la aplicacion

        public static void ValidaOSVersion()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32Windows:
                    break;
                // Windows 95 or 98, but notice that only Win98 currently supports .NET
                case PlatformID.Win32NT:
                    // Windows NT, 2000, or XP
                    switch (System.Environment.OSVersion.Version.Major)
                    {
                        case 5:
                            //Se trata de Windows 2000, XP Home o XP Pro
                            switch (System.Environment.OSVersion.Version.Minor)
                            {
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                    0:
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                    1:
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "XP";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                             2:
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "XP";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                            }
                            break;
                        case  // ERROR: Case labels with binary operators are unsupported : Equality
                                     6:
                            switch (System.Environment.OSVersion.Version.Minor)
                            {
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                         0:
                                    //Se trata de Windows Vista
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "VISTA";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                        1:
                                    //Se trata de Windows 7, se traa igual que vista
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "VISTA";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                    2:
                                    //Se trata de Windows 7, se traa igual que vista
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "VISTA";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                             3:
                                    //Se trata de Windows 7, se traa igual que vista
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "VISTA";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                            4:
                                    //Se trata de Windows 7, se traa igual que vista
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "VISTA";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                                case  // ERROR: Case labels with binary operators are unsupported : Equality
                                                     5:
                                    //Se trata de Windows 7, se traa igual que vista
                                    vIniFileG = FileSystem.CurDir() + "\\MyApp.ini";
                                    //MsgBox("El sistema operativo es: " & Chr(13) & _
                                    //       "Archivo INI a utilizar: " & vIniFileG)
                                    vPlataformaDeWindows = "VISTA";
                                    vArchivoIniDeArranque = vIniFileG;
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
        //


        public static void GenerarLOG_DB(String vOPERACION, String vVALOR, String vESTATUS, String vMENSAJE_ERROR)
        {
            string[] vEventos = new string[5];
            DateTime vDia = DateTime.Today;

            vEventos[0] = String.Format("Tiempo inicio aplicación: {0}", DateTime.Today);
            string vFecha = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM") + " del " + DateTime.Now.ToString("yyyy") + " a las " + DateTime.Now.ToString("HH").ToString() + "-" + DateTime.Now.ToString("mm").ToString() + " " + DateTime.Now.ToString("ss").ToString() + " hrs";
            string vFechaDir = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM") + " del " + DateTime.Now.ToString("yyyy");
            string vArchivo = FileSystem.CurDir() + "\\LOGS\\LOGS GENERALES\\LOGS generados el " + vFechaDir + "\\LOG generado el día " + vFecha + ".txt";

            //string vFileLOG = Application.StartupPath + "\\LOGS\\GENERALES\\" + vNombreSCRIPT + ".TXT";
            string Folder = Application.StartupPath + "\\LOGS\\LOGS GENERALES";
            string Folder2 = Application.StartupPath + "\\LOGS\\LOGS GENERALES\\LOGS generados el " + vFechaDir;
            
            try
            {
                if (!System.IO.Directory.Exists(Application.StartupPath + "\\LOGS\\LOGS GENERALES") || !System.IO.Directory.Exists(Application.StartupPath + "\\LOGS\\LOGS GENERALES\\LOGS generados el " + vFechaDir))
                {
                    //La carpeta no existe, Se debe de crear
                    System.IO.Directory.CreateDirectory(Folder);
                    System.IO.Directory.CreateDirectory(Folder2);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return;
            }

            try
            {
                if (System.IO.File.Exists(vArchivo))
                {
                    //La carpeta no existe, Se debe de crear
                    System.IO.File.Delete(vArchivo);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return;
            }
            //
            using (System.IO.StreamWriter vEscritor = new System.IO.StreamWriter(vArchivo))

                vEscritor.Flush();

            vEventos[1] = vOPERACION;//ClassGlobales.vGLobalesOPERACION_DB;
            vEventos[2] = vVALOR;//ClassGlobales.vGlobalesVALOR_OP_DB;
            vEventos[3] = vESTATUS;// ClassGlobales.vGLobalesSTATUS_OP_DB;// "STATUS: EXITOSO";
            vEventos[4] = vMENSAJE_ERROR;//ClassGlobales.vGLobalesERROR_OP_DB;// "ERROR: NINGUNO";


            File.WriteAllLines(vArchivo, vEventos);


            string vTiempoFin = String.Format("Tiempo fin aplicación: {0}", DateTime.Now.ToString());
            File.AppendAllText(vArchivo, vTiempoFin);
        }

        public static void GenerarLOG_DB_Errores(String vOPERACION, String vVALOR, String vESTATUS, String vMENSAJE_ERROR)
        {
            string[] vEventos = new string[5];
            DateTime vDia = DateTime.Today;

            vEventos[0] = String.Format("Tiempo inicio aplicación: {0}", DateTime.Today);
            string vFecha = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM") + " del " + DateTime.Now.ToString("yyyy") + " a las " + DateTime.Now.ToString("HH").ToString() + "-" + DateTime.Now.ToString("mm").ToString() + " " + DateTime.Now.ToString("ss").ToString() + "hrs";
            string vFechaDir = DateTime.Now.ToString("dddd") + " " + DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM") + " del " + DateTime.Now.ToString("yyyy");
            string vArchivo = FileSystem.CurDir() + "\\LOGS\\LOGS_ERRORES\\LOGS generados el " + vFechaDir + "\\LOG generado el día " + vFecha + ".txt";

            //string vFileLOG = Application.StartupPath + "\\LOGS\\GENERALES\\" + vNombreSCRIPT + ".TXT";
            string Folder = Application.StartupPath + "\\LOGS\\LOGS_ERRORES";
            string Folder2 = Application.StartupPath + "\\LOGS\\LOGS_ERRORES\\LOGS generados el " + vFechaDir;

            try
            {
                if (!System.IO.Directory.Exists(Application.StartupPath + "\\LOGS\\LOGS_ERRORES") || !System.IO.Directory.Exists(Application.StartupPath + "\\LOGS\\LOGS_ERRORES\\LOGS generados el " + vFechaDir))
                {
                    //La carpeta no existe, Se debe de crear
                    System.IO.Directory.CreateDirectory(Folder);
                    System.IO.Directory.CreateDirectory(Folder2);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return;
            }

            try
            {
                if (System.IO.File.Exists(vArchivo))
                {
                    //La carpeta no existe, Se debe de crear
                    System.IO.File.Delete(vArchivo);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                return;
            }
            //
            using (System.IO.StreamWriter vEscritor = new System.IO.StreamWriter(vArchivo))

                vEscritor.Flush();

            vEventos[1] = vOPERACION;//ClassGlobales.vGLobalesOPERACION_DB;
            vEventos[2] = vVALOR;//ClassGlobales.vGlobalesVALOR_OP_DB;
            vEventos[3] = vESTATUS;// ClassGlobales.vGLobalesSTATUS_OP_DB;// "STATUS: EXITOSO";
            vEventos[4] = vMENSAJE_ERROR;//ClassGlobales.vGLobalesERROR_OP_DB;// "ERROR: NINGUNO";


            File.WriteAllLines(vArchivo, vEventos);


            string vTiempoFin = String.Format("Tiempo fin aplicación: {0}", DateTime.Now.ToString());
            File.AppendAllText(vArchivo, vTiempoFin);
        }







        public static string vALIAS_GLOBAL = "";

        public static int GuardarBaseDeDatos(String vRuta, String vAlias, String vHost, String vUser, String vPass, String vPuerto) {

            int vValor=-1;
            ClassBasesDeDatos vObj = new ClassBasesDeDatos();
            int AgregarDB = vObj.AgregarBaseDeDatos(vRuta, vAlias, vHost, vUser, vPass, vPuerto);
            switch (AgregarDB)
            {
                case 0: //Indicará que se guarda en la tabla
                    vValor = 0;
                    vALIAS_GLOBAL = vAlias;
                    break;

                case 1: //Indicará que ya existe el archivo con ese nombre en la misma ruta
                    vValor = 1;
                    break;

                case 2: //Indicará que no se guarda en la tabla genera un error
                    vValor = 2;
                    break;
            }
            return vValor;
        }

        public void CrearUsuario(string nombreUsuario, string contraseña)
        {
            //Extraemos la ruta del archivo .bat
            string Ruta_Archivo = Application.StartupPath + "\\comandos.bat";

            //Leemos cuantas lineas contiene el archivo .bat
            string[] linea = File.ReadAllLines(Ruta_Archivo);

            //Editamos la linea numero2 ya que en esa linea se encuentra el comando
            linea[1] = "gsec -user SYSDBA -password masterkey -add " + nombreUsuario + " -pw " + contraseña + "";

            //Sobreescribimos la linea editada para guardar el usuario
            File.WriteAllLines(Ruta_Archivo, linea);

            //Creamos el proceso para ejecutar el archivo
            Process vProcess = new Process();
            vProcess.StartInfo.FileName = Ruta_Archivo;
            vProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            vProcess.Start();
            vProcess.WaitForExit();
        }




    }


}
