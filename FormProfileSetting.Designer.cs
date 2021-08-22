
namespace Airline_Reservation_System
{
    partial class FormProfileSetting
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 101);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(353, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(353, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(353, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(502, 360);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 27);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(502, 308);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(278, 27);
            this.txtID.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(504, 439);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(278, 27);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBack.Location = new System.Drawing.Point(12, 116);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Blue;
            this.btnChangePassword.Location = new System.Drawing.Point(826, 439);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(148, 32);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(583, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 51);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 753);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxShowPassword);
            this.panel3.Location = new System.Drawing.Point(502, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 29);
            this.panel3.TabIndex = 24;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(81, 4);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(132, 24);
            this.checkBoxShowPassword.TabIndex = 0;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // FormProfileSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProfileSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Profile Setting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfileSetting_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}