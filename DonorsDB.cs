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
    public partial class DonorsDB : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=database;password=thethreatisreal19");
        public DonorsDB()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
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
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM database.donors", con))
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
                string query = "update database.donors set iddonor='" + this.textBox1.Text + "', Name='" + this.textBox2.Text + "', Country='" + this.textBox3.Text + "', Email='" + this.textBox4.Text + "' where iddonor= '" +this.textBox1.Text+"';";
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
            string username = "Select iddonor from database.donors where iddonor = '" + this.textBox1.Text + "'; ";
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
                string savetab = "insert into database.donors (iddonor, Name, Country, Email) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text +  "') ;";
                MySqlCommand cmd = new MySqlCommand(savetab, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully added!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_row = "delete from database.donors where iddonor= '" + this.textBox1.Text + "';";
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
    }
}
