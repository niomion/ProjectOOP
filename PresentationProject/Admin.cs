using Guna.UI2.WinForms;
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
    public partial class Admin : Form
    {
       public Authentication auth;
        public List<Applicant> tmp = new List<Applicant>();
        public int currentQ { get; set; }
        public int currentU { get; set; }
        private Applicant apl;
        private Test test;
        public Admin(Applicant apl)
        {
            InitializeComponent();
            this.apl = apl;
            test = new Test();
            auth = new Authentication();
            foreach (var user in auth.userDataBase)
            {
                if (user.Key == "admin" && user.Value.GetFirstName() == "admin")
                {
                    continue;
                }
                else
                {
                    tmp.Add(user.Value);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    userList.Items.Clear();
                    foreach (var user in tmp)
                    {
                            string tmpname = user.GetFirstName() + " " + user.GetLastName();
                            userList.Items.Add(tmpname);
                    }
                    userResult.Visible = true;
                    mainM.Visible = false;
                    eQuestion.Visible = false;
                    testsett.Visible = false;
                    break;
                case 1:
                    lQuestion.Items.Clear();
                    test.loadQuestions();
                    for (int i = 0; i < test.questions.Count; i++)
                    {
                        lQuestion.Items.Add("Question " + (i+1));
                    }
                    eQuestion.Visible = true;
                    userResult.Visible = false;
                    mainM.Visible = false;
                    testsett.Visible = false;
                    break;
                case 2:
                    test.loadSetting();
                    numberq.Text = (test.settings.nQuestion).ToString();
                    valuet.Text = (test.settings.timer).ToString();
                    shuffleq.Checked = test.settings.shuffleq;

                    testsett.Visible = true;
                    eQuestion.Visible = false;
                    userResult.Visible = false;
                    mainM.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            infou.Visible = true;
            testu.Visible = true;
            currentU = userList.SelectedIndex;
            fName.Text = tmp[currentU].GetFirstName();
            lName.Text = tmp[currentU].GetLastName();
            faculty.Text = tmp[currentU].faculty;
            if (tmp[currentU].completed == true )
            {
                passt.Text = "Passed: Yes";
                passdat.Text = "Passed at: " + (tmp[currentU].dateTime).ToString();
                if (tmp[currentU].grade >= 4.5)
                {
                    markhtm.Text = $"Mark: <span style=\"color: lime;\">A</span> ({Math.Round(tmp[currentU].grade, 1)})";
                }
                if (tmp[currentU].grade >= 3.5)
                {
                    markhtm.Text = $"Mark: <span style=\"color: blue;\">B</span> ({Math.Round(tmp[currentU].grade, 1)})";
                }
                if (tmp[currentU].grade >= 3)
                {
                    markhtm.Text = $"Mark: <span style=\"color: #FFDF00;\">C</span> ({Math.Round(tmp[currentU].grade,1)})";
                }
                if (tmp[currentU].grade <= 3)
                {
                    markhtm.Text = $"Mark: <span style=\"color: red;\">D</span> ({Math.Round(tmp[currentU].grade, 1)})";
                }
                passdat.Visible = true;
                markhtm.Visible = true;
            } else
            {
                passt.Text = "Passed: No";
            }
        }

            private void lQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentQ = lQuestion.SelectedIndex;
            guna2GroupBox1.Text = "Question " + (currentQ+1);
            questionlb.Text = test.questions[currentQ].nquestion;
            optiontb1.Text = test.questions[currentQ].option1;
            optionlb2.Text = test.questions[currentQ].option2;
            optionlb3.Text = test.questions[currentQ].option3;
            optionlb4.Text = test.questions[currentQ].option4;
            guna2GroupBox1.Visible = true;
            if (test.questions[currentQ].rAnswer != 0)
            {
                switch (test.questions[currentQ].rAnswer)
                {
                    case 1:
                        option1.Checked = true;
                        break;
                    case 2:
                        option2.Checked = true;
                        break;
                    case 3:
                        option3.Checked = true;
                        break;
                    case 4:
                        option4.Checked = true;
                        break;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (option1.Checked) { test.questions[currentQ].rAnswer = 1; }
            else if (option2.Checked) { test.questions[currentQ].rAnswer = 2; }
            else if (option3.Checked) { test.questions[currentQ].rAnswer = 3; }
            else if (option4.Checked) { test.questions[currentQ].rAnswer = 4; }
            else { MessageBox.Show("One option must be checked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            if (string.IsNullOrEmpty(questionlb.Text) ||
                string.IsNullOrEmpty(optiontb1.Text) ||
                string.IsNullOrEmpty(optionlb2.Text) ||
                string.IsNullOrEmpty(optionlb3.Text) ||
                string.IsNullOrEmpty(optionlb4.Text))
            {
                MessageBox.Show("Please enter all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                test.questions[currentQ].nquestion = questionlb.Text;
                test.questions[currentQ].option1 = optiontb1.Text;
                test.questions[currentQ].option2 = optionlb2.Text;
                test.questions[currentQ].option3 = optionlb3.Text;
                test.questions[currentQ].option4 = optionlb4.Text;
            }

            test.uploadQuestion();
            test.loadQuestions();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            test.addQuestion("Question", "Option", "Option", "Option", "Option", 1);
            lQuestion.Items.Clear();
            test.uploadQuestion();
            test.loadQuestions();
            for (int i = 0; i < test.questions.Count; i++)
            {
                lQuestion.Items.Add("Question " + (i + 1));
            }
            lQuestion.SelectedIndex = test.questions.Count-1;
            currentQ = lQuestion.SelectedIndex;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (test.questions.Count == 1)
            {
                MessageBox.Show("One question minimum", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            test.questions.RemoveAt(currentQ);
            test.uploadQuestion();
            test.loadQuestions();

            lQuestion.Items.Clear();
            for (int i = 0; i < test.questions.Count; i++)
            {
                lQuestion.Items.Add("Question " + (i + 1));
            }

            lQuestion.SelectedIndex = test.questions.Count - 1;
            currentQ = lQuestion.SelectedIndex;
            guna2GroupBox1.Text = "Question " + (test.questions.Count);
            questionlb.Text = test.questions[currentQ].nquestion;
            optiontb1.Text = test.questions[currentQ].option1;
            optionlb2.Text = test.questions[currentQ].option2;
            optionlb3.Text = test.questions[currentQ].option3;
            optionlb4.Text = test.questions[currentQ].option4;

            if (test.questions[currentQ].rAnswer != 0)
            {
                switch (test.questions[currentQ].rAnswer)
                {
                    case 1:
                        option1.Checked = true;
                        break;
                    case 2:
                        option2.Checked = true;
                        break;
                    case 3:
                        option3.Checked = true;
                        break;
                    case 4:
                        option4.Checked = true;
                        break;
                }
            }
        }

        private void savesett_Click(object sender, EventArgs e)
        {
            if (int.TryParse(valuet.Text, out int number)) {
                test.settings.timer = number;
            }

            if (int.TryParse(numberq.Text, out int number2))
            {
                if (number2 > test.questions.Count)
                {
                    MessageBox.Show("Number of questions is lower than value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    test.settings.nQuestion = number2;
                }
            }
            test.settings.shuffleq = shuffleq.Checked;
            test.uploadSetting();
        }
    }
}
