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
    public partial class Volunteer : Form
    {
       
        public Volunteer()
        {
            InitializeComponent();
        }

        private void Name_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Age.Focus();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Birthday_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Address.Focus();
        }

        private void Address_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Email.Focus();
        }

        private void Email_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Phone.Focus();
        }

        private void Phone_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send_Click(sender, e);
        }

        private void Send_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau; password=thethreatisreal19");
            string email = "Select Email from adoptionzalau.vol_req where Email = '" + Email.Text + "'; ";
            MySqlDataAdapter da = new MySqlDataAdapter(email, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Email address already used!");
            }
            else
            {
                con.Open();
                string request = "insert into adoptionzalau.vol_req (Name, Age, Address, Email, Phone) values ('" + Name.Text + "', '" + Age.Text + "', '" + Address.Text + "', '" + Email.Text + "', '" + Phone.Text + "') ;";
                MySqlCommand cmd = new MySqlCommand(request, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Request sent!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
    }
}

