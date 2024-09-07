
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Diagnostics;

namespace Attendance_Automation
{
    public partial class Frm_Backup : Form
    {
        public Frm_Backup()
        {
            InitializeComponent();
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Server dbServer = new Server(new ServerConnection(txtServer.Text, txtUsername.Text, txtPassword.Text));
            try
            {
                if (rdoBackup.Checked) //for backup database
                {
                    Backup dbBackup = new Backup() { Action = BackupActionType.Files, Database = txtDatabase.Text };
                    dbBackup.Devices.AddDevice(@"C:\data\Attendance_DB.bak", DeviceType.File);
                    dbBackup.Initialize = true;
                    dbBackup.PercentComplete += DbBackup_PercentComplete;
                    dbBackup.Complete += DbBackup_Complete;
                    dbBackup.SqlBackupAsync(dbServer);
                }
                else if (rdoRestore.Checked) // for restore database
                {
                    Restore dbRestore = new Restore() { Database = txtDatabase.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                    dbRestore.Devices.AddDevice(@"C:\data\Attendance_DB.bak", DeviceType.File);
                    dbRestore.PercentComplete += DbRestore_PercentComplete;
                    dbRestore.Complete += DbRestore_Complete;
                    dbRestore.SqlRestoreAsync(dbServer);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}%";
            });
        }
    }
}
