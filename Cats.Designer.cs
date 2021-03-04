namespace DbProject
{
    partial class Cats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cats));
            this.button1 = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Adopt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "< back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(97, 195);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(101, 40);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 44F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 92);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATS";
            // 
            // Adopt
            // 
            this.Adopt.Location = new System.Drawing.Point(231, 195);
            this.Adopt.Name = "Adopt";
            this.Adopt.Size = new System.Drawing.Size(101, 40);
            this.Adopt.TabIndex = 1;
            this.Adopt.Text = "Adopt";
            this.Adopt.UseVisualStyleBackColor = true;
            this.Adopt.Click += new System.EventHandler(this.Adopt_Click);
            // 
            // Cats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Adopt);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.button1);
            this.Name = "Cats";
            this.Text = "Cats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adopt;
    }
}