using FinancialHelper.Entities;
using FinancialHelper.Shared.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialHelper
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginFormLoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loginFormLoginTextBox.Text != "" && loginFormPasswordTextBox.Text != "") submitLoginButton.Enabled = true;
            if (loginFormLoginTextBox.Text != "" && loginFormPasswordTextBox.Text != "") registerButton.Enabled = true;
            if (loginFormLoginTextBox.Text != "" && loginFormPasswordTextBox.Text != "") deleteProfileButton.Enabled = true;
        }

        private void loginFormPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loginFormLoginTextBox.Text != "" && loginFormPasswordTextBox.Text != "") submitLoginButton.Enabled = true;
            if (loginFormLoginTextBox.Text != "" && loginFormPasswordTextBox.Text != "") registerButton.Enabled = true;
            if (loginFormLoginTextBox.Text != "" && loginFormPasswordTextBox.Text != "") deleteProfileButton.Enabled = true;
        }

        private void submitLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (UserService userService = new())
                {
                    User loggedUser = userService.LogUser(
                        loginFormLoginTextBox.Text,
                        loginFormPasswordTextBox.Text);

                    if (loggedUser == null) throw new Exception("Such user does not exist!");

                    MainForm mainForm = new MainForm(loggedUser.Id);
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon logging. More details:\n{ex.Message}", "Error");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (UserService userService = new())
                {
                    User loggedUser = userService.CreateUser(
                        loginFormLoginTextBox.Text,
                        loginFormPasswordTextBox.Text);

                    if (loggedUser == null) throw new Exception("Such user with this login already exists!");

                    MainForm mainForm = new MainForm(loggedUser.Id);
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon creating new profile. More details:\n{ex.Message}", "Error");
            }
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (UserService userService = new())
                {
                    User loggedUser = userService.DeleteUser(
                        loginFormLoginTextBox.Text,
                        loginFormPasswordTextBox.Text);

                    if (loggedUser == null) throw new Exception("Such user does not exist!!");

                    MessageBox.Show("Profile successfully deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured upon deleting profile. More details:\n{ex.Message}", "Error");
            }
        }
    }
}
