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
    public partial class Form_Backup_and_Restore : Form
    {
        public Form_Backup_and_Restore()
        {
            InitializeComponent();
        }

        private void Button_backup_Click(object sender, EventArgs e)
        {
            Form_BackUp open_backup = new Form_BackUp();
            foreach (Control controles in Panel_central.Controls)
            {
                if (controles.Name.ToString() == open_backup.Name.ToString())
                {
                    open_backup.BringToFront();
                }
                else
                {
                    //Panel_central.Controls.Remove(guna2HtmlLabel1);
                    open_backup.TopLevel = false;
                    open_backup.Dock = DockStyle.Fill;
                    Panel_central.Controls.Add(open_backup);
                    open_backup.BringToFront();
                    open_backup.Show();
                }
            }
        }

        private void Button_restore_Click(object sender, EventArgs e)
        {
            Form_Restore open_restore = new Form_Restore();
            foreach (Control controles in Panel_central.Controls) 
            {   
                if (controles.Name.ToString() == open_restore.Name.ToString())
                {
                    open_restore.BringToFront();
                }
                else
                {
                    open_restore.TopLevel = false;
                    open_restore.Dock = DockStyle.Fill;
                    Panel_central.Controls.Add(open_restore);
                    open_restore.BringToFront();
                    open_restore.Show();
                    //if (controles.Name == guna2HtmlLabel1.Name)
                    //{
                    //    Panel_central.Controls.Remove(guna2HtmlLabel1);
                    //} 
                }
            }
        }
    }
}
