
namespace Airline_Reservation_System
{
    partial class Reserver
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel3.Controls.Add(this.btnSignOut);
            this.panel3.Controls.Add(this.btnHistory);
            this.panel3.Controls.Add(this.btnProfile);
            this.panel3.Controls.Add(this.btnCancelReservation);
            this.panel3.Controls.Add(this.btnReserve);
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 653);
            this.panel3.TabIndex = 1;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Red;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignOut.Location = new System.Drawing.Point(1014, 569);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(135, 52);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHistory.Location = new System.Drawing.Point(62, 306);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(171, 82);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Reservation History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnProfile.Location = new System.Drawing.Point(62, 236);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(171, 45);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile Setting";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelReservation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelReservation.Location = new System.Drawing.Point(448, 192);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(264, 76);
            this.btnCancelReservation.TabIndex = 1;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReserve.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReserve.Location = new System.Drawing.Point(448, 81);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(264, 79);
            this.btnReserve.TabIndex = 0;
            this.btnReserve.Text = "Reserve Flight";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 101);
            this.panel2.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(466, 76);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Hello, username";
            // 
            // Reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reserver_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
    }
}