namespace DbProject
{
    partial class Request
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
            this.Req = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Label();
            this.textRequest = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textBody = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Req
            // 
            this.Req.AutoSize = true;
            this.Req.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Req.Location = new System.Drawing.Point(29, 19);
            this.Req.Name = "Req";
            this.Req.Size = new System.Drawing.Size(78, 17);
            this.Req.TabIndex = 0;
            this.Req.Text = "Request: ";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(29, 53);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(86, 17);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.Location = new System.Drawing.Point(29, 86);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(63, 17);
            this.Details.TabIndex = 0;
            this.Details.Text = "Details:";
            // 
            // textRequest
            // 
            this.textRequest.Location = new System.Drawing.Point(145, 14);
            this.textRequest.Name = "textRequest";
            this.textRequest.Size = new System.Drawing.Size(183, 22);
            this.textRequest.TabIndex = 1;
            this.textRequest.TextChanged += new System.EventHandler(this.textRequest_TextChanged);
            this.textRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Request_KD);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(145, 48);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(183, 22);
            this.textUsername.TabIndex = 1;
            this.textUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_KD);
            // 
            // textBody
            // 
            this.textBody.Location = new System.Drawing.Point(32, 119);
            this.textBody.Multiline = true;
            this.textBody.Name = "textBody";
            this.textBody.Size = new System.Drawing.Size(296, 91);
            this.textBody.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(257, 226);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(71, 33);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(166, 226);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(71, 33);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.textBody);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textRequest);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Req);
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Req;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.TextBox textRequest;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textBody;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Send;
    }
}