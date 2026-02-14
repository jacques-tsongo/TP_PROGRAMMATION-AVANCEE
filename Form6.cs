using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CrystalReport2 crystal = new CrystalReport2();

            // recuperation de la connection a la db
            connexionDB conn = new connexionDB();
            conn.GetConnexion();

        }
    }
}
