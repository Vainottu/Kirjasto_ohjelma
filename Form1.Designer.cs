namespace sqltest2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            button5 = new Button();
            label14 = new Label();
            button4 = new Button();
            label15 = new Label();
            textBox6 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            button8 = new Button();
            label19 = new Label();
            listView1 = new ListView();
            label16 = new Label();
            panel1 = new Panel();
            button9 = new Button();
            panel2 = new Panel();
            label18 = new Label();
            panel3 = new Panel();
            listView2 = new ListView();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 64);
            button1.Name = "button1";
            button1.Size = new Size(191, 79);
            button1.TabIndex = 0;
            button1.Text = "Muodosta yhteys";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 138);
            button2.Name = "button2";
            button2.Size = new Size(191, 74);
            button2.TabIndex = 1;
            button2.Text = "Katkaise yhteys";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Yhteyden testaus";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(4, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(91, 199);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(42, 208);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 4;
            button3.Text = "Hae tiedot";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(92, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(91, 199);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(181, 6);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(91, 199);
            listBox3.TabIndex = 6;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(269, 6);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(108, 199);
            listBox4.TabIndex = 7;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(374, 6);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(104, 199);
            listBox5.TabIndex = 8;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(476, 6);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(82, 199);
            listBox6.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, -15);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "Tunnus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, -15);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Etunimi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, -15);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Sukunimi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, -15);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "Koso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(441, -15);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 14;
            label6.Text = "pno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(534, -15);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 15;
            label7.Text = "ptp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 15);
            label8.Name = "label8";
            label8.Size = new Size(194, 15);
            label8.TabIndex = 16;
            label8.Text = "Lisää asiakkaan tiedot järjestelmään";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(74, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(74, 172);
            textBox4.MaxLength = 6;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(74, 201);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 83);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 23;
            label9.Text = "Etunimi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 109);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 24;
            label10.Text = "Sukunimi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 141);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 25;
            label11.Text = "Koso:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 175);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 26;
            label12.Text = "pno:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 204);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 27;
            label13.Text = "ptp:";
            // 
            // button5
            // 
            button5.Location = new Point(97, 229);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 30;
            button5.Text = "Lisää asiakas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(190, 15);
            label14.TabIndex = 31;
            label14.Text = "Poista valittu asiakas järjestelmästä";
            // 
            // button4
            // 
            button4.Location = new Point(46, 18);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 32;
            button4.Text = "Poista";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 54);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 34;
            label15.Text = "Tunnus";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(74, 51);
            textBox6.MaxLength = 6;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 23);
            textBox6.TabIndex = 35;
            // 
            // button6
            // 
            button6.Location = new Point(558, 206);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 37;
            button6.Text = "Kirjaa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1336, 210);
            button7.Name = "button7";
            button7.Size = new Size(107, 23);
            button7.TabIndex = 38;
            button7.Text = "Lista kirjoista";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(517, 67);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(174, 23);
            textBox7.TabIndex = 51;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(517, 100);
            textBox8.MaxLength = 6;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(174, 23);
            textBox8.TabIndex = 52;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(395, 67);
            label23.Name = "label23";
            label23.Size = new Size(116, 15);
            label23.TabIndex = 54;
            label23.Text = "Lainattavan kirjan id:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(422, 103);
            label24.Name = "label24";
            label24.Size = new Size(89, 15);
            label24.TabIndex = 55;
            label24.Text = "Asiakas tunnus:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(531, 49);
            label25.Name = "label25";
            label25.Size = new Size(76, 15);
            label25.TabIndex = 56;
            label25.Text = "Kirjaa lainaus";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(517, 139);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(174, 23);
            textBox9.TabIndex = 57;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(517, 177);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(174, 23);
            textBox10.TabIndex = 58;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(427, 139);
            label26.Name = "label26";
            label26.Size = new Size(67, 15);
            label26.TabIndex = 60;
            label26.Text = "Kirjan nimi:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(422, 177);
            label27.Name = "label27";
            label27.Size = new Size(63, 15);
            label27.TabIndex = 61;
            label27.Text = "Lainauspv:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(787, 177);
            label28.Name = "label28";
            label28.Size = new Size(65, 15);
            label28.TabIndex = 71;
            label28.Text = "Palautuspv";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(792, 139);
            label29.Name = "label29";
            label29.Size = new Size(67, 15);
            label29.TabIndex = 70;
            label29.Text = "Kirjan nimi:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(882, 177);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(174, 23);
            textBox11.TabIndex = 69;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(882, 139);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(174, 23);
            textBox12.TabIndex = 68;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(918, 49);
            label30.Name = "label30";
            label30.Size = new Size(84, 15);
            label30.TabIndex = 67;
            label30.Text = "Kirjaa palautus";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(787, 103);
            label31.Name = "label31";
            label31.Size = new Size(89, 15);
            label31.TabIndex = 66;
            label31.Text = "Asiakas tunnus:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(749, 67);
            label32.Name = "label32";
            label32.Size = new Size(127, 15);
            label32.TabIndex = 65;
            label32.Text = "Palautettavan kirjan id:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(882, 100);
            textBox13.MaxLength = 6;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(174, 23);
            textBox13.TabIndex = 64;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(882, 67);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(174, 23);
            textBox14.TabIndex = 63;
            // 
            // button8
            // 
            button8.Location = new Point(923, 206);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 62;
            button8.Text = "Palauta";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.IndianRed;
            label19.Location = new Point(212, 225);
            label19.Name = "label19";
            label19.Size = new Size(212, 37);
            label19.TabIndex = 72;
            label19.Text = "Kirja Myöhässä";
            // 
            // listView1
            // 
            listView1.Location = new Point(606, 24);
            listView1.Name = "listView1";
            listView1.Size = new Size(622, 199);
            listView1.TabIndex = 73;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(859, -15);
            label16.Name = "label16";
            label16.Size = new Size(115, 15);
            label16.TabIndex = 74;
            label16.Text = "Lainassa olevat kirjat";
            label16.Click += label16_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(label28);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(label29);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label30);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label32);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBox14);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(textBox6);
            panel1.Location = new Point(12, 582);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 249);
            panel1.TabIndex = 75;
            // 
            // button9
            // 
            button9.Location = new Point(1038, 275);
            button9.Name = "button9";
            button9.Size = new Size(225, 25);
            button9.TabIndex = 73;
            button9.Text = "Hae vanhat lainaukset asiakkaasta";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label18);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox4);
            panel2.Controls.Add(listBox5);
            panel2.Controls.Add(listBox6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(220, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1279, 263);
            panel2.TabIndex = 76;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(854, 6);
            label18.Name = "label18";
            label18.Size = new Size(111, 15);
            label18.TabIndex = 78;
            label18.Text = "Aktiiviset lainaukset";
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(323, 208);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 46);
            panel3.TabIndex = 77;
            // 
            // listView2
            // 
            listView2.Location = new Point(3, 0);
            listView2.Name = "listView2";
            listView2.Size = new Size(626, 230);
            listView2.TabIndex = 79;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(listView2);
            panel4.Controls.Add(label19);
            panel4.Location = new Point(826, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 270);
            panel4.TabIndex = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 896);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(button9);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button5;
        private Label label14;
        private Button button4;
        private Label label15;
        private TextBox textBox6;
        private Button button6;
        private Button button7;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label23;
        private Label label24;
        private Label label25;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label label30;
        private Label label31;
        private Label label32;
        private TextBox textBox13;
        private TextBox textBox14;
        private Button button8;
        private Label label19;
        private ListView listView1;
        private Label label16;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label18;
        private ListView listView2;
        private Button button9;
        private Panel panel4;
    }
}