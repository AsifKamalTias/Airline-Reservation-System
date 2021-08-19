using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Airline_Reservation_System
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { this.ds = value; }
        }


        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-96QSE7S\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Persist Security Info=True;User ID=sa;Password=system");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
