using System;
using System.Data;
using System.Numerics;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace WinFormsApp1
{
    public partial class Selects : Form
    {
        private string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";
        //private string connectionString = "User Id=SYSTEM;Password=Ahmad2002;Data Source=localhost:1521/HOSP;Connection Timeout=30;";

        public Selects()
        {
            //private string num1= TextBox1.Text;
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Attempting to connect...");
                    MessageBox.Show("Connection successful!");

                    //string query = "SELECT * FROM BDB501.Doctor";
                    string query = "SELECT DOCTOR.EMPLOYEEID AS d_id, NURSE.EMPLOYEEID AS n_id FROM DOCTOR INNER JOIN NURSE ON DOCTOR.EMPLOYEEID <> NURSE.EMPLOYEEID;";
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
                    string query = @"SELECT SUM(BillAmount) AS TotalAmount 
                                    FROM BDB501.Patient 
                                    WHERE Disease LIKE '%Liver Cirrhosis%' 
                                    AND EXTRACT(YEAR FROM DischargeDate) = 2024";
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
                    string query = @"SELECT BDB501.Employee.Name AS DoctorName, SUM(BDB501.Patient.BillAmount) AS TotalSurgeryAmount FROM BDB501.Employee JOIN BDB501.Doctor ON BDB501.Employee.EmployeeID = BDB501.Doctor.EmployeeID JOIN BDB501.Patient ON BDB501.Doctor.EmployeeID = BDB501.Patient.DoctorID WHERE EXTRACT(YEAR FROM BDB501.Patient.DischargeDate) = 2024 GROUP BY BDB501.Employee.Name ORDER BY TotalSurgeryAmount DESC FETCH FIRST 1 ROW ONLY";


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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Batient batient = new Batient();
            batient.Show();
        }
    }
}