
namespace Airline_Reservation_System
{
    partial class FormRemoveFlight
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchForRemoveFlight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtSearchForRemoveFlight);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 638);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(698, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(481, 28);
            this.panel6.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(479, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "* All the reservation will be automattcally cancelled for removed Flight.";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(435, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 28);
            this.panel5.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "*Select required flight from the list and press Remove.";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(567, 127);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 46);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Flight List";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1085, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchForRemoveFlight
            // 
            this.txtSearchForRemoveFlight.Location = new System.Drawing.Point(27, 246);
            this.txtSearchForRemoveFlight.Name = "txtSearchForRemoveFlight";
            this.txtSearchForRemoveFlight.PlaceholderText = "Search by flight id or name...";
            this.txtSearchForRemoveFlight.Size = new System.Drawing.Size(289, 27);
            this.txtSearchForRemoveFlight.TabIndex = 37;
            this.txtSearchForRemoveFlight.TextChanged += new System.EventHandler(this.txtSearchForRemoveFlight_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(22, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Search Flight";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAirlineInfo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1182, 286);
            this.panel4.TabIndex = 35;
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
            this.dgvAirlineInfo.Size = new System.Drawing.Size(1182, 286);
            this.dgvAirlineInfo.TabIndex = 18;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Flight List";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(1076, 314);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(27, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 119);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(0, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 76);
            this.label8.TabIndex = 1;
            this.label8.Text = "Remove Flight";
            // 
            // FormRemoveFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRemoveFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Remove Flight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRemoveFlight_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirlineInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearchForRemoveFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAirlineInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedSeat;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
    }
}