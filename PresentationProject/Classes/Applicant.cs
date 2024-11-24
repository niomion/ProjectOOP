using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationProject
{
    [Serializable]
    public class Applicant : Person
    {
        private string userName { get; set; }
        public string password { get; set; }
        public string faculty { get; set; }
        public double grade { get; set; }
        public bool completed = false;
        public DateTime dateTime;
        public Applicant(string fName, string lName, string userName, string password, string faculty) : base(fName, lName)
        {
            this.userName = userName;
            this.password = password;
            this.faculty = faculty;
        }
        public bool verifyPassword(string inputPassword)
        {
            return this.password == inputPassword;
        }
    }
}
