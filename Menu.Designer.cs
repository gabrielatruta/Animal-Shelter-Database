namespace DbProject
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label_menu = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.Animals = new System.Windows.Forms.Button();
            this.Available = new System.Windows.Forms.Button();
            this.ADOPT = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.Volunteer = new System.Windows.Forms.Button();
            this.ONG = new System.Windows.Forms.Button();
            this.Foster = new System.Windows.Forms.Button();
            this.Donate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.BackColor = System.Drawing.Color.Transparent;
            this.label_menu.Font = new System.Drawing.Font("Showcard Gothic", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(263, 9);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(437, 92);
            this.label_menu.TabIndex = 1;
            this.label_menu.Text = "MAIN MENU";
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.LinkColor = System.Drawing.Color.Magenta;
            this.Logout.Location = new System.Drawing.Point(902, 9);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(52, 17);
            this.Logout.TabIndex = 2;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // Animals
            // 
            this.Animals.Location = new System.Drawing.Point(279, 221);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(118, 42);
            this.Animals.TabIndex = 3;
            this.Animals.Text = "Animals";
            this.Animals.UseVisualStyleBackColor = true;
            this.Animals.Click += new System.EventHandler(this.Animals_Click);
            // 
            // Available
            // 
            this.Available.Location = new System.Drawing.Point(279, 282);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(118, 42);
            this.Available.TabIndex = 3;
            this.Available.Text = "Available";
            this.Available.UseVisualStyleBackColor = true;
            this.Available.Click += new System.EventHandler(this.Available_Click);
            // 
            // ADOPT
            // 
            this.ADOPT.AutoSize = true;
            this.ADOPT.BackColor = System.Drawing.Color.Transparent;
            this.ADOPT.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADOPT.Location = new System.Drawing.Point(272, 163);
            this.ADOPT.Name = "ADOPT";
            this.ADOPT.Size = new System.Drawing.Size(109, 40);
            this.ADOPT.TabIndex = 4;
            this.ADOPT.Text = "ADOPT";
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.Font = new System.Drawing.Font("Sitka Subheading", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(490, 163);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(89, 40);
            this.Help.TabIndex = 7;
            this.Help.Text = "HELP";
            this.Help.Click += new System.EventHandler(this.label1_Click);
            // 
            // Volunteer
            // 
            this.Volunteer.Location = new System.Drawing.Point(497, 282);
            this.Volunteer.Name = "Volunteer";
            this.Volunteer.Size = new System.Drawing.Size(118, 42);
            this.Volunteer.TabIndex = 5;
            this.Volunteer.Text = "Volunteer";
            this.Volunteer.UseVisualStyleBackColor = true;
            this.Volunteer.Click += new System.EventHandler(this.button1_Click);
            // 
            // ONG
            // 
            this.ONG.Location = new System.Drawing.Point(497, 221);
            this.ONG.Name = "ONG";
            this.ONG.Size = new System.Drawing.Size(118, 42);
            this.ONG.TabIndex = 6;
            this.ONG.Text = "NGO";
            this.ONG.UseVisualStyleBackColor = true;
            this.ONG.Click += new System.EventHandler(this.button2_Click);
            // 
            // Foster
            // 
            this.Foster.Location = new System.Drawing.Point(497, 342);
            this.Foster.Name = "Foster";
            this.Foster.Size = new System.Drawing.Size(118, 42);
            this.Foster.TabIndex = 5;
            this.Foster.Text = "Foster";
            this.Foster.UseVisualStyleBackColor = true;
            this.Foster.Click += new System.EventHandler(this.Foster_Click);
            // 
            // Donate
            // 
            this.Donate.Location = new System.Drawing.Point(497, 403);
            this.Donate.Name = "Donate";
            this.Donate.Size = new System.Drawing.Size(118, 42);
            this.Donate.TabIndex = 5;
            this.Donate.Text = "Donate";
            this.Donate.UseVisualStyleBackColor = true;
            this.Donate.Click += new System.EventHandler(this.Donate_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 520);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Donate);
            this.Controls.Add(this.Foster);
            this.Controls.Add(this.Volunteer);
            this.Controls.Add(this.ONG);
            this.Controls.Add(this.ADOPT);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label_menu);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Button Animals;
        private System.Windows.Forms.Button Available;
        private System.Windows.Forms.Label ADOPT;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Button Volunteer;
        private System.Windows.Forms.Button ONG;
        private System.Windows.Forms.Button Foster;
        private System.Windows.Forms.Button Donate;
    }
}