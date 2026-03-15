namespace SistemaDeVentas.Forms
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // nombreLabel
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nombreLabel.Location = new System.Drawing.Point(10, 10);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(100, 19);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.MaximumSize = new System.Drawing.Size(180, 0);
            this.nombreLabel.AutoEllipsis = true;

            // descripcionLabel
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.descripcionLabel.ForeColor = System.Drawing.Color.Gray;
            this.descripcionLabel.Location = new System.Drawing.Point(10, 35);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(80, 15);
            this.descripcionLabel.TabIndex = 1;
            this.descripcionLabel.Text = "Descripción";
            this.descripcionLabel.MaximumSize = new System.Drawing.Size(180, 80);

            // precioLabel
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.precioLabel.ForeColor = System.Drawing.Color.Green;
            this.precioLabel.Location = new System.Drawing.Point(10, 125);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(50, 22);
            this.precioLabel.TabIndex = 2;
            this.precioLabel.Text = "$0.00";

            // cantidadLabel
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cantidadLabel.ForeColor = System.Drawing.Color.Blue;
            this.cantidadLabel.Location = new System.Drawing.Point(120, 130);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(19, 19);
            this.cantidadLabel.TabIndex = 3;
            this.cantidadLabel.Text = "0";

            // addButton
            this.addButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(150, 115);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);

            // ProductCard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cantidadLabel);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.nombreLabel);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(200, 165);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label cantidadLabel;
    }
}
