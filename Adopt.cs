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
    public partial class Adopt : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=database;password=thethreatisreal19");
        public Adopt()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string id = "Select idcat from database.cats where idcat = '" + idanimal.Text + "'; ";
            string idd = "Select id_dog from database.dog where id_dog = '" + idanimal.Text + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(id, con);
            MySqlDataAdapter dad = new MySqlDataAdapter(idd, con);
            DataTable dt = new DataTable();
            DataTable dtd = new DataTable();
            da.Fill(dt);
            dad.Fill(dtd);
            if ((dt.Rows.Count >= 1)||(dtd.Rows.Count>=1))
            {
                con.Open();
                string adopt = "insert into database.adoptions (Full_Name, Email, Phone, ID_animal) values ('" + this.Fullname.Text + "', '" + this.Email.Text + "', '" + this.Phone.Text + "', '" + this.idanimal.Text + "') ;";
                MySqlCommand cmd = new MySqlCommand(adopt, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                MessageBox.Show("Request sent!");
            }
            else
            {
                MessageBox.Show("ID of the animal does not exist");
            }
        }

        private void Fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_kd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Email.Focus();
        }

        private void email_kd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Phone.Focus();
        }

        private void id_kd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send_Click(sender,e);
        }

        private void phone_kd(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                idanimal.Focus();

        }
    }
}
