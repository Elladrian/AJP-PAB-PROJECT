namespace FinancialHelper
{
    partial class LoginForm
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
            submitLoginButton = new Button();
            loginFormLoginTextBox = new TextBox();
            loginFormPasswordTextBox = new TextBox();
            registerButton = new Button();
            deleteProfileButton = new Button();
            SuspendLayout();
            // 
            // submitLoginButton
            // 
            submitLoginButton.Enabled = false;
            submitLoginButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            submitLoginButton.Location = new Point(300, 175);
            submitLoginButton.Name = "submitLoginButton";
            submitLoginButton.Size = new Size(200, 60);
            submitLoginButton.TabIndex = 0;
            submitLoginButton.Text = "Submit";
            submitLoginButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            submitLoginButton.UseVisualStyleBackColor = true;
            submitLoginButton.Click += submitLoginButton_Click;
            // 
            // loginFormLoginTextBox
            // 
            loginFormLoginTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginFormLoginTextBox.Location = new Point(300, 49);
            loginFormLoginTextBox.Name = "loginFormLoginTextBox";
            loginFormLoginTextBox.Size = new Size(200, 39);
            loginFormLoginTextBox.TabIndex = 1;
            loginFormLoginTextBox.Text = "Login";
            loginFormLoginTextBox.TextAlign = HorizontalAlignment.Center;
            loginFormLoginTextBox.TextChanged += loginFormLoginTextBox_TextChanged;
            // 
            // loginFormPasswordTextBox
            // 
            loginFormPasswordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginFormPasswordTextBox.Location = new Point(300, 111);
            loginFormPasswordTextBox.Name = "loginFormPasswordTextBox";
            loginFormPasswordTextBox.PasswordChar = '*';
            loginFormPasswordTextBox.Size = new Size(200, 39);
            loginFormPasswordTextBox.TabIndex = 2;
            loginFormPasswordTextBox.Text = "Password";
            loginFormPasswordTextBox.TextAlign = HorizontalAlignment.Center;
            loginFormPasswordTextBox.TextChanged += loginFormPasswordTextBox_TextChanged;
            // 
            // registerButton
            // 
            registerButton.Enabled = false;
            registerButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.Location = new Point(188, 260);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(200, 76);
            registerButton.TabIndex = 3;
            registerButton.Text = "Create new profile";
            registerButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // deleteProfileButton
            // 
            deleteProfileButton.Enabled = false;
            deleteProfileButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            deleteProfileButton.Location = new Point(418, 260);
            deleteProfileButton.Name = "deleteProfileButton";
            deleteProfileButton.Size = new Size(200, 76);
            deleteProfileButton.TabIndex = 4;
            deleteProfileButton.Text = "Delete profile";
            deleteProfileButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteProfileButton.UseVisualStyleBackColor = true;
            deleteProfileButton.Click += deleteProfileButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(deleteProfileButton);
            Controls.Add(registerButton);
            Controls.Add(loginFormPasswordTextBox);
            Controls.Add(loginFormLoginTextBox);
            Controls.Add(submitLoginButton);
            Name = "LoginForm";
            Text = "Financial Helper - Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitLoginButton;
        private TextBox loginFormLoginTextBox;
        private TextBox loginFormPasswordTextBox;
        private Button registerButton;
        private Button deleteProfileButton;
    }
}