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
    public partial class NGO : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=database;password=thethreatisreal19");
        public NGO()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM database.ong", con))
                {
                    MySqlDataReader reader = cmdd.ExecuteReader();
                    available.Load(reader);
                }
                dataGridView1.DataSource = available;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                string query = "update database.ong set (idong, Name, Country, Contact_Person, Email) idong='" + this.textBox1.Text + "', Name='" + this.textBox2.Text + "', Country='" + this.textBox3.Text + "', Conact_Person='" + this.textBox4.Text + "', Email= '" + this.textBox5.Text + "' where idong='" + this.textBox1.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Updated");
                while (reader.Read())
                { }
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = ""; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the database!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }
        private void name_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Focus();
        }
        private void country_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4.Focus();
        }
        private void contact_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox5.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_row = "delete from database.ong where idong= '" + this.textBox1.Text + "';";
            MySqlCommand cmd = new MySqlCommand(delete_row, con);
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                MessageBox.Show("Deleted");
                while (reader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete");
            }
            textBox1.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
