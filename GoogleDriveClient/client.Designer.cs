namespace GoogleDriveClient
{
    partial class client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));
            this.inputPassword = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenu = new System.Windows.Forms.MenuItem();
            this.signoutExit = new System.Windows.Forms.MenuItem();
            this.gmailMenu = new System.Windows.Forms.MenuItem();
            this.openGmail = new System.Windows.Forms.MenuItem();
            this.gmailHelp = new System.Windows.Forms.MenuItem();
            this.refreshMenu = new System.Windows.Forms.MenuItem();
            this.refreshGD = new System.Windows.Forms.MenuItem();
            this.refreshNote = new System.Windows.Forms.MenuItem();
            this.aboutButton = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // inputPassword
            // 
            this.inputPassword.Interval = 3000;
            this.inputPassword.Tick += new System.EventHandler(this.InputPassword_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenu,
            this.gmailMenu,
            this.refreshMenu,
            this.aboutButton});
            // 
            // fileMenu
            // 
            this.fileMenu.Enabled = false;
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.signoutExit});
            this.fileMenu.Text = "File";
            // 
            // signoutExit
            // 
            this.signoutExit.Index = 0;
            this.signoutExit.Text = "Sign Out and Exit";
            this.signoutExit.Click += new System.EventHandler(this.SignoutExit_Click);
            // 
            // gmailMenu
            // 
            this.gmailMenu.Enabled = false;
            this.gmailMenu.Index = 1;
            this.gmailMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openGmail,
            this.gmailHelp});
            this.gmailMenu.Text = "Gmail";
            // 
            // openGmail
            // 
            this.openGmail.Index = 0;
            this.openGmail.Text = "Open Gmail";
            this.openGmail.Click += new System.EventHandler(this.OpenGmail_Click);
            // 
            // gmailHelp
            // 
            this.gmailHelp.Index = 1;
            this.gmailHelp.Text = "What does this do?";
            this.gmailHelp.Click += new System.EventHandler(this.GmailHelp_Click);
            // 
            // refreshMenu
            // 
            this.refreshMenu.Enabled = false;
            this.refreshMenu.Index = 2;
            this.refreshMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.refreshGD,
            this.refreshNote});
            this.refreshMenu.Text = "Refresh";
            // 
            // refreshGD
            // 
            this.refreshGD.Index = 0;
            this.refreshGD.Text = "Refresh GD";
            this.refreshGD.Click += new System.EventHandler(this.RefreshGD_Click);
            // 
            // refreshNote
            // 
            this.refreshNote.Index = 1;
            this.refreshNote.Text = "What\'s This?";
            this.refreshNote.Click += new System.EventHandler(this.RefreshNote_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Index = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 622);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slink Soft Google Drive Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer inputPassword;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenu;
        private System.Windows.Forms.MenuItem signoutExit;
        private System.Windows.Forms.MenuItem gmailMenu;
        private System.Windows.Forms.MenuItem openGmail;
        private System.Windows.Forms.MenuItem gmailHelp;
        private System.Windows.Forms.MenuItem aboutButton;
        private System.Windows.Forms.MenuItem refreshMenu;
        private System.Windows.Forms.MenuItem refreshGD;
        private System.Windows.Forms.MenuItem refreshNote;
    }
}