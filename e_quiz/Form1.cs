using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_quiz
{
    public partial class LoginPage: Form
    {
        IAuthLogic authLogic = new AuthLogic();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserTypeEnum typeEnum = getUserType();
            bool result = authLogic.login(txtUsername.Text, txtPassword.Text, typeEnum);
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
            }else
            {
                return UserTypeEnum.STUDENT;
            }
        }
    }
}
