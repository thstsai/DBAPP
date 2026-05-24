using System;
using System.Linq;
using System.Windows.Forms;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Forms
{
    public partial class FacultyForm : Form
    {
        private string _instructorId;

        public FacultyForm()
        {
            InitializeComponent();
            _instructorId = Session.CurrentUser.username;
            LoadProfile();
            LoadStudentRosters();
        }

        private void LoadProfile()
        {
            using (var db = new UniversityEntities())
            {
                var inst = db.instructor.Find(_instructorId);
                if (inst == null) return;

                instIdTextBox.Text     = inst.ID;
                instNameTextBox.Text   = inst.name;
                instDeptTextBox.Text   = inst.dept_name != null ? inst.dept_name : "";
                instSalaryTextBox.Text = inst.salary.HasValue ? inst.salary.Value.ToString("F2") : "";
            }
        }

        private void LoadStudentRosters()
        {
            using (var db = new UniversityEntities())
            {
                var rows = (from t in db.teaches
                            join sec in db.section
                                on new { t.course_id, t.sec_id, t.semester, t.year }
                                equals new { sec.course_id, sec.sec_id, sec.semester, sec.year }
                            join tk in db.takes
                                on new { sec.course_id, sec.sec_id, sec.semester, sec.year }
                                equals new { tk.course_id, tk.sec_id, tk.semester, tk.year }
                            join s in db.student on tk.ID equals s.ID
                            where t.ID == _instructorId
                            select new
                            {
                                student_id   = s.ID,
                                student_name = s.name,
                                t.course_id,
                                t.sec_id,
                                t.semester,
                                t.year,
                                tk.grade
                            }).ToList();

                rosterDataGridView.DataSource = rows;
            }
        }

        private void profileMenuItem_Click(object sender, EventArgs e)
        {
            leftPanel.Visible = true;
        }

        private void studentRostersMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentRosters();
        }

    private void FacultyForm_Load(object sender, EventArgs e)
    {

    }
  }
}
