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
    public partial class UsersDB : Form
    {
        public UsersDB()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau;password=thethreatisreal19");
            try
            {
                con.Open();
                DataTable available = new DataTable();
                using (MySqlCommand cmdd = new MySqlCommand("SELECT * FROM adoptionzalau.users", con))
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

        private void button1_Click(object sender, EventArgs e)
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
        private void textBox7_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox8.Focus();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau;password=thethreatisreal19");
            try
            {
                con.Open();
                string query = "update adoptionzalau.users set Username='" + this.textBox1.Text + "', Password='" + this.textBox2.Text + "', Name='" + this.textBox3.Text + "', Surname='" + this.textBox4.Text + "', Birthday= '" + this.textBox5.Text + "', Country= '" + this.textBox6.Text + "', Email='" + this.textBox7.Text + "', Phone='" + this.textBox8.Text + "'  where Username='" + this.textBox1.Text + "';";
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
                textBox7.Text = "";
                textBox8.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the database!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau;password=thethreatisreal19");
            con.Open();
            string delete_row = "delete from adoptionzalau.users where Username= '" + this.textBox1.Text + "';";
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string username = "Select Username from adoptionzalau.users where Username = '" + this.textBox1.Text + "'; ";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau;password=thethreatisreal19");
            MySqlDataAdapter da = new MySqlDataAdapter(username, con); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Username already used");
            }
            else //daca usernameu nu-i folosit deja le salvez in tabel
            {
                con.Open(); //cum ti-ai numit sursa databaseului chiar la inceput
                string savetab = "insert into adoptionzalau.users ( Username, Password, Name, Surname, Birthday, Country, Email, Phone) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "', '" + this.textBox4.Text + "', '" + this.textBox5.Text + "', '" + this.textBox6.Text + "', '" + this.textBox7.Text + "', '" + this.textBox8.Text + "') ;"; //aici inserez in tabel datele din register
                MySqlCommand cmd = new MySqlCommand(savetab, con); //iti creezi o comanda
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully added!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void UsersDB_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
