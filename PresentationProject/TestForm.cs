using PresentationProject.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PresentationProject
{
    public partial class TestForm : Form
    {
        public int currentQ { get; set; }
        public int totalaQ { get; set; }
        public int timeLeft;
        private float increment;
        private Authentication auth = new Authentication();
        private Test test = new Test();
        private Applicant apl;
        public TestForm(Applicant apl)
        {
            InitializeComponent();
            auth.loadFile();
            this.apl =  apl;
            increment = 100f / (test.questions.Count-1);
            timeLeft = test.settings.timer;
        }
        private void finishb_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Test complete!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string key = default;
            foreach (var pair in auth.userDataBase)
            {
                if (pair.Value.password == apl.password)
                {
                    key = pair.Key;
                    break;
                }
            }
            double grade = 0;
            foreach (var question in test.questions)
            {
                if (question.uAnswer == question.rAnswer)
                {
                    grade++;
                }
            }
            grade = (grade / test.settings.nQuestion) * 4 + 1;
            auth.userDataBase[key].completed = true;
            auth.userDataBase[key].grade = grade;
            auth.userDataBase[key].dateTime = DateTime.UtcNow;
            auth.uploadFile();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (option1.Checked == false && option2.Checked == false && option3.Checked == false && option4.Checked == false)
            {
                    MessageBox.Show("One answer should be chosen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            if (test.questions[currentQ].uAnswer == 0)
            {
                totalaQ++;
                completed.Value = Math.Min(completed.Value + (int)Math.Round(increment), 100);
            }
            if (option1.Checked == true) { test.questions[currentQ].uAnswer = 1; }
            else if (option2.Checked == true) { test.questions[currentQ].uAnswer = 2; }
            else if (option3.Checked == true) { test.questions[currentQ].uAnswer = 3; }
            else if (option4.Checked == true) { test.questions[currentQ].uAnswer = 4; }
            if (completed.Value == 100)
            {
                finishb.Enabled = true;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            test.loadSetting();
            test.loadQuestions();
            if (test.settings.shuffleq == true)
            {
                ShuffleList(test.questions);
            }
            for (int i = 0; i < test.settings.nQuestion; i++)
            {
                lQuestion.Items.Add("Question " + (i + 1));
            }
            lQuestion.SelectedIndex = 0;
            timer1.Start();
        }


        static void ShuffleList<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        private void lQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentQ = lQuestion.SelectedIndex;
            option1.Checked = false; option2.Checked = false; option3.Checked = false; option3.Checked = false;
            int ca = test.questions[currentQ].uAnswer;
            switch (ca) 
            {
                case 1: option1.Checked = true; break;
                case 2: option2.Checked = true; break;
                case 3: option3.Checked = true; break;
                case 4: option4.Checked = true; break;
                default: break;
            }
            guna2GroupBox1.Text = "Question " + (currentQ + 1);
            questionlb.Text = test.questions[currentQ].nquestion;
            option1.Text = test.questions[currentQ].option1;
            option2.Text = test.questions[currentQ].option2;
            option3.Text = test.questions[currentQ].option3;
            option4.Text = test.questions[currentQ].option4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                if (timeLeft <= (test.settings.timer * 0.1)) { timerlb.Text = $"<p style = 'font-size: 24px; margin: auto;' > Time left: <span style = 'color: red;'>{timeLeft}</span> </p>"; }
                else { timerlb.Text = $"<p style = 'font-size: 24px; margin: auto;' > Time left: {timeLeft} </p>"; }
            }
            else
            {
                timer1.Stop();
                finishb_Click(this, EventArgs.Empty);
            }
        }
    }
}
