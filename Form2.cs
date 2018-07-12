using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Darbu_sarasas
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
 



        }

        private void darbaiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.darbaiBindingSource.EndEdit();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'darbau_DBDataSet.Darbuotojai' table. You can move, or remove it, as needed.
            this.darbuotojaiTableAdapter.Fill(this.darbau_DBDataSet.Darbuotojai);
          

        }
    

        private void button2_Click(object sender, EventArgs e)
        {
      
            this.Close();
            Form1 f = new Darbu_sarasas.Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            string darbuotojo_id = comboBox1.SelectedValue.ToString();
            string darbas = textBox1.Text;
            string darbo_pr = dateTimePicker1.Value.Date.ToString("d");
            //          string darbo_pab = dateTimePicker2.Value.Date.ToString(); 
            string darbo_pab;
            if (dateTimePicker2.Checked == false)
                // darbo_pab  =null;
                darbo_pab = String.Empty;
            else
                darbo_pab = dateTimePicker2.Value.Date.ToString("d"); 

            Boolean existsdata = false;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    if (((TextBox)ctrl).Text != "")
                    {
                        existsdata = true;
                    }
                    else
                    {
                        MessageBox.Show("Užpildykite tuščius laukelius");
                        break;
                    }
                }

                if (ctrl is ComboBox)
                {
                    if (((ComboBox)ctrl) != null)
                    {
                        existsdata = true;
                    }
                    else
                    {
                        MessageBox.Show("Nepasirinkote iš sąrašo");
                        break;
                    }
                }
            }

            if (existsdata == true)
            {

                SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\USERS\VITA\DESKTOP\KURSAI\C\DARBU_SARASAS\DARBAU_DB.MDF");
                string query1 = "Insert into Darbai (Darbuotojo_Id, Darbas, Darbo_pr, Darbo_pab) Values (@darbuotojo_Id,@darbas, @darbo_pr, @darbo_pab)";
                using (SqlCommand com = new SqlCommand(query1, conn))
                {

                    com.Parameters.AddWithValue("@darbuotojo_id", darbuotojo_id);
                    com.Parameters.AddWithValue("@darbas", darbas);
                    com.Parameters.AddWithValue("@darbo_pr", darbo_pr);
                    com.Parameters.AddWithValue("@darbo_pab", darbo_pab);
                   conn.Open();
                    int rezult = com.ExecuteNonQuery();
                    if (rezult < 0)
                    {
                        Console.WriteLine("Nepavyko išsaugoti duomenų!");
                    }
                    MessageBox.Show("Darbas išsaugotas");
                    textBox1.Text="";
                    conn.Close();

                }
            }
        }
     
    }
}
        

