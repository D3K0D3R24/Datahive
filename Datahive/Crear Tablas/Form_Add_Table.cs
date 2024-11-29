using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Datahive
{
    public partial class Form_Add_Table : Form
    {
        private string ruta;
        private string nombre_form;
        string N_Tabla = "";
        string N_Atributo = "";
        string Tipo_Dato = "";
        string longitud = "";
        string Not_Null = "";
        string P_Key = "";
        public Form_Add_Table(string ruta, string nombre_form)
        {
            InitializeComponent();
            this.ruta = ruta;
            this.nombre_form = nombre_form;
            //dataGridView_Tabla.Rows[0].Height = 30;
            
        }
        
        private void combo_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //    DataGridViewComboBoxEditingControl combo = sender as DataGridViewComboBoxEditingControl;

            //    int ColumnIndex = dataGridView_Tabla.CurrentCell.ColumnIndex;
            //    int RowIndex = dataGridView_Tabla.CurrentCell.RowIndex;
            //    if (combo != null && ColumnIndex >=0 && RowIndex>=0)
            //    {
            //        if (combo.Text == "VARCHAR()")
            //        {
            //            DataGridViewTextBoxCell TextoBoxcelda = new DataGridViewTextBoxCell();
            //            TextoBoxcelda.Value = combo.Text;
            //            dataGridView_Tabla[ColumnIndex, RowIndex] = TextoBoxcelda;
            //            dataGridView_Tabla.BeginEdit(true);
            //        }
            //    }
            //}
        }

        private void Button_Add_Data_Click(object sender, EventArgs e)
        {
            N_Atributo = TextBox_Nombre_Atributo.Text;
            longitud = TextBox_longitud.Text;
            //Not_Null = 
            //P_Key = CheckBox_Primary_key.Text;

            if (ComboBox_Type.Text == "VARCHAR")
            {
                Tipo_Dato = "VARCHAR(" + TextBox_longitud.Text + ")";
            }
            else
            {
                Tipo_Dato = ComboBox_Type.Text;
            }
            DataGridView_Atributos.Rows.Add(false, N_Atributo, Tipo_Dato, Button_Primary.Checked, Button_Not_null.Checked);
            Button_Not_null.Checked = false;
            Button_Primary.Checked = false;
            TextBox_Nombre_Atributo.Clear();
            TextBox_longitud.Clear();
            ComboBox_Type.SelectedIndex = 0;
            //dataGridView1.Rows.Add(N_Atributo, Tipo_Dato, CheckBox_Primary_key.Checked, CheckBox_Not_Null.Checked);
        }

        private void ComboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Type.Text == "VARCHAR")
            {
                TextBox_longitud.Enabled = true;
            }
            else
            {
                TextBox_longitud.Enabled = false;
                TextBox_longitud.Text = "";
            }
        }

        private void Button_Create_Table_Click(object sender, EventArgs e)
        {
            N_Tabla = TextBox__Name_tabla.Text;
            string vSql = "CREATE TABLE \"" + N_Tabla + "\"(\n";
            string nombre;
            string tipo;
            string primary_key;
            string not_null;
            string claves_primarias = "";
            char[] eliminar = { ',', '\n' };
            for (int i = 0; i < DataGridView_Atributos.Rows.Count; i++)
            {
                nombre = DataGridView_Atributos.Rows[i].Cells[1].Value.ToString();
                tipo = DataGridView_Atributos.Rows[i].Cells[2].Value.ToString();

                primary_key = DataGridView_Atributos.Rows[i].Cells[3].Value.ToString();

                not_null = DataGridView_Atributos.Rows[i].Cells[4].Value.ToString();

                //Operador ternario
                claves_primarias += (primary_key == "True") ? nombre + "," : "";

                not_null = (not_null == "True") ? "Not null" : "";

                vSql += nombre + " " + tipo + " " + not_null + ",\n";
            }
            //Si la variable claves_primarias no contiene nada cierra la consulta
            vSql = (claves_primarias == "") ? vSql.TrimEnd(eliminar) + ");" :

            //Si la variable claves_primarias contien por lo menos un datos lo agrega
            vSql += "Primary key (" + claves_primarias.TrimEnd(',') + "));";

            GenerarScript("Tabla.sql", vSql);
            EjecutarScriptSQL("Tabla.sql");

            this.Close();
            Form_Open_Database_Info_Tables form = Application.OpenForms.OfType<Form_Open_Database_Info_Tables>().FirstOrDefault(formulario => formulario.Text == nombre_form);
            form.obtener_tablas();
            //foreach (Form_Open_Database_Info_Tables form in Application.OpenForms.OfType<Form_Open_Database_Info_Tables>())
            //{
            //    if (form.Name == nombre_form)
            //    {
            //        form.obtener_tablas();
            //        break;
            //    }
            //}
        }

        private void EjecutarScriptSQL(string vNombreArchivoSQL)
        {
            StreamWriter vArchivoComandos = new StreamWriter(Application.StartupPath + "\\comandos.bat", false);
            string vArchivo = Application.StartupPath + "\\comandos.bat";
            vArchivoComandos.WriteLine("cd " + Application.StartupPath + "\\ISQL");
            vArchivoComandos.WriteLine("isql -q -user SYSDBA -password masterkey \"" + ruta + "\" -i \"" + Application.StartupPath + "\\SCRIPTS\\" + vNombreArchivoSQL + "\"");

            vArchivoComandos.Flush();
            vArchivoComandos.Close();

            System.Diagnostics.Process vProcess = new System.Diagnostics.Process();
            vProcess.StartInfo.FileName = "cmd.exe";
            vProcess.StartInfo.Arguments = "/C \"" + Application.StartupPath + "\\comandos.bat\"";
            vProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            vProcess.Start();
            vProcess.WaitForExit();

        }
        private void GenerarScript(string vNombreSCRIPT, string vCadena)
        //Uno representa el nombre del archivo .sql y el otro el nombre de la base de datos nueva
        {
            string vSQLScript = Application.StartupPath + "\\SCRIPTS\\" + vNombreSCRIPT;

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
                vObjStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
                String vComando = vCadena;
                vObjStreamWriter.WriteLine(vComando);

                vObjStreamWriter.Close();
            }
            catch (IOException ex)
            {
                string vMensaje = Convert.ToString(ex);
                MessageBox.Show(vMensaje);
            }
        }
    }
}

//private void dataGridView_Tabla_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
//{
//    //MessageBox.Show("Me ejecuto 1");
//    //if (dataGridView_Tabla.CurrentCell is DataGridViewComboBoxCell)
//    //{
//    //    ComboBox combo = e.Control as ComboBox;
//    //    if (combo != null)
//    //    {
//    //        //combo.SelectionChangeCommitted -= combo_SelectionChangeCommitted;
//    //        combo.SelectionChangeCommitted += combo_SelectionChangeCommitted;
//    //    }
//    //}
//}
//if (dataGridView_Tabla.CurrentCell is DataGridViewComboBoxCell)
//{
//    DataGridViewComboBoxCell comboBoxCell = dataGridView_Tabla.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
//    if (comboBoxCell != null)
//    {
//        //DataGridViewComboBoxEditingControl editingControl = dataGridView_Tabla.EditingControl as DataGridViewComboBoxEditingControl;
//        ComboBox combo = comboBoxCell.DataGridView.EditingControl as ComboBox;
//        if (combo != null)
//        {
//            combo.SelectionChangeCommitted -= combo_SelectionChangeCommitted;
//            combo.SelectionChangeCommitted += combo_SelectionChangeCommitted;
//        }
//    }

//}

//conteo++;
//if (conteo > 1)
//{
//    if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
//    {
//        var celda = dataGridView_Tabla[e.ColumnIndex, e.RowIndex];
//        if (celda is DataGridViewComboBoxCell)
//        {
//            DataGridViewComboBoxCell combo = (DataGridViewComboBoxCell)celda;
//            var comboValue = combo.Value;
//            if (comboValue != null)
//            {
//                //MessageBox.Show(dataGridView_Tabla.CurrentCell.Value.ToString());
//                //if (dataGridView_Tabla.CurrentCell is DataGridViewComboBoxCell && dataGridView_Tabla.CurrentCell.Value.ToString() == "VARCHAR")
//                //{
//                //}
//                var item_index = combo.Items.IndexOf(comboValue);

//                DataGridViewTextBoxCell textbox_celda = new DataGridViewTextBoxCell();
//                textbox_celda.Value = comboValue;
//                dataGridView_Tabla[e.ColumnIndex, e.RowIndex] = textbox_celda;

//                dataGridView_Tabla.BeginEdit(true);

//                ((TextBox)dataGridView_Tabla.EditingControl).SelectAll();

//                if (textbox_celda.Value != null && textbox_celda.Value.ToString().Contains("("))
//                {
//                    int cursorPosition = textbox_celda.Value.ToString().IndexOf("(") + 1;
//                    ((TextBox)dataGridView_Tabla.EditingControl).SelectionStart = cursorPosition;
//                    ((TextBox)dataGridView_Tabla.EditingControl).SelectionLength = 0;
//                    //dataGridView_Tabla_CellContentClick(sender, e);
//                }
//            }
//            //    else
//            //    {
//            //        if (celda is DataGridViewTextBoxCell)
//            //        {
//            //        }
//            //    }
//        }
//    }
//}       
