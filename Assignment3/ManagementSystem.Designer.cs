namespace Assignment3
{
    partial class ManagementSystem
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
            dgvStudentList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Classname = new DataGridViewTextBoxColumn();
            Grade = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cmbGender = new ComboBox();
            txtGrade = new TextBox();
            label7 = new Label();
            txtClassname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtln = new TextBox();
            label3 = new Label();
            txtfn = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnAdmin = new Button();
            label8 = new Label();
            txtSearch = new TextBox();
            tbnsearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Columns.AddRange(new DataGridViewColumn[] { ID, FirstName, LastName, Age, Gender, Classname, Grade });
            dgvStudentList.Location = new Point(20, 56);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.Size = new Size(570, 624);
            dgvStudentList.TabIndex = 0;
            dgvStudentList.SelectionChanged += dgvStudentList_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 80;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 80;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Width = 80;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Width = 80;
            // 
            // Classname
            // 
            Classname.HeaderText = "Classname";
            Classname.Name = "Classname";
            Classname.ReadOnly = true;
            Classname.Width = 80;
            // 
            // Grade
            // 
            Grade.HeaderText = "Grade";
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            Grade.Width = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(txtGrade);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtClassname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtln);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtfn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(609, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 587);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(70, 522);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(70, 467);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(70, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(96, 254);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(100, 25);
            cmbGender.TabIndex = 14;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(96, 357);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 360);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 12;
            label7.Text = "Grade: ";
            // 
            // txtClassname
            // 
            txtClassname.Location = new Point(96, 300);
            txtClassname.Name = "txtClassname";
            txtClassname.Size = new Size(100, 23);
            txtClassname.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 303);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 10;
            label6.Text = "Classname:  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 257);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 8;
            label5.Text = "Gender: ";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(96, 200);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 203);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 6;
            label4.Text = "Age: ";
            // 
            // txtln
            // 
            txtln.Location = new Point(96, 139);
            txtln.Name = "txtln";
            txtln.Size = new Size(100, 23);
            txtln.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 142);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 4;
            label3.Text = "Last Name: ";
            // 
            // txtfn
            // 
            txtfn.Location = new Point(96, 78);
            txtfn.Name = "txtfn";
            txtfn.Size = new Size(100, 23);
            txtfn.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 2;
            label2.Text = "First Name: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "Student ID: ";
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(651, 21);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(132, 42);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Manage Student";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(20, 9);
            label8.Name = "label8";
            label8.Size = new Size(0, 26);
            label8.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(305, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 5;
            // 
            // tbnsearch
            // 
            tbnsearch.Location = new Point(411, 17);
            tbnsearch.Name = "tbnsearch";
            tbnsearch.Size = new Size(75, 23);
            tbnsearch.TabIndex = 6;
            tbnsearch.Text = " Search";
            tbnsearch.UseVisualStyleBackColor = true;
            tbnsearch.Click += tbnsearch_Click;
            // 
            // ManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 692);
            Controls.Add(tbnsearch);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(btnAdmin);
            Controls.Add(panel1);
            Controls.Add(dgvStudentList);
            Name = "ManagementSystem";
            Text = "ManagementSystem";
            Load += ManagementSystem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentList;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Classname;
        private DataGridViewTextBoxColumn Grade;
        private Panel panel1;
        private Button btnAdmin;
        private Label label1;
        private TextBox txtId;
        private ComboBox cmbGender;
        private TextBox txtGrade;
        private Label label7;
        private TextBox txtClassname;
        private Label label6;
        private Label label5;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtln;
        private Label label3;
        private TextBox txtfn;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label8;
        private TextBox txtSearch;
        private Button tbnsearch;
    }
}