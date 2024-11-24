using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PresentationProject.Classes
{
    public class Authentication
    {
        public Dictionary<string, Applicant> userDataBase;
        public Authentication()
        {
            userDataBase = new Dictionary<string, Applicant>();
            loadFile();
        }
        public Applicant getApplicant(string username)
        {
            return userDataBase[username];
        }
        public void registerUser(string username, string password, string firstName, string lastName, string faculty)
        {
            loadFile();
            password = HashPassword(password);
            Applicant User = new Applicant(firstName, lastName, username, password, faculty);
            userDataBase.Add(username, User);
            uploadFile();
        }

        public bool verifyUser(string username, string password)
        {
            password = HashPassword(password);
            if (!(this.userDataBase.ContainsKey(username)))
            {
                return false;
            }
            if (this.userDataBase[username].verifyPassword(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void loadFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                if (File.Exists("UserDataBase.dat")) {
                    using (FileStream stream = new FileStream("UserDataBase.dat", FileMode.Open))
                    {
                        userDataBase = (Dictionary<string, Applicant>)formatter.Deserialize(stream);
                    }
                }
                else
                {
                    throw new FileNotFoundException("File not Found");
                }
            }
            catch (FileNotFoundException)
            {
                string password = HashPassword("admin");
                Applicant tmpUser = new Applicant("admin", "admin", "admin", password, "admin");
                userDataBase.Add("admin", tmpUser);
                uploadFile();
            }

        }
        public void uploadFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("UserDataBase.dat", FileMode.Create))
            {
                formatter.Serialize(stream, userDataBase);
            }
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
