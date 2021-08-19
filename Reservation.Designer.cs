
namespace Airline_Reservation_System
{
    partial class Reservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAirlineInfo = new System.Windows.Forms.DataGridView();
            this.FlightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.comboPickUpPoint = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPickUpPoint = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReservation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).BeginInit();
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
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.comboDestination);
            this.panel3.Controls.Add(this.comboPickUpPoint);
            this.panel3.Controls.Add(this.lblDestination);
            this.panel3.Controls.Add(this.lblPickUpPoint);
            this.panel3.Location = new System.Drawing.Point(0, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 652);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(535, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search Flight";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(403, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 30);
            this.panel5.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Select required flight from the list and press Next button.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Available Flight List";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(1076, 257);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAirlineInfo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 361);
            this.panel4.TabIndex = 9;
            // 
            // dgvAirlineInfo
            // 
            this.dgvAirlineInfo.AllowUserToAddRows = false;
            this.dgvAirlineInfo.AllowUserToDeleteRows = false;
            this.dgvAirlineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirlineInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightId,
            this.FlightName,
            this.Category,
            this.Location1,
            this.Location2,
            this.Price,
            this.TotalSeat,
            this.ReservedSeat});
            this.dgvAirlineInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAirlineInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvAirlineInfo.Name = "dgvAirlineInfo";
            this.dgvAirlineInfo.ReadOnly = true;
            this.dgvAirlineInfo.RowHeadersWidth = 51;
            this.dgvAirlineInfo.RowTemplate.Height = 29;
            this.dgvAirlineInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAirlineInfo.Size = new System.Drawing.Size(1182, 361);
            this.dgvAirlineInfo.TabIndex = 0;
            // 
            // FlightId
            // 
            this.FlightId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlightId.DataPropertyName = "FlightId";
            this.FlightId.HeaderText = "Flight Id";
            this.FlightId.MinimumWidth = 6;
            this.FlightId.Name = "FlightId";
            this.FlightId.ReadOnly = true;
            this.FlightId.Visible = false;
            // 
            // FlightName
            // 
            this.FlightName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlightName.DataPropertyName = "FlightName";
            this.FlightName.HeaderText = "Flight Name";
            this.FlightName.MinimumWidth = 6;
            this.FlightName.Name = "FlightName";
            this.FlightName.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Location1
            // 
            this.Location1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location1.DataPropertyName = "Location1";
            this.Location1.HeaderText = "Start From";
            this.Location1.MinimumWidth = 6;
            this.Location1.Name = "Location1";
            this.Location1.ReadOnly = true;
            // 
            // Location2
            // 
            this.Location2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location2.DataPropertyName = "Location2";
            this.Location2.HeaderText = "Destination";
            this.Location2.MinimumWidth = 6;
            this.Location2.Name = "Location2";
            this.Location2.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalSeat
            // 
            this.TotalSeat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSeat.DataPropertyName = "TotalSeat";
            this.TotalSeat.HeaderText = "Total Seat";
            this.TotalSeat.MinimumWidth = 6;
            this.TotalSeat.Name = "TotalSeat";
            this.TotalSeat.ReadOnly = true;
            // 
            // ReservedSeat
            // 
            this.ReservedSeat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservedSeat.DataPropertyName = "ReservedSeat";
            this.ReservedSeat.HeaderText = "Reserved Seat";
            this.ReservedSeat.MinimumWidth = 6;
            this.ReservedSeat.Name = "ReservedSeat";
            this.ReservedSeat.ReadOnly = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(550, 195);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 46);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(21, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboDestination
            // 
            this.comboDestination.FormattingEnabled = true;
            this.comboDestination.Items.AddRange(new object[] {
            "Abu Dhabi",
            "Bali",
            "Beijing",
            "Cairo",
            "Dhaka",
            "Dubai",
            "Istambul",
            "Kathmandu",
            "Kuyalalampur",
            "London",
            "Luxemburg",
            "Madrid",
            "Makka",
            "Mumbai",
            "Munich",
            "New York",
            "Paris",
            "Riyad",
            "Rome",
            "Singapore",
            "Tokyo",
            "Torronto"});
            this.comboDestination.Location = new System.Drawing.Point(654, 122);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(151, 28);
            this.comboDestination.TabIndex = 6;
            this.comboDestination.SelectedIndexChanged += new System.EventHandler(this.comboDestination_SelectedIndexChanged);
            // 
            // comboPickUpPoint
            // 
            this.comboPickUpPoint.FormattingEnabled = true;
            this.comboPickUpPoint.Items.AddRange(new object[] {
            "Abu Dhabi",
            "Bali",
            "Beijing",
            "Cairo",
            "Dhaka",
            "Dubai",
            "Istambul",
            "Kathmandu",
            "Kuyalalampur",
            "London",
            "Luxemburg",
            "Madrid",
            "Makka",
            "Mumbai",
            "Munich",
            "New York",
            "Paris",
            "Riyad",
            "Rome",
            "Singapore",
            "Tokyo",
            "Torronto"});
            this.comboPickUpPoint.Location = new System.Drawing.Point(388, 122);
            this.comboPickUpPoint.Name = "comboPickUpPoint";
            this.comboPickUpPoint.Size = new System.Drawing.Size(151, 28);
            this.comboPickUpPoint.TabIndex = 5;
            this.comboPickUpPoint.SelectedIndexChanged += new System.EventHandler(this.comboPickUpPoint_SelectedIndexChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDestination.Location = new System.Drawing.Point(664, 88);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(131, 31);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination";
            // 
            // lblPickUpPoint
            // 
            this.lblPickUpPoint.AutoSize = true;
            this.lblPickUpPoint.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPickUpPoint.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPickUpPoint.Location = new System.Drawing.Point(396, 88);
            this.lblPickUpPoint.Name = "lblPickUpPoint";
            this.lblPickUpPoint.Size = new System.Drawing.Size(140, 31);
            this.lblPickUpPoint.TabIndex = 3;
            this.lblPickUpPoint.Text = "Pickup Point";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lblReservation);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 101);
            this.panel2.TabIndex = 0;
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReservation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReservation.Location = new System.Drawing.Point(0, 9);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(364, 76);
            this.lblReservation.TabIndex = 0;
            this.lblReservation.Text = "Reservation ";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Reservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reservation_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.ComboBox comboPickUpPoint;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPickUpPoint;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAirlineInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedSeat;
        private System.Windows.Forms.Label label2;
    }
}