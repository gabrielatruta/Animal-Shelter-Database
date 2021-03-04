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
    public partial class Available : Form
    {
        MySqlConnection sqlcon = new MySqlConnection("server=localhost;user id=root;database=database;password=thethreatisreal19");
        public Available()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM database.animals", sqlcon))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    available.Load(reader);
                }
                dataGridView1.DataSource = available;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void Request_Click(object sender, EventArgs e)
        {
            new Request().Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
    }
}
