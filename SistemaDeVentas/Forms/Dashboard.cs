using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeVentas.Data;
using SistemaDeVentas.Models;

namespace SistemaDeVentas.Forms
{
    public partial class Dashboard : Form
    {
        private MainForm mainForm;
        private List<ProductCard> productCards;
        private int cartTotal;

        public Dashboard(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            productCards = new List<ProductCard>();
            cartTotal = 0;

            // Make cart label clickable
            cartCountLabel.Cursor = Cursors.Hand;
            cartCountLabel.Click += CartCountLabel_Click;

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                ProductoData productoData = new ProductoData();
                List<Producto> productos = productoData.ObtenerProductos();

                productsFlowLayout.Controls.Clear();
                productCards.Clear();

                foreach (var producto in productos)
                {
                    ProductCard card = new ProductCard();
                    card.SetProducto(producto);
                    card.AddToCart += ProductCard_AddToCart;
                    productCards.Add(card);
                    productsFlowLayout.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void ProductCard_AddToCart(object sender, EventArgs e)
        {
            cartTotal++;
            cartCountLabel.Text = $"🛒 {cartTotal}";
        }

        private void CartCountLabel_Click(object sender, EventArgs e)
        {
            if (cartTotal == 0)
            {
                MessageBox.Show("El carrito esta vacio");
                return;
            }

            decimal totalPrice = CalculateCartTotal();
            CheckoutForm checkout = new CheckoutForm(mainForm, productCards, totalPrice);
            checkout.ShowDialog();

            // Reset cart after checkout
            cartTotal = 0;
            cartCountLabel.Text = "🛒 0";
            foreach (var card in productCards)
            {
                card.SetCantidad(0);
            }
        }

        private decimal CalculateCartTotal()
        {
            decimal total = 0;
            foreach (var card in productCards)
            {
                int cantidad = card.GetCantidad();
                if (cantidad > 0)
                {
                    Producto producto = card.GetProducto();
                    total += (producto.Precio * cantidad);
                }
            }
            return total;
        }

        public int GetCartTotal()
        {
            return cartTotal;
        }

        public List<ProductCard> GetProductCards()
        {
            return productCards;
        }
    }
}
