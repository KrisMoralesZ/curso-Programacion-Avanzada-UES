namespace SistemaDeVentas.Forms
{
    partial class CheckoutForm
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
            this.cartListView = new System.Windows.Forms.ListView();
            this.productColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.comprarButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Carrito";

            // cartListView
            this.cartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productColumn,
            this.priceColumn,
            this.quantityColumn,
            this.subtotalColumn});
            this.cartListView.Location = new System.Drawing.Point(20, 60);
            this.cartListView.Name = "cartListView";
            this.cartListView.Size = new System.Drawing.Size(760, 250);
            this.cartListView.TabIndex = 1;
            this.cartListView.UseCompatibleStateImageBehavior = false;
            this.cartListView.View = System.Windows.Forms.View.Details;
            this.cartListView.FullRowSelect = true;

            // productColumn
            this.productColumn.Text = "Producto";
            this.productColumn.Width = 300;

            // priceColumn
            this.priceColumn.Text = "Precio Unitario";
            this.priceColumn.Width = 120;

            // quantityColumn
            this.quantityColumn.Text = "Cantidad";
            this.quantityColumn.Width = 100;

            // subtotalColumn
            this.subtotalColumn.Text = "Subtotal";
            this.subtotalColumn.Width = 140;

            // totalPriceLabel
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.totalPriceLabel.ForeColor = System.Drawing.Color.Green;
            this.totalPriceLabel.Location = new System.Drawing.Point(600, 330);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(100, 22);
            this.totalPriceLabel.TabIndex = 2;
            this.totalPriceLabel.Text = "Total: $0.00";

            // comprarButton
            this.comprarButton.BackColor = System.Drawing.Color.LimeGreen;
            this.comprarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comprarButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.comprarButton.ForeColor = System.Drawing.Color.White;
            this.comprarButton.Location = new System.Drawing.Point(650, 370);
            this.comprarButton.Name = "comprarButton";
            this.comprarButton.Size = new System.Drawing.Size(130, 40);
            this.comprarButton.TabIndex = 3;
            this.comprarButton.Text = "Comprar";
            this.comprarButton.UseVisualStyleBackColor = false;
            this.comprarButton.Click += new System.EventHandler(this.comprarButton_Click);

            // cancelButton
            this.cancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(500, 370);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 40);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            // CheckoutForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.comprarButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.cartListView);
            this.Controls.Add(this.titleLabel);
            this.Name = "CheckoutForm";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView cartListView;
        private System.Windows.Forms.ColumnHeader productColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader subtotalColumn;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button comprarButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
