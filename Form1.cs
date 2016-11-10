using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Autentification.Autentification;

namespace Autentification
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Autentification aut;
        public Form()
        {
            InitializeComponent();
            aut = new Autentification();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginReturns loginR = aut.Login(txt_Login_Username.Text, 
                Autentification.StringToSecureString(txt_Login_Password.Text));
            String messageBoxText = "Error generic.";
            switch (loginR)
            {
                case LoginReturns.VALID:
                    messageBoxText = "S'ha iniciat sessió correctament.";
                    txt_Login_Username.Text
                        = txt_Login_Password.Text = "";
                    break;
                case LoginReturns.EMPTY_USERNAME:
                    messageBoxText = "El camp de l'usuari esta buit.";
                    txt_Login_Username.Focus();
                    break;
                case LoginReturns.EMPTY_PASSWORD:
                    messageBoxText = "El camp de la contrasenya esta buit.";
                    txt_Login_Password.Focus();
                    break;
                case LoginReturns.USERNAME_NOT_EXISTS:
                    messageBoxText = "L'usuari no existeix";
                    txt_Login_Username.Focus();
                    break;
                case LoginReturns.PASSWORD_MISMATCH:
                    messageBoxText = "La contrasenya no es vàlida.";
                    txt_Login_Password.Focus();
                    break;
            }
            MessageBox.Show(messageBoxText, "Error(?)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterReturns registerR = aut.Register(txt_Register_Username.Text, 
                Autentification.StringToSecureString(txt_Register_Password.Text), 
                Autentification.StringToSecureString(txt_Register_RePassword.Text));
            String messageBoxText = "Error generic.";
            switch (registerR)
            {
                case RegisterReturns.VALID:
                    messageBoxText = "S'ha registrat correctament.";
                    txt_Register_Username.Text =
                        txt_Register_Password.Text =
                        txt_Register_RePassword.Text = "";
                    break;
                case RegisterReturns.EMPTY_USERNAME:
                    messageBoxText = "El camp de l'usuari esta buit.";
                    txt_Register_Username.Focus();
                    break;
                case RegisterReturns.DOT_COMMA_USERNAME:
                    messageBoxText = "El camp de l'usuari no pot contenir el carácter ';'.";
                    txt_Register_Username.Focus();
                    break;
                case RegisterReturns.EMPTY_PASSWORD:
                    messageBoxText = "El camp de la contrasenya esta buit.";
                    txt_Register_Password.Focus();
                    break;
                case RegisterReturns.EMPTY_REPASSWORD:
                    messageBoxText = "El camp de repetir la contrasenya esta buit.";
                    txt_Register_RePassword.Focus();
                    break;
                case RegisterReturns.PASSWORDS_MISMATCH:
                    messageBoxText = "Les contrasenyas no son iguals.";
                    txt_Register_RePassword.Focus();
                    break;
                case RegisterReturns.USERNAME_ALREADY_REGISTERED:
                    messageBoxText = "L'usuari ja existeix.";
                    txt_Register_Username.Focus();
                    break;
            }
            MessageBox.Show(messageBoxText, "Error(?)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
