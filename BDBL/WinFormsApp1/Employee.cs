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
        private string connectionString = "User Id=BDB501;Password=Adam1234;Data Source=localhost:1521/test;Connection Timeout=30;";

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
        }

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
                    && double.Parse(phone.Text.ToString())>0)
                {
                    string query = "INSERT INTO BDB501.EMPLOYEE (EMPLOYEEID,NAME,SALARY,ADDRESS,PHONENUMBER) VALUES"
                        + $"({id.Text.ToString().Trim()},'{name.Text.ToString().Trim()}',{salary.Text.ToString().Trim()},'{address.Text.ToString().Trim()}','{phone.Text.ToString().Trim()}')";


                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {

                        OracleCommand cmd = new OracleCommand(query, conn);
                        try
                        {
                            conn.Open();
                            if (cmd.ExecuteScalar() != null)
                            {
                                e_output.ForeColor = System.Drawing.Color.Green;
                                e_output.Text = "Addig Employee is Done ";
                            }
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            conn.Close();
                            MessageBox.Show(ex.ToString());
                        }
                    }


                    if (radio_doctor.Checked && double.Parse(d_yoe.Text)>0 )
                    {

                        query = $"INSERT INTO BDB501.DOCTOR (EMPLOYEEID,YEARSOFEXPERIENCE) VALUES ({id.Text.ToString().Trim()},{d_yoe.Text.ToString().Trim()})";

                        using (OracleConnection conn = new OracleConnection(connectionString))
                        {
                            OracleCommand cmd = new OracleCommand(query, conn);
                            try
                            {
                                conn.Open();
                                if (cmd.ExecuteNonQuery() != null)
                                {
                                    e_output.ForeColor = System.Drawing.Color.Green;
                                    e_output.Text = "adding to doctor done";
                                    clear();
                                    getLastId();
                                }
                                else
                                {
                                    e_output.ForeColor = System.Drawing.Color.Red;
                                    e_output.Text = "something be wrong, please try again";
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
                    else if (radio_nurse.Checked &&  double.Parse(n_wh.Text)>0)
                    {
                        query = $"INSERT INTO BDB501.NURSE (EMPLOYEEID,WORKINGHOURS)  VALUES ({id.Text.ToString().Trim()},{n_wh.Text.ToString().Trim()})";

                        using (OracleConnection conn = new OracleConnection(connectionString))
                        {
                            OracleCommand cmd = new OracleCommand(query, conn);
                            try
                            {
                                conn.Open();
                                if (cmd.ExecuteNonQuery() != null)
                                {
                                    e_output.ForeColor = System.Drawing.Color.Green;
                                    e_output.Text = "adding to doctor done";
                                    clear();
                                    getLastId();
                                }
                                else
                                {
                                    e_output.ForeColor = System.Drawing.Color.Red;
                                    e_output.Text = "something be wrong, please try again";

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


                }
                else
                {
                    e_output.ForeColor = System.Drawing.Color.Red;
                    e_output.Text = "Fill All the Fild Please";
                }
            }
            catch (Exception ex)
            {
                e_output.Text="Please Check Values Of the Filds";
                MessageBox.Show(ex.ToString());
            }
        }

        
        private async void getLastId()
        {
            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    string query = "SELECT EMPLOYEEID FROM EMPLOYEE ORDER BY EMPLOYEEID DESC FETCH FIRST 1 ROW ONLY";

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
            name.Text = "";
            salary.Text = "";
            address.Text = "";
            phone.Text = "";
            d_yoe.Text = "";
            n_wh.Text = "";
            e_output.ForeColor = System.Drawing.Color.White;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
}
