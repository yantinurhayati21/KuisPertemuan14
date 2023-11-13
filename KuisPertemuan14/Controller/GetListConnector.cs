using KuisPertemuan14.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan14.Controller
{
    internal class GetListConnector:Model.Connection
    {
        Connection konek = new Connection();
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = konek.GetConn();
            DataTable table = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
        
    }
}
