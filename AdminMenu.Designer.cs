namespace DbProject
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Foster = new System.Windows.Forms.Button();
            this.Volunteer = new System.Windows.Forms.Button();
            this.ONG = new System.Windows.Forms.Button();
            this.ADOPT = new System.Windows.Forms.Label();
            this.Available = new System.Windows.Forms.Button();
            this.Animals = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.label_menu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Button();
            this.Animalsdb = new System.Windows.Forms.Button();
            this.Donors = new System.Windows.Forms.Button();
            this.Foserdb = new System.Windows.Forms.Button();
            this.Volunteersdb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Foster
            // 
            this.Foster.Location = new System.Drawing.Point(453, 353);
            this.Foster.Name = "Foster";
            this.Foster.Size = new System.Drawing.Size(118, 42);
            this.Foster.TabIndex = 14;
            this.Foster.Text = "Fosters";
            this.Foster.UseVisualStyleBackColor = true;
            this.Foster.Click += new System.EventHandler(this.Foster_Click);
            // 
            // Volunteer
            // 
            this.Volunteer.Location = new System.Drawing.Point(453, 295);
            this.Volunteer.Name = "Volunteer";
            this.Volunteer.Size = new System.Drawing.Size(118, 42);
            this.Volunteer.TabIndex = 15;
            this.Volunteer.Text = "Volunteers";
            this.Volunteer.UseVisualStyleBackColor = true;
            this.Volunteer.Click += new System.EventHandler(this.Volunteer_Click);
            // 
            // ONG
            // 
            this.ONG.Location = new System.Drawing.Point(150, 174);
            this.ONG.Name = "ONG";
            this.ONG.Size = new System.Drawing.Size(118, 42);
            this.ONG.TabIndex = 16;
            this.ONG.Text = "NGO";
            this.ONG.UseVisualStyleBackColor = true;
            this.ONG.Click += new System.EventHandler(this.ONG_Click);
            // 
            // ADOPT
            // 
            this.ADOPT.AutoSize = true;
            this.ADOPT.BackColor = System.Drawing.Color.Transparent;
            this.ADOPT.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADOPT.Location = new System.Drawing.Point(446, 116);
            this.ADOPT.Name = "ADOPT";
            this.ADOPT.Size = new System.Drawing.Size(172, 40);
            this.ADOPT.TabIndex = 12;
            this.ADOPT.Text = "REQUESTS:";
            this.ADOPT.Click += new System.EventHandler(this.ADOPT_Click);
            // 
            // Available
            // 
            this.Available.Location = new System.Drawing.Point(453, 235);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(118, 42);
            this.Available.TabIndex = 10;
            this.Available.Text = "Adoptions";
            this.Available.UseVisualStyleBackColor = true;
            this.Available.Click += new System.EventHandler(this.Available_Click);
            // 
            // Animals
            // 
            this.Animals.Location = new System.Drawing.Point(453, 174);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(118, 42);
            this.Animals.TabIndex = 11;
            this.Animals.Text = "Animals";
            this.Animals.UseVisualStyleBackColor = true;
            this.Animals.Click += new System.EventHandler(this.Animals_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.LinkColor = System.Drawing.Color.Magenta;
            this.Logout.Location = new System.Drawing.Point(694, 7);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 17);
            this.Logout.TabIndex = 9;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.BackColor = System.Drawing.Color.Transparent;
            this.label_menu.Font = new System.Drawing.Font("Showcard Gothic", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(189, 7);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(437, 92);
            this.label_menu.TabIndex = 8;
            this.label_menu.Text = "MAIN MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "DATABASES:";
            this.label1.Click += new System.EventHandler(this.Help_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(150, 235);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(118, 42);
            this.Users.TabIndex = 16;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Animalsdb
            // 
            this.Animalsdb.Location = new System.Drawing.Point(150, 295);
            this.Animalsdb.Name = "Animalsdb";
            this.Animalsdb.Size = new System.Drawing.Size(118, 42);
            this.Animalsdb.TabIndex = 16;
            this.Animalsdb.Text = "Animals";
            this.Animalsdb.UseVisualStyleBackColor = true;
            this.Animalsdb.Click += new System.EventHandler(this.Animalsdb_Click);
            // 
            // Donors
            // 
            this.Donors.Location = new System.Drawing.Point(295, 295);
            this.Donors.Name = "Donors";
            this.Donors.Size = new System.Drawing.Size(118, 42);
            this.Donors.TabIndex = 16;
            this.Donors.Text = "Donors";
            this.Donors.UseVisualStyleBackColor = true;
            this.Donors.Click += new System.EventHandler(this.Donors_Click);
            // 
            // Foserdb
            // 
            this.Foserdb.Location = new System.Drawing.Point(295, 174);
            this.Foserdb.Name = "Foserdb";
            this.Foserdb.Size = new System.Drawing.Size(118, 42);
            this.Foserdb.TabIndex = 16;
            this.Foserdb.Text = "Foster";
            this.Foserdb.UseVisualStyleBackColor = true;
            this.Foserdb.Click += new System.EventHandler(this.Foserdb_Click);
            // 
            // Volunteersdb
            // 
            this.Volunteersdb.Location = new System.Drawing.Point(295, 235);
            this.Volunteersdb.Name = "Volunteersdb";
            this.Volunteersdb.Size = new System.Drawing.Size(118, 42);
            this.Volunteersdb.TabIndex = 16;
            this.Volunteersdb.Text = "Volunteers";
            this.Volunteersdb.UseVisualStyleBackColor = true;
            this.Volunteersdb.Click += new System.EventHandler(this.Volunteersdb_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Foster);
            this.Controls.Add(this.Volunteer);
            this.Controls.Add(this.Donors);
            this.Controls.Add(this.Animalsdb);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Volunteersdb);
            this.Controls.Add(this.Foserdb);
            this.Controls.Add(this.ONG);
            this.Controls.Add(this.ADOPT);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label_menu);
            this.Name = "Admin";
            this.Text = "Main Menu (admin)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Foster;
        private System.Windows.Forms.Button Volunteer;
        private System.Windows.Forms.Button ONG;
        private System.Windows.Forms.Label ADOPT;
        private System.Windows.Forms.Button Available;
        private System.Windows.Forms.Button Animals;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Animalsdb;
        private System.Windows.Forms.Button Donors;
        private System.Windows.Forms.Button Foserdb;
        private System.Windows.Forms.Button Volunteersdb;
    }
}