using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleDriveClient
{
    public partial class disclaimer : Form
    {
        public disclaimer()
        {
            InitializeComponent();
        }

        private void AButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The client will automatically check for updates at SlinkSoft on every startup. Updates for the client are necessary due to" +
                " changes in code on Google's side. We highly suggest updating when an update is available to maintain 100% functionality of the client."
                , "Regarding Updates");
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient");
            File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss").Close();
            Application.Restart();
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
