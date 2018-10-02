namespace User_Management
{
    partial class Form1
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
            this.ManagementControls = new MetroFramework.Controls.MetroTabControl();
            this.Applications = new MetroFramework.Controls.MetroTabPage();
            this.Users = new MetroFramework.Controls.MetroTabPage();
            this.Roles = new MetroFramework.Controls.MetroTabPage();
            this.Passwords = new MetroFramework.Controls.MetroTabPage();
            this.CredentialsService = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CreateUser = new MetroFramework.Controls.MetroButton();
            this.DeleteUser = new MetroFramework.Controls.MetroButton();
            this.DeleteAllUsers = new MetroFramework.Controls.MetroButton();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.ManagementControls.SuspendLayout();
            this.Applications.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagementControls
            // 
            this.ManagementControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManagementControls.Controls.Add(this.Applications);
            this.ManagementControls.Controls.Add(this.Users);
            this.ManagementControls.Controls.Add(this.Roles);
            this.ManagementControls.Controls.Add(this.Passwords);
            this.ManagementControls.Controls.Add(this.CredentialsService);
            this.ManagementControls.Location = new System.Drawing.Point(11, 63);
            this.ManagementControls.Name = "ManagementControls";
            this.ManagementControls.SelectedIndex = 0;
            this.ManagementControls.Size = new System.Drawing.Size(833, 495);
            this.ManagementControls.TabIndex = 0;
            this.ManagementControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ManagementControls.UseSelectable = true;
            // 
            // Applications
            // 
            this.Applications.Controls.Add(this.DeleteAllUsers);
            this.Applications.Controls.Add(this.DeleteUser);
            this.Applications.Controls.Add(this.CreateUser);
            this.Applications.Controls.Add(this.metroPanel1);
            this.Applications.HorizontalScrollbarBarColor = true;
            this.Applications.HorizontalScrollbarHighlightOnWheel = false;
            this.Applications.HorizontalScrollbarSize = 10;
            this.Applications.Location = new System.Drawing.Point(4, 38);
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(825, 453);
            this.Applications.TabIndex = 0;
            this.Applications.Text = "Applications";
            this.Applications.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Applications.VerticalScrollbarBarColor = true;
            this.Applications.VerticalScrollbarHighlightOnWheel = false;
            this.Applications.VerticalScrollbarSize = 10;
            // 
            // Users
            // 
            this.Users.HorizontalScrollbarBarColor = true;
            this.Users.HorizontalScrollbarHighlightOnWheel = false;
            this.Users.HorizontalScrollbarSize = 10;
            this.Users.Location = new System.Drawing.Point(4, 38);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(758, 322);
            this.Users.TabIndex = 2;
            this.Users.Text = "Users";
            this.Users.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Users.VerticalScrollbarBarColor = true;
            this.Users.VerticalScrollbarHighlightOnWheel = false;
            this.Users.VerticalScrollbarSize = 10;
            // 
            // Roles
            // 
            this.Roles.HorizontalScrollbarBarColor = true;
            this.Roles.HorizontalScrollbarHighlightOnWheel = false;
            this.Roles.HorizontalScrollbarSize = 10;
            this.Roles.Location = new System.Drawing.Point(4, 38);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(758, 322);
            this.Roles.TabIndex = 3;
            this.Roles.Text = "Roles";
            this.Roles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Roles.VerticalScrollbarBarColor = true;
            this.Roles.VerticalScrollbarHighlightOnWheel = false;
            this.Roles.VerticalScrollbarSize = 10;
            // 
            // Passwords
            // 
            this.Passwords.HorizontalScrollbarBarColor = true;
            this.Passwords.HorizontalScrollbarHighlightOnWheel = false;
            this.Passwords.HorizontalScrollbarSize = 10;
            this.Passwords.Location = new System.Drawing.Point(4, 38);
            this.Passwords.Name = "Passwords";
            this.Passwords.Size = new System.Drawing.Size(758, 322);
            this.Passwords.TabIndex = 4;
            this.Passwords.Text = "Passwords";
            this.Passwords.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Passwords.VerticalScrollbarBarColor = true;
            this.Passwords.VerticalScrollbarHighlightOnWheel = false;
            this.Passwords.VerticalScrollbarSize = 10;
            // 
            // CredentialsService
            // 
            this.CredentialsService.HorizontalScrollbarBarColor = true;
            this.CredentialsService.HorizontalScrollbarHighlightOnWheel = false;
            this.CredentialsService.HorizontalScrollbarSize = 10;
            this.CredentialsService.Location = new System.Drawing.Point(4, 38);
            this.CredentialsService.Name = "CredentialsService";
            this.CredentialsService.Size = new System.Drawing.Size(758, 322);
            this.CredentialsService.TabIndex = 5;
            this.CredentialsService.Text = "Credentials Service";
            this.CredentialsService.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CredentialsService.VerticalScrollbarBarColor = true;
            this.CredentialsService.VerticalScrollbarHighlightOnWheel = false;
            this.CredentialsService.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Black;
            this.metroPanel1.Controls.Add(this.metroListView1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(390, 435);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CreateUser
            // 
            this.CreateUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.CreateUser.Location = new System.Drawing.Point(399, 15);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(75, 23);
            this.CreateUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.CreateUser.TabIndex = 3;
            this.CreateUser.Text = "Create";
            this.CreateUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CreateUser.UseSelectable = true;
            this.CreateUser.UseStyleColors = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DeleteUser.Location = new System.Drawing.Point(399, 44);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeleteUser.TabIndex = 4;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteUser.UseSelectable = true;
            this.DeleteUser.UseStyleColors = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // DeleteAllUsers
            // 
            this.DeleteAllUsers.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.DeleteAllUsers.Location = new System.Drawing.Point(399, 427);
            this.DeleteAllUsers.Name = "DeleteAllUsers";
            this.DeleteAllUsers.Size = new System.Drawing.Size(75, 23);
            this.DeleteAllUsers.Style = MetroFramework.MetroColorStyle.Blue;
            this.DeleteAllUsers.TabIndex = 5;
            this.DeleteAllUsers.Text = "Delete All";
            this.DeleteAllUsers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DeleteAllUsers.UseSelectable = true;
            this.DeleteAllUsers.UseStyleColors = true;
            // 
            // metroListView1
            // 
            this.metroListView1.BackColor = System.Drawing.Color.Black;
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(5, 3);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(382, 429);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(867, 581);
            this.Controls.Add(this.ManagementControls);
            this.Name = "Form1";
            this.Text = "User Management";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ManagementControls.ResumeLayout(false);
            this.Applications.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ManagementControls;
        private MetroFramework.Controls.MetroTabPage Applications;
        private MetroFramework.Controls.MetroTabPage Users;
        private MetroFramework.Controls.MetroTabPage Roles;
        private MetroFramework.Controls.MetroTabPage Passwords;
        private MetroFramework.Controls.MetroTabPage CredentialsService;
        private MetroFramework.Controls.MetroButton DeleteAllUsers;
        private MetroFramework.Controls.MetroButton DeleteUser;
        private MetroFramework.Controls.MetroButton CreateUser;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView metroListView1;
    }
}

