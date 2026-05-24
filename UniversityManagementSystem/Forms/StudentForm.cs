using System;
using System.Linq;
using System.Windows.Forms;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Forms
{
    public partial class StudentForm : Form
    {
        private string _studentId;

        public StudentForm()
        {
            InitializeComponent();
            _studentId = Session.CurrentUser.username;
            LoadProfile();
            LoadEnrollment();
        }

        private void LoadProfile()
        {
            using (var db = new UniversityEntities())
            {
                var s = db.student.Find(_studentId);
                if (s == null) return;

                deptNameTextBox.Text = s.dept_name != null ? s.dept_name : "";
                idTextBox.Text       = s.ID;
                nameTextBox.Text     = s.name;
                totCredTextBox.Text  = s.tot_cred.HasValue ? s.tot_cred.Value.ToString() : "0";
            }
        }

        private void LoadEnrollment()
        {
            using (var db = new UniversityEntities())
            {
                var rows = (from t in db.takes
                            join sec in db.section
                                on new { t.course_id, t.sec_id, t.semester, t.year }
                                equals new { sec.course_id, sec.sec_id, sec.semester, sec.year }
                            join c in db.course on t.course_id equals c.course_id
                            where t.ID == _studentId
                            select new
                            {
                                t.course_id,
                                course_title = c.title,
                                t.sec_id,
                                t.semester,
                                t.year,
                                t.grade
                            }).ToList();

                enrollDataGridView.DataSource = rows;
            }
        }

        private void profileMenuItem_Click(object sender, EventArgs e)
        {
            leftPanel.Visible = true;
        }

        private void enrollMenuItem_Click(object sender, EventArgs e)
        {
            LoadEnrollment();
        }
    }
}
