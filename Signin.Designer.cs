
namespace Airline_Reservation_System
{
    partial class Signin
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
            this.pnlQuickP2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSignin = new System.Windows.Forms.Label();
            this.pnlQuickP2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuickP2
            // 
            this.pnlQuickP2.Controls.Add(this.panel1);
            this.pnlQuickP2.Controls.Add(this.panel2);
            this.pnlQuickP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuickP2.Location = new System.Drawing.Point(0, 0);
            this.pnlQuickP2.Name = "pnlQuickP2";
            this.pnlQuickP2.Size = new System.Drawing.Size(1182, 753);
            this.pnlQuickP2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.btnSignin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(405, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 314);
            this.panel1.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblID.Location = new System.Drawing.Point(27, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(86, 26);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "User ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(283, 27);
            this.txtId.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPassword.Location = new System.Drawing.Point(27, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 26);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignin.Location = new System.Drawing.Point(115, 213);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(111, 48);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(32, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(283, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lblSignin);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 104);
            this.panel2.TabIndex = 0;
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignin.Location = new System.Drawing.Point(12, 9);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(193, 76);
            this.lblSignin.TabIndex = 1;
            this.lblSignin.Text = "Signin";
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pnlQuickP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Reservation System | Signin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.pnlQuickP2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuickP2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Panel panel1;
    }
}