namespace SistemaDeVentas.Forms
{
    partial class RegisterForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.linkLabelBackToLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();

            // Username Label
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(50, 50);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Nombre:";
            
            // textBoxUsername
            this.textBoxUsername.Location = new System.Drawing.Point(50, 70);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(300, 20);
            this.textBoxUsername.TabIndex = 1;
            
            // Email
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(50, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Correo:";
            
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(50, 130);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 20);
            this.textBoxEmail.TabIndex = 2;
            
            // Password
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(50, 170);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Contraseña:";
            
            // textBoxPassword
            this.textBoxPassword.Location = new System.Drawing.Point(50, 190);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(300, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            
            // Password Confirmation
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(50, 230);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.labelConfirmPassword.TabIndex = 4;
            this.labelConfirmPassword.Text = "Confirmar Contraseña:";
            
            // textBoxConfirmPassword
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(50, 250);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(300, 20);
            this.textBoxConfirmPassword.TabIndex = 4;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            
            // Register Button
            this.buttonRegister.Location = new System.Drawing.Point(50, 300);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(300, 30);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Registrar";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            
            // Back to Login Link
            this.linkLabelBackToLogin.AutoSize = true;
            this.linkLabelBackToLogin.Location = new System.Drawing.Point(50, 350);
            this.linkLabelBackToLogin.Name = "linkLabelBackToLogin";
            this.linkLabelBackToLogin.Size = new System.Drawing.Size(74, 13);
            this.linkLabelBackToLogin.TabIndex = 6;
            this.linkLabelBackToLogin.TabStop = true;
            this.linkLabelBackToLogin.Text = "Volver a Login";
            this.linkLabelBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBackToLogin_LinkClicked);
            
            // RegisterForm Layout
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.linkLabelBackToLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.LinkLabel linkLabelBackToLogin;
    }
}