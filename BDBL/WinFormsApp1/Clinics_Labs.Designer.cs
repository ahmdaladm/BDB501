namespace WinFormsApp1
{
    partial class Clinics_Labs
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
            Clinic_id = new TextBox();
            label2 = new Label();
            txtClinicName = new TextBox();
            txtPhone = new TextBox();
            label3 = new Label();
            label1 = new Label();
            lbltransaction = new Label();
            Lab_ID = new TextBox();
            txtNumberRoom = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtequipment = new RichTextBox();
            btnAddLab = new Button();
            label8 = new Label();
            btnAddClinic = new Button();
            comboClinic = new ComboBox();
            btnClear = new Button();
            lblLab = new Label();
            SuspendLayout();
            // 
            // Clinic_id
            // 
            Clinic_id.Enabled = false;
            Clinic_id.Location = new Point(181, 43);
            Clinic_id.Margin = new Padding(3, 2, 3, 2);
            Clinic_id.Name = "Clinic_id";
            Clinic_id.Size = new Size(174, 23);
            Clinic_id.TabIndex = 1;
            Clinic_id.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 9;
            label2.Text = "Clinic ID";
            // 
            // txtClinicName
            // 
            txtClinicName.Location = new Point(181, 88);
            txtClinicName.Margin = new Padding(3, 2, 3, 2);
            txtClinicName.Name = "txtClinicName";
            txtClinicName.Size = new Size(174, 23);
            txtClinicName.TabIndex = 10;
            txtClinicName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(181, 134);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(174, 23);
            txtPhone.TabIndex = 11;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 13;
            label3.Text = "Clinic Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 14;
            label1.Text = "Clinic Phone Number";
            // 
            // lbltransaction
            // 
            lbltransaction.AutoSize = true;
            lbltransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbltransaction.Location = new Point(12, 12);
            lbltransaction.Name = "lbltransaction";
            lbltransaction.Size = new Size(193, 19);
            lbltransaction.TabIndex = 15;
            lbltransaction.Text = "Please Enter The Clinic Data";
            // 
            // Lab_ID
            // 
            Lab_ID.Enabled = false;
            Lab_ID.Location = new Point(566, 38);
            Lab_ID.Margin = new Padding(3, 2, 3, 2);
            Lab_ID.Name = "Lab_ID";
            Lab_ID.Size = new Size(250, 23);
            Lab_ID.TabIndex = 16;
            Lab_ID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumberRoom
            // 
            txtNumberRoom.Location = new Point(566, 132);
            txtNumberRoom.Margin = new Padding(3, 2, 3, 2);
            txtNumberRoom.Name = "txtNumberRoom";
            txtNumberRoom.Size = new Size(250, 23);
            txtNumberRoom.TabIndex = 18;
            txtNumberRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(428, 45);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 19;
            label5.Text = "Lab ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(428, 90);
            label6.Name = "label6";
            label6.Size = new Size(120, 19);
            label6.TabIndex = 20;
            label6.Text = "Assosiated Clinic";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(428, 139);
            label7.Name = "label7";
            label7.Size = new Size(132, 19);
            label7.TabIndex = 21;
            label7.Text = "Number of Rooms";
            // 
            // txtequipment
            // 
            txtequipment.Location = new Point(566, 184);
            txtequipment.Name = "txtequipment";
            txtequipment.Size = new Size(250, 55);
            txtequipment.TabIndex = 22;
            txtequipment.Text = "";
            // 
            // btnAddLab
            // 
            btnAddLab.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLab.ForeColor = SystemColors.ActiveCaptionText;
            btnAddLab.Location = new Point(566, 269);
            btnAddLab.Name = "btnAddLab";
            btnAddLab.Size = new Size(250, 23);
            btnAddLab.TabIndex = 23;
            btnAddLab.Text = "Add Lab";
            btnAddLab.UseVisualStyleBackColor = true;
            btnAddLab.Click += InsertLab;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(428, 188);
            label8.Name = "label8";
            label8.Size = new Size(86, 19);
            label8.TabIndex = 24;
            label8.Text = "Equipments";
            // 
            // btnAddClinic
            // 
            btnAddClinic.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddClinic.ForeColor = SystemColors.ActiveCaptionText;
            btnAddClinic.Location = new Point(23, 269);
            btnAddClinic.Name = "btnAddClinic";
            btnAddClinic.Size = new Size(250, 23);
            btnAddClinic.TabIndex = 25;
            btnAddClinic.Text = "Add Clinic";
            btnAddClinic.UseVisualStyleBackColor = true;
            btnAddClinic.Click += InsertClinic;
            // 
            // comboClinic
            // 
            comboClinic.FormattingEnabled = true;
            comboClinic.Location = new Point(566, 87);
            comboClinic.Name = "comboClinic";
            comboClinic.Size = new Size(250, 23);
            comboClinic.TabIndex = 26;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(356, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 23);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear ";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnclear_click;
            // 
            // lblLab
            // 
            lblLab.AutoSize = true;
            lblLab.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLab.Location = new Point(428, 12);
            lblLab.Name = "lblLab";
            lblLab.Size = new Size(181, 19);
            lblLab.TabIndex = 28;
            lblLab.Text = "Please Enter The Lab Data";
            // 
            // Clinics_Labs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(849, 327);
            Controls.Add(lblLab);
            Controls.Add(btnClear);
            Controls.Add(comboClinic);
            Controls.Add(btnAddClinic);
            Controls.Add(label8);
            Controls.Add(btnAddLab);
            Controls.Add(txtequipment);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNumberRoom);
            Controls.Add(Lab_ID);
            Controls.Add(lbltransaction);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(txtClinicName);
            Controls.Add(label2);
            Controls.Add(Clinic_id);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Clinics_Labs";
            Padding = new Padding(0, 3, 0, 0);
            Text = "Clinics And Labs";
            Load += Clinic_Lab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Clinic_id;
        private Label label2;
        private TextBox txtClinicName;
        private TextBox txtPhone;
        private Label label3;
        private Label label1;
        private Label lbltransaction;
        private TextBox Lab_ID;
        private TextBox txtNumberRoom;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox txtequipment;
        private Button btnAddLab;
        private Label label8;
        private Button btnAddClinic;
        private ComboBox comboClinic;
        private Button btnClear;
        private Label lblLab;
    }
}