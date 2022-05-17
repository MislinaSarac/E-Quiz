using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_quiz
{
    public partial class RegisterPage : Form
    {
        IAuthLogic authLogic = new AuthLogic(); 
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserTypeEnum userTypeEnum = getUserType();
            bool result = authLogic.register(txtUsername.Text,txtPassword.Text, userTypeEnum);
            if (result)
            {
                MessageBox.Show("BAŞARILI");
            }
            else
            {
                MessageBox.Show("BAŞARISIZ");
            }
        }

        private UserTypeEnum getUserType()
        {
            if (radioButton1.Checked)
            {
                return UserTypeEnum.ADMIN;
            }
            else if (radioButton2.Checked)
            {
                return UserTypeEnum.EXAMER;
            }
            else
            {
                return UserTypeEnum.STUDENT;
            }
        }
    }
}
