using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class ManagementSystem : Form
    {
        StudentDB.Admin admin;

        public ManagementSystem(StudentDB.Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void ManagementSystem_Load(object sender, EventArgs e)
        {
            LoadData();
            panel1.Visible = false;
        }

        public void LoadData()
        {
            label8.Text = "Hi " + admin.UserName;
            dgvStudentList.Rows.Clear();
            foreach (Student s in StudentDB.students)
            {
                dgvStudentList.Rows.Add(
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    s.Age,
                    s.Gender,
                    s.Classname,
                    s.Grade);
            }
        }

        public void InitailizePane()
        {
            txtId.Text = null;
            txtfn.Text = null;
            txtln.Text = null;
            txtAge.Text = null;
            cmbGender.SelectedIndex = 0;
            txtClassname.Text = null;
            txtGrade.Text = null;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string password = Interaction.InputBox("Input password", "Authentication", "", -1, -1);
            if (password == admin.Password)
            {
                panel1.Visible = true;
            }
        }

        private void dgvStudentList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudentList.CurrentRow != null)
            {
                int index = dgvStudentList.CurrentRow.Index;
                if (index >= 0 && index < StudentDB.students.Count)
                {
                    Student s = StudentDB.students[index];
                    txtId.Text = s.Id.ToString();
                    txtfn.Text = s.FirstName;
                    txtln.Text = s.LastName;
                    txtAge.Text = s.Age.ToString();
                    cmbGender.SelectedItem = s.Gender;
                    txtClassname.Text = s.Classname;
                    txtGrade.Text = s.Grade.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvStudentList.CurrentRow.Index;
            if (index >= 0)
            {
                Student s = StudentDB.students[index];
                StudentDB.students.RemoveAt(index);
                dgvStudentList.Rows.RemoveAt(index);
                StudentDB.WriteStudent();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string fn = txtfn.Text;
                string ln = txtln.Text;
                int age = int.Parse(txtAge.Text);
                string gender = cmbGender.Text;
                string clsname = txtClassname.Text;
                float grade = float.Parse(txtGrade.Text);
                if (StudentDB.students.Any(student => student.Id == id))
                {
                    MessageBox.Show($"Student({id}) exist.");
                }
                else
                {
                    StudentDB.students.Add(new Student(id, fn, ln, age, gender, clsname, grade));
                    LoadData();
                    StudentDB.WriteStudent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string fn = txtfn.Text;
                string ln = txtln.Text;
                int age = int.Parse(txtAge.Text);
                string gender = cmbGender.Text;
                string clsname = txtClassname.Text;
                float grade = float.Parse(txtGrade.Text);

                int i = StudentDB.students.FindIndex(student => student.Id == id);

                if (i != dgvStudentList.CurrentRow.Index && i != -1)
                {
                    MessageBox.Show($"Student({id}) exist.");
                }
                else
                {
                    StudentDB.students[dgvStudentList.CurrentRow.Index] = new Student(id, fn, ln, age, gender, clsname, grade);
                    LoadData();
                    StudentDB.WriteStudent();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void tbnsearch_Click(object sender, EventArgs e)
        {
            bool result = false;
            if(int.TryParse(txtSearch.Text, out int id))
            {
                int i = StudentDB.students.FindIndex(s => s.Id == id);
                if(i != -1)
                {
                    dgvStudentList.ClearSelection();
                    dgvStudentList.Rows[i].Selected = true;
                    Student s = StudentDB.students[i];
                    txtId.Text = s.Id.ToString();
                    txtfn.Text = s.FirstName;
                    txtln.Text = s.LastName;
                    txtAge.Text = s.Age.ToString();
                    cmbGender.SelectedItem = s.Gender;
                    txtClassname.Text = s.Classname;
                    txtGrade.Text = s.Grade.ToString();
                    result = true;
                }
            }
            else
            {
                string name = txtSearch.Text;
                int i = StudentDB.students.FindIndex(s => s.FirstName == name || s.LastName == name);
                if (i != -1)
                {
                    dgvStudentList.ClearSelection();
                    dgvStudentList.Rows[i].Selected = true;
                    Student s = StudentDB.students[i];
                    txtId.Text = s.Id.ToString();
                    txtfn.Text = s.FirstName;
                    txtln.Text = s.LastName;
                    txtAge.Text = s.Age.ToString();
                    cmbGender.SelectedItem = s.Gender;
                    txtClassname.Text = s.Classname;
                    txtGrade.Text = s.Grade.ToString();
                    result = true;
                }
            }
            if(!result)
            {
                MessageBox.Show("Cann't find.");
            }
        }
    }
}
