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
    public partial class FosterDB : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=database;password=thethreatisreal19");
        public FosterDB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FosterDB_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }

        private void textBox2_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3.Focus();
        }
        private void textBox3_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM database.foster", con))
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
                string query = "update database.foster set idanimal='" + this.textBox1.Text + "', Name='" + this.textBox2.Text + "', Start_date='" + this.textBox3.Text + "', Volunteer='" + this.textBox4.Text + "' where idanimal='" + this.textBox1.Text + "';";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the database!");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string username = "Select idanimal from database.foster where idanimal = '" + this.textBox1.Text + "'; ";
            MySqlDataAdapter da = new MySqlDataAdapter(username, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Id already used");
            }
            else
            {
                con.Open();
                string savetab = "insert into database.foster (idanimal, Name, Start_date, Volunteer) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "') ;";
                MySqlCommand cmd = new MySqlCommand(savetab, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully added!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_row = "delete from database.foster where idanimal= '" + this.textBox1.Text + "';";
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
            con.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }
    }
}
