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
        private MainForm mainForm;
        public LoginForm(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }
           
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if (e.Link != null) {
                e.Link.Visited = true;
                mainForm.OpenForm(new RegisterForm(mainForm));
            }
        }
    }
}
