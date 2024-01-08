using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Globalization;
using System.Data;

namespace sqltest2
{

    public partial class Form1 : Form
    {
        private void Form_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Asiakas Tunnus", 100);
            listView1.Columns.Add("Kirjan Nimi", 200);
            listView1.Columns.Add("Lainauspvm", 100);
            listView1.Columns.Add("Palautuspvm", 100);
            listView1.FullRowSelect = true;
            listView2.View = View.Details;
            listView2.Columns.Add("ID", 50);
            listView2.Columns.Add("Asiakas Tunnus", 100);
            listView2.Columns.Add("Kirjan Nimi", 200);
            listView2.Columns.Add("Lainauspvm", 100);
            listView2.Columns.Add("Palautuspvm", 100);
            listView2.FullRowSelect = true;
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form_Load);
            button2.Visible = false;
            button3.Visible = false;
            //myöhässä label
            label19.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            button9.Visible = false;
            Update();

            //katsotaan klikataanko boxia ja kutsutaan aliohjelmaa
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox2.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox3.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox4.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox5.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox6.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        //yhteys
        MySqlConnection connection = new MySqlConnection("");




        private void Form1_Load(object sender, EventArgs e)
        {
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
        }
        //avetaan yhteys tietokantaan
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Yhteyden muodostus onnistui");
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                panel1.Visible = true;
                panel2.Visible = true;
                button9.Visible = true;

                tyhjenna();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Yhteyttä ei muodostettu: " + ex.Message + " (Error code: " + ex.ErrorCode + ")");

            }

        }
        //suljetaan yhteys tietokantaan
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                MessageBox.Show("Yhteys katkaistu");
                button1.Visible = true;
                button2.Visible = false;
                tyhjenna();
            }
            catch { MessageBox.Show("Yhtyettä ei katkaistu"); }
        }
        //haetaan asiakkaan tiedot ja lisätään tiedot listboxeihin
        private void button3_Click(object sender, EventArgs e)
        {
            //kutsutaan aliohjelmaa
            tyhjenna();

            //haetaan asiakas taulusta
            string query = "SELECT * FROM asiakas WHERE aktiivinen = 1";

            MySqlCommand command = new MySqlCommand(query, connection);
            //avetaan lukija/alustetaan
            MySqlDataReader reader = command.ExecuteReader();
            //luetaan data
            while (reader.Read())
            {
                // 
                string tunnus = reader.GetString(reader.GetOrdinal("tunnus"));
                string enimi = reader.GetString(reader.GetOrdinal("enimi"));
                string snimi = reader.GetString(reader.GetOrdinal("snimi"));
                string koso = reader.GetString(reader.GetOrdinal("koso"));
                string pno = reader.GetString(reader.GetOrdinal("pno"));
                string ptp = reader.GetString(reader.GetOrdinal("ptp"));

                // 
                listBox1.Items.Add(tunnus);
                listBox2.Items.Add(enimi);
                listBox3.Items.Add(snimi);
                listBox4.Items.Add(koso);
                listBox5.Items.Add(pno);
                listBox6.Items.Add(ptp);
            }
            //suljetaan lukija
            reader.Close();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                string query = "SELECT MAX(tunnus) FROM asiakas;";
                MySqlCommand command = new MySqlCommand(query, connection);


                //annetaan arvot muuttujille textboxeista.
                string enimi = textBox1.Text;
                string snimi = textBox2.Text;
                string koso = textBox3.Text;
                string pno = textBox4.Text;
                string ptp = textBox5.Text;
                string tunnus = textBox6.Text;

                //lisätään data 
                query = "INSERT INTO asiakas (tunnus,enimi, snimi, koso, pno, ptp) VALUES (@tunnus, @enimi, @snimi, @koso, @pno, @ptp);";
                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@tunnus", tunnus);
                command.Parameters.AddWithValue("@enimi", enimi);
                command.Parameters.AddWithValue("@snimi", snimi);
                command.Parameters.AddWithValue("@koso", koso);
                command.Parameters.AddWithValue("@pno", pno);
                command.Parameters.AddWithValue("@ptp", ptp);

                //
                int rowsAffected = command.ExecuteNonQuery();

                //Ilmoitetaan lisättiinkö asiakas 
                MessageBox.Show("Asiakas lisättiin onnistuneesti.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            tyhjenna();
        }
        //tyhjentää boxit
        void tyhjenna(params TextBox[] textBoxes)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();



        }
        //seurataan kokoajan muuttuuko tiedot käyttäjän toimesta
        private void Update()
        {
            //seurataan päivittyykö teksti boxeissa
            textBox7.TextChanged += new EventHandler(textBox7_TextChanged);
            textBox13.TextChanged += new EventHandler(textBox13_TextChanged);
            textBox14.TextChanged += new EventHandler(textBox14_TextChanged);


        }
        //kunt textbox7 arvo muuttuu
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = DateTime.Now.ToString("dd/MM/yyyy"); // päivitetään nykyseksi päiväksi, kun id on syötetty
            string connectionString = "";
            string query = "SELECT kirjan_nimi FROM kirjat WHERE id = @textBox7Value";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@textBox7Value", textBox7.Text);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string kirjan_nimi = reader.GetString(0); // haetaan kirjan nimi tietokannasta
                        textBox9.Text = kirjan_nimi;         // haettu tieto syötetään automaattisesti textboxiin
                        textBox10.Text = DateTime.Now.ToString("dd/MM/yyyy"); // päivitetään nykyseksi päiväksi, kun id on syötetty
                    }
                }
                else
                {
                    // no rows were returned by the query
                    textBox9.Text = "";

                }
                connection.Close();
            }
        }
        //kun textbox 14 arvo muuttuu
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "";
            string query = "SELECT kirjan_nimi FROM lainat WHERE id = @textBox14Value";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@textBox14Value", textBox14.Text);

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string kirjan_nimi = reader.GetString(0); // haetaan kirjan nimi tietokannasta
                        textBox12.Text = kirjan_nimi;         // haettu tieto syötetään automaattisesti textboxiin
                        textBox11.Text = DateTime.Now.ToString("dd/MM/yyyy"); // päivitetään nykyseksi päiväksi, kun id on syötetty
                    }
                }
                else
                {
                    // kun ei mitään palautettu
                    textBox12.Text = "Error";
                    textBox11.Text = "Error";

                }
                connection.Close();
            }
        }
        //valitsee listboxilta kaikki itemit
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            listBox2.SelectedIndex = selectedIndex;
            listBox3.SelectedIndex = selectedIndex;
            listBox4.SelectedIndex = selectedIndex;
            listBox5.SelectedIndex = selectedIndex;
            listBox6.SelectedIndex = selectedIndex;


            if (listBox1.SelectedItem != null) // katsotaan onko listbox 1 valittuna joku
            {
                string tunnus = listBox1.SelectedItem.ToString(); // haetaan valittu teksti muuttujaan
                //päivitellään tiedot automaattisesti txtboxiin
                textBox8.Text = tunnus;
                textBox13.Text = tunnus;
            }
            //piilotetaan poista nappi jos asiakkaalla lainauksia
            if (listView1.Items.Count > 0)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
            panel4.Visible = false;

            //haetaan tiedot heti kun kirjaa lainatessa kirjataan Id textboxiin
            void textBox7_TextChanged(object sender, EventArgs e)
            {
                textBox10.Text = DateTime.Now.ToString("dd/MM/yyyy"); // päivitetään nykyseksi päiväksi, kun id on syötetty

                string connectionString = "";
                string query = "SELECT Kirjan_nimi FROM kirjat WHERE id = @textBox7Value";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@textBox7Value", textBox7.Text);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string kirjan_nimi = reader.GetString(0); // retrieve the value of kirjan_nimi from the first column of the result set
                            textBox9.Text = kirjan_nimi;         // do something with kirjan_nimi here
                        }
                    }
                    else
                    {
                        // no rows were returned by the query
                        textBox9.Text = "Virheilmoitus";
                    }
                    connection.Close();
                }
            }
            //haetaan palautettavan kirjan tiedot automaattiesti
            void textBox14_TextChanged(object sender, EventArgs e)
            {
                string connectionString = "";
                string query = "SELECT id, asiakas_tunnus, kirjan_nimi FROM lainat WHERE id = @textBox7Value AND tunnus = @textBox14Value AND kirjan_nimi = @textBox9Value";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@textBox14Value", textBox14.Text);
                    command.Parameters.AddWithValue("@textBox13Value", textBox13.Text);
                    command.Parameters.AddWithValue("@textBox12Value", textBox12.Text);

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0); // haetaan id tiedot taulusta
                            string tunnus = reader.GetString(1); // haetaan tunnus tiedot taulusta
                            string kirjan_nimi = reader.GetString(2); // retrieve the value of kirjan_nimi from the third column of the result set

                            // update the palautspvm column with the current date
                            string updateQuery = "UPDATE kirjat SET palautspvm = CURDATE() WHERE id = @id AND tunnus = @tunnus AND Kirjan_nimi = @kirjanNimi";
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@id", id);
                            updateCommand.Parameters.AddWithValue("@tunnus", tunnus);
                            updateCommand.Parameters.AddWithValue("@kirjanNimi", kirjan_nimi);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // no rows were returned by the query
                        textBox9.Text = "Virheilmoitus";
                    }
                    connection.Close();
                }
            }
        }
        //kun asiakastunnus valitaan, haetaan automaattisesti lainaustiedot asiakkaasta.
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            label19.Visible = false;

            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                string connectionString = "";
                string query = "SELECT id, asiakas_tunnus, kirjan_nimi, lainauspvm, palautuspvm FROM lainat WHERE asiakas_tunnus = @textBox13Value";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@textBox13Value", textBox13.Text);

                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader.IsDBNull(reader.GetOrdinal("id")) ? null : reader.GetString(reader.GetOrdinal("id"));
                        string asiakas_tunnus = reader.GetString(reader.GetOrdinal("asiakas_tunnus"));
                        string kirjan_nimi = reader.IsDBNull(reader.GetOrdinal("kirjan_nimi")) ? null : reader.GetString(reader.GetOrdinal("kirjan_nimi"));
                        DateTime lainauspvm = reader.IsDBNull(reader.GetOrdinal("lainauspvm")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("lainauspvm"));
                        DateTime palautuspvm = reader.IsDBNull(reader.GetOrdinal("palautuspvm")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("palautuspvm"));

                        // skip adding the item to the ListView if the book has been returned
                        if (palautuspvm != DateTime.MinValue)
                        {
                            continue;
                        }

                        ListViewItem item = new ListViewItem(new[] { id, asiakas_tunnus, kirjan_nimi, lainauspvm.ToString("yyyy-MM-dd"), palautuspvm.ToString("yyyy-MM-dd") });
                        listView1.Items.Add(item);

                        if (palautuspvm != DateTime.MinValue && (palautuspvm - lainauspvm).TotalDays > 7)
                        {
                            item.BackColor = Color.Red;
                            label19.Visible = true;
                        }
                    }

                    reader.Close();
                }
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = listBox2.SelectedIndex;


            listBox1.SelectedIndex = selectedIndex;
            listBox3.SelectedIndex = selectedIndex;
            listBox4.SelectedIndex = selectedIndex;
            listBox5.SelectedIndex = selectedIndex;
            listBox6.SelectedIndex = selectedIndex;

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = listBox3.SelectedIndex;


            listBox1.SelectedIndex = selectedIndex;
            listBox2.SelectedIndex = selectedIndex;
            listBox4.SelectedIndex = selectedIndex;
            listBox5.SelectedIndex = selectedIndex;
            listBox6.SelectedIndex = selectedIndex;

        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = listBox4.SelectedIndex;


            listBox1.SelectedIndex = selectedIndex;
            listBox2.SelectedIndex = selectedIndex;
            listBox4.SelectedIndex = selectedIndex;
            listBox5.SelectedIndex = selectedIndex;
            listBox6.SelectedIndex = selectedIndex;
        }
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox5.SelectedIndex;

            listBox1.SelectedIndex = selectedIndex;
            listBox2.SelectedIndex = selectedIndex;
            listBox4.SelectedIndex = selectedIndex;
            listBox5.SelectedIndex = selectedIndex;
            listBox6.SelectedIndex = selectedIndex;
        }
        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox6.SelectedIndex;

            listBox1.SelectedIndex = selectedIndex;
            listBox2.SelectedIndex = selectedIndex;
            listBox4.SelectedIndex = selectedIndex;
            listBox5.SelectedIndex = selectedIndex;
            listBox6.SelectedIndex = selectedIndex;



        }



        //Poistetaan valittu tieto taulusta
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex != -1)
                {
                    // poistetaan valittu
                    string tunnus = listBox1.SelectedItem.ToString();
                    string query = "DELETE FROM asiakas WHERE tunnus = @tunnus;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    //Kyseessä on metodi, joka lisää parametrin SQL-komentoon. Parametrin nimi on "@tunnus" ja sen arvo on muuttujan "tunnus" arvo.
                    //Parametrien käyttö SQL-komennoissa auttaa estämään SQL-injektiohyökkäyksiä, joissa haitallisesti käyttävät voivat muuttaa SQL-komentoja saadakseen luvattoman pääsyn tietokantaan tai vahingoittamaan tietoja.
                    //Parametrien käytön avulla arvot kunnolla koodataan ja validoidaan ennen kuin ne siirretään tietokantaan, mikä auttaa suojaamaan SQL-injektiohyökkäyksiltä.
                    command.Parameters.AddWithValue("@tunnus", tunnus);
                    //
                    //Tämä koodirivi suorittaa SQL-komennon ja palauttaa vaikutettujen rivien määrän muuttujassa "rowsAffected".
                    //Kun ohjelmoidaan SQL-tietokantojen kanssa esimerkiksi C#, VB.NET- tai Javalla, käytetään usein ExecuteNonQuery-metodia suorittamaan SQL-komentoja, jotka eivät palauta tuloksia, kuten INSERT, UPDATE tai DELETE -komentoja.
                    //Tämä metodi suorittaa SQL-komennon tietokannassa ja palauttaa sen vaikutus rivien määrän, joka on tallennettu "rowsAffected" muuttujaan.
                    //Muuttujan "rowsAffected" avulla ohjelmoija voi tarkistaa, kuinka monta riviä on lisätty, päivitetty tai poistettu tietokannasta suoritetun SQL-komennon avulla. Tämä tieto voi auttaa ohjelmoijaa varmistamaan, että SQL-komento on suoritettu oikein ja että tietokannan tila vastaa odotuksia.
                    int rowsAffected = command.ExecuteNonQuery();
                    // 
                    listBox1.Items.RemoveAt(selectedIndex);
                    listBox2.Items.RemoveAt(selectedIndex);
                    listBox3.Items.RemoveAt(selectedIndex);
                    listBox4.Items.RemoveAt(selectedIndex);
                    listBox5.Items.RemoveAt(selectedIndex);
                    listBox6.Items.RemoveAt(selectedIndex);

                    // 
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    tyhjenna();

                    MessageBox.Show("Asiakas poistettu onnistuneesti.");
                }
                else
                {
                    MessageBox.Show("Valitse ensin poistettava asiakas.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Kirjatlista f2 = new Kirjatlista();
            f2.ShowDialog(); // Show kirjalista
        }
        //kirjataan lainaus asiakkaan tietoihin. Kirjan id vaaditaan.
        private void button6_Click(object sender, EventArgs e)
        {
            string id = textBox7.Text;
            string tunnus = textBox8.Text;
            string kirja = textBox9.Text;
            string lainauspv = textBox10.Text;
            //tarkistetaan pvm onko mitä muotoa.

            if (lainauspv.Contains('.'))
            {
                // korvataan pisteet /viivalla ja jatketaan
                lainauspv = lainauspv.Replace('.', '/');
            }

            DateTime dt = DateTime.ParseExact(lainauspv, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string lainauspvm = dt.ToString("yyyy-MM-dd");

            textBox10.Text = lainauspvm;

            MySqlConnection conn = new MySqlConnection("");
            conn.Open();
            // Get the kirja_id from the kirjat table using the book name
            MySqlCommand getKirjaId = new MySqlCommand("SELECT id FROM kirjat WHERE Kirjan_nimi = @kirjan_nimi", conn);
            getKirjaId.Parameters.AddWithValue("@kirjan_nimi", kirja);
            object kirjaIdObj = getKirjaId.ExecuteScalar();
            if (kirjaIdObj != null)
            {
                string kirja_id = kirjaIdObj.ToString();
                //DEFAULT PALAUTUSPVM OLTAVA 0000 LAINATESSA
                MySqlCommand cmd = new MySqlCommand("INSERT INTO lainat (id, asiakas_tunnus, kirjan_nimi, lainauspvm, palautuspvm, kirja_id) VALUES (@id, @asiakas_tunnus, @kirjan_nimi, @lainauspvm, '0001-01-01', @kirja_id)", conn);
                MySqlCommand stockupdate = new MySqlCommand("UPDATE kirjat SET Stock = Stock - 1 WHERE id = @kirja_id", conn);
                stockupdate.Parameters.AddWithValue("@kirja_id", kirja_id);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@asiakas_tunnus", tunnus);
                cmd.Parameters.AddWithValue("@kirjan_nimi", kirja);
                cmd.Parameters.AddWithValue("@lainauspvm", lainauspvm);
                cmd.Parameters.AddWithValue("@kirja_id", kirja_id);

                cmd.ExecuteNonQuery();
                stockupdate.ExecuteNonQuery();

                MessageBox.Show("Kirja lainattu onnistuneesti");
            }
            else
            {
                MessageBox.Show("Kirjaa ei löydetty. Tarkista kirjan nimi ja yritä uudelleen.");
            }

            conn.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string kirja_id = textBox14.Text;
            string asiakas_tunnus = textBox13.Text;
            string palautuspvm = textBox11.Text;



            DateTime dt = DateTime.ParseExact(palautuspvm, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string formattedPalautuspvm = dt.Date.ToString("yyyy-MM-dd");

            //tarkistetaan onko piste vai /
            if (formattedPalautuspvm.Contains('.'))
            {
                formattedPalautuspvm = formattedPalautuspvm.Replace('.', '/');
            }

            MySqlConnection conn = new MySqlConnection("");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("UPDATE lainat SET palautuspvm = @palautuspvm WHERE asiakas_tunnus = @asiakas_tunnus AND kirja_id = @kirja_id", conn);


            MySqlCommand stockupdate = new MySqlCommand("UPDATE kirjat SET Stock = Stock + 1 WHERE id = @kirja_id", conn);
            cmd.Parameters.AddWithValue("@kirja_id", kirja_id);
            cmd.Parameters.AddWithValue("@asiakas_tunnus", asiakas_tunnus);
            cmd.Parameters.AddWithValue("@palautuspvm", formattedPalautuspvm);
            stockupdate.Parameters.AddWithValue("@kirja_id", kirja_id);

            stockupdate.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Palautus kirjattu onnistuneesti");
        }



        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            lainaushistoria f2 = new lainaushistoria();
            f2.ShowDialog(); // Show kirjalista
        }
        //HISTORIATIEDOT
        private void button9_Click_1(object sender, EventArgs e)
        {
            {
                panel4.Visible = true;
                listView2.Items.Clear();
                label19.Visible = false;

                if (!string.IsNullOrEmpty(textBox13.Text))
                {
                    string connectionString = "";
                    string query = "SELECT id, asiakas_tunnus, kirjan_nimi, lainauspvm, palautuspvm FROM lainat WHERE asiakas_tunnus = @textBox13Value";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@textBox13Value", textBox13.Text);

                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string id = reader.IsDBNull(reader.GetOrdinal("id")) ? null : reader.GetString(reader.GetOrdinal("id"));
                            string asiakas_tunnus = reader.GetString(reader.GetOrdinal("asiakas_tunnus"));
                            string kirjan_nimi = reader.IsDBNull(reader.GetOrdinal("kirjan_nimi")) ? null : reader.GetString(reader.GetOrdinal("kirjan_nimi"));
                            DateTime lainauspvm = reader.IsDBNull(reader.GetOrdinal("lainauspvm")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("lainauspvm"));
                            DateTime palautuspvm = reader.IsDBNull(reader.GetOrdinal("palautuspvm")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("palautuspvm"));

                            ListViewItem item = new ListViewItem(new[] { id, asiakas_tunnus, kirjan_nimi, lainauspvm.ToString("yyyy/MM/dd"), palautuspvm.ToString("yyyy/MM/dd") });
                            listView2.Items.Add(item);

                            if (palautuspvm != DateTime.MinValue && (palautuspvm - lainauspvm).TotalDays > 7)
                            {
                                item.BackColor = Color.Red;
                                label19.Visible = true;
                            }
                        }

                        reader.Close();
                    }
                }
            }
        }
    }
}

