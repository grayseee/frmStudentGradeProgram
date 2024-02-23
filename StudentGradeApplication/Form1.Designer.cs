namespace StudentGradeApplication
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnglishB = new System.Windows.Forms.TextBox();
            this.MathB = new System.Windows.Forms.TextBox();
            this.Science = new System.Windows.Forms.TextBox();
            this.Filipino = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GeneratedAverage = new System.Windows.Forms.Button();
            this.GeneralAverage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EnglishB
            // 
            this.EnglishB.BackColor = System.Drawing.Color.DarkSalmon;
            this.EnglishB.Location = new System.Drawing.Point(136, 128);
            this.EnglishB.Name = "EnglishB";
            this.EnglishB.Size = new System.Drawing.Size(169, 20);
            this.EnglishB.TabIndex = 1;
            this.EnglishB.Text = "h";
            this.EnglishB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MathB
            // 
            this.MathB.BackColor = System.Drawing.Color.DarkSalmon;
            this.MathB.Location = new System.Drawing.Point(136, 172);
            this.MathB.Name = "MathB";
            this.MathB.Size = new System.Drawing.Size(169, 20);
            this.MathB.TabIndex = 2;
            // 
            // Science
            // 
            this.Science.BackColor = System.Drawing.Color.DarkSalmon;
            this.Science.Location = new System.Drawing.Point(136, 220);
            this.Science.Name = "Science";
            this.Science.Size = new System.Drawing.Size(169, 20);
            this.Science.TabIndex = 3;
            // 
            // Filipino
            // 
            this.Filipino.BackColor = System.Drawing.Color.DarkSalmon;
            this.Filipino.Location = new System.Drawing.Point(136, 265);
            this.Filipino.Name = "Filipino";
            this.Filipino.Size = new System.Drawing.Size(169, 20);
            this.Filipino.TabIndex = 4;
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.DarkSalmon;
            this.History.Location = new System.Drawing.Point(136, 313);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(169, 20);
            this.History.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Math";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "History";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Filipino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Science";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "GRADES";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GeneratedAverage
            // 
            this.GeneratedAverage.BackColor = System.Drawing.Color.Thistle;
            this.GeneratedAverage.Location = new System.Drawing.Point(160, 359);
            this.GeneratedAverage.Name = "GeneratedAverage";
            this.GeneratedAverage.Size = new System.Drawing.Size(110, 55);
            this.GeneratedAverage.TabIndex = 15;
            this.GeneratedAverage.Text = "Generate Average ";
            this.GeneratedAverage.UseVisualStyleBackColor = false;
            this.GeneratedAverage.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneralAverage
            // 
            this.GeneralAverage.AllowDrop = true;
            this.GeneralAverage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GeneralAverage.Location = new System.Drawing.Point(412, 194);
            this.GeneralAverage.Name = "GeneralAverage";
            this.GeneralAverage.Size = new System.Drawing.Size(263, 71);
            this.GeneralAverage.TabIndex = 16;
            this.GeneralAverage.Text = "GeneralAverage";
            this.GeneralAverage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeneralAverage);
            this.Controls.Add(this.GeneratedAverage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Filipino);
            this.Controls.Add(this.Science);
            this.Controls.Add(this.MathB);
            this.Controls.Add(this.EnglishB);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox EnglishB;
        private System.Windows.Forms.TextBox MathB;
        private System.Windows.Forms.TextBox Science;
        private System.Windows.Forms.TextBox Filipino;
        private System.Windows.Forms.TextBox History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GeneratedAverage;
        private System.Windows.Forms.Button GeneralAverage;
    }
}

