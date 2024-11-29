using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datahive
{
    public partial class Form_Permisos_Tabla : Form
    {
        private DataTable Data;
        //Dictionary<string,string> usuariosUnicos = new Dictionary<string, string>();
        List<string> usuariosUnicos = new List<string>();
        public Form_Permisos_Tabla(DataTable Data)
        {
            InitializeComponent();
            this.Data = Data;

            // Recorrer cada fila del DataTable original
            foreach (DataRow row in Data.Rows)
            {
                string usuario = row["Usuario"].ToString();

                // Verificar si el nombre de usuario ya existe en el diccionario
                if (!usuariosUnicos.Contains(usuario))
                {
                    // Agregar una nueva fila al diccionario para el nombre de usuario
                    usuariosUnicos.Add(usuario);
                }
            }
        }

        private void Form_Permisos_Tablas_Load(object sender, EventArgs e)
        {
            bool select = false;
            bool insert = false;
            bool update = false;
            bool delete = false;
            bool references = false;

            for (int fila = 0; fila < Data.Rows.Count; fila++)
            {
                string usuario = Data.Rows[fila][0].ToString().Trim();

                select = Data.Rows[fila][1].ToString().Trim() == "S" ? true : false;
                insert = Data.Rows[fila][2].ToString().Trim() == "I" ? true : false;
                update = Data.Rows[fila][3].ToString().Trim() == "U" ? true : false;
                delete = Data.Rows[fila][4].ToString().Trim() == "D" ? true : false;
                references = Data.Rows[fila][5].ToString().Trim() == "R" ? true : false;

                DataGridView_Permisos_Tablas.Rows.Add(usuario, select, insert, update, delete, references);
            }
        }
    }
}