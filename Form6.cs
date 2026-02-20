using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();
        }


        public static bool IsFormOpen(Type formType)
        {
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    // 1️⃣ Création du rapport
                    CrystalReport2 rapport = new CrystalReport2(); // 2️⃣ Chargement du rapport dans le CrystalReportViewer
                    crystalReportViewer1.ReportSource = rapport; // 3️⃣ Rafraîchir l'affichage crystalReportViewer1 . Actualiser ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                    // }  
                }
        }
    }
}
