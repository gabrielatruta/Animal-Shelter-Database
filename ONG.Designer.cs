namespace DbProject
{
    partial class ONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ONG));
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(12, 188);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(787, 89);
            this.Description.TabIndex = 0;
            this.Description.Text = "   A NGO is a non-profit organization that operates independently of any governme" +
    "nt, typically one whose purpose is to address a social or political issue.";
            this.Description.UseMnemonic = false;
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "The NGOs we colaborate with:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(696, 254);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 3;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "< back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Name = "ONG";
            this.Text = "ONG";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button back;
    }
}