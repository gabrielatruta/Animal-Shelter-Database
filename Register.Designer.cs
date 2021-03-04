namespace DbProject
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Reg = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Birthday_Reg = new System.Windows.Forms.Label();
            this.Country_Reg = new System.Windows.Forms.Label();
            this.Email_Reg = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.btn_register = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 96);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 44F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(217, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRATION";
            // 
            // Name_Reg
            // 
            this.Name_Reg.AutoSize = true;
            this.Name_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Reg.Location = new System.Drawing.Point(297, 199);
            this.Name_Reg.Name = "Name_Reg";
            this.Name_Reg.Size = new System.Drawing.Size(59, 17);
            this.Name_Reg.TabIndex = 3;
            this.Name_Reg.Text = "Name: ";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(297, 230);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(82, 17);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Surname: ";
            // 
            // Birthday_Reg
            // 
            this.Birthday_Reg.AutoSize = true;
            this.Birthday_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday_Reg.Location = new System.Drawing.Point(297, 263);
            this.Birthday_Reg.Name = "Birthday_Reg";
            this.Birthday_Reg.Size = new System.Drawing.Size(78, 17);
            this.Birthday_Reg.TabIndex = 3;
            this.Birthday_Reg.Text = "Birthday: ";
            this.Birthday_Reg.Click += new System.EventHandler(this.Birthday_Reg_Click);
            // 
            // Country_Reg
            // 
            this.Country_Reg.AutoSize = true;
            this.Country_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_Reg.Location = new System.Drawing.Point(297, 298);
            this.Country_Reg.Name = "Country_Reg";
            this.Country_Reg.Size = new System.Drawing.Size(69, 17);
            this.Country_Reg.TabIndex = 3;
            this.Country_Reg.Text = "Country:";
            // 
            // Email_Reg
            // 
            this.Email_Reg.AutoSize = true;
            this.Email_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Reg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Email_Reg.Location = new System.Drawing.Point(297, 329);
            this.Email_Reg.Name = "Email_Reg";
            this.Email_Reg.Size = new System.Drawing.Size(52, 17);
            this.Email_Reg.TabIndex = 3;
            this.Email_Reg.Text = "Email:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(297, 362);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(64, 17);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone: ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(297, 399);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 17);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(392, 194);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 22);
            this.txtName.TabIndex = 4;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_KeyDown);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(391, 225);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(207, 22);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Surname_KeyDown);
            // 
            // txtCountry
            // 
            this.txtCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic (CAR)",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini (formerly Swaziland)",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (formerly Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia (formerly Macedonia)",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates (UAE)",
            "United Kingdom (UK)",
            "United States of America (USA)",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City (Holy See)",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.txtCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCountry.Location = new System.Drawing.Point(391, 293);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(207, 22);
            this.txtCountry.TabIndex = 4;
            this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Country_KD);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(391, 357);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(207, 22);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phone_KD);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(391, 324);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_KD);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(391, 427);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KD);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(391, 394);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 22);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_KD);
            // 
            // Birthday
            // 
            this.Birthday.CustomFormat = "yyyy-MM-dd";
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthday.Location = new System.Drawing.Point(391, 258);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(210, 22);
            this.Birthday.TabIndex = 5;
            this.Birthday.Value = new System.DateTime(2020, 1, 11, 0, 0, 0, 0);
            this.Birthday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.Birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Birthday_KeyDown);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(391, 456);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(210, 32);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 13);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(83, 34);
            this.back.TabIndex = 7;
            this.back.Text = "< back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(969, 500);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Country_Reg);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Birthday_Reg);
            this.Controls.Add(this.Email_Reg);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name_Reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_Reg;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Birthday_Reg;
        private System.Windows.Forms.Label Country_Reg;
        private System.Windows.Forms.Label Email_Reg;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button back;
    }
}