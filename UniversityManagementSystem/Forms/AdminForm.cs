using System;
using System.Linq;
using System.Windows.Forms;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        // ── helpers ─────────────────────────────────────────────────────────

        private void LoadGrid(object data, string panelTitle)
        {
            titleLabel.Text = panelTitle;
            mainDataGridView.DataSource = data;
            mainDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ── User Management ──────────────────────────────────────────────────

        private void manageUsersMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.user.Select(u => new { u.ID, u.username, u.role }).ToList(),
                         "User Management");

            BuildInputPanel(new[] { "Username", "Password", "Role (administrator/instructor/student)" },
                onAdd: vals =>
                {
                    using (var db = new UniversityEntities())
                    {
                        db.user.Add(new User { username = vals[0], password = vals[1], role = vals[2] });
                        db.SaveChanges();
                    }
                    manageUsersMenuItem_Click(sender, e);
                },
                onDelete: () =>
                {
                    if (mainDataGridView.CurrentRow == null) return;
                    int id = (int)mainDataGridView.CurrentRow.Cells["ID"].Value;
                    using (var db = new UniversityEntities())
                    {
                        var u = db.user.Find(id);
                        if (u != null) { db.user.Remove(u); db.SaveChanges(); }
                    }
                    manageUsersMenuItem_Click(sender, e);
                });
        }

        private void manageStudentsMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.student.ToList(), "Student Management");

            BuildInputPanel(new[] { "ID (5 chars)", "Name", "Dept Name", "Tot Credits" },
                onAdd: vals =>
                {
                    decimal tc;
                    decimal.TryParse(vals[3], out tc);
                    using (var db = new UniversityEntities())
                    {
                        db.student.Add(new Student
                        {
                            ID = vals[0], name = vals[1],
                            dept_name = vals[2], tot_cred = tc
                        });
                        db.SaveChanges();
                    }
                    manageStudentsMenuItem_Click(sender, e);
                },
                onDelete: () =>
                {
                    if (mainDataGridView.CurrentRow == null) return;
                    string id = mainDataGridView.CurrentRow.Cells["ID"].Value != null
                        ? mainDataGridView.CurrentRow.Cells["ID"].Value.ToString() : null;
                    using (var db = new UniversityEntities())
                    {
                        var s = db.student.Find(id);
                        if (s != null) { db.student.Remove(s); db.SaveChanges(); }
                    }
                    manageStudentsMenuItem_Click(sender, e);
                });
        }

        private void manageInstructorsMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.instructor.ToList(), "Instructor Management");

            BuildInputPanel(new[] { "ID (5 chars)", "Name", "Dept Name", "Salary" },
                onAdd: vals =>
                {
                    decimal sal;
                    decimal.TryParse(vals[3], out sal);
                    using (var db = new UniversityEntities())
                    {
                        db.instructor.Add(new Instructor
                        {
                            ID = vals[0], name = vals[1],
                            dept_name = vals[2], salary = sal
                        });
                        db.SaveChanges();
                    }
                    manageInstructorsMenuItem_Click(sender, e);
                },
                onDelete: () =>
                {
                    if (mainDataGridView.CurrentRow == null) return;
                    string id = mainDataGridView.CurrentRow.Cells["ID"].Value != null
                        ? mainDataGridView.CurrentRow.Cells["ID"].Value.ToString() : null;
                    using (var db = new UniversityEntities())
                    {
                        var inst = db.instructor.Find(id);
                        if (inst != null) { db.instructor.Remove(inst); db.SaveChanges(); }
                    }
                    manageInstructorsMenuItem_Click(sender, e);
                });
        }

        // ── Course Management ────────────────────────────────────────────────

        private void manageCoursesMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.course.ToList(), "Course Management");

            BuildInputPanel(new[] { "Course ID", "Title", "Dept Name", "Credits" },
                onAdd: vals =>
                {
                    decimal cr;
                    if (!decimal.TryParse(vals[3], out cr)) cr = 3;
                    using (var db = new UniversityEntities())
                    {
                        db.course.Add(new Course
                        {
                            course_id = vals[0], title = vals[1],
                            dept_name = vals[2], credits = cr
                        });
                        db.SaveChanges();
                    }
                    manageCoursesMenuItem_Click(sender, e);
                },
                onDelete: () =>
                {
                    if (mainDataGridView.CurrentRow == null) return;
                    string id = mainDataGridView.CurrentRow.Cells["course_id"].Value != null
                        ? mainDataGridView.CurrentRow.Cells["course_id"].Value.ToString() : null;
                    using (var db = new UniversityEntities())
                    {
                        var c = db.course.Find(id);
                        if (c != null) { db.course.Remove(c); db.SaveChanges(); }
                    }
                    manageCoursesMenuItem_Click(sender, e);
                });
        }

        private void manageSectionsMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.section.ToList(), "Section Management");
            BuildInputPanel(new string[0], null, null);
        }

        private void managePrereqsMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.prereq.ToList(), "Prerequisite Management");
            BuildInputPanel(new string[0], null, null);
        }

        // ── Department Management ────────────────────────────────────────────

        private void manageDepartmentsMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.department.ToList(), "Department Management");

            BuildInputPanel(new[] { "Dept Name", "Building", "Budget" },
                onAdd: vals =>
                {
                    decimal b;
                    decimal.TryParse(vals[2], out b);
                    using (var db = new UniversityEntities())
                    {
                        db.department.Add(new Department
                        {
                            dept_name = vals[0], building = vals[1], budget = b
                        });
                        db.SaveChanges();
                    }
                    manageDepartmentsMenuItem_Click(sender, e);
                },
                onDelete: () =>
                {
                    if (mainDataGridView.CurrentRow == null) return;
                    string id = mainDataGridView.CurrentRow.Cells["dept_name"].Value != null
                        ? mainDataGridView.CurrentRow.Cells["dept_name"].Value.ToString() : null;
                    using (var db = new UniversityEntities())
                    {
                        var d = db.department.Find(id);
                        if (d != null) { db.department.Remove(d); db.SaveChanges(); }
                    }
                    manageDepartmentsMenuItem_Click(sender, e);
                });
        }

        private void manageClassroomsMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
                LoadGrid(db.classroom.ToList(), "Classroom Management");
            BuildInputPanel(new string[0], null, null);
        }

        // ── Reporting & Analytics ────────────────────────────────────────────

        private void enrollmentReportMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
            {
                var rows = (from t in db.takes
                            group t by new { t.course_id, t.semester, t.year } into g
                            select new
                            {
                                g.Key.course_id,
                                g.Key.semester,
                                g.Key.year,
                                enrolled = g.Count()
                            }).OrderByDescending(x => x.enrolled).ToList();
                LoadGrid(rows, "Enrollment Statistics");
            }
            BuildInputPanel(new string[0], null, null);
        }

        private void coursePerformanceMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
            {
                var rows = (from t in db.takes
                            where t.grade != null
                            group t by t.course_id into g
                            join c in db.course on g.Key equals c.course_id
                            select new
                            {
                                course_id = g.Key,
                                title     = c.title,
                                students  = g.Count(),
                                grade_A   = g.Count(x => x.grade == "A" || x.grade == "A-")
                            }).ToList();
                LoadGrid(rows, "Course Performance");
            }
            BuildInputPanel(new string[0], null, null);
        }

        private void studentProgressMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
            {
                var rows = (from s in db.student
                            join a in db.advisor on s.ID equals a.s_ID into advisors
                            from a in advisors.DefaultIfEmpty()
                            join i in db.instructor on a.i_ID equals i.ID into insts
                            from i in insts.DefaultIfEmpty()
                            select new
                            {
                                student_id   = s.ID,
                                student_name = s.name,
                                dept         = s.dept_name,
                                tot_cred     = s.tot_cred,
                                advisor      = i.name
                            }).ToList();
                LoadGrid(rows, "Student Progress");
            }
            BuildInputPanel(new string[0], null, null);
        }

        // ── dynamic input panel builder ──────────────────────────────────────

        private void BuildInputPanel(string[] fieldLabels, Action<string[]> onAdd, Action onDelete)
        {
            inputPanel.Controls.Clear();
            var inputs = new TextBox[fieldLabels.Length];

            int y = 8;
            for (int i = 0; i < fieldLabels.Length; i++)
            {
                var lbl = new Label
                {
                    Text = fieldLabels[i],
                    Location = new System.Drawing.Point(4, y + 2),
                    AutoSize = true
                };
                var tb = new TextBox
                {
                    Location = new System.Drawing.Point(250, y),
                    Size = new System.Drawing.Size(180, 20)
                };
                inputs[i] = tb;
                inputPanel.Controls.Add(lbl);
                inputPanel.Controls.Add(tb);
                y += 30;
            }

            if (onAdd != null)
            {
                var addBtn = new Button
                {
                    Text = "Add",
                    Location = new System.Drawing.Point(4, y + 6),
                    Size = new System.Drawing.Size(80, 26),
                    BackColor = System.Drawing.Color.MediumSeaGreen,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                var addCapture = onAdd;
                addBtn.Click += (s, ev) =>
                {
                    try
                    {
                        string[] vals = new string[inputs.Length];
                        for (int i = 0; i < inputs.Length; i++) vals[i] = inputs[i].Text.Trim();
                        addCapture(vals);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                inputPanel.Controls.Add(addBtn);
            }

            if (onDelete != null)
            {
                var delBtn = new Button
                {
                    Text = "Delete Selected",
                    Location = new System.Drawing.Point(90, y + 6),
                    Size = new System.Drawing.Size(120, 26),
                    BackColor = System.Drawing.Color.Tomato,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                var delCapture = onDelete;
                delBtn.Click += (s, ev) =>
                {
                    if (MessageBox.Show("Delete selected record?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try { delCapture(); }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
                inputPanel.Controls.Add(delBtn);
            }
        }
    }
}
