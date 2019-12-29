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
using System.Text.RegularExpressions;
using CefSharp;
using CefSharp.WinForms;

namespace GoogleDriveClient
{
    public partial class signInInfo : Form
    {
        private List<string> accInfo = new List<string>(); // List that will handle the list of accounts 
        private int version, revision; // holds version and revision number
        private ChromiumWebBrowser updater = new ChromiumWebBrowser(); // use chromium to scrap slink soft's source
        private string sourceScraped = ""; // to hold scrapped information
        private string completeversionnumber; // holds complete version number for update checking purposes
        public signInInfo()
        {
            InitializeComponent();
            updater.Load("https://realslinksoft.wixsite.com/slink-soft-portfolio/project-releases"); // load Slink Soft
            updater.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(updater_FrameLoadEnd); // Add FrameLoadEnd handler
            this.Controls.Add(updater); // add chromium embedded to the UI
            version = 1;
            revision = 0;
            versionDisplay.Text = "Version: " + version + "." + revision; // update version display to UI
            completeversionnumber = "GDC: " + version + "." + revision;

            /* Check if the directory exists. If a fresh restart of the client, then create the dirextory and accounts file. Otherwise, read the contents of the
            accounts file and update the account list */
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient"))
            {
               
                MessageBox.Show("Welcome to the Slink Soft Google Drive client. To get started, add your account for auto-login.\n" +
                "(IMPORTANT NOTE: Your information is stored LOCALLY onto your machine and THAT IS IT. No information is sent " +
                "to Slink Soft. The only communication between the client and Slink Soft is update checks for the client itself." +
                " If you are still skeptical, please do not use this client. Thank you.)\n\n- §link", "IMPORTANT NOTICE");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient");
                File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss").Close();
            }
            else
            {
                updateAccountList();
            }
            
            // enable all input controls
            foreach (Control c in this.Controls)
            {
                if (c.Name == "emailInput" || c.Name == "passwordInput" || c.Name == "label1" || c.Name == "label2" || c.Name == "addAccount")
                {
                    c.Enabled = true;
                    c.Visible = true;
                }
            }

        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            // if either iputs are blank, let the user know.
            if (emailInput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show("Email or password input is blank!", "Error");
            }
            else
            {
                // create streamwriter object to write to the accounts file
                StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss", true);
                write.WriteLine(emailInput.Text + "|" + passwordInput.Text); // add account info to file with the following format: gmail|password
                write.Close(); // close writer reference instance
                MessageBox.Show("Account Added.", "Account Added Successfully");
                updateAccountList(); // call method to read the accounts file and update the account list
                emailInput.Text = "";
                passwordInput.Text = "";
            }
        }

        private void updateAccountList()
        {
            // create stream reader object
            StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss");
            accInfo.Clear(); // clear list for rebuilding
            
            // read till end of file
            while (read.EndOfStream == false)
            {
                string cLine = read.ReadLine(); // store read line

                if (cLine == "") // if line is blank, skip (possible this can happening when deleting accounts
                { }
                else
                {
                    string email = cLine.Split('|')[0]; // store only email (we don't want the passwords to show to the world
                    accInfo.Add(email);
                }
            }
            read.Close(); // close reader reference instance
            selectAccount.Items.Clear(); // clear combo box for rebuilding
            // add all accounts to combo box that were stored in accInfo list
            for (int i = 0; i < accInfo.Count; i++)
            {
                selectAccount.Items.Add(accInfo[i]);
            }
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            string accountInfo = selectAccount.GetItemText(selectAccount.SelectedItem); // grabs account from account combo box
            string readFile = ""; // initialize hold for read file

            if (accountInfo == "" || accountInfo == null) // calls if no account selected
            {
                MessageBox.Show("Select An Account First!", "Error"); 
            }

            else
            {
                StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss"); // reads account file

                while (read.EndOfStream == false) // until end of file
                {
                    readFile += read.ReadLine() + "\n"; // add lines of data to readFile
                }
                read.Close(); 
                string currLine = "";
                StringReader scanStringFile = new StringReader(readFile);
                while ((currLine = scanStringFile.ReadLine()) != null) // scan account data to find selected account
                {
                    if (currLine.Contains(accountInfo))
                    {
                        break;
                    }
                }

                readFile = readFile.Replace(currLine, "");
                readFile = Regex.Replace(readFile, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd(new char[] { '\r', '\n' }).TrimStart(new char[] { '\r', '\n' }).Trim(new char[] { '\r', '\n' }); // deletes account data found
                StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss"); // write new data back
                write.WriteLine(readFile);
                MessageBox.Show("Account Deleted.", "Account Deleted Successfully.");
                write.Close();
                updateAccountList(); // update ui list

            }

        }

        private void LaunchGD_Click(object sender, EventArgs e)
        {
            string accountInfo = selectAccount.GetItemText(selectAccount.SelectedItem); // gets selected account
            if (accountInfo == "" || accountInfo == null)
            {
                MessageBox.Show("Select and/or add an account first!", "Error");
            }
            else
            {
                // read account file
                string readFile = "";

                StreamReader read = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SSGoogleDriveClient/accounts.ss");
                while (read.EndOfStream == false)
                {
                    readFile += read.ReadLine() + "\n";
                }
                read.Close();
                string currLine = "";
                StringReader scanStringFile = new StringReader(readFile);
                while ((currLine = scanStringFile.ReadLine()) != null)
                {
                    if (currLine.Contains(accountInfo))
                    {
                        break;
                    }
                }

                string email = currLine.Split('|')[0]; // get email
                string password = currLine.Split('|')[1]; // get password
                client newClient = new client(email, password, version, revision); // initialize new client reference
                newClient.Show(); // show reference ui
                this.Hide(); // hide account info ui
            }
        }


        private void updater_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            // scans Slink Soft for version
            if (e.Frame.IsMain)
            {
                updater.GetSourceAsync().ContinueWith(taskHtml =>
                {
                    sourceScraped = taskHtml.Result;
                });
                scanSource.Start();
            }
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Slink Soft's Simple Google Drive Client\n\nDeveloper: Slink, CefSharp Team\n\nVersion: " + version + "." + revision + "\n\nVisit: https://realslinksoft.wixsite.com/slink-soft-portfolio" +
                "\nand\n http://www.YouTube.Com/ReTrOSlink \n\nThank you all for the support! And thank you, Google, for offering your amazing and simple-to-use cloud" +
                " service!\n\n\n- §link", "About Slink Soft Google Drive Client");
        }

        private void ScanSource_Tick(object sender, EventArgs e)
        {
            // if found version matching current client version, disposes browser reference
            if (sourceScraped.Contains(completeversionnumber))
            {
                this.Invoke((Action)delegate
                {
                    updateCheck.Visible = true;
                    updater.Dispose();
                });
            }
            // detects a blank page; could be a connection error or no Internet connection on the advice
            else if (sourceScraped == "<html><head></head><body></body></html>") // cefsharp chromium processes a blank webpage with the basic tags: html,head, and body with no content within them.
            {
                this.Invoke((Action)delegate
                {
                    MessageBox.Show("Error: Failed to fetch version from Slink Soft! Either you have no Internet connection or the website (Wix servers) are down! Please try again later.", "ERROR!");
                    updater.Dispose();
                });
            }

            // if the current cliesnt version is not found on Slink Soft, prompts user to update
            else
            {
                this.Invoke((Action)delegate
                {
                    MessageBox.Show("There is an update for Slink Soft's Google Drive Client! Go to https://realslinksoft.wixsite.com/slink-soft-portfolio/project-releases and download it. " +
                        "Please note that you will not have to take any action with the file containing your account(s) information (it will be compatiable" +
                        " in the update).", "Update Available!");
                    updater.Dispose();
                });
            }

            scanSource.Dispose();
        }

    }
}
