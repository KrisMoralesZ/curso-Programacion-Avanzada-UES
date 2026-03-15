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
    public partial class CheckoutForm : Form
    {
        private MainForm mainForm;
        private List<ProductCard> cartItems;
        private decimal totalPrice;

        public CheckoutForm(MainForm main, List<ProductCard> items, decimal total)
        {
            InitializeComponent();
            mainForm = main;
            cartItems = items;
            totalPrice = total;
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            try
            {
                cartListView.Items.Clear();

                foreach (var card in cartItems)
                {
                    int cantidad = card.GetCantidad();
                    if (cantidad > 0)
                    {
                        Producto producto = card.GetProducto();
                        decimal subtotal = producto.Precio * cantidad;

                        ListViewItem item = new ListViewItem(producto.Nombre);
                        item.SubItems.Add(producto.Precio.ToString("C"));
                        item.SubItems.Add(cantidad.ToString());
                        item.SubItems.Add(subtotal.ToString("C"));

                        cartListView.Items.Add(item);
                    }
                }

                // Display total price
                totalPriceLabel.Text = $"Total: {totalPrice:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar carrito: " + ex.Message);
            }
        }

        private void comprarButton_Click(object sender, EventArgs e)
        {
            try
            {
                VentaData ventaData = new VentaData();

                // For now, using a default clienteID = 1
                // In a real app, you'd get this from the logged-in user
                int clienteID = 1;

                foreach (var card in cartItems)
                {
                    int cantidad = card.GetCantidad();
                    if (cantidad > 0)
                    {
                        Producto producto = card.GetProducto();
                        decimal subtotal = producto.Precio * cantidad;

                        ventaData.GuardarVenta(clienteID, producto.PruductoID, cantidad, subtotal);
                    }
                }

                MessageBox.Show("Compra realizada exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
