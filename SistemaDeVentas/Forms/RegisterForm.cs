using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Forms
{
    public partial class RegisterForm : Form
    {
        private MainForm mainForm;

        public RegisterForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Add validation and registration logic here
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter an email.", "Validation Error");
                return;
            }
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error");
                return;
            }

            // TODO: Save user to database
            MessageBox.Show("Registration successful!", "Success");
            mainForm.OpenForm(new LoginForm(mainForm));
        }

        private void linkLabelBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link != null)
            {
                e.Link.Visited = true;
                MessageBox.Show("Usuario Creado Correctamente");
            }
        }
    }
}


