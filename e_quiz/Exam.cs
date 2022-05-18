using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e_quiz
{
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamStart examStart = new ExamStart();
            examStart.ShowDialog();
            this.Close();
        }
    }
    }

