using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationProject
{
    [Serializable]
    public abstract class Person
    {
        protected string firstName { get; set; }
        protected string lastName { get; set; }
        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }
        public string GetFirstName() => firstName;
        public void SetFirstName(string value) => firstName = value;

        public string GetLastName() => lastName;
        public void SetLastName(string value) => lastName = value;
    }
}
