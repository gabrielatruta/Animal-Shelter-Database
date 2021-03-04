namespace DbProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bbtLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassdword = new System.Windows.Forms.TextBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LINK = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bbtLogin
            // 
            this.bbtLogin.Location = new System.Drawing.Point(325, 353);
            this.bbtLogin.Name = "bbtLogin";
            this.bbtLogin.Size = new System.Drawing.Size(94, 33);
            this.bbtLogin.TabIndex = 0;
            this.bbtLogin.Text = "Login";
            this.bbtLogin.UseVisualStyleBackColor = true;
            this.bbtLogin.Click += new System.EventHandler(this.bbtLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(325, 188);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(223, 22);
            this.textUsername.TabIndex = 2;
            this.textUsername.Click += new System.EventHandler(this.textUsername_Click);
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            this.textUsername.Enter += new System.EventHandler(this.textUsername_Enter);
            this.textUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textUsername_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textPassdword
            // 
            this.textPassdword.Location = new System.Drawing.Point(325, 252);
            this.textPassdword.Name = "textPassdword";
            this.textPassdword.Size = new System.Drawing.Size(223, 22);
            this.textPassdword.TabIndex = 2;
            this.textPassdword.Click += new System.EventHandler(this.textPassdword_Click);
            this.textPassdword.TextChanged += new System.EventHandler(this.textPassdword_TextChanged);
            this.textPassdword.Enter += new System.EventHandler(this.textPassdword_Enter);
            this.textPassdword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPaswdword_KeyDown);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(454, 353);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(94, 33);
            this.bttnExit.TabIndex = 0;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 74);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 98);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 44F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(67, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 92);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adoption Zalau";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LINK
            // 
            this.LINK.AutoSize = true;
            this.LINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LINK.Location = new System.Drawing.Point(256, 411);
            this.LINK.Name = "LINK";
            this.LINK.Size = new System.Drawing.Size(339, 17);
            this.LINK.TabIndex = 6;
            this.LINK.TabStop = true;
            this.LINK.Text = "https://www.facebook.com/CainiEcarisajZalau/";
            this.LINK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Don\'t have an account? ";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Register.Location = new System.Drawing.Point(390, 307);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(90, 17);
            this.Register.TabIndex = 8;
            this.Register.TabStop = true;
            this.Register.Text = "Register now";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LINK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textPassdword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bbtLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bbtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassdword;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LINK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Register;
    }
}