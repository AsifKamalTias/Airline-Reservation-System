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
    public partial class FormEditUser : Form
    {
        private Admin FormAdmin { get; set; }
        private DataAccess Da { get; set; }
        public FormEditUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public FormEditUser(Admin formAdmin) : this()
        {
            this.FormAdmin = formAdmin;
        }

        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvUserInfo.AutoGenerateColumns = false;
                this.dgvUserInfo.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something Went Wrong. \n\n" + exc);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.FormAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void FormEditUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvUserInfo_Click(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvUserInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvUserInfo.CurrentRow.Cells[1].Value.ToString();
            this.dateTimePickerDateOfBirth.Text = this.dgvUserInfo.CurrentRow.Cells[2].Value.ToString();
            if (this.dgvUserInfo.CurrentRow.Cells[3].Value.ToString().Equals("Male"))
            {
                this.radioButtonMale.Checked = true;
            }
            else
            {
                this.radioButtonFemale.Checked = true;
            }
            this.comboRole.Text = this.dgvUserInfo.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.IsInvalidInput() || !VaildateRadioGroupIsChecked(this.radioButtonMale, this.radioButtonFemale))
            {
                MessageBox.Show("Please Select an User.");
            }
            else
            {
                try
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
                    var sql = "UPDATE UserInfo SET UserName = '" + this.txtName.Text + "', DateOfBirth = '" + this.dateTimePickerDateOfBirth.Text + "', Gender = '" +gender+ "', Role = '" + this.comboRole.Text + "' WHERE UserId = '" + this.txtUserId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("User information updated.");
                        this.PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfull Update Operation");
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
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.dateTimePickerDateOfBirth.Text) || String.IsNullOrEmpty(this.comboRole.Text))
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
    }
}
