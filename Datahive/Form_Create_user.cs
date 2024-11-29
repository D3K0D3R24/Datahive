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
    public partial class Form_Create_user : Form
    {
        public Form_Create_user()
        {
            InitializeComponent();
        }

        private void Button_crear_user_Click(object sender, EventArgs e)
        {
            ClassGlobales crear_Usuario = new ClassGlobales();
            crear_Usuario.CrearUsuario(TextBox_username.Text, TextBox_Password.Text);
            this.Close();
            Form_Creación_Usuarios ejecutar = Application.OpenForms.OfType<Form_Creación_Usuarios>().FirstOrDefault();
            ejecutar.obtener_usuarios();
        }
    }
}
