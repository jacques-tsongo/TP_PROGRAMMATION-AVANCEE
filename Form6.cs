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
            CrystalReport2 crystal = new CrystalReport2();

            // recuperation de la connection a la db
            SqlConnection conn = new SqlConnection();
           // conn.ConnectionString = ConfigurationManager.ConnectionStrings[""].toString();

           

        }
    }
}
