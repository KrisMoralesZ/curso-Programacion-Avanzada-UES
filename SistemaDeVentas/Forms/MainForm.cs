using System.Windows.Forms;

namespace SistemaDeVentas.Forms
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Panel panelContainer;

        public MainForm()
        {
            InitializeComponent();

            panelContainer = new System.Windows.Forms.Panel
            {
                Name = "panelContainer",
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panelContainer);

            OpenForm(new LoginForm(this));
        }

        public void OpenForm(Form form)
        {
            panelContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(form);
            form.Show();
        }
    }
}
