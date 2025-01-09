using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Patient : Form
    {
        //string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";
        private string connectionString = "User Id=SYSTEM;Password=Ahmad2002;Data Source=localhost:1521/HOSP;Connection Timeout=30;";
        private int lastId = 0;
        public Patient()
        {
            InitializeComponent();
        }

        private async void getLastID()
        {
            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT PATIENTID FROM BDB501.PATIENT ORDER BY PATIENTID DESC FETCH FIRST 1 ROW ONLY";

                OracleCommand cmd = new OracleCommand(query, conn);
                try
                {
                    conn.Open();
                    var res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        lastId = int.Parse(res.ToString()) + 1;
                        p_id.Text = lastId.ToString();
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

        private void Patient_Load(object sender, EventArgs e)
        {
            getLastID();
            //get_doctors_nurse_id();

            DoctorCombo();
            NurseCombo();

        }

        private async void clear()
        {
            p_id.Text = lastId.ToString();
            name.Text = "";
            DisChargeDate.Text = "";
            DisChargeStatus.Text = "";
            Disease.Text = "";
            age.Text = "";
            billAmount.Text = "";
            d_id.Text = "";
            n_id.Text = "";
            DiagnosisType.Text = "";
        }


        private void Add_Click(object sender, EventArgs e)
        {

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    DateTime selectedDateTime = DisChargeDate.Value;

                    // Validate inputs
                    if (int.TryParse(p_id.Text, out int patientId) && patientId > 0
                        && name.Text.Length > 3
                        && !string.IsNullOrEmpty(Disease.Text)
                        && int.TryParse(age.Text, out int patientAge) && patientAge > 0 && patientAge < 150
                        && !string.IsNullOrEmpty(d_id.Text)
                        && !string.IsNullOrEmpty(n_id.Text)
                        && !string.IsNullOrEmpty(DisChargeStatus.Text)
                        && double.TryParse(billAmount.Text, out double billAmountValue) && billAmountValue > 0
                        && !string.IsNullOrEmpty(DiagnosisType.Text))
                    {
                        // Parameterized query
                        string query = "INSERT INTO BDB501.PATIENT (PATIENTID, NAME, DISEASE, AGE, DOCTORID, NURSEID, DISCHARGEDATE, DISCHARGESTATUS, BILLAMOUNT, DIAGNOSISTYPE) " +
                                       "VALUES (:PATIENTID, :NAME, :DISEASE, :AGE, :DOCTORID, :NURSEID, :DISCHARGEDATE, :DISCHARGESTATUS, :BILLAMOUNT, :DIAGNOSISTYPE)";

                        string selectedItemDoctor = d_id.SelectedItem.ToString();
                        int separatorIndexDoctor = selectedItemDoctor.IndexOf('-');
                        string DoctorStr = selectedItemDoctor.Substring(0, separatorIndexDoctor).Trim();
                        string selectedItemNurse = n_id.SelectedItem.ToString();
                        int separatorIndexNurse = selectedItemNurse.IndexOf('-');
                        string NurseStr = selectedItemNurse.Substring(0, separatorIndexNurse).Trim();
                        conn.Open();
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            // Add parameters with correct OracleDbType
                            cmd.Parameters.Add("PATIENTID", OracleDbType.Int32).Value = patientId;
                            cmd.Parameters.Add("NAME", OracleDbType.Varchar2).Value = name.Text.Trim();
                            cmd.Parameters.Add("DISEASE", OracleDbType.Varchar2).Value = Disease.Text.Trim();
                            cmd.Parameters.Add("AGE", OracleDbType.Int32).Value = patientAge;
                            cmd.Parameters.Add("DOCTORID", OracleDbType.Int32).Value = DoctorStr;
                            cmd.Parameters.Add("NURSEID", OracleDbType.Int32).Value = NurseStr;
                            cmd.Parameters.Add("DISCHARGEDATE", OracleDbType.Date).Value = selectedDateTime;
                            cmd.Parameters.Add("DISCHARGESTATUS", OracleDbType.Varchar2).Value = DisChargeStatus.Text.Trim();
                            cmd.Parameters.Add("BILLAMOUNT", OracleDbType.Decimal).Value = billAmountValue;
                            cmd.Parameters.Add("DIAGNOSISTYPE", OracleDbType.Varchar2).Value = DiagnosisType.Text.Trim();

                            // Execute the query
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                p_output.Text = "Adding Is Done";
                                p_output.ForeColor = Color.Green;
                            }
                            else
                            {
                                p_output.ForeColor = Color.Red;
                                p_output.Text = "Something Wrong, Please Try again";
                            }
                        }
                    }
                    else
                    {
                        p_output.Text = "Please Fill All Fields Correctly And Try Again";
                        p_output.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            name.Focus();
            p_output.Text = "Please Fill Again ";
        }
        private void DoctorCombo()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT DOCTOR.EMPLOYEEID, EMPLOYEE.NAME 
                    FROM BDB501.DOCTOR 
                    JOIN BDB501.EMPLOYEE ON DOCTOR.EMPLOYEEID = EMPLOYEE.EMPLOYEEID";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int DoctorID = reader.GetInt32(0);
                                string DoctorName = reader.GetString(1);
                                d_id.Items.Add($"{DoctorID} - {DoctorName}");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString(), "Error: Doctor ID");
                }
            }
        }
        private void NurseCombo()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT NURSE.EMPLOYEEID, EMPLOYEE.NAME 
                    FROM BDB501.NURSE 
                    JOIN BDB501.EMPLOYEE ON NURSE.EMPLOYEEID = EMPLOYEE.EMPLOYEEID";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int NurseID = reader.GetInt32(0);
                                string NurseName = reader.GetString(1);
                                n_id.Items.Add($"{NurseID} - {NurseName}");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString(), "Error: Nurse ID");
                }
            }
        }
        //private void get_doctors_nurse_id()
        //{
        //    n_id.Items.Clear();
        //    using (OracleConnection conn = new OracleConnection(connectionString))
        //    {   //
        //        //string query = "SELECT EMPLOYEEID FORM NURSE ORDER BY EMPLOYEEID ;";
        //        //conn.Open();
        //        //using (OracleCommand cmd = new OracleCommand(query, conn))
        //        //{
        //        //    using (OracleDataReader reader = cmd.ExecuteReader()) 
        //        //}
        //    }
        //
        //    using (OracleConnection conn = new OracleConnection(connectionString))
        //    {
        //        try
        //        {
        //            string query = "SELECT EMPLOYEEID FROM BDB501.NURSE ORDER BY EMPLOYEEID";
        //            conn.Open();
        //            using (OracleCommand cmd = new OracleCommand(query, conn))
        //            {
        //                using (OracleDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //
        //                        n_id.Items.Add(reader["employeeid"]);
        //                    }
        //                    reader.Close();
        //                    conn.Close();
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            conn.Close();
        //            MessageBox.Show(ex.ToString(), "Error: Doctor ID");
        //        }
        //    }
        //
        //
        //    d_id.Items.Clear();
        //
        //    using (OracleConnection conn = new OracleConnection(connectionString))
        //    {
        //        try
        //        {
        //            string query = "SELECT EMPLOYEEID FROM BDB501.DOCTOR ORDER BY EMPLOYEEID";
        //            conn.Open();
        //            using (OracleCommand cmd = new OracleCommand(query, conn))
        //            {
        //                using (OracleDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                       
        //                        d_id.Items.Add(reader["employeeid"]);
        //                    }
        //                    reader.Close();
        //                    conn.Close();
        //                }
        //            }
        //        }catch (Exception ex)
        //        {
        //            conn.Close();
        //            MessageBox.Show(ex.ToString(),"Error: Doctor ID");
        //        }
        //    }
        //
        //   
        //
        //}
        private void check_id(object sender,EventArgs e)
        {
        
            if (sender == d_id)
            {
                try
                {
                    bool t = false;
                    for (int i = 0; i < d_id.Items.Count; i++)
                    {
                        if (d_id.Text.ToString().Trim() == d_id.Items[i].ToString().Trim())
                        {
                            t = true;
                            break;
                        }
                    }
                    if(d_id.Text=="") p_output.Text = "Please Make Sure Doctor Id exsist ..";
                    else if (!t ) { p_output.Text = "Please Make Sure Doctor Id exsist .."; d_id.Focus(); }
                    else { p_output.Text = "Now it is Correct please Complete the Field"; }
                }   
                catch (Exception ex)
                {
                        MessageBox.Show("The Ids Of Doctor Not Avalibele \n" + ex.ToString());
                }
            }else if(sender == n_id) {
                try
                {
                    bool t = false;
                    for(int i = 0; i < n_id.Items.Count; i++)
                    {
                        if (n_id.Text.ToString().Trim() == n_id.Items[i].ToString().Trim())
                        {
                            t = true;
                            break;
                        }
                    }
                    if (n_id.Text == "") { p_output.Text = "Please Make Sure Nurse Id Exsist .. "; }
                    else if (!t) { p_output.Text = "Please Make Sure Nurse Id Exsist .. ";n_id.Focus(); }
                    else { p_output.Text = "Now it is Correct please Complete the Field"; }
                }catch (Exception ex)
                {
                    MessageBox.Show("The Ids Of Nurse Is Not Avalibele");
                }
            }
            
        }
    }
}
