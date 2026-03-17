namespace SistemaDeVentas.Forms
{
    partial class Dashboard
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.cartCountLabel = new System.Windows.Forms.Label();
            this.productsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(150, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Productos";

            // cartCountLabel
            this.cartCountLabel.AutoSize = true;
            this.cartCountLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.cartCountLabel.Location = new System.Drawing.Point(750, 30);
            this.cartCountLabel.Name = "cartCountLabel";
            this.cartCountLabel.Size = new System.Drawing.Size(50, 18);
            this.cartCountLabel.TabIndex = 1;
            this.cartCountLabel.Text = "🛒 0";
            this.cartCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // productsFlowLayout
            this.productsFlowLayout.AutoScroll = true;
            this.productsFlowLayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.productsFlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.productsFlowLayout.Location = new System.Drawing.Point(20, 60);
            this.productsFlowLayout.Name = "productsFlowLayout";
            this.productsFlowLayout.Size = new System.Drawing.Size(760, 370);
            this.productsFlowLayout.TabIndex = 2;
            this.productsFlowLayout.WrapContents = true;

            // Dashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productsFlowLayout);
            this.Controls.Add(this.cartCountLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label cartCountLabel;
        private System.Windows.Forms.FlowLayoutPanel productsFlowLayout;
    }
}