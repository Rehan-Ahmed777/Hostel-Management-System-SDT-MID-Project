namespace HostelManagementApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblStudentID = new Label();
            lblFullName = new Label();
            lblAge = new Label();
            lblRoomNo = new Label();
            lblContact = new Label();
            lblAddress = new Label();
            txtStudentID = new TextBox();
            txtAge = new TextBox();
            txtFullName = new TextBox();
            txtRoomNo = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            lblMonthlyFee = new Label();
            txtMonthlyFee = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dataGridViewStudents = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 11F);
            lblStudentID.ForeColor = Color.Black;
            lblStudentID.Location = new Point(502, 83);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(119, 30);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11F);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(502, 129);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(115, 30);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 11F);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(523, 177);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(57, 30);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            lblAge.Click += label3_Click;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Font = new Font("Segoe UI", 11F);
            lblRoomNo.ForeColor = Color.Black;
            lblRoomNo.Location = new Point(494, 228);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(110, 30);
            lblRoomNo.TabIndex = 3;
            lblRoomNo.Text = "Room No:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 11F);
            lblContact.ForeColor = Color.Black;
            lblContact.Location = new Point(490, 283);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(127, 30);
            lblContact.TabIndex = 4;
            lblContact.Text = "Contact No:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 11F);
            lblAddress.ForeColor = Color.Black;
            lblAddress.Location = new Point(502, 332);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(91, 30);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            lblAddress.Click += lblAddress_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.White;
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Font = new Font("Segoe UI", 11F);
            txtStudentID.ForeColor = Color.Black;
            txtStudentID.Location = new Point(652, 84);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(157, 37);
            txtStudentID.TabIndex = 6;
            txtStudentID.TextChanged += textBox1_TextChanged;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 11F);
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(652, 179);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(157, 37);
            txtAge.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(652, 131);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(157, 37);
            txtFullName.TabIndex = 8;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtRoomNo
            // 
            txtRoomNo.BackColor = Color.White;
            txtRoomNo.BorderStyle = BorderStyle.FixedSingle;
            txtRoomNo.Font = new Font("Segoe UI", 11F);
            txtRoomNo.ForeColor = Color.Black;
            txtRoomNo.Location = new Point(652, 228);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(157, 37);
            txtRoomNo.TabIndex = 9;
            txtRoomNo.TextChanged += txtRoomNo_TextChanged;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.White;
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 11F);
            txtContact.ForeColor = Color.Black;
            txtContact.Location = new Point(652, 283);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(157, 37);
            txtContact.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 11F);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(652, 332);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(157, 37);
            txtAddress.TabIndex = 11;
            // 
            // lblMonthlyFee
            // 
            lblMonthlyFee.AutoSize = true;
            lblMonthlyFee.Font = new Font("Segoe UI", 11F);
            lblMonthlyFee.ForeColor = Color.Black;
            lblMonthlyFee.Location = new Point(482, 393);
            lblMonthlyFee.Name = "lblMonthlyFee";
            lblMonthlyFee.Size = new Size(139, 30);
            lblMonthlyFee.TabIndex = 12;
            lblMonthlyFee.Text = "Monthly Fee:";
            lblMonthlyFee.Click += label1_Click;
            // 
            // txtMonthlyFee
            // 
            txtMonthlyFee.BackColor = Color.White;
            txtMonthlyFee.BorderStyle = BorderStyle.FixedSingle;
            txtMonthlyFee.Font = new Font("Segoe UI", 11F);
            txtMonthlyFee.ForeColor = Color.Black;
            txtMonthlyFee.Location = new Point(652, 391);
            txtMonthlyFee.Name = "txtMonthlyFee";
            txtMonthlyFee.Size = new Size(157, 37);
            txtMonthlyFee.TabIndex = 13;
            txtMonthlyFee.TextChanged += txtMonthlyFee_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(379, 446);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 47);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(557, 446);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(165, 47);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update Student";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(775, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 47);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(970, 446);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 47);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AllowUserToAddRows = false;
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStudents.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.GridColor = Color.Silver;
            dataGridViewStudents.Location = new Point(12, 524);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 62;
            dataGridViewStudents.Size = new Size(1331, 187);
            dataGridViewStudents.TabIndex = 18;
            dataGridViewStudents.CellClick += dataGridViewStudents_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(523, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 48);
            label1.TabIndex = 19;
            label1.Text = "MK Boys Hostel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1358, 752);
            Controls.Add(label1);
            Controls.Add(dataGridViewStudents);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtMonthlyFee);
            Controls.Add(lblMonthlyFee);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtRoomNo);
            Controls.Add(txtFullName);
            Controls.Add(txtAge);
            Controls.Add(txtStudentID);
            Controls.Add(lblAddress);
            Controls.Add(lblContact);
            Controls.Add(lblRoomNo);
            Controls.Add(lblAge);
            Controls.Add(lblFullName);
            Controls.Add(lblStudentID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblFullName;
        private Label lblAge;
        private Label lblRoomNo;
        private Label lblContact;
        private Label lblAddress;
        private TextBox txtStudentID;
        private TextBox txtAge;
        private TextBox txtFullName;
        private TextBox txtRoomNo;
        private TextBox txtContact;
        private TextBox txtAddress;
        private Label lblMonthlyFee;
        private TextBox txtMonthlyFee;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dataGridViewStudents;
        private Label label1;
    }
}
