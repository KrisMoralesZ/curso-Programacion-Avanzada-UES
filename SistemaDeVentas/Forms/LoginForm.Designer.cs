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
            System.Windows.Forms.TextBox emailTextBox = new System.Windows.Forms.TextBox();
            emailTextBox.Location = new System.Drawing.Point(200, 130);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new System.Drawing.Size(400, 30);
            emailTextBox.TabIndex = 0;
            this.Controls.Add(emailTextBox);

            // Password Label
            System.Windows.Forms.Label passwordLabel = new System.Windows.Forms.Label();
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Arial", 10F);
            passwordLabel.Location = new System.Drawing.Point(200, 180);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Text = "Contraseña:";
            this.Controls.Add(passwordLabel);

            // Password TextBox
            System.Windows.Forms.TextBox passwordTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox.Location = new System.Drawing.Point(200, 210);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(400, 30);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            this.Controls.Add(passwordTextBox);

            // Login Button
            System.Windows.Forms.Button loginButton = new System.Windows.Forms.Button();
            loginButton.Location = new System.Drawing.Point(350, 270);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(100, 40);
            loginButton.Text = "Iniciar Sesión";
            this.Controls.Add(loginButton);

            // Register Link
            System.Windows.Forms.Label registerLabel = new System.Windows.Forms.Label();
            registerLabel.AutoSize = true;
            registerLabel.Font = new System.Drawing.Font("Arial", 10F);
            registerLabel.Location = new System.Drawing.Point(200, 320);
            registerLabel.Name = "registerLabel";
            registerLabel.Text = "¿No tienes una Cuenta?";
            this.Controls.Add(registerLabel);

            System.Windows.Forms.LinkLabel registerLink = new System.Windows.Forms.LinkLabel();
            registerLink.AutoSize = true;
            registerLink.Font = new System.Drawing.Font("Arial", 10F);
            registerLink.Location = new System.Drawing.Point(380, 320);
            registerLink.Name = "registerLink";
            registerLink.TabIndex = 2;
            registerLink.TabStop = true;
            registerLink.Text = "Regístrate";
            registerLink.LinkColor = System.Drawing.Color.Blue;
            registerLink.VisitedLinkColor = System.Drawing.Color.Blue;
            registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            this.Controls.Add(registerLink);
        }

        #endregion
    } 
}

