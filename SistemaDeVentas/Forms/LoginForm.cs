using SistemaDeVentas.Forms;
using SistemaDeVentas.Data;
using System;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        public LoginForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            this.loginButton.Click += loginButton_Click;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            // Aquí puedes agregar la lógica de autenticación
            if (AuthenticateUser(email, password))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                mainForm.OpenForm(new Dashboard(mainForm));
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if (e.Link != null) {
                e.Link.Visited = true;
                mainForm.OpenForm(new RegisterForm(mainForm));
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            try
            {
                ClienteData clienteData = new ClienteData();
                return clienteData.ValidarCredenciales(email, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar credenciales: " + ex.Message);
                return false;
            }
        }
    }
}
