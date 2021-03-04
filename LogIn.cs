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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                bbtLogin_Click(sender, e);
            }
        }

        private void bbtLogin_Click(object sender, EventArgs e)
        {
            
            MySqlConnection sqlcon = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau; password=thethreatisreal19"); //sursa unde se afla databaseu cu tabelu unde-i username&password
            string query = "Select Username, Password from users where Username = '" + textUsername.Text.Trim() + "' and Password = '" + textPassdword.Text.Trim() +"';"; //iau Username, Password (coloanele din tabelul users din databaseul de mai sus) si le atribui textboxurile unde scriu username, password
            MySqlDataAdapter sda = new MySqlDataAdapter(query, sqlcon); //restu copiezi cum e
            DataTable dtb1 = new DataTable();
            try
            {
                sda.Fill(dtb1);
                if (dtb1.Rows.Count == 1) //daca usernameu&password sunt corecte
                {
                    string message = "Successfully Logged In"; //mi-am facut fereastra de mesaj doar
                    string title = "Congrats!";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, button);
                    this.Hide();
                    if (textUsername.Text == "admin") //daca m-am logat cu username de admin, imi afiseaza alta fereastra fata de cea pt o persoana normala
                        new Admin().Show();
                    if (textUsername.Text != "admin")
                        new Menu().Show();

                }
                else
                {
                    string message = "Incorrect username or password";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }

       

        private void bttnExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                // Do nothing  
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
          
        }

     

        private void textPassdword_TextChanged(object sender, EventArgs e)
        {
            textPassdword.PasswordChar = '*';
        }

        private void LINK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/CainiEcarisajZalau/");
        }

        private void textUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textPassdword.Focus();
            
        }

        private void textPaswdword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bbtLogin.PerformClick();
        }

        private void textUsername_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
        }

        private void textPassdword_Click(object sender, EventArgs e)
        {
            textPassdword.Clear();
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            textUsername.Clear();
        }

        private void textPassdword_Enter(object sender, EventArgs e)
        {
            textPassdword.Clear();
        }

        private void Register_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Register().Show();
        }
    }
}
