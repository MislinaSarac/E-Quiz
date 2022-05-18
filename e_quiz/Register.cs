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

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

      
        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
