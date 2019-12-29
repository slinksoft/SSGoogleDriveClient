namespace GoogleDriveClient
{
    partial class signInInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInInfo));
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAccount = new System.Windows.Forms.Button();
            this.selectAccount = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.launchGD = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.versionDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scanSource = new System.Windows.Forms.Timer(this.components);
            this.updateCheck = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailInput
            // 
            this.emailInput.Enabled = false;
            this.emailInput.Location = new System.Drawing.Point(6, 47);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(141, 20);
            this.emailInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.emailInput, "Your Gmail or Google username");
            this.emailInput.Visible = false;
            // 
            // passwordInput
            // 
            this.passwordInput.Enabled = false;
            this.passwordInput.Location = new System.Drawing.Point(6, 84);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(141, 20);
            this.passwordInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.passwordInput, "Your password associated with the above Gmail or Google username");
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Visible = false;
            // 
            // addAccount
            // 
            this.addAccount.Enabled = false;
            this.addAccount.Location = new System.Drawing.Point(20, 112);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(116, 22);
            this.addAccount.TabIndex = 4;
            this.addAccount.Text = "Add Account";
            this.toolTip1.SetToolTip(this.addAccount, "Adds your account information to use with the client");
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Visible = false;
            this.addAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // selectAccount
            // 
            this.selectAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.Location = new System.Drawing.Point(193, 25);
            this.selectAccount.MaxLength = 5;
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(99, 21);
            this.selectAccount.TabIndex = 5;
            this.toolTip1.SetToolTip(this.selectAccount, "Account you will use for the client");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Account";
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(169, 52);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(148, 22);
            this.deleteAccount.TabIndex = 7;
            this.deleteAccount.Text = "Delete Selected Account";
            this.toolTip1.SetToolTip(this.deleteAccount, "Delete the selected account");
            this.deleteAccount.UseVisualStyleBackColor = true;
            this.deleteAccount.Click += new System.EventHandler(this.DeleteAccount_Click);
            // 
            // launchGD
            // 
            this.launchGD.BackgroundImage = global::GoogleDriveClient.Properties.Resources.Logo_of_Google_Drive;
            this.launchGD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.launchGD.Location = new System.Drawing.Point(217, 85);
            this.launchGD.Name = "launchGD";
            this.launchGD.Size = new System.Drawing.Size(53, 49);
            this.launchGD.TabIndex = 8;
            this.toolTip1.SetToolTip(this.launchGD, "Launch Google Drive!");
            this.launchGD.UseVisualStyleBackColor = true;
            this.launchGD.Click += new System.EventHandler(this.LaunchGD_Click);
            // 
            // versionDisplay
            // 
            this.versionDisplay.AutoSize = true;
            this.versionDisplay.Location = new System.Drawing.Point(3, 153);
            this.versionDisplay.Name = "versionDisplay";
            this.versionDisplay.Size = new System.Drawing.Size(63, 13);
            this.versionDisplay.TabIndex = 9;
            this.versionDisplay.Text = "Version: 0.0";
            this.toolTip1.SetToolTip(this.versionDisplay, "Version");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add Account";
            // 
            // scanSource
            // 
            this.scanSource.Interval = 3000;
            this.scanSource.Tick += new System.EventHandler(this.ScanSource_Tick);
            // 
            // updateCheck
            // 
            this.updateCheck.AutoSize = true;
            this.updateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCheck.Location = new System.Drawing.Point(67, 152);
            this.updateCheck.Name = "updateCheck";
            this.updateCheck.Size = new System.Drawing.Size(16, 13);
            this.updateCheck.TabIndex = 11;
            this.updateCheck.Text = "✓";
            this.toolTip1.SetToolTip(this.updateCheck, "You are on the latest update.");
            this.updateCheck.Visible = false;
            // 
            // credits
            // 
            this.credits.Location = new System.Drawing.Point(263, 144);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(75, 23);
            this.credits.TabIndex = 12;
            this.credits.Text = "About";
            this.toolTip1.SetToolTip(this.credits, "About...");
            this.credits.UseVisualStyleBackColor = true;
            this.credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // signInInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 172);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.updateCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.versionDisplay);
            this.Controls.Add(this.launchGD);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectAccount);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(361, 211);
            this.MinimumSize = new System.Drawing.Size(361, 211);
            this.Name = "signInInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In Info - Slink Soft GD Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.ComboBox selectAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.Button launchGD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label versionDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer scanSource;
        private System.Windows.Forms.Label updateCheck;
        private System.Windows.Forms.Button credits;
    }
}

