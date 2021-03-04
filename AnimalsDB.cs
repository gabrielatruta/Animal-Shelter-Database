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
    public partial class AnimalsDB : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=database;password=thethreatisreal19");
        public AnimalsDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM database.dog", con))
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM database.cats", con))
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update database.dog set id_dog='" + this.textBox1.Text + "', Name='" + this.textBox2.Text + "', Gender='" + this.textBox3.Text + "', Age='" + this.textBox4.Text + "', Breed= '" + this.textBox6.Text + "', Size= '" + this.textBox7.Text + "' where id_dog='" + this.textBox1.Text + "';";
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
                textBox6.Text = "";
                textBox7.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the database!");
            }
           
        }

        private void UpdateC_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update database.cats set idcat='" + this.textBox1.Text + "', Name='" + this.textBox2.Text + "', Gender='" + this.textBox3.Text + "', Age='" + this.textBox4.Text + "', Colour= '" + this.textBox5.Text + " 'where idcat='" + this.textBox1.Text + "';";
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

        private void Add_Click(object sender, EventArgs e)
        {
            string username = "Select id_dog from database.dog where id_dog = '" + this.textBox1.Text + "'; ";  
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
                string savetab = "insert into database.dog (id_dog, Name, Gender, Age, Breed, Size) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox6.Text + "', '" + this.textBox7.Text + "') ;"; 
                MySqlCommand cmd = new MySqlCommand(savetab, con); 
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully added!");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = "Select idcat from database.cats where idcat = '" + this.textBox1.Text + "'; ";
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
                string savetab = "insert into database.cats (idcat, Name, Gender, Age, Colour) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "') ;";
                MySqlCommand cmd = new MySqlCommand(savetab, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully added!");
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_row = "delete from database.dog where id_dog= '" + this.textBox1.Text + "';";
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

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string delete_row = "delete from database.cats where idcat= '" + this.textBox1.Text + "';";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
    
}
