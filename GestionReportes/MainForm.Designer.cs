namespace GestionReportes
{
    partial class MainForm
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

            // Create a Label for the title
            System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label();

            // Create a Button
            System.Windows.Forms.Button submitButton = new System.Windows.Forms.Button();

            // Configure the title label
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            titleLabel.Location = new System.Drawing.Point(300, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Text = "Descarga tu Reporte";

            // Configure the button
            submitButton.Font = new System.Drawing.Font("Arial", 10F);
            submitButton.Location = new System.Drawing.Point(350, 150);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(100, 40);
            submitButton.Text = "Descargar";
            submitButton.UseVisualStyleBackColor = true;

            // Add controls to the form
            this.Controls.Add(titleLabel);
            this.Controls.Add(submitButton);

            // Configure the form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "MainForm";
        }

        #endregion
    }
}