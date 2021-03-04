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
    public partial class Donate : Form
    {
        public Donate()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau; password=thethreatisreal19");
            string card = Birthday.Text;
            int length = card.Length;
            if (length == 19)
            {
                con.Open();
                string savetab = "insert into adoptionzalau.donations (Name, Surname, Card_number, Expiration_date, CVV, Sum) values('" + this.txtName.Text + "', '" + this.txtSurname.Text + "', '" + this.Birthday.Text + "', '" + this.txtCountry.Text + "', '" + this.txtEmail.Text + "', '" + this.Sum.Text + "') ;"; //aici inserez in tabel datele din register
                MySqlCommand cmd = new MySqlCommand(savetab, con); //iti creezi o comanda
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Donation made!");
            }
            else MessageBox.Show("Invalid card number!");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Name_KeyDown(object sender, KeyEventArgs e) //asta e casuta pt nume
        {
            if (e.KeyCode == Keys.Enter) //daca esti pe casuta pe nume si dai enter se muta pe urmatoarea casuta (la fel si la restu de mai jos)
                txtSurname.Focus();
        }

        private void Surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^
                Birthday.Focus();
        }

        private void Birthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^
                txtCountry.Focus();
        }
        private void Country_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^^^
                txtEmail.Focus();
        }

        private void Email_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^^^^
                Sum.Focus();
        }
        private void Sum_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                button1_Click(sender, e);
        }

       
    }
}
