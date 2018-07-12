using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Darbu_sarasas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridPildymas(@"select Darbuotojo_Id,(select Vardas  from Darbuotojai where Id = Darbuotojo_Id) AS Vardas, Darbas, Darbo_pr, Darbo_pab from Darbai");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darbau_DBDataSet1.Darbai' table. You can move, or remove it, as needed.
            //    this.darbaiTableAdapter1.Fill(this.darbau_DBDataSet1.Darbai);
            // TODO: This line of code loads data into the 'darbau_DBDataSet.Darbai' table. You can move, or remove it, as needed.
     //       this.darbaiTableAdapter.Fill(this.darbau_DBDataSet.Darbai);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Refresh();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ats_siuntimas f = new ats_siuntimas();
            //   f.Refresh();
            f.Show();

        }

        public void DataGridPildymas(string sqlQuery)
        {
            string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF";
            //    string query = "SELECT * FROM Darbai";

            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                //    string sqlQuery = @"SELECT * FROM Darbai";
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
                sqlConn.Close();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            DataGridPildymas(@"select Darbuotojo_Id,(select Vardas  from Darbuotojai where Id = Darbuotojo_Id) AS Vardas, Darbas, Darbo_pr, Darbo_pab, DATEDIFF(day, Darbo_pr, Darbo_pab) AS Skirta_dienų from Darbai where Darbai.Darbo_pab!=''");
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            DataGridPildymas(@"select Darbuotojo_Id,(select Vardas  from Darbuotojai where Id = Darbuotojo_Id) AS Vardas, Darbas, Darbo_pr, Darbo_pab from Darbai where Darbai.Darbo_pab=''");
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            DataGridPildymas(@"select Darbuotojo_Id,(select Vardas  from Darbuotojai where Id = Darbuotojo_Id) AS Vardas, Darbas, Darbo_pr, Darbo_pab from Darbai");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Darbu_koregavimas f = new Darbu_koregavimas();
            //   f.Refresh();
            f.Show();
        }
    }
}






