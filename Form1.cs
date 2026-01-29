using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Variable qui garde la référence du formulaire actuellement affiché
        // dans le panneau central
        private Form activeForm = null;

        // Méthode qui permet d'afficher un formulaire enfant
        // dans le panneau central (pnlCentraleFrmmain)
        private void callMultiForm(Form chilForm)
        {
            // Si un formulaire est déjà ouvert dans le panneau,
            // on le ferme avant d'en afficher un autre
            if (activeForm != null)
                activeForm.Close();

            // Le nouveau formulaire devient le formulaire actif
            activeForm = chilForm;

            // Indique que le formulaire ne sera pas affiché
            // comme une fenêtre indépendante
            chilForm.TopLevel = false;

            // Suppression de la bordure du formulaire
            // pour qu'il s'intègre dans le panneau
            chilForm.FormBorderStyle = FormBorderStyle.None;

            // Le formulaire occupe tout l'espace du panneau central
            chilForm.Dock = DockStyle.Fill;

            // Ajout du formulaire dans le panneau central
            panel1.Controls.Add(chilForm);

            // Stockage du formulaire dans la propriété Tag du panneau
            panel1.Tag = chilForm;

            // Le formulaire est placé au premier plan
            chilForm.BringToFront();

            // Affichage du formulaire
            chilForm.Show();
        }

        // Méthode appelée lorsqu'on veut afficher le formulaire des clients
        private void call_client()
        {
            // Cette méthode permet d'afficher le formulaire "frmClients"
            // une seule fois (éviter les doublons)
            try
            {
                // Vérifie si le formulaire frmClients n'est pas déjà ouvert
                if (!Form2.IsFormOpen(typeof(Form2)))
                {
                    // Si le formulaire n'est pas ouvert,
                    // on l'affiche dans le panneau central
                    callMultiForm(new Form2());
                }
                else
                {
                    // Si le formulaire est déjà ouvert,
                    // on ne fait rien
                }
            }
            catch
            {
                // Capture silencieuse des erreurs
                // (non recommandée en production)
            }
        }

        private void call_produits()
        {
            //fonction executer lorsqu'on veut faire afficher un frm specifique et ça une selle fois
            try
            {
                if (!Form3.IsFormOpen(typeof(Form3)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Form3());
                    //...
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }

        private void call_ventes()
        {
            //fonction executer lorsqu'on veut faire afficher un frm specifique et ça une selle fois
            try
            {
                if (!Form4.IsFormOpen(typeof(Form4)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Form4());
                    //...
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }


        // la creation de la varaible de connexion
        OleDbConnection connexion = new OleDbConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            //la connexion a la base de donnees
            try
            {
                connexion.ConnectionString = @"Provider=SQLOLEDB;Data Source=.; Initial Catalog=GestionBoutique;User ID=sa; password=jacques@2004;Persist Security Info=false";
                connexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur survenue est : "+ex.Message);
            }
        }

        private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // appel de la methode qui va ouvrir la fenetre client dans le panel
            call_client();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // appel de la methode qui va ouvrir la fenetre produit dans le panel
            call_produits();
        }

        private void ventesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // appel de la methode qui va ouvrir la fenetre vente dans le panel
            call_ventes();
        }
    }
}
