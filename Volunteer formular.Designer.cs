namespace DbProject
{
    partial class Volunteer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volunteer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOLUNTEER NOW!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone: ";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(199, 178);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(262, 22);
            this.Name.TabIndex = 2;
            this.Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Name_KD);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(199, 216);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(262, 22);
            this.Age.TabIndex = 2;
            this.Age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Birthday_KD);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(199, 254);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(262, 22);
            this.Address.TabIndex = 2;
            this.Address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_KD);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(199, 291);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(262, 22);
            this.Email.TabIndex = 2;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_KD);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(199, 328);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(262, 22);
            this.Phone.TabIndex = 2;
            this.Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Phone_KD);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(2, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "< back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(313, 379);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(71, 33);
            this.Send.TabIndex = 6;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(390, 379);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(71, 33);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 276);
            this.label8.TabIndex = 8;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Volunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label8;
    }
}