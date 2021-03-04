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
    public partial class Request : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau; password=thethreatisreal19");
        public Request()
        {
            InitializeComponent();
        }

        private void Request_Load(object sender, EventArgs e)
        {

        }

        private void textRequest_TextChanged(object sender, EventArgs e)
        {

        }

        private void Request_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textUsername.Focus();
        }

        private void Username_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBody.Focus();
        }


        private void Send_Click(object sender, EventArgs e)
        {

            string username = "Select Username from adoptionzalau.users where Username = '" + textUsername.Text + "'; "; 
            MySqlDataAdapter da = new MySqlDataAdapter(username, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.Open();
                string request = "insert into adoptionzalau.requests (Request, Username, Text) values ('" + this.textRequest.Text + "', '" + this.textUsername.Text + "', '" + this.textBody.Text + "') ;";
                MySqlCommand cmd = new MySqlCommand(request, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                MessageBox.Show("Request sent!");
            }
            else 
            {
                MessageBox.Show("Username does not exist");
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
