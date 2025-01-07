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
    public partial class Batient : Form
    {
        string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";
        //string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";
        private int lastId = 0;
        public Batient()
        {
            InitializeComponent();
        }

        private async void getLastID()
        {
            await using (OracleConnection conn = new OracleConnection(connectionString))
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

        private void Batient_Load(object sender, EventArgs e)
        {
            getLastID();
            get_doctors_nurse_id();
            

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
                       
                    if (int.Parse(p_id.Text) > 0
                        && name.Text.Length > 3
                        && Disease.Text != null
                        && int.Parse(age.Text) > 0 && int.Parse(age.Text) < 150
                        && int.Parse(d_id.Text.ToString()) > 0
                        && int.Parse(n_id.Text.ToString()) > 0
                        && DisChargeStatus.Text != null
                        && double.Parse(billAmount.Text) > 0
                        && DiagnosisType.Text != null
                        )
                    {
                        string query = "INSERT INTO BDB501.PATIENT (PATIENTID,NAME,DISEASE,AGE,DOCTORID,NURSEID,DISCHARGEDATE,DISCHARGESTATUS,BILLAMOUNT,DIAGNOSISTYPE)" +
                            $" VALUES ({p_id.Text},'{name.Text.Trim()}','{Disease.Text.Trim()}',{age.Text.Trim()},{d_id.Text.Trim()},{n_id.Text.Trim()}" +
                            $",':date_time_value','{DisChargeStatus.Text.Trim()}',{billAmount.Text.Trim()},'{DiagnosisType.Text.Trim()}')";

                        conn.Open();
                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.Parameters.Add("date_time_value", OracleDbType.Date).Value = selectedDateTime.ToString("yyyy-MM-dd");
                            if (cmd.ExecuteScalar()!=null)
                            {
                                p_output.Text = "Adding Is Done";
                                p_output.ForeColor = Color.Green;
                            }
                            else
                            {
                                p_output.ForeColor= Color.Red;
                                p_output.Text = "Something Wrong ,Please Try again ";
                            }
                        }
                    }
                    else
                    {
                        p_output.Text = "Please Fill All Fild, And Try again ";
                        p_output.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
            name.Focus();
            p_output.Text = "Please Fill Again ";
        }
        private void get_doctors_nurse_id()
        {
            n_id.Items.Clear();
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                string query = "SELECT EMPLOYEEID FORM NURSE ORDER BY EMPLOYEEID ;";
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using(OracleDataReader reader = cmd.ExecuteReader)
                }
            }



                d_id.Items.Clear();

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    string query = "SELECT EMPLOYEEID FROM DOCTOR ORDER BY EMPLOYEEID";
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               
                                d_id.Items.Add(reader["employeeid"]);
                            }
                            reader.Close();
                            conn.Close();
                        }
                    }
                }catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString(),"Error: Doctor ID");
                }
            }

           

        }
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
                    if(d_id.Text=="") p_output.Text = "Please Make Sure Doctor Id is exsist ..";
                    else if (!t ) { p_output.Text = "Please Make Sure Doctor Id is exsist .."; d_id.Focus(); }
                    else { p_output.Text = "Now it is Correct please Complete the Fild"; }
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
                    if (n_id.Text == "") { p_output.Text = "Please Make Sure Nurse Id Is Exsist .. "; }
                    else if (!t) { p_output.Text = "Please Make Sure Nurse Id Is Exsist .. ";n_id.Focus(); }
                    else { p_output.Text = "Now it is Correct please Complete the Fild"; }
                }catch (Exception ex)
                {
                    MessageBox.Show("The Ids Of Nurse Not Avalibele");
                }
            }
            
        }
       
    }
}
