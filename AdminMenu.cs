using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ADOPT_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void ONG_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NGO().Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsersDB().Show();
        }

        private void Animalsdb_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AnimalsDB().Show();
        }

        private void Foserdb_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FosterDB().Show();
        }

        private void Volunteersdb_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VolunteerDB().Show();
        }

        private void Donors_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DonorsDB().Show();
        }

        private void Animals_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AnimalsReq().Show();
        }

        private void Available_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdoptionReq().Show();
        }

        private void Volunteer_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VolunteerReq().Show();
        }

        private void Foster_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FosterReq().Show();
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ContactReq().Show();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
