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
    public partial class Form_Renombrar_DB : Form
    {
        private string Nombre_DB;
        public Form_Renombrar_DB(string Nombre_DB)
        {
            InitializeComponent();
            this.Nombre_DB = Nombre_DB;
            Button_Text.Text = Nombre_DB;
        }

        private void Button_Select_DB_Click(object sender, EventArgs e)
        {
            string archivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "FirebirdDataBase(*.FDB) | *.fdb";
            openFileDialog.DefaultExt = "FDB";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = openFileDialog.FileName;
            }

            if (archivo != string.Empty)
            {

                TextBox_RutaDB.Text = archivo;
                TextBox_Alias.Select();
            }
        }

        private void Button_acept_DB_Click(object sender, EventArgs e)
        {
            ClassBasesDeDatos objeto = new ClassBasesDeDatos();
            //MessageBox.Show("UPDATE BASESSDEDATOS SET RUTADB = '" + TextBox_RutaDB.Text + "', ALIAS = '" + TextBox_Alias.Text + "', HOST = '" + TextBox_Host.Text + "', USUARIO = '" + TextBox_User.Text + "', PASS = '" + TextBox_Password.Text + "', PUERTO = '" + TextBox_Puerto.Text + "' WHERE ALIAS = '" + Button_Text.Text + "' ;");
            objeto.EjecutarSQL_QUERY("UPDATE BASESSDEDATOS SET RUTADB = '" + TextBox_RutaDB.Text + "', ALIAS = '" + TextBox_Alias.Text + "', HOST = '" + TextBox_Host.Text + "', USUARIO = '" + TextBox_User.Text + "', PASS = '" + TextBox_Password.Text + "', PUERTO = '" + TextBox_Puerto.Text + "' WHERE ALIAS = '" + Button_Text.Text + "' ;");
            //'" + vRUTA + "','" + vALIAS + "','" + vHOST + "','" + vUSUARIO + "','" + vPASS + "','" + vPUERTO + "'); ";
            Form_Menu_Inicio ejecutar = Application.OpenForms.OfType<Form_Menu_Inicio>().FirstOrDefault();
            ejecutar.Menu_Bases_botones();
            this.Hide();
        }
    }
}
