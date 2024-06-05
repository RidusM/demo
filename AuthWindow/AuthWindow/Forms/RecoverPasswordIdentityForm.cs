using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthWindow.Forms
{
    public partial class RecoverPasswordIdentityForm : Form
    {
        public RecoverPasswordIdentityForm()
        {
            InitializeComponent();
        }

        private void buttonPasswordMask_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == false)
                textBoxPassword.UseSystemPasswordChar = true;
            else if (textBoxPassword.UseSystemPasswordChar == true)
                textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonEnterToSystem_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                errorProvider.SetError(textBoxLogin, "Укажите пожалуйста логин!");
                textBoxLogin.BackColor = Color.Yellow;
                errorProvider.SetError(textBoxPassword, "Укажите пожалуйста пароль");
                textBoxPassword.BackColor = Color.Yellow;
            }
            else if (textBoxLogin.Text == "")
            {
                errorProvider.SetError(textBoxLogin, "Укажите пожалуйста логин!");
                textBoxLogin.BackColor = Color.Yellow;
            }
            else if (textBoxPassword.Text == "")
            {
                errorProvider.SetError(textBoxPassword, "Укажите пожалуйста пароль");
                textBoxPassword.BackColor = Color.Yellow;
            }
        }
    }
}
