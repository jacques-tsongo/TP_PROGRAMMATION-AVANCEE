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
            OleDbConnection conn = connexion.GetConnexion();
            string requete = "SELECT IdClient, Nom FROM Clients";

            OleDbCommand commande = new OleDbCommand(requete, conn);

            OleDbDataReader reader = commande.ExecuteReader();

            comboBox1.Items.Clear();
            while (reader.Read())
            {
                // le text a afficher dans le comboBox
                comboBox1.Items.Add(
                    reader["idClient"].ToString() + "" + reader["nom"].ToString()
                );
            }

            reader.Close(); // on ferme le lecteur des donnees
        }
        // la methode qui charge les produits dans le combobox produit
        void chargerProduits()
        {
            OleDbConnection conn = connexion.GetConnexion();
            string requete = "SELECT IdProduit, Description FROM Produits";

            OleDbCommand produits = new OleDbCommand(requete, conn);

            OleDbDataReader reader = produits.ExecuteReader();

            comboBox2.Items.Clear();
            while (reader.Read())
            {
                // le texte a afficher dans le combobox produit
                comboBox2.Items.Add(
                    reader["idProduit"].ToString() + "" + reader["Description"].ToString()
                );
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public static bool IsFormOpen(Type formType)
        {
            return false;
        }
    }
    
}
