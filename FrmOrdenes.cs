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
    public partial class FrmOrdenes : Form
    {
        private Data data;

        public FrmOrdenes()
        {
            InitializeComponent();
            data = new Data("Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True");
        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            DataTable dt = data.ConsultaOrden();
            dataGridViewOrdenes.DataSource = dt;
        }

        private void dataGridViewOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = data.ConsultaOrden();
            dataGridViewOrdenes.DataSource = dt;
        }

        private void bttndetalle_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrdenes.SelectedRows.Count > 0)
            {
                int orderID = Convert.ToInt32(dataGridViewOrdenes.SelectedRows[0].Cells["Nro"].Value);
                FrmDetalle frmDetalle = new FrmDetalle(data, orderID);
                frmDetalle.ShowDialog();
            }
        }
    }
}
