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
    public partial class Mensaje_eliminar_usuario : Form
    {
        private string user_name;
        public Mensaje_eliminar_usuario(string user_name)
        {
            InitializeComponent();
            this.user_name = user_name;
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlBox_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            Form_Creación_Usuarios ejecutar = Application.OpenForms.OfType<Form_Creación_Usuarios>().FirstOrDefault();

            FbUserData user = new FbUserData();
            user.UserName = user_name;
            FbConnectionStringBuilder datos = new FbConnectionStringBuilder();
            datos.UserID = "SYSDBA";
            datos.Password = "masterkey";
            FbSecurity sec = new FbSecurity();
            sec.ConnectionString = datos.ConnectionString;
            sec.DeleteUser(user);

            ejecutar.obtener_usuarios();
            this.Close();

        }

        private void Mensaje_eliminar_usuario_Load(object sender, EventArgs e)
        {
            Label_Name_User.Text = user_name;
        }
    }
}
