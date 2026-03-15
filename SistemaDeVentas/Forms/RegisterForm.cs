using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeVentas.Data;

namespace SistemaDeVentas.Forms
{
    public partial class RegisterForm : Form
    {
        private MainForm mainForm;
        private ClienteData clienteData;

        public RegisterForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            clienteData = new ClienteData();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
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

            try
            {
                bool registered = clienteData.RegistrarCliente(
                    textBoxUsername.Text,
                    textBoxEmail.Text,
                    textBoxPassword.Text,
                    "",
                    ""
                );

                if (registered)
                {
                    MessageBox.Show("Usuario Creado Correctamente", "Success");
                    mainForm.OpenForm(new LoginForm(mainForm));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message, "Error");
            }
        }

        private void linkLabelBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link != null)
            {
                e.Link.Visited = true;
                mainForm.OpenForm(new LoginForm(mainForm));
            }
        }
    }
}
