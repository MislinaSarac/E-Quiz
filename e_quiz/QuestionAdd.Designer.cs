
namespace e_quiz
{
    partial class QuestionAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.questiontxt = new System.Windows.Forms.RichTextBox();
            this.radioBtnA = new System.Windows.Forms.RadioButton();
            this.radioBtnB = new System.Windows.Forms.RadioButton();
            this.radioBtnC = new System.Windows.Forms.RadioButton();
            this.radioBtnD = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(225, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 248);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // questiontxt
            // 
            this.questiontxt.Location = new System.Drawing.Point(225, 344);
            this.questiontxt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.questiontxt.Name = "questiontxt";
            this.questiontxt.Size = new System.Drawing.Size(486, 95);
            this.questiontxt.TabIndex = 1;
            this.questiontxt.Text = "";
            // 
            // radioBtnA
            // 
            this.radioBtnA.AutoSize = true;
            this.radioBtnA.Location = new System.Drawing.Point(225, 497);
            this.radioBtnA.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnA.Name = "radioBtnA";
            this.radioBtnA.Size = new System.Drawing.Size(190, 35);
            this.radioBtnA.TabIndex = 2;
            this.radioBtnA.TabStop = true;
            this.radioBtnA.Text = "radioButton1";
            this.radioBtnA.UseVisualStyleBackColor = true;
            // 
            // radioBtnB
            // 
            this.radioBtnB.AutoSize = true;
            this.radioBtnB.Location = new System.Drawing.Point(225, 570);
            this.radioBtnB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnB.Name = "radioBtnB";
            this.radioBtnB.Size = new System.Drawing.Size(192, 35);
            this.radioBtnB.TabIndex = 3;
            this.radioBtnB.TabStop = true;
            this.radioBtnB.Text = "radioButton2";
            this.radioBtnB.UseVisualStyleBackColor = true;
            // 
            // radioBtnC
            // 
            this.radioBtnC.AutoSize = true;
            this.radioBtnC.Location = new System.Drawing.Point(225, 639);
            this.radioBtnC.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnC.Name = "radioBtnC";
            this.radioBtnC.Size = new System.Drawing.Size(194, 35);
            this.radioBtnC.TabIndex = 4;
            this.radioBtnC.TabStop = true;
            this.radioBtnC.Text = "radioButton3";
            this.radioBtnC.UseVisualStyleBackColor = true;
            // 
            // radioBtnD
            // 
            this.radioBtnD.AutoSize = true;
            this.radioBtnD.Location = new System.Drawing.Point(222, 693);
            this.radioBtnD.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnD.Name = "radioBtnD";
            this.radioBtnD.Size = new System.Drawing.Size(193, 35);
            this.radioBtnD.TabIndex = 5;
            this.radioBtnD.TabStop = true;
            this.radioBtnD.Text = "radioButton4";
            this.radioBtnD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(957, 776);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioBtnD);
            this.Controls.Add(this.radioBtnC);
            this.Controls.Add(this.radioBtnB);
            this.Controls.Add(this.radioBtnA);
            this.Controls.Add(this.questiontxt);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "QuestionAdd";
            this.Text = "QuestionAdd";
            this.Load += new System.EventHandler(this.QuestionAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox questiontxt;
        private System.Windows.Forms.RadioButton radioBtnA;
        private System.Windows.Forms.RadioButton radioBtnB;
        private System.Windows.Forms.RadioButton radioBtnC;
        private System.Windows.Forms.RadioButton radioBtnD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}