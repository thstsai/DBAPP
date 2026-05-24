namespace UniversityManagementSystem.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip                   = new System.Windows.Forms.MenuStrip();
            this.userMgmtMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersMenuItem         = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInstructorsMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMgmtMenuItem          = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoursesMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSectionsMenuItem      = new System.Windows.Forms.ToolStripMenuItem();
            this.managePrereqsMenuItem       = new System.Windows.Forms.ToolStripMenuItem();
            this.deptMgmtMenuItem            = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDepartmentsMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClassroomsMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentReportMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.coursePerformanceMenuItem   = new System.Windows.Forms.ToolStripMenuItem();
            this.studentProgressMenuItem     = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel                  = new System.Windows.Forms.Label();
            this.mainDataGridView            = new System.Windows.Forms.DataGridView();
            this.inputPanel                  = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.userMgmtMenuItem,
                this.courseMgmtMenuItem,
                this.deptMgmtMenuItem,
                this.reportingMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1100, 24);

            // userMgmtMenuItem
            this.userMgmtMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.manageUsersMenuItem,
                this.manageStudentsMenuItem,
                this.manageInstructorsMenuItem });
            this.userMgmtMenuItem.Name = "userMgmtMenuItem";
            this.userMgmtMenuItem.Text = "User Management";

            this.manageUsersMenuItem.Name = "manageUsersMenuItem";
            this.manageUsersMenuItem.Text = "Manage Users";
            this.manageUsersMenuItem.Click += new System.EventHandler(this.manageUsersMenuItem_Click);

            this.manageStudentsMenuItem.Name = "manageStudentsMenuItem";
            this.manageStudentsMenuItem.Text = "Manage Students";
            this.manageStudentsMenuItem.Click += new System.EventHandler(this.manageStudentsMenuItem_Click);

            this.manageInstructorsMenuItem.Name = "manageInstructorsMenuItem";
            this.manageInstructorsMenuItem.Text = "Manage Instructors";
            this.manageInstructorsMenuItem.Click += new System.EventHandler(this.manageInstructorsMenuItem_Click);

            // courseMgmtMenuItem
            this.courseMgmtMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.manageCoursesMenuItem,
                this.manageSectionsMenuItem,
                this.managePrereqsMenuItem });
            this.courseMgmtMenuItem.Name = "courseMgmtMenuItem";
            this.courseMgmtMenuItem.Text = "Course Management";

            this.manageCoursesMenuItem.Name = "manageCoursesMenuItem";
            this.manageCoursesMenuItem.Text = "Courses";
            this.manageCoursesMenuItem.Click += new System.EventHandler(this.manageCoursesMenuItem_Click);

            this.manageSectionsMenuItem.Name = "manageSectionsMenuItem";
            this.manageSectionsMenuItem.Text = "Sections";
            this.manageSectionsMenuItem.Click += new System.EventHandler(this.manageSectionsMenuItem_Click);

            this.managePrereqsMenuItem.Name = "managePrereqsMenuItem";
            this.managePrereqsMenuItem.Text = "Prerequisites";
            this.managePrereqsMenuItem.Click += new System.EventHandler(this.managePrereqsMenuItem_Click);

            // deptMgmtMenuItem
            this.deptMgmtMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.manageDepartmentsMenuItem,
                this.manageClassroomsMenuItem });
            this.deptMgmtMenuItem.Name = "deptMgmtMenuItem";
            this.deptMgmtMenuItem.Text = "Department Management";

            this.manageDepartmentsMenuItem.Name = "manageDepartmentsMenuItem";
            this.manageDepartmentsMenuItem.Text = "Departments";
            this.manageDepartmentsMenuItem.Click += new System.EventHandler(this.manageDepartmentsMenuItem_Click);

            this.manageClassroomsMenuItem.Name = "manageClassroomsMenuItem";
            this.manageClassroomsMenuItem.Text = "Classrooms";
            this.manageClassroomsMenuItem.Click += new System.EventHandler(this.manageClassroomsMenuItem_Click);

            // reportingMenuItem
            this.reportingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.enrollmentReportMenuItem,
                this.coursePerformanceMenuItem,
                this.studentProgressMenuItem });
            this.reportingMenuItem.Name = "reportingMenuItem";
            this.reportingMenuItem.Text = "Reporting && Analytics";

            this.enrollmentReportMenuItem.Name = "enrollmentReportMenuItem";
            this.enrollmentReportMenuItem.Text = "Enrollment Statistics";
            this.enrollmentReportMenuItem.Click += new System.EventHandler(this.enrollmentReportMenuItem_Click);

            this.coursePerformanceMenuItem.Name = "coursePerformanceMenuItem";
            this.coursePerformanceMenuItem.Text = "Course Performance";
            this.coursePerformanceMenuItem.Click += new System.EventHandler(this.coursePerformanceMenuItem_Click);

            this.studentProgressMenuItem.Name = "studentProgressMenuItem";
            this.studentProgressMenuItem.Text = "Student Progress";
            this.studentProgressMenuItem.Click += new System.EventHandler(this.studentProgressMenuItem_Click);

            // titleLabel
            this.titleLabel.AutoSize = false;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.None;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titleLabel.Location = new System.Drawing.Point(0, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1100, 30);
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.titleLabel.Text = "Select a menu item to begin";

            // mainDataGridView
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 60);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.RowHeadersVisible = false;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(1100, 420);

            // inputPanel
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Location = new System.Drawing.Point(0, 483);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(1100, 117);
            this.inputPanel.AutoScroll = true;

            // AdminForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.inputPanel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip         menuStrip;
        private System.Windows.Forms.ToolStripMenuItem userMgmtMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInstructorsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMgmtMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCoursesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSectionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePrereqsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deptMgmtMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDepartmentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClassroomsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursePerformanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentProgressMenuItem;
        private System.Windows.Forms.Label             titleLabel;
        private System.Windows.Forms.DataGridView      mainDataGridView;
        private System.Windows.Forms.Panel             inputPanel;
    }
}
