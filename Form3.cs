using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // on affiche les donnees lors du chargement du formulaire
            multiFonctions("SELECT * FROM Produits");
            
        }
        public static bool IsFormOpen(Type formType)
        {
            return false;
        }
        // la variable de connexion a la base de donnees
        connexionDB connexion = new connexionDB();   // on recupere la variable qui contient la chaine de connexion
        private void enreg_Click(object sender, EventArgs e)
        {
            connexion.ExecuterCommande("insert into Produits(Description,Prix_unitaire_de_vente) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')", "Produit enregistré avec succès");
            // on reaffiche les donnees apres insertion des produits
            multiFonctions("select * from Produits");
        }

        // la methode qui lit les donnees depuis la DB
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

        private void suppr_Click(object sender, EventArgs e)
        {
            multiFonctions("update Produits set Description ='" + textBox1.Text + "', Prix_unitaire_de_vente = '" + textBox2.Text + "' where IdProduit = '" + int.Parse(id_produit.Text) + "' "); // la on vient de faire la mise a jour (modeification) des donnees
            multiFonctions("select * from Produits");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // on verifie si la ligne clickee contient des contenues
            {
                var selectedRow = dataGridView1.SelectedRows[0];   // puis on chargent tout les contenues dans une variable 
                id_produit.Text = selectedRow.Cells[0].Value.ToString(); // on charge l'id du client cible
                textBox1.Text = selectedRow.Cells[1].Value.ToString(); // la on passe dans chaque champ la  valeur y relatif
                textBox2.Text = selectedRow.Cells[2].Value.ToString(); // la on passe dans chaque champ la  valeur y relatif
            }
        }

        private void modif_Click(object sender, EventArgs e)
        {
            string proIdDelete = Interaction.InputBox("ENTRER L'IDENTIFIANT DU PRODUIT A SUPPRIMER");
            multiFonctions("delete from Produits where IdProduit = '"+ proIdDelete +"' ");
            multiFonctions("select * from Produits");
        }
    }
}
