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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Volunteer().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ONG().Show();
        }

        private void Animals_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Animals().Show();
        }

        private void Available_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Available().Show();
        }

        private void Foster_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Foster().Show();
        }

        private void Donate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Donate().Show();
        }
    }
}
