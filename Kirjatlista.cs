using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqltest2
{
    public partial class Kirjatlista : Form
    {
        public Kirjatlista()
        {
            InitializeComponent();

            //katsotaan klikataanko boxia ja kutsutaan aliohjelmaa. Valinta ID 
            listView1.View = View.Details;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Kirjan_nimi", 150);
            listView1.Columns.Add("Kirjailija", 150);
            listView1.Columns.Add("Julkaisuvuosi", 100);
            listView1.Columns.Add("ISBN_tunnus", 150);
            listView1.Columns.Add("Saldo", 100);

            listView1.FullRowSelect = true;
        }
        //yhteysasetukset
        MySqlConnection connection = new MySqlConnection("");
        //päivttää kirjalistan listboxeihin, ja luo yhteyden tietokantaan.
        private void button1_Click(object sender, EventArgs e)
        {
            // clear the listview
            listView1.Items.Clear();

            // query the database
            string query = "SELECT * FROM kirjat";
            MySqlCommand command = new MySqlCommand(query, connection);

            // open the connection
            connection.Open();

            // execute the query
            MySqlDataReader reader = command.ExecuteReader();

            // loop through the results
            while (reader.Read())
            {
                // get the values from the database
                string id = reader.GetString("id");
                string Kirjan_nimi = reader.GetString("Kirjan_nimi");
                string Kirjailija = reader.GetString("Kirjailija");
                string Julkaisuvuosi = reader.GetString("Julkaisuvuosi");
                string ISBN_tunnus = reader.GetString("ISBN_tunnus");
                string saldo = reader.GetString("stock");

                // create a new listview item and add the values
                ListViewItem item = new ListViewItem(new string[] { id, Kirjan_nimi, Kirjailija, Julkaisuvuosi, ISBN_tunnus, saldo });

                // add the item to the listview
                listView1.Items.Add(item);
            }

            // close the reader and connection
            reader.Close();
            connection.Close();
        }


        //tyhjenna listboxit. Kutsutaan kirjalistan päivittäessä.

        //sulkee kirjalistan
        private void button2_Click(object sender, EventArgs e)
        {
            //Sulkee kirjalistan
            Kirjatlista f3 = new Kirjatlista();
            f3.Show();
            this.Close();
        }
        //päivittää listboxin valintoja
        private void label7_Click(object sender, EventArgs e)
        {
            //EIVOI POISTAA RIKKOO KOKO PAS**N
        }
        //kirjan lisäys tietokantaan
        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string kirjannimi = textBox2.Text;
            string kirjailija = textBox3.Text;
            string julkaisuvuosi = textBox4.Text;
            string ISBN = textBox5.Text;
            string saldo = textBox6.Text;

            //katsotaan onko kentät tyhjiä
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(kirjannimi) || string.IsNullOrWhiteSpace(julkaisuvuosi) || string.IsNullOrWhiteSpace(ISBN) || string.IsNullOrWhiteSpace(saldo) || string.IsNullOrWhiteSpace(kirjailija))
            {
                MessageBox.Show("Täytäthän kaikki kentät ennen kirjan lisäystä");
                return;
            }
            //katsotaan onko tekstikentät int
            if (!int.TryParse(julkaisuvuosi, out int julkaisuvuosiInt))
            {
                MessageBox.Show("Julkaisuvuosi must be a valid integer.");
                return;
            }

            string connectionString = "";
            string query = "INSERT INTO kirjat (id, Kirjan_nimi, Kirjailija, Julkaisuvuosi, ISBN_tunnus, Stock) VALUES (@id, @kirjan_nimi, @kirjailija, @julkaisuvuosi, @isbn_tunnus, @stock)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@kirjan_nimi", kirjannimi);
                command.Parameters.AddWithValue("@kirjailija", kirjailija);
                command.Parameters.AddWithValue("@julkaisuvuosi", julkaisuvuosi);
                command.Parameters.AddWithValue("@isbn_tunnus", ISBN);
                command.Parameters.AddWithValue("@stock", saldo);

                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Uusi kirja lisätty onnistuneesti");
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }




    }
}

