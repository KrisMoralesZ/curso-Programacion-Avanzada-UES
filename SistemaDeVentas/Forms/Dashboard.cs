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
