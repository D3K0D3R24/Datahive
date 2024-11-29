using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using DBLevel;
//using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Datahive
{
    class ClassBasesDeDatos
    {

       
        public void cerrar_conexion()
        {
            FbConnection Conexion = new FbConnection(ClassGlobales.vCadenaConexionDataBase);
            Conexion.Close();
        }
        public DataTable DescribeTabla(string tabla)
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
                "WHERE r.RDB$RELATION_NAME='" + tabla + "'" +
                "ORDER BY r.RDB$FIELD_POSITION;");
            return describe_tablas;
        }
        public int AgregarBaseDeDatos(string vRUTA, string vALIAS, string vHOST,string vUSUARIO, string vPASS, string vPUERTO)
        {
            //           IDBASE   INTEGER NOT NULL,

            FbConnection vConexion = new FbConnection(ClassGlobales.vCadenaConexionDataBase);

            String vSQL_SELECT = "SELECT * FROM BASESSDEDATOS WHERE RUTADB='" + vRUTA + "' AND ALIAS='" + vALIAS +"';";

            FbDataAdapter da = new FbDataAdapter(vSQL_SELECT, ClassGlobales.vCadenaConexionDataBase);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //SI devuelve 1 entonces quiere decir que ya existe
                vConexion.Close();
                return 1;
            }
            else
            {
                //RUTADB   VARCHAR(254) NOT NULL,
                //ALIAS    VARCHAR(100) NOT NULL,
                //HOST     VARCHAR(25) NOT NULL,
                //USUARIO  VARCHAR(25) NOT NULL,
                //PASS     VARCHAR(25) NOT NULL,
                //PUERTO   VARCHAR(20) NOT NULL,
                String vSQL_Insert = "INSERT INTO BASESSDEDATOS (RUTADB,ALIAS,HOST,USUARIO,PASS,PUERTO) VALUES ( '" + vRUTA + "','" + vALIAS + "','" + vHOST + "','" + vUSUARIO + "','" + vPASS + "','" + vPUERTO + "'); ";
                FbCommand cmd = new FbCommand(vSQL_Insert, vConexion);
                vConexion.Open();

                if ((cmd.ExecuteNonQuery() == 1))
                {
                    //Si devuelve 0 entonces se ejecuto la consulta
                    vConexion.Close();
                    return 0;

                }
                else
                {
                    //Si devuelve 2 quiere decir que ocurrio un error al insertar
                    vConexion.Close();
                    return 2;
                }
            }
        }

        public DataTable EjecutarSQL_QUERY(String vSQL)
        {
            DataTable vData_Table = new DataTable();
            try {
                FbDataAdapter vFBConecccion = new FbDataAdapter(vSQL, ClassGlobales.vCadenaConexionDataBase);
                //ClassGlobales.GenerarLOG_DB("SQL", vSQL, "EXITOSO", "NINGUNO");    
                vFBConecccion.Fill(vData_Table);
            } 
            catch (Exception vExcep ){
                //ClassGlobales.GenerarLOG_DB_Errores("SQL", vSQL, "EXITOSO", "NINGUNO");   
            }
            return vData_Table;

        }

        public int EliminarBaseDeDatos(string alias)
        {
            FbConnection vConexion = new FbConnection(ClassGlobales.vCadenaConexionDataBase);

            String vSQL_SELECT = "SELECT * FROM BASESSDEDATOS WHERE ALIAS='" + alias + "';";

            FbDataAdapter da = new FbDataAdapter(vSQL_SELECT, ClassGlobales.vCadenaConexionDataBase);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                //SI devuelve 1 entonces quiere decir que ya existe
                String vSQL_DELETE = "DELETE FROM BASESSDEDATOS WHERE ALIAS ='" + alias + "';";
                FbCommand cmd = new FbCommand(vSQL_DELETE, vConexion);
                vConexion.Open();

                if ((cmd.ExecuteNonQuery() == 1))
                {
                    //Si devuelve 0 entonces se ejecuto la consulta
                    vConexion.Close();
                    return 0;

                }
                else
                {
                    //Si devuelve 2 quiere decir que ocurrio un error al insertar
                    vConexion.Close();
                    return 2;
                }


            }
            else
            {
                //Si devuelve 0 quiere decir que no se encuentra el dato3
                vConexion.Close();
                return 1;
            }
        }
        public void consultas(String vSQL)
        {
            FbConnection vConexion = new FbConnection(ClassGlobales.vCadenaConexionDataBase);
            
            FbDataAdapter da = new FbDataAdapter(vSQL, ClassGlobales.vCadenaConexionDataBase);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }

    }
}
