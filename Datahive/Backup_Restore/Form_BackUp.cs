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
    public partial class Form_BackUp : Form
    {
        public Form_BackUp()
        {
            InitializeComponent();
        }

        private void Button_Open_Ruta_Click(object sender, EventArgs e)
        {
            string vRutBackup = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "FirebirdDataBase(*.FDB) | *.fdb";
            openFileDialog.DefaultExt = "FDB";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                vRutBackup = openFileDialog.FileName;
            }
            TextBox_Open_Ruta.Text = vRutBackup;

            
        }

        private void Button_Select_Save_Click(object sender, EventArgs e)
        {
            string RBArchive = string.Empty;
            saveFileDialog1.Filter = "GenBank (*.GBK)|*.gbk";
            saveFileDialog1.DefaultExt = "GBK";
            saveFileDialog1.ShowDialog();
            TextBox_Save_Ruta.Text = saveFileDialog1.FileName;
        }

        private void Button_Respaldar_Click(object sender, EventArgs e)
        {
            try
            {
                FbConnectionStringBuilder vCString = new FbConnectionStringBuilder();
                vCString.UserID = "SYSDBA";
                vCString.Password = "masterkey";
                vCString.Database = TextBox_Open_Ruta.Text;

                FbBackup vBackup = new FbBackup();

                vBackup.ConnectionString = vCString.ToString();
                vBackup.BackupFiles.Add(new FbBackupFile(TextBox_Save_Ruta.Text, 2048));
                vBackup.Verbose = true;

                vBackup.Options = FbBackupFlags.IgnoreLimbo;
                vBackup.ServiceOutput += new ServiceOutputEventHandler(ServiceOutput);
                vBackup.Execute();
            }
            catch (Exception vExcep)
            {
                MessageBox.Show(vExcep.ToString());

            }

            MessageBox.Show("El respaldo se ha generado existosamente");

        }
        static void ServiceOutput(object sender, ServiceOutputEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }

    }
}
