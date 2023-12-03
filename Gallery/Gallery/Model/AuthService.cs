using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Model
{
    public class AuthService
    {
        private static AuthService instance;

        private List<UserModel> registeredUsers = new List<UserModel>();
        private AuthService() { }

        public static AuthService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthService();
                }
                return instance;
            }
        }
        public void SaveUsersToJson()
        {
            string json = JsonConvert.SerializeObject(registeredUsers);
            File.WriteAllText("UsersDB.json", json);
        }

        public void LoadUsersFromJson()
        {
            if (File.Exists("UsersDB.json"))
            {
                string json = File.ReadAllText("UsersDB.json");
                registeredUsers = JsonConvert.DeserializeObject<List<UserModel>>(json);
            }
        }
        public bool RegisterUser(string username, string password,string author)
        {
            if (registeredUsers.Any(user => user.Username == username)) return false;
            if(password.Length <8) return false;
            registeredUsers.Add(new UserModel { Username = username, Password = password, Author = author });
            return true;
        }

        public bool AuthenticateUser(string username, string password)
        {
            var user = registeredUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }
    }
}
