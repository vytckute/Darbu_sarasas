using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;

namespace Darbu_sarasas
{
    public partial class ats_siuntimas : Form
    {
        public ats_siuntimas()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            laisko_siuntimas("Neatlikti", "neatliktų", @"select  Darbas from Darbai where Darbai.Darbo_pab='' and Darbuotojo_Id=@value");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            laisko_siuntimas("Atlikti", "atliktų", @"select  Darbas from Darbai where Darbai.Darbo_pab!='' and Darbuotojo_Id=@value");
        }

        private void ats_siuntimas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darbau_DBDataSet.Darbuotojai' table. You can move, or remove it, as needed.
            this.darbuotojaiTableAdapter.Fill(this.darbau_DBDataSet.Darbuotojai);
            //     GridPildymasnuoCombobox();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            laisko_siuntimas("Visi", "visų", @"select  Darbas from Darbai where Darbuotojo_Id=@value");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Darbu_sarasas.Form1();
            f.Show();
        }

        public string pastoadresas()
        {
            SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF");
            string to = string.Empty; ;
            string darbuotojo_id = comboBox1.SelectedValue.ToString();
            string querystring1 = "SELECT Elpastas from Darbuotojai where Id=@id";
            using (SqlCommand command = new SqlCommand(querystring1, sql))
            {
                SqlDataReader reader = null;
                command.Parameters.AddWithValue("@id", darbuotojo_id);
                sql.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    to = reader["Elpastas"].ToString();
                }
                sql.Close();
                return to;
            }

        }
        public void laisko_siuntimas(string tekstas1, string tekstas2, string select)
        {
            string darbuotojo_id = comboBox1.SelectedValue.ToString();
            string vardas = comboBox1.Text.ToString();

            var fromEmail = ConfigurationSettings.AppSettings["mail"];
            var fromPassword = ConfigurationSettings.AppSettings["pass"];
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                SqlConnection sql = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF");
                string from = "lukosienei.v@gmail.com";
                string to = pastoadresas();
                 string subject = tekstas1 + " darbai";
                string body = "Sveiki, " + vardas + ",\nsiunčiame " + tekstas2 + " darbų ataskaitą:" + "\n";


                SqlDataAdapter thisAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(select, sql);
                command.Parameters.Add("@value", darbuotojo_id);
                thisAdapter.SelectCommand = command;
                DataSet DataSet = new DataSet(); thisAdapter.Fill(DataSet, "Darbas");
                foreach (DataRow Row in DataSet.Tables["Darbas"].Rows)
                {
                    body = body + "\n" + Row["Darbas"];
                }
                if (DataSet.Tables[0].Rows.Count != 0)
                {
                    smtp.Port = 587;
                  smtp.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);
                                      smtp.EnableSsl = true;
                    smtp.Send(from, to, subject, body);
                    MessageBox.Show("Ataskaita išsiųsta");
                }
                else { MessageBox.Show("Ataskaita neišsiųsta, nes nėra " + tekstas2 + " darbų!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public void GridPildymasnuoCombobox()
        {
            string darbuotojo_id = comboBox1.SelectedValue.ToString();
            string vardas = comboBox1.Text.ToString();
            string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF";
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                string sqlQuery = @"SELECT * FROM Darbai where Darbuotojo_Id=@Value";

                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                cmd.Parameters.Add("@Value", darbuotojo_id);
                sqlConn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = new BindingSource(table, null);
                sqlConn.Close();
            }
            label1.Text = vardas + " visi darbai";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                GridPildymasnuoCombobox();
            }
        }    
        }
    }


