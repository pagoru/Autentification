using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autentification
{
    class User
    {
        public static User[] getUsersFromFile()
        {
            String fileText = System.IO.File.ReadAllText(Autentification.filePath);
            String[] fileUsers = Regex.Split(fileText, "\n");

            User[] users = new User[fileUsers.Length];
            for (int i = 0; i < users.Length; i++)
            {
                if(fileUsers[i].Length > 0)
                {
                    users[i] = new User(fileUsers[i]);
                }
            }
            return users;
        }

        public static User getUser(String username)
        {
            foreach(User u in getUsersFromFile())
            {
                if(u != null)
                {
                if (u.getUsername().Equals(username))
                {
                    return u;
                }
                }
            }
            return null;
        }

        private String username;
        private byte[] salt;
        private byte[] password;

        public User(String userText)
        {
            String[] user = userText.Split(';');

            this.username = user[0];
            this.salt = Convert.FromBase64String(user[1]);
            this.password = Convert.FromBase64String(user[2]);
        }
        public User(String username, String salt, String password)
        {
            this.username = username;
            this.salt = Convert.FromBase64String(salt);
            this.password = Convert.FromBase64String(password);
        }

        public User(String username, byte[] salt, byte[] password)
        {
            this.username = username;
            this.salt = salt;
            this.password = password;
        }

        public String getUsername()
        {
            return username;
        }

        public byte[] getSalt()
        {
            return salt;
        }

        public bool comparePassword(String password)
        {
            return Convert.ToBase64String(this.password).Equals(password);
        }

        public String getWriteableString()
        {
            return username 
                + ";" + Convert.ToBase64String(salt) 
                + ";" + Convert.ToBase64String(password)
                + "\n";
        }

    }
}
