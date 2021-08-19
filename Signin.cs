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

namespace Airline_Reservation_System
{
    public partial class Signin : Form
    {
        private DataAccess Da { get; set; }
        public Signin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (!IsInvalidInput())
            {
                MessageBox.Show("Please, fill up Id and Password.");
            }
            else
            {
                try
                {
                    string sql = "select * from UserInfo where UserId = '" + this.txtId.Text + "' and Password = '" + this.txtPassword.Text + "';";
                    SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-96QSE7S\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Persist Security Info=True;User ID=sa;Password=system");
                    sqlCon.Open();
                    SqlCommand sqlCom = new SqlCommand(sql, sqlCon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlCom);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        this.Clear();
                        this.Hide();
                        //MessageBox.Show("Login Successfull");
                        
                        string reserverId = ds.Tables[0].Rows[0][0].ToString();
                        string reserverName = ds.Tables[0].Rows[0][1].ToString();
                        string reserverDOB = ds.Tables[0].Rows[0][2].ToString();
                        string reserverGender = ds.Tables[0].Rows[0][3].ToString();
                        string reserverPassword = ds.Tables[0].Rows[0][4].ToString();

                        if (ds.Tables[0].Rows[0][5].ToString() == "admin")
                        {
                            Admin admin = new Admin(this);
                            admin.Show();
                        }
                        else if (ds.Tables[0].Rows[0][5].ToString() == "reserver")
                        {
                            Reserver reserver = new Reserver(this, reserverId, reserverName, reserverDOB, reserverGender, reserverPassword);
                            reserver.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Password");
                    }

                    sqlCon.Close();
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Something Went Wrong. \n\n" + exc);
                }
            }
        }

        private void Clear()
        {
            this.txtId.Clear();
            this.txtPassword.Clear();
        }

        private bool IsInvalidInput()
        {
            if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
