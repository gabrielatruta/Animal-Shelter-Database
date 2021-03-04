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
    public partial class Foster : Form
    {
        public Foster()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Country_Reg_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=adoptionzalau; password=thethreatisreal19");
            con.Open();
            string savetab = "insert into adoptionzalau.foster_req (Name, Surname, Address, Email, Phone) values('" + this.txtName.Text + "', '" + this.txtSurname.Text +  "', '" + this.txtCountry.Text + "', '" + this.txtEmail.Text + "', '" + this.txtPhone.Text + "') ;";
            MySqlCommand cmd = new MySqlCommand(savetab, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Request sent!");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Name_KD(object sender, KeyEventArgs e) //asta e casuta pt nume
        {
            if (e.KeyCode == Keys.Enter) //daca esti pe casuta pe nume si dai enter se muta pe urmatoarea casuta (la fel si la restu de mai jos)
                txtSurname.Focus();
        }

        private void Surname_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^
                txtCountry.Focus();
        }

        private void Country_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^
                txtEmail.Focus();
        }

        private void Email_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //la fel ca sus ^^^^^
                txtPhone.Focus();

        }

        private void Phone_KD(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send_Click(sender, e);

        }
    }
}
