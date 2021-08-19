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
    public partial class FormAddUser : Form
    {
        private Admin FormAdmin { get; set; }
        private DataAccess Da { get; set; }
        public FormAddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoGenerateId();
        }

        public FormAddUser(Admin formAdmin):this()
        {
            this.FormAdmin = formAdmin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.FormAdmin.Show();
        }

        private void AutoGenerateId()
        {
            var sql = "select UserId from UserInfo order by UserId desc;";
            DataSet ds = this.Da.ExecuteQuery(sql);

            string previousId = ds.Tables[0].Rows[0]["UserId"].ToString();
            string[] temp = previousId.Split("-");
            int num = Convert.ToInt32(temp[1]);
            string newId = "us-" + (++num).ToString("d3");
            this.txtUserId.Text = newId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.IsInvalidInput() || !VaildateRadioGroupIsChecked(this.radioButtonMale, this.radioButtonFemale))
            {
                MessageBox.Show("Please fill up all information properly");
            }
            else
            {
                string gender;
                if (this.radioButtonMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                try
                {
                    string sql = "insert into UserInfo values('" + this.txtUserId.Text + "', '"+this.txtName.Text+"', '" + this.dateTimePickerDateOfBirth.Text + "', '" + gender + "', '" + this.txtPassword.Text + "', '" + this.comboRole.Text + "');";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    if(count == 1)
                    {
                        MessageBox.Show("User Added Successfully.");
                        this.Clear();
                        this.AutoGenerateId();
                    }
                    else
                    {
                        MessageBox.Show("User did not added.");
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Something Went Wrong. \n\n" + exc);
                }
            }
        }

        private bool IsInvalidInput()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.comboRole.Text) || String.IsNullOrEmpty(this.dateTimePickerDateOfBirth.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VaildateRadioGroupIsChecked(RadioButton a, RadioButton b)
        {
            if (!a.Checked && !b.Checked)
            {
                return false;
            }
            return true;
        }

        private void Clear()
        {
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.comboRole.SelectedIndex = -1;
            this.radioButtonMale.Checked = false;
            this.radioButtonFemale.Checked = false;
        }
    }
}
