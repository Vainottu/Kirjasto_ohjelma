namespace sqltest2
{
    partial class Kirjatlista
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button3 = new Button();
            listView1 = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(418, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Päivitä lista";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(378, 399);
            button2.Name = "button2";
            button2.Size = new Size(152, 23);
            button2.TabIndex = 2;
            button2.Text = "Palaa edelliseen ikkunaan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 548);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 577);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 606);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 635);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(94, 664);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(94, 693);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 548);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 20;
            label7.Text = "ID";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 577);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 21;
            label8.Text = "Kirjan nimi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 606);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 22;
            label9.Text = "Kirjailija";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 630);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 23;
            label10.Text = "Julkaisuvuosi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 661);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 24;
            label11.Text = "ISBN tunnus";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 693);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 25;
            label12.Text = "Saldo";
            // 
            // button3
            // 
            button3.Location = new Point(95, 722);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 26;
            button3.Text = "Lisää uusi kirja";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(41, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(831, 337);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 513);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 28;
            label1.Text = "Lisää uusi kirja järjestelmään";
            // 
            // Kirjatlista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 803);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Kirjatlista";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button3;
        private ListView listView1;
        private Label label1;
    }
}