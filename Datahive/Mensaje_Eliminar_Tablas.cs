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
    public partial class Mensaje_Eliminar_Tablas : Form
    {
        private string nombre_form;
        public Mensaje_Eliminar_Tablas(string nombre_form)
        {
            InitializeComponent();
            this.nombre_form = nombre_form;
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            Form_Open_Database form = Application.OpenForms.OfType<Form_Open_Database>().FirstOrDefault();
            form.delete_tablas();
            this.Close();
        }
    }
}
