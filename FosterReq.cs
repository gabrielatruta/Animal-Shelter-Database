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
    public partial class FosterReq : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau;password=thethreatisreal19");
        public FosterReq()
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
        private void textBox4_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox5.Focus();
        }
        private void textBox5_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox6.Focus();

        }
        private void textBox6_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox7.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM adoptionzalau.foster_req", con))
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
                string query = "update adoptionzalau.foster_req set Name ='" + this.textBox2.Text + "', Surname='" + this.textBox3.Text + "', Address='" + this.textBox4.Text + "', Email='" + this.textBox5.Text + "', Phone='"+ this.textBox6.Text + "', Status='" +this.textBox7.Text+"' where idfoster_req= '" + this.textBox1.Text + "';";
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
                textBox6.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the database!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_row = "delete from adoptionzalau.foster_req where idfoster_req= '" + this.textBox1.Text + "';";
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