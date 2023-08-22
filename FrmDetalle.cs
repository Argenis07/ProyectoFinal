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
    public partial class FrmDetalle : Form
    {
        private int orderID;
        private Data data;

        public FrmDetalle(Data data, int orderID)
        {
            InitializeComponent();
            this.data = data;
            this.orderID = orderID;
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            LoadDetalleOrden();
        }

        public void LoadDetalleOrden()
        {
            List<Product> detalleOrden = data.DetalleOrden(orderID);
            dataGridView1.DataSource = detalleOrden;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar(data, orderID);
            frmAgregar.ShowDialog();
            LoadDetalleOrden();
        }

    }
}
