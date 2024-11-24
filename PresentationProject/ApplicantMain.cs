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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationProject
{
    public partial class ApplicantMain : Form
    {
        private Applicant apl;
        public ApplicantMain(Applicant apl)
        {
            InitializeComponent();
            this.apl = apl;
        }

        private void ApplicantMain_Load(object sender, EventArgs e)
        {
            string greetingtext = "<p style=\"font-size: 16px\";>\r\n&#128075 Welcome, <strong>" + apl.GetFirstName() +"</strong>!\r\n</p>\r\n\r\n";
            greeting.Text = greetingtext;
            if (apl.completed == true) { startt.Enabled = false; }
        }

        private void startt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("When you press OK the test will begin. Do you confirm?", "Test", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                TestForm testform = new TestForm(apl);
                this.Hide();
                testform.Show();
                testform.FormClosed += (s, args) => this.Show();
                startt.Enabled = false;
            }
        }
    }
}
