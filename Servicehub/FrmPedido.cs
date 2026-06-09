using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceHubClass;

namespace Servicehub
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string texto = "") 
        {
            dgvPedido.Rows.Clear();
            List<Pedido> pedidos = Pedido.ObterLista(texto);
            foreach (var pedido in pedidos) 
            {
                dgvPedido.Rows.Add();
                dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells[0].Value = pedido.Id;
                dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells[2].Value = pedido.Usuario_Id;
                dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells[3].Value = pedido.Cliente_Id;
                dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells[4].Value = pedido.Data;
                dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells[5].Value = pedido.Status;
                dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells[6].Value = pedido.Desconto;
            }
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
