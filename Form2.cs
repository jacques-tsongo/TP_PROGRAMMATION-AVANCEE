using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            multiFonctions("SELECT * FROM Clients order by nom asc");
        }
        // la creation d'une methode
        public static bool IsFormOpen(Type formType)
        {
            return false;
        }

        // la variable de connexion est déclarée ici
        connexionDB connexion = new connexionDB();
        private void enreg_Click(object sender, EventArgs e)
        {
            connexionDB cmd = new connexionDB();
            cmd.ExecuterCommande("INSERT INTO Clients(Nom,Adresse) VALUES('" + textBox2.Text + "','" + textBox3.Text + "')", "Client enregistré avec Succes");
            multiFonctions("SELECT * FROM Clients order by nom asc");
        }

        // declaration d'une methode qui me sert de faire plusieurs fonctions de crud
        void multiFonctions(string requete)
        {
            OleDbConnection con = connexion.GetConnexion();

            // string requete = "SELECT * FROM Clients";
            OleDbCommand cmd = new OleDbCommand(requete, con);

            OleDbDataReader reader = cmd.ExecuteReader();

            reader.Read();


            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(   // la on ajoute le texte dans la tableau
                    reader[0].ToString(), // Colonne 1
                    reader[1].ToString(), // Colonne 2
                    reader[2].ToString()  // Colonne 3
                );
            }

            reader.Close();
        }

        // la methode qui vide le champs apres insertion ou miase ajour
        public void viderChamps()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // on verifie si la ligne clickee contient des contenues
            {
                var selectedRow = dataGridView1.SelectedRows[0];   // puis on chargent tout les contenues dans une variable 
                textBox1.Text = selectedRow.Cells[0].Value.ToString(); // on charge l'id du client cible
                textBox2.Text = selectedRow.Cells[1].Value.ToString(); // la on passe dans chaque champ la  valeur y relatif
                textBox3.Text = selectedRow.Cells[2].Value.ToString(); // la on passe dans chaque champ la  valeur y relatif
            }
        }

        private void suppr_Click(object sender, EventArgs e)
        {
            string deletedObject = Interaction.InputBox("entrer le nom a supprimer");
            multiFonctions("delete  from Clients where nom = '"+ deletedObject +"' ");
            multiFonctions("select * from Clients order by nom asc");
        }

        private void modif_Click(object sender, EventArgs e)  // on cree un evenement de click
        {
            multiFonctions("update Clients set nom ='" + textBox2.Text + "', adresse = '" + textBox3.Text + "' where IdClient = '"+ int.Parse(textBox1.Text)+"' "); // la on vient de faire la mise a jour (modeification) des donnees
            multiFonctions("select * from Clients order by nom asc");
        }
    }
}
