using PresentationProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationProject
{
    public partial class Form1 : Form
    {
        private Authentication auth;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            auth = new Authentication();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginb_Click(object sender, EventArgs e)
        {
            
            string username = usernametb.Text;
            string password = passwordtb.Text;
            if (string.IsNullOrWhiteSpace(usernametb.Text) && string.IsNullOrWhiteSpace(passwordtb.Text))
            {
                MessageBox.Show("Username and Password cannot be empty!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(usernametb.Text))
            {
                MessageBox.Show("Username cannot be empty!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(passwordtb.Text))
            {
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "admin" && auth.verifyUser(username, password))
            {
                Admin Adminform = new Admin(auth.getApplicant(username));
                this.Hide();
                Adminform.Show();
                Adminform.FormClosed += (s, args) => this.Show();
            }
            else if (auth.verifyUser(username, password))
            {
                ApplicantMain applicantform = new ApplicantMain(auth.getApplicant(username));
                this.Hide();
                applicantform.Show();
                applicantform.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Wrong login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerb_Click(object sender, EventArgs e)
        {
            Registration childForm = new Registration(auth);
            childForm.ShowDialog();
        }
    }
}
