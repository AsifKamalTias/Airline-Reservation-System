
namespace Airline_Reservation_System
{
    partial class FormViewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvlViewUser = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(529, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Search by Role";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "admin",
            "reserver"});
            this.comboRole.Location = new System.Drawing.Point(524, 269);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(151, 28);
            this.comboRole.TabIndex = 29;
            this.comboRole.SelectedIndexChanged += new System.EventHandler(this.comboRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(118, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search by User Id or Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 270);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 27);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(12, 110);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "User List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lvlViewUser);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 104);
            this.panel2.TabIndex = 23;
            // 
            // lvlViewUser
            // 
            this.lvlViewUser.AutoSize = true;
            this.lvlViewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlViewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lvlViewUser.Location = new System.Drawing.Point(12, 9);
            this.lvlViewUser.Name = "lvlViewUser";
            this.lvlViewUser.Size = new System.Drawing.Size(289, 76);
            this.lvlViewUser.TabIndex = 1;
            this.lvlViewUser.Text = "View User";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(1076, 374);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 344);
            this.panel1.TabIndex = 22;
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.DateOfBirth,
            this.Gender,
            this.Password,
            this.Role});
            this.dgvUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.RowHeadersWidth = 51;
            this.dgvUserInfo.RowTemplate.Height = 29;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(1182, 344);
            this.dgvUserInfo.TabIndex = 1;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User Id";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 99;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // FormViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | View Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewUser_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lvlViewUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}