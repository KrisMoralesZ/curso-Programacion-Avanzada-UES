using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeVentas.Forms;

namespace SistemaDeVentas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
           
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if (e.Link != null) {
                e.Link.Visited = true;
                RegisterForm registerForm = new RegisterForm();
                registerForm.Show();
                this.Hide();
            }
        }
    }
}
