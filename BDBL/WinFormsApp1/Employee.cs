using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Employee : Form
    {
        //private string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";
        private string connectionString = "User Id=SYSTEM;Password=Ahmad2002;Data Source=localhost:1521/HOSP;Connection Timeout=30;";
        private int last_id = 0;
        public Employee()
        {
            InitializeComponent();
        }

        private async void chose_major(object sender, EventArgs e)
        {
            if (radio_doctor.Checked)
            {
                d_yoe.Enabled = true;
                n_wh.Enabled = false;
            }
            else
            {
                d_yoe.Enabled = false;
                n_wh.Enabled = true;
            }
        }

        private async void Employee_Load(object sender, EventArgs e)
        {
            getLastId();
            ClinicCombo();
        }

        //private async void insert_employee(object sender, EventArgs e)
        //{
        //
        //    try
        //    {
        //
        //
        //        if (id.Text.Length > 0
        //            && name.Text.Length > 3
        //            && salary.Text.Length > 3
        //            && double.Parse(salary.Text.ToString()) > 0
        //            && address.Text.Length > 3
        //            && phone.Text.Length > 9
        //            && double.Parse(phone.Text.ToString()) > 0
        //            )
        //        {
        //            string query = "INSERT INTO BDB501.EMPLOYEE (EMPLOYEEID,NAME,SALARY,ADDRESS,PHONENUMBER) VALUES"
        //                + $"({last_id.ToString().Trim()},'{name.Text.ToString().Trim()}',{salary.Text.ToString().Trim()},'{address.Text.ToString().Trim()}','{phone.Text.ToString().Trim()}')";
        //            using (OracleConnection conn = new OracleConnection(connectionString))
        //            {
        //
        //                OracleCommand cmd = new OracleCommand(query, conn);
        //                try
        //                {
        //                    conn.Open();
        //                    if (cmd.ExecuteScalar() != null)
        //                    {
        //                        e_output.ForeColor = System.Drawing.Color.Green;
        //                        e_output.Text = "Addig Employee is Done ";
        //                    }
        //                    conn.Close();
        //                }
        //                catch (Exception ex)
        //                {
        //                    conn.Close();
        //                    MessageBox.Show(ex.ToString());
        //                }
        //            }
        //
        //            if (radio_doctor.Checked && double.Parse(d_yoe.Text) > 0)
        //            {
        //
        //                query = $"INSERT INTO BDB501.DOCTOR (EMPLOYEEID,YEARSOFEXPERIENCE) VALUES ({id.Text.ToString().Trim()},{d_yoe.Text.ToString().Trim()})";
        //
        //                using (OracleConnection conn = new OracleConnection(connectionString))
        //                {
        //                    OracleCommand cmd = new OracleCommand(query, conn);
        //                    try
        //                    {
        //                        conn.Open();
        //                        if (cmd.ExecuteNonQuery() != null)
        //                        {
        //                            e_output.ForeColor = System.Drawing.Color.Green;
        //                            e_output.Text = "adding to doctor done";
        //                            clear();
        //                            getLastId();
        //                        }
        //                        else
        //                        {
        //                            e_output.ForeColor = System.Drawing.Color.Red;
        //                            e_output.Text = "something be wrong, please try again";
        //                        }
        //                        conn.Close();
        //
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        conn.Close();
        //                        MessageBox.Show(ex.ToString());
        //
        //                    }
        //                }
        //            }
        //            else if (radio_nurse.Checked && double.Parse(n_wh.Text) > 0)
        //            {
        //                query = $"INSERT INTO BDB501.NURSE (EMPLOYEEID,WORKINGHOURS)  VALUES ({id.Text.ToString().Trim()},{n_wh.Text.ToString().Trim()})";
        //
        //                using (OracleConnection conn = new OracleConnection(connectionString))
        //                {
        //                    OracleCommand cmd = new OracleCommand(query, conn);
        //                    try
        //                    {
        //                        conn.Open();
        //                        if (cmd.ExecuteNonQuery() != null)
        //                        {
        //                            e_output.ForeColor = System.Drawing.Color.Green;
        //                            e_output.Text = "adding to doctor done";
        //                            clear();
        //                            getLastId();
        //                        }
        //                        else
        //                        {
        //                            e_output.ForeColor = System.Drawing.Color.Red;
        //                            e_output.Text = "something be wrong, please try again";
        //
        //                        }
        //                        conn.Close();
        //
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        conn.Close();
        //                        MessageBox.Show(ex.ToString());
        //
        //                    }
        //                }
        //            }
        //            //SELECTING THE CLINIC AND INSERTING INTO WORKSIT TABLE LOGIC
        //
        //            string selectedItem = comboBoxClinic.SelectedItem.ToString();
        //            int separatorIndex = selectedItem.IndexOf('-');
        //            string clinicIDStr = selectedItem.Substring(0, separatorIndex).Trim();
        //            string insertQuery = $"INSERT INTO BDB501.WORKSIN (EMPLOYEEID, CLINICID) VALUES ({id.Text.ToString().Trim()},{clinicIDStr})";
        //            using (OracleConnection connection = new OracleConnection(connectionString))
        //            {
        //                OracleCommand command = new OracleCommand(insertQuery, connection);
        //                try
        //                {
        //                    connection.Open();
        //                    if (command.ExecuteNonQuery() != null)
        //                    {
        //                        e_output.ForeColor = System.Drawing.Color.Green;
        //                        e_output.Text = "adding to doctor done";
        //                        clear();
        //                        getLastId();
        //                    }
        //                    else
        //                    {
        //                        e_output.ForeColor = System.Drawing.Color.Red;
        //                        e_output.Text = "something be wrong, please try again";
        //                    }
        //
        //                    connection.Close();
        //                }
        //                catch (Exception ex)
        //                {
        //                    connection.Close();
        //                    MessageBox.Show(ex.ToString());
        //
        //                }
        //
        //
        //            }
        //
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        e_output.Text = "Please Check Values Of the Filds";
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private async void insert_employee(object sender, EventArgs e)
        {
            try
            {
                if (id.Text.Length > 0
                    && name.Text.Length > 3
                    && salary.Text.Length > 3
                    && double.Parse(salary.Text.ToString()) > 0
                    && address.Text.Length > 3
                    && phone.Text.Length > 9
                    && double.Parse(phone.Text.ToString()) > 0
                    && !string.IsNullOrEmpty(comboBoxClinic.Text))
                {
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        conn.Open();
                        OracleTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Insert into EMPLOYEE
                            string query = "INSERT INTO BDB501.EMPLOYEE (EMPLOYEEID, NAME, SALARY, ADDRESS, PHONENUMBER) VALUES"
                                + $"({id.Text.ToString().Trim()}, '{name.Text.ToString().Trim()}', {salary.Text.ToString().Trim()}, '{address.Text.ToString().Trim()}', '{phone.Text.ToString().Trim()}')";
                            OracleCommand cmd = new OracleCommand(query, conn);
                            cmd.Transaction = transaction;
                            cmd.ExecuteNonQuery();

                            // Insert into DOCTOR or NURSE
                            if (radio_doctor.Checked && double.Parse(d_yoe.Text) > 0)
                            {
                                query = $"INSERT INTO BDB501.DOCTOR (EMPLOYEEID, YEARSOFEXPERIENCE) VALUES ({id.Text.ToString().Trim()}, {d_yoe.Text.ToString().Trim()})";
                                cmd.CommandText = query;
                                cmd.ExecuteNonQuery();
                            }
                            else if (radio_nurse.Checked && double.Parse(n_wh.Text) > 0)
                            {
                                query = $"INSERT INTO BDB501.NURSE (EMPLOYEEID, WORKINGHOURS) VALUES ({id.Text.ToString().Trim()}, {n_wh.Text.ToString().Trim()})";
                                cmd.CommandText = query;
                                cmd.ExecuteNonQuery();
                            }

                            // Insert into WORKSIN
                            string selectedItem = comboBoxClinic.SelectedItem.ToString();
                            int separatorIndex = selectedItem.IndexOf('-');
                            if (separatorIndex == -1)
                            {
                                MessageBox.Show("Invalid clinic selection format.");
                                transaction.Rollback();
                                return;
                            }
                            string clinicIDStr = selectedItem.Substring(0, separatorIndex).Trim();

                            // Validate EMPLOYEEID and CLINICID
                            string checkEmployeeQuery = $"SELECT COUNT(*) FROM BDB501.EMPLOYEE WHERE EMPLOYEEID = {id.Text.ToString().Trim()}";
                            string checkClinicQuery = $"SELECT COUNT(*) FROM BDB501.CLINIC WHERE CLINICID = {clinicIDStr}";

                            OracleCommand checkEmployeeCmd = new OracleCommand(checkEmployeeQuery, conn);
                            int employeeCount = Convert.ToInt32(checkEmployeeCmd.ExecuteScalar());

                            OracleCommand checkClinicCmd = new OracleCommand(checkClinicQuery, conn);
                            int clinicCount = Convert.ToInt32(checkClinicCmd.ExecuteScalar());

                            if (employeeCount == 0)
                            {
                                MessageBox.Show("Employee ID does not exist in the EMPLOYEE table.");
                                transaction.Rollback();
                                return;
                            }

                            if (clinicCount == 0)
                            {
                                MessageBox.Show("Clinic ID does not exist in the CLINIC table.");
                                transaction.Rollback();
                                return;
                            }

                            string insertQuery = $"INSERT INTO BDB501.WORKSIN (EMPLOYEEID, CLINICID) VALUES ({id.Text.ToString().Trim()}, {clinicIDStr})";
                            cmd.CommandText = insertQuery;
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            e_output.ForeColor = System.Drawing.Color.Green;
                            e_output.Text = "Adding Employee is Done";
                            clear();
                            getLastId();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                e_output.Text = "Please Check Values Of the Fields";
                MessageBox.Show(ex.ToString());
            }
        }
        private async void getLastId()
        {
            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    string query = "SELECT EMPLOYEEID FROM BDB501.EMPLOYEE ORDER BY EMPLOYEEID DESC FETCH FIRST 1 ROW ONLY";

                    OracleCommand cmd = new OracleCommand(query, conn);
                    try
                    {
                        conn.Open();
                        var res = cmd.ExecuteScalar();
                        if (res != null)
                        {
                            last_id = int.Parse(res.ToString()) + 1;
                            id.Text = last_id.ToString();
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
        private void clear()
        {
            id.Text = last_id.ToString();
            name.Text = "";
            salary.Text = "";
            address.Text = "";
            phone.Text = "";
            d_yoe.Text = "";
            n_wh.Text = "";
            e_output.ForeColor = System.Drawing.Color.White;
            comboBoxClinic.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void ClinicCombo()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CLINICID, NAME FROM BDB501.CLINIC";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int clinicID = reader.GetInt32(0);
                                string clinicName = reader.GetString(1);
                                comboBoxClinic.Items.Add($"{clinicID} - {clinicName}");
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
    }
}
