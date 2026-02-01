using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAVAIL_PROGRAMMATION_AVANCEE
{
    internal class Connexion
    {
        private OleDbConnection conn;
        public Connexion()
        {
            conn = new OleDbConnection(@"Provider=SQLOLEDB; Data Source=.; Initial Catalog=GestionBoutique; Integrated Security=SSPI; Persist Security Info=False;Connect Timeout=30;");
            //conn = new OleDbConnection(@"Provider = SQLOLEDB; Data source = .; Initial Catalog = GestionBoutique; User ID = sa; passord = jacques@server; Persisty Security Info = false");
        }

        public OleDbConnection GetConnexion()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            return conn;
        }

        public void FermerConnexion()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }
    }
}
