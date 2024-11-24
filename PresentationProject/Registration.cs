using PresentationProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationProject
{
    public partial class Registration : Form
    {
        private Authentication auth;
        public Registration(Authentication auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    private void registerb_Click(object sender, EventArgs e)
        {
            string username = usernametb1.Text;
            string password = passwordtb1.Text;
            string fname = fnametb.Text;
            string lname = lnametb.Text;
            string faculty = facultydl.Text;
            if (string.IsNullOrWhiteSpace(usernametb1.Text) || string.IsNullOrWhiteSpace(passwordtb1.Text)
                || string.IsNullOrWhiteSpace(fnametb.Text) || string.IsNullOrWhiteSpace(lnametb.Text) 
                || string.IsNullOrWhiteSpace(facultydl.Text))
            {
                MessageBox.Show("All fileds should be complete!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            auth.registerUser(username, password, fname, lname, faculty);
            MessageBox.Show("Registration complete", "Complete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            this.Close();
        }
    }
}
