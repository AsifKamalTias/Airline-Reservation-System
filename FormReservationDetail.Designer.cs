
namespace Airline_Reservation_System
{
    partial class FormReservationDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtReservationId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFlightId = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtPickUpPoint = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfFlight = new System.Windows.Forms.DateTimePicker();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPickUpPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerGender = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Details";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(54, 131);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 44);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtReservationId
            // 
            this.txtReservationId.Enabled = false;
            this.txtReservationId.Location = new System.Drawing.Point(338, 203);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.Size = new System.Drawing.Size(167, 27);
            this.txtReservationId.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(178, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Reservation Id";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(575, 629);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(118, 51);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioBtnFemale);
            this.panel4.Controls.Add(this.radioBtnMale);
            this.panel4.Location = new System.Drawing.Point(182, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 37);
            this.panel4.TabIndex = 20;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(98, 3);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(78, 24);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(12, 3);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(63, 24);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 645);
            this.panel3.TabIndex = 1;
            // 
            // txtFlightId
            // 
            this.txtFlightId.Enabled = false;
            this.txtFlightId.Location = new System.Drawing.Point(741, 203);
            this.txtFlightId.Name = "txtFlightId";
            this.txtFlightId.Size = new System.Drawing.Size(168, 27);
            this.txtFlightId.TabIndex = 19;
            // 
            // txtDestination
            // 
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(798, 366);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(125, 27);
            this.txtDestination.TabIndex = 18;
            // 
            // txtPickUpPoint
            // 
            this.txtPickUpPoint.Enabled = false;
            this.txtPickUpPoint.Location = new System.Drawing.Point(798, 295);
            this.txtPickUpPoint.Name = "txtPickUpPoint";
            this.txtPickUpPoint.Size = new System.Drawing.Size(125, 27);
            this.txtPickUpPoint.TabIndex = 17;
            // 
            // dateTimePickerDateOfFlight
            // 
            this.dateTimePickerDateOfFlight.CustomFormat = "yyyy/ mm/ dd";
            this.dateTimePickerDateOfFlight.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfFlight.Location = new System.Drawing.Point(187, 598);
            this.dateTimePickerDateOfFlight.MinDate = new System.DateTime(1753, 1, 11, 0, 0, 0, 0);
            this.dateTimePickerDateOfFlight.Name = "dateTimePickerDateOfFlight";
            this.dateTimePickerDateOfFlight.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDateOfFlight.TabIndex = 16;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDestination.Location = new System.Drawing.Point(643, 366);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(131, 31);
            this.lblDestination.TabIndex = 15;
            this.lblDestination.Text = "Destination";
            // 
            // lblPickUpPoint
            // 
            this.lblPickUpPoint.AutoSize = true;
            this.lblPickUpPoint.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPickUpPoint.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPickUpPoint.Location = new System.Drawing.Point(643, 295);
            this.lblPickUpPoint.Name = "lblPickUpPoint";
            this.lblPickUpPoint.Size = new System.Drawing.Size(149, 31);
            this.lblPickUpPoint.TabIndex = 14;
            this.lblPickUpPoint.Text = "Pick Up Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(178, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date of Flight";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(187, 406);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(276, 27);
            this.txtCustomerEmail.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(187, 321);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(276, 27);
            this.txtCustomerName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(643, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight Id";
            // 
            // lblCustomerGender
            // 
            this.lblCustomerGender.AutoSize = true;
            this.lblCustomerGender.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerGender.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCustomerGender.Location = new System.Drawing.Point(178, 459);
            this.lblCustomerGender.Name = "lblCustomerGender";
            this.lblCustomerGender.Size = new System.Drawing.Size(185, 30);
            this.lblCustomerGender.TabIndex = 3;
            this.lblCustomerGender.Text = "Customer Gender";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCustomerEmail.Location = new System.Drawing.Point(178, 366);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(164, 30);
            this.lblCustomerEmail.TabIndex = 2;
            this.lblCustomerEmail.Text = "Customer Email";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCustomerName.Location = new System.Drawing.Point(178, 279);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(171, 30);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 108);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtReservationId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtFlightId);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Controls.Add(this.txtPickUpPoint);
            this.panel1.Controls.Add(this.dateTimePickerDateOfFlight);
            this.panel1.Controls.Add(this.lblDestination);
            this.panel1.Controls.Add(this.lblPickUpPoint);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomerEmail);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCustomerGender);
            this.panel1.Controls.Add(this.lblCustomerEmail);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 753);
            this.panel1.TabIndex = 1;
            // 
            // FormReservationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReservationDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Reservation Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReservationDetail_FormClosed);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtReservationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFlightId;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtPickUpPoint;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfFlight;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPickUpPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerGender;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}