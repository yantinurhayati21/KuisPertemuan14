using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace KuisPertemuan14.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection conn;

        public MySqlConnection GetConn() 
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost; user=root; database=kuis14";
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Konek gagal " + ex.Message);
            }
            return conn; 
        }
    }
}
