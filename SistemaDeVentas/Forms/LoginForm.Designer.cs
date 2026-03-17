namespace SistemaDeVentas
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Login Form";

            // LoginForm Header
            System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label();
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            titleLabel.Location = new System.Drawing.Point(300, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Text = "Login";
            this.Controls.Add(titleLabel);

            // Email Label
            System.Windows.Forms.Label emailLabel = new System.Windows.Forms.Label();
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial", 10F);
            emailLabel.Location = new System.Drawing.Point(200, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Text = "Correo:";
            this.Controls.Add(emailLabel);

            // Email TextBox
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox.Location = new System.Drawing.Point(200, 130);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(400, 30);
            this.emailTextBox.TabIndex = 0;
            this.Controls.Add(this.emailTextBox);

            // Password Label
            System.Windows.Forms.Label passwordLabel = new System.Windows.Forms.Label();
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Arial", 10F);
            passwordLabel.Location = new System.Drawing.Point(200, 180);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Text = "Contraseña:";
            this.Controls.Add(passwordLabel);

            // Password TextBox
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox.Location = new System.Drawing.Point(200, 210);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(400, 30);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.Controls.Add(this.passwordTextBox);

            // Login Button
            this.loginButton = new System.Windows.Forms.Button();
            this.loginButton.Location = new System.Drawing.Point(350, 270);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.Text = "Iniciar Sesión";
            this.Controls.Add(this.loginButton);

            // Register Link
            System.Windows.Forms.Label registerLabel = new System.Windows.Forms.Label();
            registerLabel.AutoSize = true;
            registerLabel.Font = new System.Drawing.Font("Arial", 10F);
            registerLabel.Location = new System.Drawing.Point(200, 320);
            registerLabel.Name = "registerLabel";
            registerLabel.Text = "¿No tienes una Cuenta?";
            this.Controls.Add(registerLabel);

            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.registerLinkLabel.Location = new System.Drawing.Point(380, 320);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.TabIndex = 2;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Regístrate";
            this.registerLinkLabel.LinkColor = System.Drawing.Color.Blue;
            this.registerLinkLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            this.Controls.Add(this.registerLinkLabel);
        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
    } 
}

