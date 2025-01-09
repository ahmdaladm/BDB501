using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
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
    public partial class Clinics_Labs : Form
    {
        private string connectionString = "User Id=SYSTEM;Password=Ahmad2002;Data Source=localhost:1521/HOSP;Connection Timeout=30;";
        int last_ClinicID = 0;
        int last_LabID = 0;
        public Clinics_Labs()
        {
            InitializeComponent();
        }
        private async void Clinic_Lab_Load(object sender, EventArgs e)
        {
            Get_Last_LabID_ClinicID();
            ComboClinic();
        }
        private async void InsertClinic(object sender, EventArgs e)
        {
            try
            {
                if (Clinic_id.Text.Length > 0
                    && txtClinicName.Text.Length > 5
                    && txtPhone.Text.Length > 9)
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {

                        conn.Open();
                        OracleTransaction transatcionClinic = conn.BeginTransaction();
                        try
                        {
                            string clinicquery = "INSERT INTO BDB501.CLINIC (CLINICID,NAME,PHONENUMBER) VALUES " + $"({Clinic_id.Text.ToString().Trim()}, '{txtClinicName.Text.ToString().Trim()}', '{txtPhone.Text.ToString().Trim()}')";
                            OracleCommand cmd = new OracleCommand(clinicquery, conn);
                            cmd.Transaction = transatcionClinic;
                            cmd.ExecuteNonQuery();
                            lbltransaction.ForeColor = System.Drawing.Color.Green;
                            lbltransaction.Text = "Adding Clinics Is Completed";
                            transatcionClinic.Commit();
                            Get_Last_LabID_ClinicID();
                            Clear();
                        }
                        catch (Exception ex) { MessageBox.Show("Invalide Entry Please try again"); }
                    }

                }
                else
                {
                    lbltransaction.Text = "Please Fill All Fields Correctly And Try Again";
                    lbltransaction.ForeColor = Color.Red;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.ToString()); }
        }
        private async void InsertLab(object sender, EventArgs e)
        {
            try
            {
                if (Lab_ID.Text.Length > 0
                    && txtNumberRoom.Text.Length > 0
                    && txtequipment.Text.Length > 0
                    && !string.IsNullOrEmpty(comboClinic.Text))
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        using (OracleTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                string selectedItemClinic = comboClinic.SelectedItem.ToString();
                                int separatorIndexClinic = selectedItemClinic.IndexOf('-');
                                int clinicID = Convert.ToInt32(selectedItemClinic.Substring(0, separatorIndexClinic).Trim());

                                string insertQuery = "INSERT INTO BDB501.LAB (LABID, CLINICID, NUMBEROFROOMS, EQUIPMENT) VALUES (:LabID, :ClinicID, :NumberOfRooms, :Equipment)";
                                using (OracleCommand cmd = new OracleCommand(insertQuery, conn))
                                {
                                    cmd.Transaction = transaction;

                                    cmd.Parameters.Add(":LabID", OracleDbType.Int32).Value = Convert.ToInt32(Lab_ID.Text.Trim());
                                    cmd.Parameters.Add(":ClinicID", OracleDbType.Int32).Value = clinicID;
                                    cmd.Parameters.Add(":NumberOfRooms", OracleDbType.Int32).Value = Convert.ToInt32(txtNumberRoom.Text.Trim());
                                    cmd.Parameters.Add(":Equipment", OracleDbType.Varchar2).Value = txtequipment.Text.Trim();

                                    cmd.ExecuteNonQuery();
                                    lblLab.ForeColor = System.Drawing.Color.Green;
                                    lblLab.Text = "Adding Lab Is Completed";
                                }

                                transaction.Commit();
                                Get_Last_LabID_ClinicID();
                                Clear();          
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    lblLab.Text = "Please Fill All Fields Correctly And Try Again";
                    lblLab.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.ToString());
            }
        }
        private void Clear()
        {
            txtClinicName.Text = string.Empty;
            txtClinicName.Focus();
            txtPhone.Text = string.Empty;
            txtequipment.Text = string.Empty;
            txtNumberRoom.Text = string.Empty;
            comboClinic.Text = string.Empty;
            lbltransaction.ForeColor = System.Drawing.Color.White;
            lbltransaction.Text = "Please Enter The Clinic Data";
            lblLab.ForeColor = System.Drawing.Color.White;
            lblLab.Text = "Please Enter Lab Data";
        }
        private void btnclear_click(object sender, EventArgs e)
        {
            Clear();
        }
        private async void Get_Last_LabID_ClinicID()
        {
            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    string clinicIDquery = "SELECT CLINICID FROM BDB501.CLINIC ORDER BY CLINICID DESC FETCH FIRST 1 ROW ONLY";

                    OracleCommand cmd = new OracleCommand(clinicIDquery, conn);
                    try
                    {
                        conn.Open();
                        var res = cmd.ExecuteScalar();
                        if (res != null)
                        {
                            last_ClinicID = int.Parse(res.ToString()) + 1;
                            Clinic_id.Text = last_ClinicID.ToString();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.ToString());
                    }
                    string LabIDquery = "SELECT LABID FROM BDB501.LAB ORDER BY LABID DESC FETCH FIRST 1 ROW ONLY";

                    OracleCommand cmd2 = new OracleCommand(LabIDquery, conn);
                    try
                    {
                        conn.Open();
                        var res = cmd2.ExecuteScalar();
                        if (res != null)
                        {
                            last_LabID = int.Parse(res.ToString()) + 1;
                            Lab_ID.Text = last_LabID.ToString();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show(ex.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void ComboClinic()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT CLINIC.CLINICID, CLINIC.NAME 
                    FROM BDB501.CLINIC
                    ORDER BY CLINIC.CLINICID ASC";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int ClinicID = reader.GetInt32(0);
                                string ClinicName = reader.GetString(1);
                                comboClinic.Items.Add($"{ ClinicID} - {ClinicName}");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.ToString(), "Error: Clinic ID");
                }
            }
        }
    }
}
