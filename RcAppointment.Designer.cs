namespace Hospital_Management_System
{
    partial class RcAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnappmBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtperday = new System.Windows.Forms.TextBox();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnApptApply = new System.Windows.Forms.Button();
            this.dtpapp = new System.Windows.Forms.DateTimePicker();
            this.txtMJ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtappPId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dvgAppointment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "APPOINTMENT MANAGEMENT";
            // 
            // btnappmBack
            // 
            this.btnappmBack.BackColor = System.Drawing.Color.Violet;
            this.btnappmBack.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btnappmBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnappmBack.Location = new System.Drawing.Point(322, 320);
            this.btnappmBack.Name = "btnappmBack";
            this.btnappmBack.Size = new System.Drawing.Size(93, 44);
            this.btnappmBack.TabIndex = 5;
            this.btnappmBack.Text = "Back";
            this.btnappmBack.UseVisualStyleBackColor = false;
            this.btnappmBack.Click += new System.EventHandler(this.btnappmBack_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.txtColour);
            this.panel3.Controls.Add(this.txtperday);
            this.panel3.Controls.Add(this.txtSchedule);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cmbDoctor);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtDoctorId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 376);
            this.panel3.TabIndex = 2;
            // 
            // txtColour
            // 
            this.txtColour.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColour.Location = new System.Drawing.Point(76, 303);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(278, 47);
            this.txtColour.TabIndex = 25;
            // 
            // txtperday
            // 
            this.txtperday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperday.Location = new System.Drawing.Point(267, 223);
            this.txtperday.Name = "txtperday";
            this.txtperday.Size = new System.Drawing.Size(98, 32);
            this.txtperday.TabIndex = 24;
            // 
            // txtSchedule
            // 
            this.txtSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchedule.Location = new System.Drawing.Point(152, 161);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(213, 32);
            this.txtSchedule.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = " Appointment per day : \r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "Schedule :";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.ForeColor = System.Drawing.Color.Black;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(195, 36);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(240, 30);
            this.cmbDoctor.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Doctor Name :";
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorId.Location = new System.Drawing.Point(169, 99);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(92, 30);
            this.txtDoctorId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doctor Id :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.btnApptApply);
            this.panel4.Controls.Add(this.dtpapp);
            this.panel4.Controls.Add(this.txtMJ);
            this.panel4.Controls.Add(this.btnappmBack);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cmbPatient);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtappPId);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(489, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 376);
            this.panel4.TabIndex = 3;
            // 
            // btnApptApply
            // 
            this.btnApptApply.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApptApply.Location = new System.Drawing.Point(94, 280);
            this.btnApptApply.Name = "btnApptApply";
            this.btnApptApply.Size = new System.Drawing.Size(173, 52);
            this.btnApptApply.TabIndex = 27;
            this.btnApptApply.Text = "Aplly";
            this.btnApptApply.UseVisualStyleBackColor = true;
            this.btnApptApply.Click += new System.EventHandler(this.btnApptApply_Click);
            // 
            // dtpapp
            // 
            this.dtpapp.Location = new System.Drawing.Point(58, 219);
            this.dtpapp.Name = "dtpapp";
            this.dtpapp.Size = new System.Drawing.Size(308, 26);
            this.dtpapp.TabIndex = 26;
            // 
            // txtMJ
            // 
            this.txtMJ.Location = new System.Drawing.Point(202, 155);
            this.txtMJ.Name = "txtMJ";
            this.txtMJ.Size = new System.Drawing.Size(177, 26);
            this.txtMJ.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Major Deases :";
            // 
            // cmbPatient
            // 
            this.cmbPatient.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(198, 46);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(214, 35);
            this.cmbPatient.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Patient Name :";
            // 
            // txtappPId
            // 
            this.txtappPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappPId.Location = new System.Drawing.Point(198, 98);
            this.txtappPId.Name = "txtappPId";
            this.txtappPId.Size = new System.Drawing.Size(100, 30);
            this.txtappPId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Id :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.btnconfirm);
            this.panel2.Location = new System.Drawing.Point(0, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 50);
            this.panel2.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(771, 8);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 37);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Deatels";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "TK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Appointment Cost   ";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.Tomato;
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCost.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(467, 11);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(75, 30);
            this.txtCost.TabIndex = 2;
            this.txtCost.Text = "  1000";
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(632, 3);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(104, 43);
            this.btnconfirm.TabIndex = 1;
            this.btnconfirm.Text = "confirm";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dvgAppointment);
            this.panel5.Location = new System.Drawing.Point(0, 525);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(904, 161);
            this.panel5.TabIndex = 5;
            // 
            // dvgAppointment
            // 
            this.dvgAppointment.AllowUserToAddRows = false;
            this.dvgAppointment.AllowUserToDeleteRows = false;
            this.dvgAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvgAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAppointment.Location = new System.Drawing.Point(3, 0);
            this.dvgAppointment.Name = "dvgAppointment";
            this.dvgAppointment.ReadOnly = true;
            this.dvgAppointment.RowHeadersWidth = 62;
            this.dvgAppointment.RowTemplate.Height = 28;
            this.dvgAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAppointment.Size = new System.Drawing.Size(898, 158);
            this.dvgAppointment.TabIndex = 0;
            // 
            // RcAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 687);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "RcAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RcAppointment";
            this.Load += new System.EventHandler(this.RcAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnappmBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtappPId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.TextBox txtMJ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtperday;
        private System.Windows.Forms.Button btnApptApply;
        private System.Windows.Forms.DateTimePicker dtpapp;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dvgAppointment;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShow;
    }
}