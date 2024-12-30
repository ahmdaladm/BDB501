using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //private string connectionString = "User Id=SYSTEM;Password=Adam1234;Data Source=localhost:1521/orcl;Connection Timeout=30;";
        private string connectionString = "User Id=SYSTEM;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";

        public Form1()
        {
            //private string num1= TextBox1.Text;
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await  using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Attempting to connect...");
                    MessageBox.Show("Connection successful!");

                    string query = "SELECT * FROM DOCTOR";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                label1.Text = "Fetch of data is done.";
            }
        }
        private async void select_one(object sender, EventArgs e)
        {

            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Attempting to connect...");
                    MessageBox.Show("Connection successful!");

                    string query =  "SELECT SUM(BillAmount) AS TotalAmount FROM Patients"+
                                    "WHERE Disease LIKE '%Liver%'"+
                                    "AND EXTRACT(YEAR FROM DischargeDate) = 2024;";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                label1.Text = "Fetch of data is done.";
            }
        }
        private async void Select_two(object sender, EventArgs e)
        {
            
            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Attempting to connect...");
                    MessageBox.Show("Connection successful!");

                    string query = "SELECT d.Name AS DoctorName, COUNT(s.SurgeryID) AS SurgeryCount, SUM(s.AmountCharged) AS TotalAmount" +
                        "FROM Doctors d JOIN Surgeries s ON d.EmployeeID = s.DoctorID" +
                        "WHERE EXTRACT(YEAR FROM s.SurgeryDate) = 2024" +
                        "GROUP BY d.Name ORDER BY SurgeryCount DESC FETCH FIRST 1 ROWS ONLY;";
                    OracleCommand cmd = new OracleCommand(query, conn);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Oracle error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                label1.Text = "Fetch of data is done.";
            }

        }
        
    }
}