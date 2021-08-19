using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class FormAddFlight : Form
    {
        private Admin FormAdmin { get; set; }
        private DataAccess Da { get; set; }
        public FormAddFlight()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoGenerateId();
        }

        public FormAddFlight(Admin formAdmin):this()
        {
            this.FormAdmin = formAdmin;
        }

        private void FormAddFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
          
           Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsInvalidInput())
            {
                MessageBox.Show("Please fill up all the fields properlly.");
            }
            else
            {
                try
                {
                    string sql = "Insert into FlightInfo values('"+this.txtFlightID.Text+"', '"+this.txtFlightName.Text+"', '"+this.comboFlightCategory.Text+"', '"+this.comboStartForm.Text+"', '"+this.comboDestination.Text+"', "+this.txtPrice.Text+", "+this.txtTotalSeat.Text+", 0);";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    if(count == 1)
                    {
                        MessageBox.Show("Flight Added Successfully.");
                        this.Clear();
                        this.AutoGenerateId();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful.");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Something Went Wrong. \n\n" + exc);
                }

            }  
        }

        private bool IsInvalidInput()
        {
            if (String.IsNullOrEmpty(this.txtFlightID.Text) || String.IsNullOrEmpty(this.txtFlightName.Text) || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.txtTotalSeat.Text) || String.IsNullOrEmpty(this.comboFlightCategory.Text) || String.IsNullOrEmpty(this.comboStartForm.Text) || String.IsNullOrEmpty(this.comboDestination.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AutoGenerateId()
        {
            var sql = "select FlightId from FlightInfo order by FlightId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);

            string previousId = ds.Tables[0].Rows[0]["FlightId"].ToString();
            string[] temp = previousId.Split("-");
            int num = Convert.ToInt32(temp[1]);
            string newId = "f-" + (++num).ToString("d3");
            this.txtFlightID.Text = newId;
        }

        private void Clear()
        {
            this.txtFlightName.Clear();
            this.comboFlightCategory.SelectedIndex = -1;
            this.comboStartForm.SelectedIndex = -1;
            this.comboDestination.SelectedIndex = -1;
            this.txtPrice.Clear();
            this.txtTotalSeat.Clear();
        }
    }
}
