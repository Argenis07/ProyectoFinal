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

        public FrmDetalle()
        {
            InitializeComponent();
        }

        public void SetDataAndOrderId(Data newData, int newOrderID)
        {
            data = newData;
            orderID = newOrderID;
            LoadDetalleOrden();
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDetalleOrden()
        {
            List<Product> detalleOrden = data.DetalleOrden(orderID);
            dataGridView1.DataSource = detalleOrden;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar(data, this);
            frmAgregar.ShowDialog();
        }

        public void RefreshDetalle()
        {
            dataGridView1.DataSource = data.DetalleOrden(orderID);
        }
    }
}
