using KuisPertemuan14.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan14
{
    public partial class Form1 : Form
    {
        GetListConnector logcon;

        public Form1()
        {
            logcon = new GetListConnector();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtEmail.Text == " ") || (txtPsw.Text == " "))
            {
                MessageBox.Show("Need login data", " Wrong login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string name= txtEmail.Text;
                string pass= txtPsw.Text;
                DataTable table = logcon.getList(new MySqlConnector.MySqlCommand
                    ("select * from admin where email = '" + name + "' ND pass ='"));

                if(table.Rows.Count > 0)
                {
                    Form1 form = new Form1();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Failed", " Wrong login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
