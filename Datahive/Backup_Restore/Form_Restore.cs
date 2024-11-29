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
    public partial class Form_Restore : Form
    {
        public Form_Restore()
        {
            InitializeComponent();
        }

        private void Button_Select_Ruta_Click(object sender, EventArgs e)
        {
            string vRutBackup = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "GenBank (*.GBK)|*.gbk";
            openFileDialog.DefaultExt = "GNK";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                vRutBackup = openFileDialog.FileName;
            }
            TextBox_Select_Ruta.Text = vRutBackup;
        }

        private void Button_Save_Ruta_Click(object sender, EventArgs e)
        {
            string RBArchive = string.Empty;
            saveFileDialog1.Filter = "FirebirdDataBase(*.FDB) | *.fdb";
            saveFileDialog1.DefaultExt = "FDB";
            saveFileDialog1.ShowDialog();
            TextBox_Save_Ruta.Text = saveFileDialog1.FileName;
        }

        private void Button_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                FbConnectionStringBuilder vCString = new FbConnectionStringBuilder();

                vCString.UserID = "SYSDBA";
                vCString.Password = "masterkey";
                vCString.Database = TextBox_Save_Ruta.Text;

                FbRestore vRestore = new FbRestore();

                vRestore.ConnectionString = vCString.ToString();
                vRestore.BackupFiles.Add(new FbBackupFile(TextBox_Select_Ruta.Text, 2048));
                vRestore.Verbose = true;
                vRestore.PageSize = 4096;
                vRestore.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace;

                vRestore.ServiceOutput += new ServiceOutputEventHandler(ServiceOutput);

                vRestore.Execute();
            }
            catch (Exception vExcep)
            {
                MessageBox.Show(vExcep.ToString());
            }
            MessageBox.Show("La restauracion se ha generado exitosamente");
        }
        static void ServiceOutput(object sender, ServiceOutputEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
}
