
namespace Airline_Reservation_System
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnEditPlaneDetails = new System.Windows.Forms.Button();
            this.btnViewFlight = new System.Windows.Forms.Button();
            this.btnRemovePlane = new System.Windows.Forms.Button();
            this.btnReservationDetails = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdminDashBoard = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 753);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnReservationDetails);
            this.panel3.Controls.Add(this.btnSignOut);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 655);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnEditUser);
            this.panel5.Controls.Add(this.btnAddUser);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnViewUser);
            this.panel5.Controls.Add(this.btnRemoveUser);
            this.panel5.Location = new System.Drawing.Point(803, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 456);
            this.panel5.TabIndex = 10;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditUser.Location = new System.Drawing.Point(25, 263);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(211, 50);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "Edit User Information";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(25, 106);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(211, 46);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(52, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Manage Users";
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewUser.Location = new System.Drawing.Point(25, 176);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(211, 46);
            this.btnViewUser.TabIndex = 4;
            this.btnViewUser.Text = "View Users";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveUser.Location = new System.Drawing.Point(25, 342);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(211, 50);
            this.btnRemoveUser.TabIndex = 7;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAddFlight);
            this.panel4.Controls.Add(this.btnEditPlaneDetails);
            this.panel4.Controls.Add(this.btnViewFlight);
            this.panel4.Controls.Add(this.btnRemovePlane);
            this.panel4.Location = new System.Drawing.Point(93, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 456);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Flights";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFlight.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFlight.Location = new System.Drawing.Point(24, 104);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(211, 48);
            this.btnAddFlight.TabIndex = 1;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnEditPlaneDetails
            // 
            this.btnEditPlaneDetails.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditPlaneDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPlaneDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditPlaneDetails.Location = new System.Drawing.Point(24, 262);
            this.btnEditPlaneDetails.Name = "btnEditPlaneDetails";
            this.btnEditPlaneDetails.Size = new System.Drawing.Size(211, 51);
            this.btnEditPlaneDetails.TabIndex = 2;
            this.btnEditPlaneDetails.Text = "Edit Flight Details";
            this.btnEditPlaneDetails.UseVisualStyleBackColor = false;
            this.btnEditPlaneDetails.Click += new System.EventHandler(this.btnEditPlaneDetails_Click);
            // 
            // btnViewFlight
            // 
            this.btnViewFlight.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewFlight.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewFlight.Location = new System.Drawing.Point(24, 176);
            this.btnViewFlight.Name = "btnViewFlight";
            this.btnViewFlight.Size = new System.Drawing.Size(211, 53);
            this.btnViewFlight.TabIndex = 3;
            this.btnViewFlight.Text = "View Flights";
            this.btnViewFlight.UseVisualStyleBackColor = false;
            this.btnViewFlight.Click += new System.EventHandler(this.btnViewFlight_Click);
            // 
            // btnRemovePlane
            // 
            this.btnRemovePlane.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRemovePlane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePlane.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemovePlane.Location = new System.Drawing.Point(18, 342);
            this.btnRemovePlane.Name = "btnRemovePlane";
            this.btnRemovePlane.Size = new System.Drawing.Size(217, 52);
            this.btnRemovePlane.TabIndex = 6;
            this.btnRemovePlane.Text = "Remove Flight";
            this.btnRemovePlane.UseVisualStyleBackColor = false;
            this.btnRemovePlane.Click += new System.EventHandler(this.btnRemovePlane_Click);
            // 
            // btnReservationDetails
            // 
            this.btnReservationDetails.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReservationDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservationDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservationDetails.Location = new System.Drawing.Point(474, 158);
            this.btnReservationDetails.Name = "btnReservationDetails";
            this.btnReservationDetails.Size = new System.Drawing.Size(225, 68);
            this.btnReservationDetails.TabIndex = 5;
            this.btnReservationDetails.Text = "View Reservation Details";
            this.btnReservationDetails.UseVisualStyleBackColor = false;
            this.btnReservationDetails.Click += new System.EventHandler(this.btnReservationDetails_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Red;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignOut.Location = new System.Drawing.Point(982, 567);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(135, 52);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lblAdminDashBoard);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 99);
            this.panel2.TabIndex = 0;
            // 
            // lblAdminDashBoard
            // 
            this.lblAdminDashBoard.AutoSize = true;
            this.lblAdminDashBoard.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblAdminDashBoard.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminDashBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdminDashBoard.Location = new System.Drawing.Point(12, 9);
            this.lblAdminDashBoard.Name = "lblAdminDashBoard";
            this.lblAdminDashBoard.Size = new System.Drawing.Size(533, 76);
            this.lblAdminDashBoard.TabIndex = 0;
            this.lblAdminDashBoard.Text = "Admin Dash Board";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnRemovePlane;
        private System.Windows.Forms.Button btnReservationDetails;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button btnViewFlight;
        private System.Windows.Forms.Button btnEditPlaneDetails;
        //private System.Windows.Forms.Button btnAddFligh;
        private System.Windows.Forms.Label lblAdminDashBoard;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
    }
}