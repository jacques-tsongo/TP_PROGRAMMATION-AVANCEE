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
using System.Data.SqlClient;

namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        //OleDbConnection connexion = new OleDbConnection();
        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                // variable de connexion
                connection = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=GestionBoutique; Integrated Security=True;");


                //connexion.ConnectionString = @"Provider=SQLOLEDB;Data Source=.; Initial Catalog=GestionBoutique;User ID=sa; password=jacques@server;Persist Security Info=false";
                //connexion.Open();
                MessageBox.Show("ca tient deja");
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'erreur survenue est : " + ex.Message);
            }
        }
    }
}
