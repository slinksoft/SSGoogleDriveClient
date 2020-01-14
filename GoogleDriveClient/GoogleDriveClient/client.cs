using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Example;
using CefSharp.Example.Handlers;

namespace GoogleDriveClient
{
    public partial class client : Form
    {
        private bool initialLoad, userNameInputted, loadCompleted;
        private string accEmail, accPassword;
        private int ver, revis;
        ChromiumWebBrowser browser = new ChromiumWebBrowser();
        public client()
        {
            InitializeComponent();

        }

        public client(string email, string password, int version, int revision)
        {
            InitializeComponent();

            // initialize account info and chromium browser
            ver = version;
            revis = revision;
            accEmail = email;
            accPassword = password;
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(browser_FrameLoadEnd);
            browser.DownloadHandler = new DownloadHandler();
            browser.Load("https://accounts.google.com/ServiceLogin?service=wise&passive=true&continue=http%3A%2F%2Fdrive.google.com%2F%3Futm_source%3Den&utm_medium=button&utm_campaign=web&utm_content=gotodrive&usp=gtd&ltmpl=drive&urp=https%3A%2F%2Fwww.google.com%2F");
        }

        private void InputPassword_Tick(object sender, EventArgs e)
        {
                // inputs password until browser successfully signs in and goes to the user's Drive (implementation may be changed in the future
          
                if (browser.Address != "https://drive.google.com/drive/my-drive" && userNameInputted == true)
                {
                    browser.ExecuteScriptAsync("document.getElementsByClassName('whsOnd zHQkBf')[0].value='" + accPassword + "';");
                    browser.ExecuteScriptAsync("document.getElementById('passwordNext').click();");
                }

                if (browser.Address == "https://drive.google.com/drive/my-drive")
                {
                    inputPassword.Stop();
                    loadCompleted = true;
                this.Invoke((Action)delegate
                {
                    fileMenu.Enabled = true;
                    gmailMenu.Enabled = true;
                    refreshMenu.Enabled = true;
                });
                }
        }

        private void SignoutExit_Click(object sender, EventArgs e)
        {
            // signs out and clears browser cookies
            foreach (Form f in Application.OpenForms)
            {
                if (f is signInInfo)
                {
                    browser.ExecuteScriptAsync("document.getElementsByClassName('gb_B gb_Da gb_g')[0].click();");
                    browser.ExecuteScriptAsync("document.getElementById('gb_71').click();");
                    browser.GetCookieManager().DeleteCookies();
                    browser.Reload();
                    f.Show();
                }
            }
            this.Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Slink Soft's Simple Google Drive Client\n\nDeveloper: Slink, CefSharp Team\n\nVersion: " + ver + "." + revis + "\n\nVisit: https://realslinksoft.wixsite.com/slink-soft-portfolio" +
                "\nand\n http://www.YouTube.Com/ReTrOSlink \n\nThank you all for the support! And thank you, Google, for offering your amazing and simple-to-use cloud" +
                " service!\n\n\n- §link", "About Slink Soft Google Drive Client");
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            // it detected user closing UI, clear cookies and sign out
            if (loadCompleted == false)
            {
                e.Cancel = true;
                
            }
            else
            {
                browser.GetCookieManager().DeleteCookies();
                browser.Reload();
            }
        }

        private void RefreshNote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Google Drive can tend to freeze or lock up and not respond to your actions. Simply refreshing it will" +
                " fix the issue.", "Note");
        }

        private void RefreshGD_Click(object sender, EventArgs e)
        {
            // refresh browser
            browser.Reload();
        }

        private void GmailHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you wish to send a email via your Gmail account to a colleague with a Google Drive link to a directory or file on your Google Drive, then you " +
                "can open your gmail account with the above option.", "Note");
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is signInInfo)
                {
                    browser.ExecuteScriptAsync("document.getElementsByClassName('gb_B gb_Da gb_g')[0].click();");
                    browser.ExecuteScriptAsync("document.getElementById('gb_71').click();");
                    f.Show();
                }
            }
        }

        private void OpenGmail_Click(object sender, EventArgs e)
        {
            browser.ExecuteScriptAsync("document.getElementsByClassName('gb_B')[0].click();");
            browser.ExecuteScriptAsync("document.getElementById('gb23').click();");
        }

        private void browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            // once google is done loading, input username
            if (loadCompleted == false)
            {
                if (initialLoad == false)
                {
                    initialLoad = true;

                }

                if (initialLoad == true && userNameInputted == false)
                {
                    browser.ExecuteScriptAsync("document.getElementById('identifierId').value='" + accEmail + "';");
                    browser.ExecuteScriptAsync("document.getElementById('identifierNext').click();");
                    userNameInputted = true;
                    // start process to insert password
                    inputPassword.Start();
                }
            }
          }
        }
    
}
