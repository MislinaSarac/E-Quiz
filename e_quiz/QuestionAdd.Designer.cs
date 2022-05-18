
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionAdd));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioBtnA = new System.Windows.Forms.RadioButton();
            this.radioBtnB = new System.Windows.Forms.RadioButton();
            this.radioBtnC = new System.Windows.Forms.RadioButton();
            this.radioBtnD = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.questiontxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(132, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioBtnA
            // 
            this.radioBtnA.AutoSize = true;
            this.radioBtnA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnA.Location = new System.Drawing.Point(282, 863);
            this.radioBtnA.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnA.Name = "radioBtnA";
            this.radioBtnA.Size = new System.Drawing.Size(64, 35);
            this.radioBtnA.TabIndex = 2;
            this.radioBtnA.Text = "A)";
            this.radioBtnA.UseVisualStyleBackColor = true;
            // 
            // radioBtnB
            // 
            this.radioBtnB.AutoSize = true;
            this.radioBtnB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnB.Location = new System.Drawing.Point(395, 863);
            this.radioBtnB.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnB.Name = "radioBtnB";
            this.radioBtnB.Size = new System.Drawing.Size(62, 35);
            this.radioBtnB.TabIndex = 3;
            this.radioBtnB.Text = "B)";
            this.radioBtnB.UseVisualStyleBackColor = true;
            // 
            // radioBtnC
            // 
            this.radioBtnC.AutoSize = true;
            this.radioBtnC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnC.Location = new System.Drawing.Point(502, 863);
            this.radioBtnC.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnC.Name = "radioBtnC";
            this.radioBtnC.Size = new System.Drawing.Size(61, 35);
            this.radioBtnC.TabIndex = 4;
            this.radioBtnC.Text = "C)";
            this.radioBtnC.UseVisualStyleBackColor = true;
            // 
            // radioBtnD
            // 
            this.radioBtnD.AutoSize = true;
            this.radioBtnD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnD.Location = new System.Drawing.Point(611, 863);
            this.radioBtnD.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.radioBtnD.Name = "radioBtnD";
            this.radioBtnD.Size = new System.Drawing.Size(63, 35);
            this.radioBtnD.TabIndex = 5;
            this.radioBtnD.Text = "D)";
            this.radioBtnD.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(912, 847);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(247, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Question";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(912, 563);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(247, 50);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "Choose Question";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(27, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 68);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 51);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Question";
            // 
            // questiontxt
            // 
            this.questiontxt.Location = new System.Drawing.Point(129, 702);
            this.questiontxt.Name = "questiontxt";
            this.questiontxt.Size = new System.Drawing.Size(752, 120);
            this.questiontxt.TabIndex = 11;
            this.questiontxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Question:";
            // 
            // QuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1260, 936);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questiontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radioBtnD);
            this.Controls.Add(this.radioBtnC);
            this.Controls.Add(this.radioBtnB);
            this.Controls.Add(this.radioBtnA);
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
        private System.Windows.Forms.RadioButton radioBtnA;
        private System.Windows.Forms.RadioButton radioBtnB;
        private System.Windows.Forms.RadioButton radioBtnC;
        private System.Windows.Forms.RadioButton radioBtnD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox questiontxt;
        private System.Windows.Forms.Label label1;
    }
}