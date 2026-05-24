namespace UniversityManagementSystem.Forms
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip          = new System.Windows.Forms.MenuStrip();
            this.profileMenuItem    = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollMenuItem     = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel          = new System.Windows.Forms.Panel();
            this.deptNameLabel      = new System.Windows.Forms.Label();
            this.deptNameTextBox    = new System.Windows.Forms.TextBox();
            this.idLabel            = new System.Windows.Forms.Label();
            this.idTextBox          = new System.Windows.Forms.TextBox();
            this.nameLabel          = new System.Windows.Forms.Label();
            this.nameTextBox        = new System.Windows.Forms.TextBox();
            this.totCredLabel       = new System.Windows.Forms.Label();
            this.totCredTextBox     = new System.Windows.Forms.TextBox();
            this.enrollDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollDataGridView)).BeginInit();
            this.SuspendLayout();

            // menuStrip
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.profileMenuItem, this.enrollMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.Text = "menuStrip";

            // profileMenuItem
            this.profileMenuItem.Name = "profileMenuItem";
            this.profileMenuItem.Text = "Profile";
            this.profileMenuItem.Click += new System.EventHandler(this.profileMenuItem_Click);

            // enrollMenuItem
            this.enrollMenuItem.Name = "enrollMenuItem";
            this.enrollMenuItem.Text = "Enroll";
            this.enrollMenuItem.Click += new System.EventHandler(this.enrollMenuItem_Click);

            // leftPanel
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.deptNameLabel);
            this.leftPanel.Controls.Add(this.deptNameTextBox);
            this.leftPanel.Controls.Add(this.idLabel);
            this.leftPanel.Controls.Add(this.idTextBox);
            this.leftPanel.Controls.Add(this.nameLabel);
            this.leftPanel.Controls.Add(this.nameTextBox);
            this.leftPanel.Controls.Add(this.totCredLabel);
            this.leftPanel.Controls.Add(this.totCredTextBox);
            this.leftPanel.Location = new System.Drawing.Point(0, 27);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(210, 443);

            // deptNameLabel
            this.deptNameLabel.AutoSize = true;
            this.deptNameLabel.Location = new System.Drawing.Point(8, 20);
            this.deptNameLabel.Name = "deptNameLabel";
            this.deptNameLabel.Text = "dept name:";

            // deptNameTextBox
            this.deptNameTextBox.Location = new System.Drawing.Point(82, 17);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.ReadOnly = true;
            this.deptNameTextBox.Size = new System.Drawing.Size(110, 20);

            // idLabel
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(8, 55);
            this.idLabel.Name = "idLabel";
            this.idLabel.Text = "ID:";

            // idTextBox
            this.idTextBox.Location = new System.Drawing.Point(82, 52);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(110, 20);

            // nameLabel
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Text = "name:";

            // nameTextBox
            this.nameTextBox.Location = new System.Drawing.Point(82, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);

            // totCredLabel
            this.totCredLabel.AutoSize = true;
            this.totCredLabel.Location = new System.Drawing.Point(8, 125);
            this.totCredLabel.Name = "totCredLabel";
            this.totCredLabel.Text = "tot cred:";

            // totCredTextBox
            this.totCredTextBox.Location = new System.Drawing.Point(82, 122);
            this.totCredTextBox.Name = "totCredTextBox";
            this.totCredTextBox.ReadOnly = true;
            this.totCredTextBox.Size = new System.Drawing.Size(110, 20);

            // enrollDataGridView
            this.enrollDataGridView.AllowUserToAddRows = false;
            this.enrollDataGridView.AllowUserToDeleteRows = false;
            this.enrollDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enrollDataGridView.Location = new System.Drawing.Point(215, 27);
            this.enrollDataGridView.Name = "enrollDataGridView";
            this.enrollDataGridView.ReadOnly = true;
            this.enrollDataGridView.RowHeadersVisible = false;
            this.enrollDataGridView.Size = new System.Drawing.Size(685, 443);
            this.enrollDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // StudentForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.enrollDataGridView);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enrollDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip         menuStrip;
        private System.Windows.Forms.ToolStripMenuItem profileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollMenuItem;
        private System.Windows.Forms.Panel             leftPanel;
        private System.Windows.Forms.Label             deptNameLabel;
        private System.Windows.Forms.TextBox           deptNameTextBox;
        private System.Windows.Forms.Label             idLabel;
        private System.Windows.Forms.TextBox           idTextBox;
        private System.Windows.Forms.Label             nameLabel;
        private System.Windows.Forms.TextBox           nameTextBox;
        private System.Windows.Forms.Label             totCredLabel;
        private System.Windows.Forms.TextBox           totCredTextBox;
        private System.Windows.Forms.DataGridView      enrollDataGridView;
    }
}
