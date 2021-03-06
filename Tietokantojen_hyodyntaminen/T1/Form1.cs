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

namespace T1
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Opiskelijat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        public void SqlConnectionAvattu()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void SqlConnetionSuljettu()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void LisaaTiedotButton_Click(object sender, EventArgs e)
        {
            SqlConnectionAvattu();

            SqlCommand myCommand = new SqlCommand("SET IDENTITY_INSERT Nimi ON; INSERT INTO Nimi (Id, Nimi, opintoryhma_Id) " +
                                     "Values('" + OpiskelijaIdTextBox.Text + "','" + NimiTextBox.Text + "','" + OpiskelijaryhmanIdTextBox.Text + "') SET IDENTITY_INSERT Nimi OFF;", myConnection);
            myCommand.ExecuteNonQuery();
            SqlConnetionSuljettu();
        }

        private void HaeTiedotButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Opiskelijat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlConnectionAvattu();
                SqlDataAdapter Adapteri = new SqlDataAdapter("SELECT * FROM Nimi", myConnection);
                DataTable Datataulu = new DataTable();
                Adapteri.Fill(Datataulu);
                dataGridView1.DataSource = Datataulu;
                SqlConnetionSuljettu();
            }
        }

        private void PoistaNimiButton_Click(object sender, EventArgs e)
        {
            Poista_Tietue();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void Poista_Tietue()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand delcmd = new SqlCommand();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Opiskelijat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                delcmd.CommandText = "DELETE FROM Nimi WHERE Id=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                conn.Open();
                delcmd.Connection = conn;
                delcmd.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Tietue poistettu!!");
            }
        }

        private void HaeOpiskelijaryhmaButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Opiskelijat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                SqlConnectionAvattu();
                SqlDataAdapter Adapteri = new SqlDataAdapter("SELECT * FROM Opiskelijaryhma", myConnection);
                DataTable Datataulu = new DataTable();
                Adapteri.Fill(Datataulu);
                dataGridView2.DataSource = Datataulu;
                SqlConnetionSuljettu();
            }
        }
    }
}
