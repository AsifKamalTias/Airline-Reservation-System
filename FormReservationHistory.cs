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
    public partial class FormReservationHistory : Form
    {
        private DataAccess Da { get; set; }
        private Reserver FormReserver { get; set; }
        private Admin FormAdmin { get; set; }

        private byte countBack = 0;
        public FormReservationHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public FormReservationHistory(Reserver reserver) : this()
        {
            this.FormReserver = reserver;
            countBack = 0;
        }
        public FormReservationHistory(Admin formAdmin) : this()
        {
            this.FormAdmin = formAdmin;
            countBack = 1;
        }

        private void PopulateGridView(string sql = "select * from ReservationDetails;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvReservationList.AutoGenerateColumns = false;
                this.dgvReservationList.DataSource = ds.Tables[0];
            }
            catch(Exception exc)
            {
                MessageBox.Show("Something Went Wrong. \n\n" + exc);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormReserver.Show();
            if(countBack == 0)
            {
                FormReserver.Show();
            }
            else
            {
                FormAdmin.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormReservationHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sqlSearch = "select * from ReservationDetails where ReservationId = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(sqlSearch);
        }
    }
}
