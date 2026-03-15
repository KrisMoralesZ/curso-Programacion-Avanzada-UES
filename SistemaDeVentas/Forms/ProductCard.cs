using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeVentas.Models;

namespace SistemaDeVentas.Forms
{
    public partial class ProductCard : UserControl
    {
        private Producto producto;
        private int cantidad;

        public event EventHandler AddToCart;

        public ProductCard()
        {
            InitializeComponent();
            cantidad = 0;
            this.Margin = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
        }

        public void SetProducto(Producto prod)
        {
            producto = prod;
            cantidad = 0;
            RefreshUI();
        }

        public Producto GetProducto()
        {
            return producto;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public void SetCantidad(int cant)
        {
            cantidad = cant;
            cantidadLabel.Text = cantidad.ToString();
        }

        private void RefreshUI()
        {
            if (producto == null) return;

            nombreLabel.Text = producto.Nombre;
            descripcionLabel.Text = producto.Descripcion;
            precioLabel.Text = $"${producto.Precio:F2}";
            cantidadLabel.Text = "0";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            cantidad++;
            cantidadLabel.Text = cantidad.ToString();
            AddToCart?.Invoke(this, EventArgs.Empty);
        }
    }
}
