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
    public partial class Darbu_koregavimas : Form
    {
        public Darbu_koregavimas()
        {
            InitializeComponent();
        }



        private void Darbu_koregavimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darbau_DBDataSet.Darbai' table. You can move, or remove it, as needed.
            this.darbaiTableAdapter.Fill(this.darbau_DBDataSet.Darbai);
            // TODO: This line of code loads data into the 'darbau_DBDataSet.Darbai' table. You can move, or remove it, as needed.
            //    this.darbaiTableAdapter.Fill(this.darbau_DBDataSet.Darbai);
            // TODO: This line of code loads data into the 'darbau_DBDataSet.Darbai' table. You can move, or remove it, as needed.
            this.darbaiTableAdapter.Fill(this.darbau_DBDataSet.Darbai);
            DataGridPildymas(@"select Id, Darbuotojo_Id, Darbas, Darbo_pr, Darbo_pab from Darbai");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Darbu_sarasas.Form1();
            f.Show();
        }



   
        private void button2_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string darid = darbuotojo_IdTextBox.Text;
            string darbas = darbasTextBox.Text;
            string darbo_pr = darbo_prTextBox.Text;
            string darbo_pab = darbo_pabTextBox.Text;
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF");
            string query1 = "Update Darbai set Darbuotojo_Id=@darbuotojo_Id, Darbas=@darbas, Darbo_pr=@darbo_pr, Darbo_pab=@darbo_pab where id=@id";
            using (SqlCommand com = new SqlCommand(query1, conn))
            {
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@darbuotojo_id", darid);
                com.Parameters.AddWithValue("@darbas", darbas);
                com.Parameters.AddWithValue("@darbo_pr", darbo_pr);
                com.Parameters.AddWithValue("@darbo_pab", darbo_pab);
                conn.Open();
              com.ExecuteNonQuery();
                MessageBox.Show("Darbas, kurio id="+id+ " redaguotas");
                conn.Close();
                  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF");
            string quert2 = "DELETE FROM Darbai WHERE Id = @id";
            using (SqlCommand com = new SqlCommand(quert2, conn))
            {
                com.Parameters.AddWithValue("@id", id);
                conn.Open();
                com.ExecuteNonQuery();

                conn.Close();
                DataGridPildymas(@"select Id, Darbuotojo_Id, Darbas, Darbo_pr, Darbo_pab from Darbai");
                MessageBox.Show("Darbas, kurio id=" + id + " pašalintas");
            }
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
                darbaiDataGridView.DataSource = new BindingSource(table, null);
                sqlConn.Close();
            }
        }
    }
}

