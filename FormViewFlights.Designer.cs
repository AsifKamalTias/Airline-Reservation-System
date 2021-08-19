
namespace Airline_Reservation_System
{
    partial class FormViewFlights
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
            this.dgvAirlineInfo = new System.Windows.Forms.DataGridView();
            this.FlightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSignin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboStartFrom = new System.Windows.Forms.ComboBox();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAirlineInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 344);
            this.panel1.TabIndex = 0;
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
            this.dgvAirlineInfo.Size = new System.Drawing.Size(1182, 344);
            this.dgvAirlineInfo.TabIndex = 12;
            // 
            // FlightId
            // 
            this.FlightId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlightId.DataPropertyName = "FlightId";
            this.FlightId.HeaderText = "Flight Id";
            this.FlightId.MinimumWidth = 6;
            this.FlightId.Name = "FlightId";
            this.FlightId.ReadOnly = true;
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
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignin.Location = new System.Drawing.Point(12, 9);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(345, 76);
            this.lblSignin.TabIndex = 1;
            this.lblSignin.Text = "View Flights";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lblSignin);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 104);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Flight List";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(1076, 374);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(12, 110);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 270);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 27);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(112, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Search by Flight Id or Name";
            // 
            // comboStartFrom
            // 
            this.comboStartFrom.FormattingEnabled = true;
            this.comboStartFrom.Items.AddRange(new object[] {
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
            this.comboStartFrom.Location = new System.Drawing.Point(524, 269);
            this.comboStartFrom.Name = "comboStartFrom";
            this.comboStartFrom.Size = new System.Drawing.Size(151, 28);
            this.comboStartFrom.TabIndex = 18;
            this.comboStartFrom.SelectedIndexChanged += new System.EventHandler(this.comboStartFrom_SelectedIndexChanged);
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
            this.comboDestination.Location = new System.Drawing.Point(785, 270);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(151, 28);
            this.comboDestination.TabIndex = 19;
            this.comboDestination.SelectedIndexChanged += new System.EventHandler(this.comboDestination_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(502, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search by Start From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(762, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Search by Destination";
            // 
            // FormViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDestination);
            this.Controls.Add(this.comboStartFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | View Flights";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewFlights_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAirlineInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboStartFrom;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}