using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Batient : Form
    {
        //string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;"
        string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";
        private int lastId = 0;
        public Batient()
        {
            InitializeComponent();
        }

        private async void getLastID()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT PATIENTID FROM PATIENT ORDER BY PATIENTID DESC FETCH FIRST 1 ROW ONLY";

                OracleCommand cmd = new OracleCommand(query, conn);

                try
                {
                    conn.Open();
                    var res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        lastId = int.Parse(res.ToString());
                        b_id.Text = lastId.ToString();
                        conn.Close();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Batient_Load(object sender, EventArgs e)
        {
            getLastID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDateTime = DisChargeDate.Value;
            disChargeDate.Text = DisChargeDate.Value.ToString();
        }
    }
}
