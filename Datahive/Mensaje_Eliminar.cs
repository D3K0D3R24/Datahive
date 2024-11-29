using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Datahive
{
    public partial class Mensaje_Eliminar : Form
    {
        private string Name_Base;
        public Mensaje_Eliminar(string Name_Base)
        {
            InitializeComponent();
            this.Name_Base = Name_Base;
        }

        private void Mensaje_Eliminar_Load(object sender, EventArgs e)
        {
            Label_Name_Base.Text = Name_Base;
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            Form1 padre = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            padre.nombre = Name_Base;
            foreach (Form forms in padre.GradientPanel_Central.Controls)
            {
                if (forms is Form)
                {
                    if (forms.Name.ToString() == Name_Base)
                    {
                        forms.Close();
                        forms.Dispose();

                        foreach (Guna2Button boton in padre.flowLayoutPanel1.Controls)
                        {
                            if (boton.Text == Name_Base)
                            {
                                foreach (Guna2Button botoncerrar in boton.Controls)
                                {
                                    botoncerrar.PerformClick();
                                }
                            }
                        }
                    }
                }
                
            }
            ClassBasesDeDatos objeto = new ClassBasesDeDatos();
            int eliminar = objeto.EliminarBaseDeDatos(Name_Base);
            switch (eliminar)
            {
                case 0:
                    break;

                case 1:
                    MessageBox.Show("No se pudo eliminar la base de datos");
                    break;
            }
            Form1 ejecutar = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            ejecutar.treeview();

            Form_Menu_Inicio ejecutar2 = Application.OpenForms.OfType<Form_Menu_Inicio>().FirstOrDefault();
            ejecutar2.Menu_Bases_botones();
            this.Close();
        }
    }
}
