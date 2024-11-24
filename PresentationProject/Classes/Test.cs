using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PresentationProject
{
    internal class Test
    {
        public List<Question> questions = new List<Question>();
        public Test() {
            loadQuestions();
            
        }
        [Serializable]
        public class Settings
        {
            public int nQuestion = 1;
            public int timer = 360;
            public bool shuffleq = false;
        }

        public Settings settings = new Settings();

        public void loadSetting()
        {
            BinaryFormatter formatter3 = new BinaryFormatter();
            try
            {
                if (File.Exists("Settings.dat"))
                {
                    using (FileStream stream2 = new FileStream("Settings.dat", FileMode.Open))
                    {
                        settings = (Settings)formatter3.Deserialize(stream2);
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not Found");
                }
            }
            catch (FileNotFoundException)
            {
                BinaryFormatter tmp = new BinaryFormatter();
                using (FileStream stream2 = new FileStream("Settings.dat", FileMode.Create))
                {
                    tmp.Serialize(stream2, settings);
                }
                loadSetting();
            }
        }

        public void uploadSetting()
        {
            BinaryFormatter formatter13 = new BinaryFormatter();
            using (FileStream stream2 = new FileStream("Settings.dat", FileMode.Create))
            {
                formatter13.Serialize(stream2, settings);
            }
        }

        public void uploadQuestion()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("QuestionsDataBase.dat", FileMode.Create))
            {
                formatter.Serialize(stream, questions);
            }
        }

        public List<Question> loadQuestions()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                if (File.Exists("QuestionsDataBase.dat"))
                {
                    using (FileStream stream = new FileStream("QuestionsDataBase.dat", FileMode.Open))
                    {
                        questions = (List<Question>)formatter.Deserialize(stream);
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not Found");
                }
                return questions;
            }
            catch (FileNotFoundException)
            {
                addQuestion("Question", "Option", "Option", "Option", "Option", 1);
                BinaryFormatter tmp = new BinaryFormatter();
                using (FileStream stream = new FileStream("QuestionsDataBase.dat", FileMode.Create))
                {
                    formatter.Serialize(stream, questions);
                }
                return questions;
            }
        }

        public void addQuestion(string nquestion, string option1, string option2, string option3, string option4, int rAnswer)
        {
            Question tmp = new Question(nquestion, option1, option2, option3, option4, rAnswer);
            questions.Add(tmp);
        }
    }
}

[Serializable]
public class Question
{
    public string nquestion { get; set; }
    public string option1 { get; set; }
    public string option2 { get; set; }
    public string option3 { get; set; }
    public string option4 { get; set; }
    public int rAnswer { get; set; }
    public int uAnswer { get; set; } = 0;
    public Question(string nquestion, string option1, string option2, string option3, string option4, int rAnswer)
    {
        this.nquestion = nquestion;
        this.option1 = option1;
        this.option2 = option2;
        this.option3 = option3;
        this.option4 = option4;
        this.rAnswer = rAnswer;
    }
}