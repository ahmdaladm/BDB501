namespace WinFormsApp1
{
    partial class Batient
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
            p_id = new TextBox();
            name = new TextBox();
            age = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            billAmount = new TextBox();
            label10 = new Label();
            p_output = new Label();
            add = new Button();
            clearButton = new Button();
            label11 = new Label();
            DisChargeStatus = new ComboBox();
            Disease = new ComboBox();
            DiagnosisType = new ComboBox();
            DisChargeDate = new DateTimePicker();
            d_id = new ComboBox();
            n_id = new ComboBox();
            SuspendLayout();
            // 
            // p_id
            // 
            p_id.Enabled = false;
            p_id.Location = new Point(183, 75);
            p_id.Name = "p_id";
            p_id.Size = new Size(198, 27);
            p_id.TabIndex = 0;
            p_id.TextAlign = HorizontalAlignment.Center;
            // 
            // name
            // 
            name.Location = new Point(183, 131);
            name.Name = "name";
            name.Size = new Size(198, 27);
            name.TabIndex = 1;
            name.TextAlign = HorizontalAlignment.Center;
            // 
            // age
            // 
            age.Location = new Point(183, 241);
            age.Name = "age";
            age.Size = new Size(198, 27);
            age.TabIndex = 3;
            age.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(22, 75);
            label1.Name = "label1";
            label1.Size = new Size(28, 23);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(22, 131);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 8;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(22, 187);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 9;
            label3.Text = "Disease";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(22, 245);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 10;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(22, 296);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 11;
            label5.Text = "Doctor ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(403, 79);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 12;
            label6.Text = "Nurse ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(403, 131);
            label7.Name = "label7";
            label7.Size = new Size(140, 23);
            label7.TabIndex = 13;
            label7.Text = "Dis Charge Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(404, 188);
            label8.Name = "label8";
            label8.Size = new Size(152, 23);
            label8.TabIndex = 15;
            label8.Text = "Dis Charge Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(404, 237);
            label9.Name = "label9";
            label9.Size = new Size(106, 23);
            label9.TabIndex = 17;
            label9.Text = "Bill Amount";
            // 
            // billAmount
            // 
            billAmount.Location = new Point(562, 236);
            billAmount.Name = "billAmount";
            billAmount.Size = new Size(198, 27);
            billAmount.TabIndex = 16;
            billAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(404, 293);
            label10.Name = "label10";
            label10.Size = new Size(130, 23);
            label10.TabIndex = 19;
            label10.Text = "Diagnosis Type";
            // 
            // p_output
            // 
            p_output.AutoSize = true;
            p_output.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            p_output.Location = new Point(45, 360);
            p_output.Name = "p_output";
            p_output.Size = new Size(25, 23);
            p_output.TabIndex = 20;
            p_output.Text = "...";
            // 
            // add
            // 
            add.ForeColor = SystemColors.ActiveCaptionText;
            add.Location = new Point(594, 409);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 21;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += Add_Click;
            // 
            // clearButton
            // 
            clearButton.ForeColor = SystemColors.ActiveCaptionText;
            clearButton.Location = new Point(694, 409);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 22;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(22, 9);
            label11.Name = "label11";
            label11.Size = new Size(221, 46);
            label11.TabIndex = 23;
            label11.Text = "Batient Information\r\nPlease Fill The Below Fild  ";
            // 
            // DisChargeStatus
            // 
            DisChargeStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DisChargeStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            DisChargeStatus.FormattingEnabled = true;
            DisChargeStatus.Items.AddRange(new object[] { "Recovery", "Review", "Death" });
            DisChargeStatus.Location = new Point(562, 186);
            DisChargeStatus.Name = "DisChargeStatus";
            DisChargeStatus.Size = new Size(198, 28);
            DisChargeStatus.TabIndex = 24;
            // 
            // Disease
            // 
            Disease.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Disease.AutoCompleteSource = AutoCompleteSource.ListItems;
            Disease.FormattingEnabled = true;
            Disease.Items.AddRange(new object[] { "Appendicitis", "Ovarian Cancer", "Pancreatitis", "Varicose Veins", "Liver Cirrhosis", "Breast Cancer", "COVID-19", "Ear Infections", "Tooth pathology", "Endometriosis", "Uterine Fibroids", "Atopic Dermatitis" });
            Disease.Location = new Point(183, 187);
            Disease.Name = "Disease";
            Disease.Size = new Size(198, 28);
            Disease.TabIndex = 27;
            // 
            // DiagnosisType
            // 
            DiagnosisType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DiagnosisType.AutoCompleteSource = AutoCompleteSource.ListItems;
            DiagnosisType.FormattingEnabled = true;
            DiagnosisType.Items.AddRange(new object[] { "Surgery", "Vaccination", "Prescription" });
            DiagnosisType.Location = new Point(562, 293);
            DiagnosisType.Name = "DiagnosisType";
            DiagnosisType.Size = new Size(198, 28);
            DiagnosisType.TabIndex = 28;
            // 
            // DisChargeDate
            // 
            DisChargeDate.Location = new Point(562, 131);
            DisChargeDate.Name = "DisChargeDate";
            DisChargeDate.Size = new Size(198, 27);
            DisChargeDate.TabIndex = 29;
            // 
            // d_id
            // 
            d_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            d_id.AutoCompleteSource = AutoCompleteSource.ListItems;
            d_id.Location = new Point(183, 296);
            d_id.Name = "d_id";
            d_id.Size = new Size(198, 28);
            d_id.TabIndex = 32;
            d_id.Leave += check_id;
            // 
            // n_id
            // 
            n_id.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            n_id.AutoCompleteSource = AutoCompleteSource.ListItems;
            n_id.FormattingEnabled = true;
            n_id.Location = new Point(562, 79);
            n_id.Name = "n_id";
            n_id.Size = new Size(198, 28);
            n_id.TabIndex = 33;
            n_id.Leave += check_id;
            // 
            // Batient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(794, 448);
            Controls.Add(n_id);
            Controls.Add(d_id);
            Controls.Add(DisChargeDate);
            Controls.Add(DiagnosisType);
            Controls.Add(Disease);
            Controls.Add(DisChargeStatus);
            Controls.Add(label11);
            Controls.Add(clearButton);
            Controls.Add(add);
            Controls.Add(p_output);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(billAmount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(p_id);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Batient";
            Text = "Batient";
            Load += Batient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox p_id;
        private TextBox name;
        private TextBox age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox billAmount;
        private Label label10;
        private Label p_output;
        private Button add;
        private Button clearButton;
        private Label label11;
        private ComboBox DisChargeStatus;
        private TextBox disChargeDate;
        private Button button1;
        private ComboBox Disease;
        private ComboBox DiagnosisType;
        private DateTimePicker DisChargeDate;
        private ComboBox d_id;
        private ComboBox n_id;
    }
}