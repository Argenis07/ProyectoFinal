using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmAgregar : Form
    {
        private Data data;
        private int orderID;
        private FrmDetalle frmDetalle;

        public FrmAgregar(Data data, FrmDetalle frmDetalle)
        {
            InitializeComponent();
            this.data = data;
            this.orderID = orderID;
            this.frmDetalle = frmDetalle;
            LoadProductos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Product selectedProduct)
            {
                textBox1.Text = selectedProduct.Producto;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Product selectedProduct)
            {
                int productID = selectedProduct.IdProducto;
                data.Agregar_Producto(orderID, productID);

                frmDetalle.RefreshDetalle(); 
                Close(); 
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void LoadProductos()
        {
            List<Product> productos = data.Lista_Productos(); ;
            comboBox1.DataSource = productos;
            comboBox1.DisplayMember = "Producto";
            comboBox1.ValueMember = "IdProducto";
        }
    }
}
