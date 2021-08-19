
namespace Airline_Reservation_System
{
    partial class FormReservationHistory
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvReservationList = new System.Windows.Forms.DataGridView();
            this.ReservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfFly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReservationList = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblReservationList);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 753);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(1076, 386);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvReservationList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 332);
            this.panel3.TabIndex = 10;
            // 
            // dgvReservationList
            // 
            this.dgvReservationList.AllowUserToAddRows = false;
            this.dgvReservationList.AllowUserToDeleteRows = false;
            this.dgvReservationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationId,
            this.ReservationStatus,
            this.CustomerName,
            this.CustomerEmail,
            this.CustomerGender,
            this.DateOfFly,
            this.PickupPoint,
            this.Destination,
            this.FlightId});
            this.dgvReservationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationList.Location = new System.Drawing.Point(0, 0);
            this.dgvReservationList.Name = "dgvReservationList";
            this.dgvReservationList.ReadOnly = true;
            this.dgvReservationList.RowHeadersWidth = 51;
            this.dgvReservationList.RowTemplate.Height = 29;
            this.dgvReservationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationList.Size = new System.Drawing.Size(1182, 332);
            this.dgvReservationList.TabIndex = 16;
            // 
            // ReservationId
            // 
            this.ReservationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservationId.DataPropertyName = "ReservationId";
            this.ReservationId.HeaderText = "Reservation Id";
            this.ReservationId.MinimumWidth = 6;
            this.ReservationId.Name = "ReservationId";
            this.ReservationId.ReadOnly = true;
            // 
            // ReservationStatus
            // 
            this.ReservationStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservationStatus.DataPropertyName = "ReservationStatus";
            this.ReservationStatus.HeaderText = "Reservation Status";
            this.ReservationStatus.MinimumWidth = 6;
            this.ReservationStatus.Name = "ReservationStatus";
            this.ReservationStatus.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerEmail.DataPropertyName = "CustomerEmail";
            this.CustomerEmail.HeaderText = "Customer Email";
            this.CustomerEmail.MinimumWidth = 6;
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            // 
            // CustomerGender
            // 
            this.CustomerGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerGender.DataPropertyName = "CustomerGender";
            this.CustomerGender.HeaderText = "Customer Gender";
            this.CustomerGender.MinimumWidth = 6;
            this.CustomerGender.Name = "CustomerGender";
            this.CustomerGender.ReadOnly = true;
            // 
            // DateOfFly
            // 
            this.DateOfFly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfFly.DataPropertyName = "DateOfFly";
            this.DateOfFly.HeaderText = "Date of Fly";
            this.DateOfFly.MinimumWidth = 6;
            this.DateOfFly.Name = "DateOfFly";
            this.DateOfFly.ReadOnly = true;
            // 
            // PickupPoint
            // 
            this.PickupPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PickupPoint.DataPropertyName = "PickupPoint";
            this.PickupPoint.HeaderText = "Pickup Point";
            this.PickupPoint.MinimumWidth = 6;
            this.PickupPoint.Name = "PickupPoint";
            this.PickupPoint.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 6;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
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
            // lblReservationList
            // 
            this.lblReservationList.AutoSize = true;
            this.lblReservationList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReservationList.Location = new System.Drawing.Point(12, 390);
            this.lblReservationList.Name = "lblReservationList";
            this.lblReservationList.Size = new System.Drawing.Size(147, 28);
            this.lblReservationList.TabIndex = 17;
            this.lblReservationList.Text = "Reservation List";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(12, 118);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(442, 266);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by Id";
            this.txtSearch.Size = new System.Drawing.Size(329, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(442, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 103);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation History";
            // 
            // FormReservationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReservationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Reservation History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReservationHistory_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvReservationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfFly;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightId;
        private System.Windows.Forms.Label lblReservationList;
    }
}