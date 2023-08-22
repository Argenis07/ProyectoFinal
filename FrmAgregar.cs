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
        private int productID;

        public FrmAgregar(Data data, int orderID)
        {
            InitializeComponent();
            this.data = data;
            this.orderID = orderID;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Product selectedProduct = (Product)comboBox1.SelectedItem;
                productID = selectedProduct.IdProducto;
                string productName = data.GetProductName(productID);
                textBox1.Text = productName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                data.AgregarProducto(orderID, productID);

                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un producto antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            List<Product> productos = data.Lista_Productos(); ;
            comboBox1.DataSource = productos;
            comboBox1.DisplayMember = "Producto";
            comboBox1.ValueMember = "IdProducto";
        }

        
    }
}
