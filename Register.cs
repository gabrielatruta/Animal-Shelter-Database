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
    public partial class Register : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau; password=thethreatisreal19"); //aici scrii sursa databaseului unde ai tabelele in care o sa bage datele dupa inregistrare; tot de aici o sa verifice daca usernameu e folosit deja
        public Register()                                       
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {
            txtPassword.PasswordChar = '*'; //sa maschezi parola

        }

        private void Birthday_Reg_Click(object sender, EventArgs e)
        {

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //aici am o casuta unde-si seteaza data nasterii si e datetimepicker (din toolbox)
        {

        }

        private void Country_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^^^
                txtEmail.Focus();
        }

        private void Email_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^^^^
                txtPhone.Focus();

        }

        private void Phone_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//la fel ca sus ^^^^^^
                txtUsername.Focus();
        }
        private void Username_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//stii povestea deja
                txtPassword.Focus();

        }
        private void Password_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//aici password mi-e ultima casuta si dupa daca dai enter dai trigger la butonu de register si salvez datele in tabel
                button1_Click(sender, e); //asta e butonu de register
        }

        private void button1_Click(object sender, EventArgs e) //butonu de register
        {
            string username = "Select Username from adoptionzalau.users where Username = '" + txtUsername.Text.Trim() + "'; "; //iau usernameu; adoptionzalau e numele databaseului; users e tabelu din databaseu ala unde gasesc coloana cu username; Username e numele coloanei din tabel care are usernameurile
            MySqlDataAdapter da = new MySqlDataAdapter(username, con); //pe astea le copiezi asa cum sunt
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count>=1)
            {
                MessageBox.Show("Username already used");
            }
            else //daca usernameu nu-i folosit deja le salvez in tabel
            {
                con.Open(); //cum ti-ai numit sursa databaseului chiar la inceput
                string savetab = "insert into adoptionzalau.users ( Username, Password, Name, Surname, Birthday, Country, Email, Phone) values('" + this.txtUsername.Text + "', '" + this.txtPassword.Text + "', '" + this.txtName.Text + "', '" + this.txtSurname.Text + "', '" + this.Birthday.Text + "', '" + this.txtCountry.Text + "', '" + this.txtEmail.Text + "', '" + this.txtPhone.Text + "') ;"; //aici inserez in tabel datele din register
                MySqlCommand cmd = new MySqlCommand(savetab, con); //iti creezi o comanda
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succesfully Registered!");
            }
        }

        private void back_Click(object sender, EventArgs e) //buton de back 
        {
            this.Hide();
           new Login().Show();
        }
    }
}
