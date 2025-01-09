namespace WinFormsApp1
{
    partial class Employee
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
            id = new TextBox();
            name = new TextBox();
            salary = new TextBox();
            address = new TextBox();
            phone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            radio_doctor = new RadioButton();
            radio_nurse = new RadioButton();
            n_wh = new TextBox();
            d_yoe = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            clearButton = new Button();
            label8 = new Label();
            e_output = new Label();
            label9 = new Label();
            comboBoxClinic = new ComboBox();
            SuspendLayout();
            // 
            // id
            // 
            id.Enabled = false;
            id.Location = new Point(150, 60);
            id.Margin = new Padding(3, 2, 3, 2);
            id.Name = "id";
            id.Size = new Size(280, 23);
            id.TabIndex = 0;
            id.TextAlign = HorizontalAlignment.Center;
            // 
            // name
            // 
            name.Location = new Point(150, 90);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(280, 23);
            name.TabIndex = 1;
            // 
            // salary
            // 
            salary.Location = new Point(150, 120);
            salary.Margin = new Padding(3, 2, 3, 2);
            salary.Name = "salary";
            salary.Size = new Size(280, 23);
            salary.TabIndex = 2;
            // 
            // address
            // 
            address.Location = new Point(150, 150);
            address.Margin = new Padding(3, 2, 3, 2);
            address.Name = "address";
            address.Size = new Size(280, 23);
            address.TabIndex = 3;
            // 
            // phone
            // 
            phone.Location = new Point(150, 210);
            phone.Margin = new Padding(3, 2, 3, 2);
            phone.Name = "phone";
            phone.Size = new Size(280, 23);
            phone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(40, 60);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(40, 90);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(40, 120);
            label3.Margin = new Padding(3, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 7;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(40, 150);
            label4.Margin = new Padding(3, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(40, 210);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 19);
            label5.TabIndex = 9;
            label5.Text = "Phone ";
            // 
            // radio_doctor
            // 
            radio_doctor.AutoSize = true;
            radio_doctor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radio_doctor.ForeColor = SystemColors.ControlLightLight;
            radio_doctor.Location = new Point(40, 260);
            radio_doctor.Margin = new Padding(3, 2, 3, 2);
            radio_doctor.Name = "radio_doctor";
            radio_doctor.Size = new Size(73, 23);
            radio_doctor.TabIndex = 12;
            radio_doctor.TabStop = true;
            radio_doctor.Text = "Doctor";
            radio_doctor.UseVisualStyleBackColor = true;
            radio_doctor.CheckedChanged += chose_major;
            // 
            // radio_nurse
            // 
            radio_nurse.AutoSize = true;
            radio_nurse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radio_nurse.ForeColor = SystemColors.ControlLightLight;
            radio_nurse.Location = new Point(40, 329);
            radio_nurse.Margin = new Padding(3, 2, 3, 2);
            radio_nurse.Name = "radio_nurse";
            radio_nurse.Size = new Size(66, 23);
            radio_nurse.TabIndex = 13;
            radio_nurse.TabStop = true;
            radio_nurse.Text = "Nurse";
            radio_nurse.UseVisualStyleBackColor = true;
            radio_nurse.CheckedChanged += chose_major;
            // 
            // n_wh
            // 
            n_wh.Enabled = false;
            n_wh.Location = new Point(147, 355);
            n_wh.Margin = new Padding(3, 2, 3, 2);
            n_wh.Name = "n_wh";
            n_wh.Size = new Size(110, 23);
            n_wh.TabIndex = 14;
            // 
            // d_yoe
            // 
            d_yoe.Enabled = false;
            d_yoe.Location = new Point(147, 288);
            d_yoe.Margin = new Padding(3, 2, 3, 2);
            d_yoe.Name = "d_yoe";
            d_yoe.Size = new Size(110, 23);
            d_yoe.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(135, 263);
            label6.Name = "label6";
            label6.Size = new Size(142, 19);
            label6.TabIndex = 16;
            label6.Text = "Years Of Experience";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(135, 332);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 17;
            label7.Text = "Working Hours";
            // 
            // button1
            // 
            button1.Location = new Point(260, 400);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += insert_employee;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(347, 400);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 22);
            clearButton.TabIndex = 19;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(10, 7);
            label8.Name = "label8";
            label8.Size = new Size(245, 38);
            label8.TabIndex = 20;
            label8.Text = "Insert Employee\r\nPlease Fill the required Information";
            // 
            // e_output
            // 
            e_output.AutoSize = true;
            e_output.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            e_output.ForeColor = SystemColors.ControlLightLight;
            e_output.Location = new Point(27, 396);
            e_output.Name = "e_output";
            e_output.Size = new Size(21, 19);
            e_output.TabIndex = 21;
            e_output.Text = "...";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(40, 180);
            label9.Margin = new Padding(3, 3, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(45, 19);
            label9.TabIndex = 22;
            label9.Text = "Clinic";
            // 
            // comboBoxClinic
            // 
            comboBoxClinic.FormattingEnabled = true;
            comboBoxClinic.Location = new Point(150, 180);
            comboBoxClinic.Name = "comboBoxClinic";
            comboBoxClinic.Size = new Size(280, 23);
            comboBoxClinic.TabIndex = 23;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(442, 437);
            Controls.Add(comboBoxClinic);
            Controls.Add(label9);
            Controls.Add(e_output);
            Controls.Add(label8);
            Controls.Add(clearButton);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(d_yoe);
            Controls.Add(n_wh);
            Controls.Add(radio_nurse);
            Controls.Add(radio_doctor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone);
            Controls.Add(address);
            Controls.Add(salary);
            Controls.Add(name);
            Controls.Add(id);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private TextBox name;
        private TextBox salary;
        private TextBox address;
        private TextBox phone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radio_doctor;
        private RadioButton radio_nurse;
        private TextBox n_wh;
        private TextBox d_yoe;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button clearButton;
        private Label label8;
        private Label e_output;
        private Label label9;
        private ComboBox comboBoxClinic;
    }
}