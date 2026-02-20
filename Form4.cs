using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // importer la connexion depuis la classe de connexion
        connexionDB connexion = new connexionDB();
        // la focntion qui charge le combobox
        void chargerComboBox()
        {
            SqlConnection conn = connexion.GetConnexion();
            string requete = "SELECT IdClient, Nom FROM Clients";

            SqlCommand commande = new SqlCommand(requete, conn);

            SqlDataReader reader = commande.ExecuteReader();

            comboBox1.Items.Clear();
            while (reader.Read())
            {
                // le text a afficher dans le comboBox
                comboBox1.Items.Add(
                    reader["idClient"].ToString() + " " + reader["nom"].ToString()
                );
            }

            reader.Close(); // on ferme le lecteur des donnees
        }
        // la methode qui charge les produits dans le combobox produit
        void chargerProduits()
        {
            SqlConnection conn = connexion.GetConnexion();
            string requete = "SELECT IdProduit, Description FROM Produits";

            SqlCommand produits = new SqlCommand(requete, conn);

            SqlDataReader reader = produits.ExecuteReader();

            comboBox2.Items.Clear();
            while (reader.Read())
            {
                // le texte a afficher dans le combobox produit
                comboBox2.Items.Add(
                    reader["idProduit"].ToString() + " " + reader["Description"].ToString()
                );
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chargerComboBox();
            chargerProduits();
            //multiFonctions("SELECT v.IdVente,c.Nom,v.DateVente FROM Vente as v INNER JOIN Clients as c ON c.IdClient=v.IdClient ");


        }

        public static bool IsFormOpen(Type formType)
        {
            return false;
        }

        // la fonction qui nous permet de prendre le premier mot
        public string PrendrePremierMot(string txt)
        {
            string[] mots = txt.Split(' ');
            return mots[0];
        }

        private void addToPanel_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(PrendrePremierMot(comboBox1.Text), comboBox2.Text, textBox2.Text, textBox3.Text);

        }


        public void multiFonctions(string requete)
        {
            SqlConnection con = connexion.GetConnexion();

            SqlCommand cmd = new SqlCommand(requete, con);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();


            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(   // la on ajoute le texte dans la tableau
                    reader[0].ToString(), // Colonne 1
                    reader[1].ToString(),// Colonne 2
                    reader[2].ToString()
                );
            }

            reader.Close();
        }

        private void addToList_Click(object sender, EventArgs e)
        {
            string produits = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Ignorer la dernière ligne vide
                if (row.IsNewRow)
                    continue;

                string idProduit = row.Cells[0].Value.ToString();
                string qtte = row.Cells[2].Value.ToString();
                string pvu = row.Cells[3].Value.ToString();

                produits += idProduit + "," + qtte + "," + pvu + ";";
            }

            //MessageBox.Show(produits);

            connexion.InsererVenteAvecPlusieursProduitsSimple(
                int.Parse(PrendrePremierMot(comboBox1.Text)),
                produits, "Vente enregistrer avec succes");

            multiFonctions("SELECT v.IdVente,c.Nom,v.DateVente FROM Vente as v INNER JOIN Clients as c ON c.IdClient=v.IdClient ");

            dataGridView1.Rows.Clear();
        }

           


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }
    }
    
}
