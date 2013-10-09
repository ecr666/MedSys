namespace Med_Sys.GUIs
{
    partial class Doctor_Main_Window
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
            this.LogLabel = new System.Windows.Forms.Label();
            this.AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.boxInTime = new System.Windows.Forms.CheckedListBox();
            this.Form = new System.Windows.Forms.Label();
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.PrescriptionGrid = new System.Windows.Forms.DataGridView();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntakeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntakeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_per_Intake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(54, 30);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(0, 13);
            this.LogLabel.TabIndex = 0;
            this.LogLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AppointmentGrid
            // 
            this.AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGrid.Location = new System.Drawing.Point(40, 110);
            this.AppointmentGrid.Name = "AppointmentGrid";
            this.AppointmentGrid.Size = new System.Drawing.Size(848, 126);
            this.AppointmentGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appointments";
            // 
            // btnPrescription
            // 
            this.btnPrescription.Location = new System.Drawing.Point(759, 263);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(129, 23);
            this.btnPrescription.TabIndex = 3;
            this.btnPrescription.Text = "Create Prescription";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "xxxx",
            "xxyy",
            "xyyyy",
            "yyyy"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(274, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Available Amount";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(401, 416);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "After Meal";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(401, 392);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Before Meal";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // boxInTime
            // 
            this.boxInTime.FormattingEnabled = true;
            this.boxInTime.Items.AddRange(new object[] {
            "Morning",
            "Day ",
            "Night"});
            this.boxInTime.Location = new System.Drawing.Point(401, 337);
            this.boxInTime.Name = "boxInTime";
            this.boxInTime.Size = new System.Drawing.Size(76, 49);
            this.boxInTime.TabIndex = 45;
            // 
            // Form
            // 
            this.Form.AutoSize = true;
            this.Form.Location = new System.Drawing.Point(161, 319);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(30, 13);
            this.Form.TabIndex = 44;
            this.Form.Text = "Form";
            // 
            // cmbForm
            // 
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.Items.AddRange(new object[] {
            "Pills",
            "Syrups"});
            this.cmbForm.Location = new System.Drawing.Point(160, 338);
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(102, 21);
            this.cmbForm.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(802, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 22);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(769, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Total Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Qty per Intake";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Intake time/ slot";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(641, 337);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(112, 21);
            this.comboBox5.TabIndex = 37;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(510, 337);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(769, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteCustomSource.AddRange(new string[] {
            "xxxx",
            "xxyy",
            "xyyyy",
            "yyyy"});
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(40, 338);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(806, 661);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PrescriptionGrid
            // 
            this.PrescriptionGrid.AllowUserToAddRows = false;
            this.PrescriptionGrid.AllowUserToDeleteRows = false;
            this.PrescriptionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescriptionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medName,
            this.ColForm,
            this.IntakeTime,
            this.IntakeSlot,
            this.Qty_per_Intake,
            this.Duration,
            this.Total});
            this.PrescriptionGrid.Location = new System.Drawing.Point(40, 490);
            this.PrescriptionGrid.Name = "PrescriptionGrid";
            this.PrescriptionGrid.ReadOnly = true;
            this.PrescriptionGrid.Size = new System.Drawing.Size(841, 150);
            this.PrescriptionGrid.TabIndex = 31;
            // 
            // medName
            // 
            this.medName.Frozen = true;
            this.medName.HeaderText = "Name";
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            // 
            // ColForm
            // 
            this.ColForm.Frozen = true;
            this.ColForm.HeaderText = "Form";
            this.ColForm.Name = "ColForm";
            this.ColForm.ReadOnly = true;
            // 
            // IntakeTime
            // 
            this.IntakeTime.Frozen = true;
            this.IntakeTime.HeaderText = "IntakeTime";
            this.IntakeTime.Name = "IntakeTime";
            this.IntakeTime.ReadOnly = true;
            // 
            // IntakeSlot
            // 
            this.IntakeSlot.Frozen = true;
            this.IntakeSlot.HeaderText = "IntakeSlot";
            this.IntakeSlot.Name = "IntakeSlot";
            this.IntakeSlot.ReadOnly = true;
            // 
            // Qty_per_Intake
            // 
            this.Qty_per_Intake.Frozen = true;
            this.Qty_per_Intake.HeaderText = "Qty-per-Intake";
            this.Qty_per_Intake.Name = "Qty_per_Intake";
            this.Qty_per_Intake.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.Frozen = true;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.Frozen = true;
            this.Total.HeaderText = "Total Amount";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Added Medicines";
            // 
            // Doctor_Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 749);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.boxInTime);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.cmbForm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PrescriptionGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentGrid);
            this.Controls.Add(this.LogLabel);
            this.Name = "Doctor_Main_Window";
            this.Text = "Doctor_Main_Window";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescriptionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.DataGridView AppointmentGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckedListBox boxInTime;
        private System.Windows.Forms.Label Form;
        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView PrescriptionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntakeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntakeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_per_Intake;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
    }
}