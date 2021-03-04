namespace DbProject
{
    partial class Foster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foster));
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Country_Reg = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Email_Reg = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Name_Reg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOSTER";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(2, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(83, 34);
            this.back.TabIndex = 8;
            this.back.Text = "< back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 22);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_KD);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(280, 239);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(328, 22);
            this.txtSurname.TabIndex = 16;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Surname_KD);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(281, 331);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(328, 22);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phone_KD);
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
            this.txtCountry.Location = new System.Drawing.Point(281, 267);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(328, 22);
            this.txtCountry.TabIndex = 18;
            this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Country_KD);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(281, 208);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 22);
            this.txtName.TabIndex = 19;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_KD);
            // 
            // Country_Reg
            // 
            this.Country_Reg.AutoSize = true;
            this.Country_Reg.BackColor = System.Drawing.Color.Transparent;
            this.Country_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_Reg.Location = new System.Drawing.Point(187, 272);
            this.Country_Reg.Name = "Country_Reg";
            this.Country_Reg.Size = new System.Drawing.Size(72, 17);
            this.Country_Reg.TabIndex = 9;
            this.Country_Reg.Text = "Address:";
            this.Country_Reg.Click += new System.EventHandler(this.Country_Reg_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(187, 336);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(64, 17);
            this.Phone.TabIndex = 10;
            this.Phone.Text = "Phone: ";
            // 
            // Email_Reg
            // 
            this.Email_Reg.AutoSize = true;
            this.Email_Reg.BackColor = System.Drawing.Color.Transparent;
            this.Email_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Reg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Email_Reg.Location = new System.Drawing.Point(187, 303);
            this.Email_Reg.Name = "Email_Reg";
            this.Email_Reg.Size = new System.Drawing.Size(52, 17);
            this.Email_Reg.TabIndex = 12;
            this.Email_Reg.Text = "Email:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.BackColor = System.Drawing.Color.Transparent;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(186, 244);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(82, 17);
            this.Surname.TabIndex = 13;
            this.Surname.Text = "Surname: ";
            // 
            // Name_Reg
            // 
            this.Name_Reg.AutoSize = true;
            this.Name_Reg.BackColor = System.Drawing.Color.Transparent;
            this.Name_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Reg.Location = new System.Drawing.Point(186, 213);
            this.Name_Reg.Name = "Name_Reg";
            this.Name_Reg.Size = new System.Drawing.Size(59, 17);
            this.Name_Reg.TabIndex = 14;
            this.Name_Reg.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(791, 72);
            this.label2.TabIndex = 20;
            this.label2.Text = "   Foster care means that you shelter the animal until he/she finds his/her forev" +
    "er family :)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(446, 378);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(71, 33);
            this.Send.TabIndex = 21;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(537, 378);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(71, 33);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Foster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Country_Reg);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email_Reg);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name_Reg);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "Foster";
            this.Text = "Foster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Country_Reg;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Email_Reg;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name_Reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cancel;
    }
}