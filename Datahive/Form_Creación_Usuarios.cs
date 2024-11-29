using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;


namespace Datahive
{
    public partial class Form_Creación_Usuarios : Form
    {
        public Form_Creación_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Creación_Usuarios_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vscroll = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView_Usuarios, gunaVScrollBar1, true);
            obtener_usuarios();
        }
        public void obtener_usuarios()
        {
            DataGridView_Usuarios.Rows.Clear();
            FbConnectionStringBuilder datos = new FbConnectionStringBuilder();
            datos.UserID = "SYSDBA";
            datos.Password = "masterkey";
            FbSecurity sec = new FbSecurity();
            sec.ConnectionString = datos.ConnectionString;
            
            FbUserData[] usuarios = sec.DisplayUsers();

            for (int i = 0; i < usuarios.Length; i++)
            {
                DataGridView_Usuarios.Rows.Add(false, usuarios[i].UserName);

            }
        }

        private void DataGridView_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex>=0)
            {
                string nombre = DataGridView_Usuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (nombre == "SYSDBA")
                {
                    MessageBox.Show("Operacion denegada");
                }
                else
                {
                    Mensaje_eliminar_usuario abrir = new Mensaje_eliminar_usuario(nombre);
                    abrir.ShowDialog();
                }
            }
        }

        private void DataGridView_Usuarios_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 || e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridView_Usuarios.Cursor = Cursors.Hand;
            }
            else
            {
                DataGridView_Usuarios.Cursor = Cursors.Arrow;
            }
        }

        private void Button_crear_Click(object sender, EventArgs e)
        {
            Form_Create_user abrir = new Form_Create_user();
            abrir.ShowDialog();
        }
    }
}
