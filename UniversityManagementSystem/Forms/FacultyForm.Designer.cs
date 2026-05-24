namespace UniversityManagementSystem.Forms
{
    partial class FacultyForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.profileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.studentRostersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.leftPanel = new System.Windows.Forms.Panel();
      this.instIdLabel = new System.Windows.Forms.Label();
      this.instIdTextBox = new System.Windows.Forms.TextBox();
      this.instNameLabel = new System.Windows.Forms.Label();
      this.instNameTextBox = new System.Windows.Forms.TextBox();
      this.instDeptLabel = new System.Windows.Forms.Label();
      this.instDeptTextBox = new System.Windows.Forms.TextBox();
      this.instSalaryLabel = new System.Windows.Forms.Label();
      this.instSalaryTextBox = new System.Windows.Forms.TextBox();
      this.rosterDataGridView = new System.Windows.Forms.DataGridView();
      this.menuStrip.SuspendLayout();
      this.leftPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rosterDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileMenuItem,
            this.studentRostersMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip.Size = new System.Drawing.Size(1350, 33);
      this.menuStrip.TabIndex = 0;
      // 
      // profileMenuItem
      // 
      this.profileMenuItem.Name = "profileMenuItem";
      this.profileMenuItem.Size = new System.Drawing.Size(81, 27);
      this.profileMenuItem.Text = "Profile";
      this.profileMenuItem.Click += new System.EventHandler(this.profileMenuItem_Click);
      // 
      // studentRostersMenuItem
      // 
      this.studentRostersMenuItem.Name = "studentRostersMenuItem";
      this.studentRostersMenuItem.Size = new System.Drawing.Size(161, 27);
      this.studentRostersMenuItem.Text = "Student Rosters";
      this.studentRostersMenuItem.Click += new System.EventHandler(this.studentRostersMenuItem_Click);
      // 
      // leftPanel
      // 
      this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.leftPanel.Controls.Add(this.instIdLabel);
      this.leftPanel.Controls.Add(this.instIdTextBox);
      this.leftPanel.Controls.Add(this.instNameLabel);
      this.leftPanel.Controls.Add(this.instNameTextBox);
      this.leftPanel.Controls.Add(this.instDeptLabel);
      this.leftPanel.Controls.Add(this.instDeptTextBox);
      this.leftPanel.Controls.Add(this.instSalaryLabel);
      this.leftPanel.Controls.Add(this.instSalaryTextBox);
      this.leftPanel.Location = new System.Drawing.Point(0, 37);
      this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(314, 613);
      this.leftPanel.TabIndex = 1;
      // 
      // instIdLabel
      // 
      this.instIdLabel.AutoSize = true;
      this.instIdLabel.Location = new System.Drawing.Point(12, 28);
      this.instIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.instIdLabel.Name = "instIdLabel";
      this.instIdLabel.Size = new System.Drawing.Size(31, 18);
      this.instIdLabel.TabIndex = 0;
      this.instIdLabel.Text = "ID:";
      // 
      // instIdTextBox
      // 
      this.instIdTextBox.Location = new System.Drawing.Point(123, 24);
      this.instIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.instIdTextBox.Name = "instIdTextBox";
      this.instIdTextBox.ReadOnly = true;
      this.instIdTextBox.Size = new System.Drawing.Size(163, 29);
      this.instIdTextBox.TabIndex = 1;
      // 
      // instNameLabel
      // 
      this.instNameLabel.AutoSize = true;
      this.instNameLabel.Location = new System.Drawing.Point(12, 76);
      this.instNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.instNameLabel.Name = "instNameLabel";
      this.instNameLabel.Size = new System.Drawing.Size(50, 18);
      this.instNameLabel.TabIndex = 2;
      this.instNameLabel.Text = "name:";
      // 
      // instNameTextBox
      // 
      this.instNameTextBox.Location = new System.Drawing.Point(123, 72);
      this.instNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.instNameTextBox.Name = "instNameTextBox";
      this.instNameTextBox.ReadOnly = true;
      this.instNameTextBox.Size = new System.Drawing.Size(163, 29);
      this.instNameTextBox.TabIndex = 3;
      // 
      // instDeptLabel
      // 
      this.instDeptLabel.AutoSize = true;
      this.instDeptLabel.Location = new System.Drawing.Point(12, 125);
      this.instDeptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.instDeptLabel.Name = "instDeptLabel";
      this.instDeptLabel.Size = new System.Drawing.Size(84, 18);
      this.instDeptLabel.TabIndex = 4;
      this.instDeptLabel.Text = "dept name:";
      // 
      // instDeptTextBox
      // 
      this.instDeptTextBox.Location = new System.Drawing.Point(123, 120);
      this.instDeptTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.instDeptTextBox.Name = "instDeptTextBox";
      this.instDeptTextBox.ReadOnly = true;
      this.instDeptTextBox.Size = new System.Drawing.Size(163, 29);
      this.instDeptTextBox.TabIndex = 5;
      // 
      // instSalaryLabel
      // 
      this.instSalaryLabel.AutoSize = true;
      this.instSalaryLabel.Location = new System.Drawing.Point(12, 173);
      this.instSalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.instSalaryLabel.Name = "instSalaryLabel";
      this.instSalaryLabel.Size = new System.Drawing.Size(55, 18);
      this.instSalaryLabel.TabIndex = 6;
      this.instSalaryLabel.Text = "salary:";
      // 
      // instSalaryTextBox
      // 
      this.instSalaryTextBox.Location = new System.Drawing.Point(123, 169);
      this.instSalaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.instSalaryTextBox.Name = "instSalaryTextBox";
      this.instSalaryTextBox.ReadOnly = true;
      this.instSalaryTextBox.Size = new System.Drawing.Size(163, 29);
      this.instSalaryTextBox.TabIndex = 7;
      // 
      // rosterDataGridView
      // 
      this.rosterDataGridView.AllowUserToAddRows = false;
      this.rosterDataGridView.AllowUserToDeleteRows = false;
      this.rosterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.rosterDataGridView.ColumnHeadersHeight = 34;
      this.rosterDataGridView.Location = new System.Drawing.Point(322, 37);
      this.rosterDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rosterDataGridView.Name = "rosterDataGridView";
      this.rosterDataGridView.ReadOnly = true;
      this.rosterDataGridView.RowHeadersVisible = false;
      this.rosterDataGridView.RowHeadersWidth = 62;
      this.rosterDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.rosterDataGridView.Size = new System.Drawing.Size(1028, 613);
      this.rosterDataGridView.TabIndex = 2;
      // 
      // FacultyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1350, 651);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.leftPanel);
      this.Controls.Add(this.rosterDataGridView);
      this.MainMenuStrip = this.menuStrip;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FacultyForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "InstructorForm";
      this.Load += new System.EventHandler(this.FacultyForm_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.leftPanel.ResumeLayout(false);
      this.leftPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rosterDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip         menuStrip;
        private System.Windows.Forms.ToolStripMenuItem profileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRostersMenuItem;
        private System.Windows.Forms.Panel             leftPanel;
        private System.Windows.Forms.Label             instIdLabel;
        private System.Windows.Forms.TextBox           instIdTextBox;
        private System.Windows.Forms.Label             instNameLabel;
        private System.Windows.Forms.TextBox           instNameTextBox;
        private System.Windows.Forms.Label             instDeptLabel;
        private System.Windows.Forms.TextBox           instDeptTextBox;
        private System.Windows.Forms.Label             instSalaryLabel;
        private System.Windows.Forms.TextBox           instSalaryTextBox;
        private System.Windows.Forms.DataGridView      rosterDataGridView;
    }
}
