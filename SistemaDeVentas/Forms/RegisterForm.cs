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
    }
}
