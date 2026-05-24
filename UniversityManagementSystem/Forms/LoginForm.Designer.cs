namespace UniversityManagementSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel    = new System.Windows.Forms.Panel();
            this.titleLabel     = new System.Windows.Forms.Label();
            this.loginPanel     = new System.Windows.Forms.Panel();
            this.usernameLabel  = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel  = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton    = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();

            // headerPanel
            this.headerPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 260);

            // titleLabel
            this.titleLabel.AutoSize = false;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 260);
            this.titleLabel.Text = "University Management System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // loginPanel
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(240, 290);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(320, 180);

            // usernameLabel
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(20, 28);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Text = "username:";

            // usernameTextBox
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernameTextBox.Location = new System.Drawing.Point(105, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(190, 25);

            // passwordLabel
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(20, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Text = "password:";

            // passwordTextBox
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(105, 65);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(190, 25);
            this.passwordTextBox.UseSystemPasswordChar = true;

            // loginButton
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(70, 115);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(180, 35);
            this.loginButton.Text = "LOGIN";
            this.loginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Management System";
            this.headerPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel   headerPanel;
        private System.Windows.Forms.Label   titleLabel;
        private System.Windows.Forms.Panel   loginPanel;
        private System.Windows.Forms.Label   usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label   passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button  loginButton;
    }
}
