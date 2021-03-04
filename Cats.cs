using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DbProject
{
    public partial class Cats : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost;user id=root;database=database;password=thethreatisreal19");
        public Cats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Animals().Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                DataTable cats = new DataTable();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.cats", sqlcon))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cats.Load(reader);
                }
                dataGridView1.DataSource = cats;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void Adopt_Click(object sender, EventArgs e)
        {
            new Adopt().Show();
        }
    }
}
