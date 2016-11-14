using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autentification
{
    class Autentification
    {
        public static String filePath = @"C:\Users\pablo\Documents\passwords.txt";
        public static String SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }

        public static SecureString StringToSecureString(String value)
        {
            SecureString ss = new SecureString();
            foreach (char c in value)
            {
                ss.AppendChar(c);
            }
            ss.MakeReadOnly();
            return ss;
        }

        public enum LoginReturns
        {
            VALID,
            EMPTY_USERNAME,
            EMPTY_PASSWORD,
            USERNAME_NOT_EXISTS,
            PASSWORD_MISMATCH
            
        }
        public enum RegisterReturns
        {
            VALID,
            EMPTY_USERNAME,
            CHARACTERS_NOT_VALID_USERNAME,
            EMPTY_PASSWORD,
            EMPTY_REPASSWORD,
            PASSWORDS_MISMATCH,
            USERNAME_ALREADY_REGISTERED
        }
        public LoginReturns Login(String username, SecureString password)
        {
            if(username.Length == 0)
            {
                return LoginReturns.EMPTY_USERNAME;
            }
            if(password.Length == 0)
            {
                return LoginReturns.EMPTY_PASSWORD;
            }
            User user = User.getUser(username);
            if (user == null)
            {
                return LoginReturns.USERNAME_NOT_EXISTS;
            }
            String hashedPassword = Convert.ToBase64String(getHash(user.getSalt(), password));
            if (!user.comparePassword(hashedPassword))
            {
                return LoginReturns.PASSWORD_MISMATCH;
            }
            return LoginReturns.VALID;
        }

        public RegisterReturns Register(String username, SecureString password, SecureString rePassword)
        {
            if (username.Length == 0)
            {
                return RegisterReturns.EMPTY_USERNAME;
            }
            if (username.Contains(';') || username.Contains(' '))
            {
                return RegisterReturns.CHARACTERS_NOT_VALID_USERNAME;
            }
            if (password.Length == 0)
            {
                return RegisterReturns.EMPTY_PASSWORD;
            }
            if (rePassword.Length == 0)
            {
                return RegisterReturns.EMPTY_REPASSWORD;
            }
            if (!SecureStringToString(password).Equals(SecureStringToString(rePassword)))
            {
                return RegisterReturns.PASSWORDS_MISMATCH;
            }
            if (User.getUser(username) != null)
            {
                return RegisterReturns.USERNAME_ALREADY_REGISTERED;
            }
            
            byte[] salt = getSalt(16);
            byte[] passwordHash = getHash(salt, password);

            User newUser = new User(username, salt, passwordHash);

            System.IO.File.AppendAllText(filePath, newUser.getWriteableString());
            
            return RegisterReturns.VALID;
        }

        private byte[] getSalt(int size)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return salt;
        }

        private byte[] getHash(byte[] salt, SecureString password)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(SecureStringToString(password), salt, 100);
            return pbkdf2.GetBytes(16);
        }

    }

}
