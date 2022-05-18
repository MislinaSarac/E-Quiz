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
            if (radioButton3.Checked)
            {
                QuestionAdd questionAdd = new QuestionAdd();
                questionAdd.Show();
                this.Hide();
                this.Close();
            }
            else if (radioButton2.Checked)
            {
                Exam exam  = new Exam();
                exam.Show();
                this.Hide();
                this.Close();
            }
            else
            {
                Executive executive = new Executive();
                executive.Show();
                this.Hide();
                this.Close();
            }


            UserTypeEnum typeEnum = getUserType();
            bool result = authLogic.login(txtUsername.Text, txtPassword.Text, typeEnum);
           
        }

        private UserTypeEnum getUserType()
        {
            if (radioButton1.Checked)
            {
                return UserTypeEnum.ADMIN;
            }
            else if (radioButton2.Checked)
            {
                return UserTypeEnum.EXAMİNER;
            }else
            {
                return UserTypeEnum.STUDENT;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
