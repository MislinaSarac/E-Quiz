using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;


namespace e_quiz
{
    public partial class QuestionAdd : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-71BP9LD\\SQLEXPRESS;Initial Catalog=tutorialdb;Integrated Security=True");

        public QuestionAdd()
        {
            InitializeComponent();
        }
            

        private void QuestionAdd_Load(object sender, EventArgs e)
        {
            //addquestion();

        }
        
     
        public void addquestion()
        {
            con.Open();
            string commandText = "INSERT INTO Questions- VALUES (@questiontxt,@ansverA,@ansverB,@ansverC,@ansverD,@image,@trueansver)";
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@questiontxt", questiontxt.Text);
            command.Parameters.AddWithValue("@ansverA", radioBtnA.Text);
            command.Parameters.AddWithValue("@ansverB", radioBtnB.Text);
            command.Parameters.AddWithValue("@ansverc",radioBtnC.Text);
            command.Parameters.AddWithValue("@ansverD",radioBtnD.Text);

            MemoryStream memoryStream = new MemoryStream();
            command.Parameters.AddWithValue("@image", (Byte[])memoryStream.ToArray());


            if (radioBtnA.Checked)
            {
                command.Parameters.AddWithValue("@trueansver",radioBtnA.Text);
            }
            else if (radioBtnB.Checked)
            {
                command.Parameters.AddWithValue("@trueansver",radioBtnB.Text);
            }

            else if (radioBtnC.Checked)
            {
                command.Parameters.AddWithValue("@trueansver",radioBtnC.Text);
            }
           else 
            {
                command.Parameters.AddWithValue("@trueansver",radioBtnD.Text);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addquestion();
            /* questions questions = new questions();
             questions.qustiontest = questiontxt.Text;
             questions.ansverA = radioBtnA.Text;
             questions.ansverB = radioBtnB.Text;
             questions.ansverC = radioBtnC.Text;
             questions.ansverD = radioBtnD.Text;
            // questions.image=*/

            MemoryStream memoryStream = new MemoryStream();

            pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
            _ = memoryStream.ToArray();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Select image(.JpG;.png)|.JpG; .png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Close();
        }


    }
}
