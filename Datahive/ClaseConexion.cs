using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Datahive //Cambia el nombre por el nombre de tu proyecto
{
    class ClaseConexion
    {
        public string vServidor { get; set; }
        public string vUsuario { get; set; }
        public string vPassword { get; set; }
        public string vBaseDeDatos { get; set; }

        public static MySqlConnection SQLConnection = new MySqlConnection();
        string vServerString = "";
        string vEstatus_Conexion = "";


        public int ABRIR_CONEXION_DB_MYSQL(ClaseConexion vObjConexion)
        {
            int vResultado = 1;
            vServerString = ("Server="
                        + (vObjConexion.vServidor + (";" + ("user Id="
                        + (vObjConexion.vUsuario + (";" + ("Password="
                        + (vObjConexion.vPassword + (";" + ("Database=" + vObjConexion.vBaseDeDatos))))))))));
            SQLConnection.Close();
            SQLConnection.ConnectionString = vServerString;
            
            try
            {
                if ((SQLConnection.State == ConnectionState.Closed))
                {
                    SQLConnection.Open();
                    vResultado = 0;
                    vEstatus_Conexion = "OPEN";
                    return vResultado;
                }
                else
                {
                    SQLConnection.Close();
                    vResultado = 1;
                    vEstatus_Conexion = "CLOSE";
                    return vResultado;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            return vResultado;
        }

        public DataTable DescribeTabla(string nombre_base, string tabla)
        {
            
            DataTable describe_tablas = QUERY("SELECT COLUMN_NAME AS nombre_campo, " +
                "CASE WHEN DATA_TYPE = 'int' THEN 'INTEGER' " +
                "WHEN DATA_TYPE = 'varchar' THEN 'VARCHAR' " +
                "WHEN DATA_TYPE = 'double' THEN 'DOUBLE PRECISION' " +
                "WHEN DATA_TYPE = 'varchar' THEN 'VARCHAR' " +
                "WHEN DATA_TYPE = 'decimal' THEN 'DECIMAL' " +
                "WHEN DATA_TYPE = 'char' THEN 'CHAR' " +
                
                "WHEN DATA_TYPE = 'text' THEN 'BLOB' " +
                "WHEN DATA_TYPE = 'tinyint' THEN 'SMALLINT' " +
                "WHEN DATA_TYPE = 'float' THEN 'FLOAT' " +
                "WHEN DATA_TYPE = 'smallint' THEN 'SMALLINT' " +
                "WHEN DATA_TYPE = 'mediumint' THEN 'INTEGER' " +
                "WHEN DATA_TYPE = 'blob' THEN 'BLOB SUB_TYPE BINARY SEGMENT SIZE 50' " +
                "WHEN DATA_TYPE = 'longblob' THEN 'BLOB SUB_TYPE BINARY SEGMENT SIZE 50' " +
                //"WHEN 'decimal' 'DECIMAL'" +
                ///"WHEN 'char' 'CHAR'" +
                ////"WHEN 'text' THEN 'BLOB'\r\n" +
                ////"WHEN 'tinyint' THEN 'SMALLINT'\r\n" +
                ////"WHEN 'float' THEN 'FLOAT'\r\n" +
                ////"WHEN 'smallint' THEN 'SMALLINT'\r\n" +
                ////"WHEN 'mediumint' THEN 'INTEGER'\r\n" +
                ////"WHEN 'blob' THEN 'BLOB SUB_TYPE BINARY SEGMENT SIZE 50'\r\n" +
                ////"WHEN 'longblob' THEN 'BLOB SUB_TYPE BINARY SEGMENT SIZE 50'\r\n" +
                "ELSE DATA_TYPE " +
                "END AS Type,\r\n " +

                "CHARACTER_MAXIMUM_LENGTH AS longitud, " +

                "CASE WHEN IS_NULLABLE = 'YES' THEN '' " +
                "WHEN IS_NULLABLE = 'NO' THEN 'NOT NULL' " +
                "ELSE IS_NULLABLE " +
                "END AS nulos, " +
                //"COLUMN_KEY AS es_primary_key " +
                "CASE WHEN COLUMN_KEY = 'PRI' THEN 'PRIMARY KEY' " +
                "ELSE COLUMN_KEY "+
                "END AS PRIMARY_KEY "+
                "FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" +nombre_base+"' " +
                "AND TABLE_NAME = '"+tabla+"' " +
                "ORDER BY ORDINAL_POSITION;");
            return describe_tablas;
        }
        public DataTable QUERY(string vSQL)
        {
            DataTable vTable = new DataTable();
            try
            {
                MySqlDataAdapter vAdaptador = new MySqlDataAdapter(vSQL, ClaseConexion.SQLConnection);

                
                vAdaptador.Fill(vTable);
                ClaseConexion.SQLConnection.Close();
                ClaseConexion.SQLConnection.Dispose();
                return vTable;
            }
            catch (Exception ex)
            {
                return vTable;
            }
            
        }
        //string conexion = "server=localhost;port=3306;user=root;password=;";
        public DataTable Consultas (string consulta,string conexion)
        {
            DataTable Resultado = new DataTable();
            MySqlConnection conect = new MySqlConnection(conexion);
            try
            {
                conect.Open();
                String vSQL = consulta + ";";//"INSERT INTO medicos (IDMEDICOS,NOMBRE,CEDULA,EDAD,SEXO, NUM_CONSULTORIO,ESPECIALIDAD,TELEFONO) VALUES (@IDMEDICOS, @NOMBRE, @CEDULA, @EDAD, @SEXO, @NUM_CONSULTORIO, @ESPECIALIDAD, @TELEFONO)";

                MySqlCommand cmd = new MySqlCommand(vSQL, conect);
                MySqlDataReader reader = cmd.ExecuteReader();

                Resultado.Load(reader);
            }
            catch (Exception vExcep)
            {
                MessageBox.Show(vExcep.ToString());
            }
            return Resultado;
        }

        
    }
}
