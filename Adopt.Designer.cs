namespace DbProject
{
    partial class Adopt
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
            this.name = new System.Windows.Forms.Label();
            this.ID_Animal = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.TextBox();
            this.idanimal = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(59, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Full Name: ";
            // 
            // ID_Animal
            // 
            this.ID_Animal.AutoSize = true;
            this.ID_Animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Animal.Location = new System.Drawing.Point(59, 119);
            this.ID_Animal.Name = "ID_Animal";
            this.ID_Animal.Size = new System.Drawing.Size(85, 17);
            this.ID_Animal.TabIndex = 1;
            this.ID_Animal.Text = "ID_Animal:";
            // 
            // Fullname
            // 
            this.Fullname.Location = new System.Drawing.Point(155, 31);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(185, 22);
            this.Fullname.TabIndex = 2;
            this.Fullname.TextChanged += new System.EventHandler(this.Fullname_TextChanged);
            this.Fullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_kd);
            // 
            // idanimal
            // 
            this.idanimal.Location = new System.Drawing.Point(155, 114);
            this.idanimal.Name = "idanimal";
            this.idanimal.Size = new System.Drawing.Size(185, 22);
            this.idanimal.TabIndex = 2;
            this.idanimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_kd);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(174, 165);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(265, 165);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(155, 59);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(185, 22);
            this.Email.TabIndex = 2;
            this.Email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_kd);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone:";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(155, 86);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(185, 22);
            this.Phone.TabIndex = 2;
            this.Phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_kd);
            // 
            // Adopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 200);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idanimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.ID_Animal);
            this.Controls.Add(this.name);
            this.Name = "Adopt";
            this.Text = "Adopt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ID_Animal;
        private System.Windows.Forms.TextBox Fullname;
        private System.Windows.Forms.TextBox idanimal;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phone;
    }
}