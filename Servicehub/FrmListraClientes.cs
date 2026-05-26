using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicehub
{
    public partial class FrmListraClientes : Form
    {
        public FrmListraClientes()
        {
            InitializeComponent();
        }

        private void FrmListraClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add();
            dgvClientes.Rows[0].Cells[0].Value = 1;
            dgvClientes.Rows[0].Cells[1].Value = 1095732;
            dgvClientes.Rows[0].Cells[2].Value = "nicolas";
            dgvClientes.Rows[0].Cells[3].Value = "14895738907";
            dgvClientes.Rows[0].Cells[4].Value = "nicolas@gmail.com";
            dgvClientes.Rows[0].Cells[5].Value = "1140028922";
            dgvClientes.Rows[0].Cells[6].Value = true;

            dgvClientes.Rows.Add();
            dgvClientes.Rows[1].Cells[0].Value = 2;
            dgvClientes.Rows[1].Cells[1].Value = 1095743;
            dgvClientes.Rows[1].Cells[2].Value = "federico";
            dgvClientes.Rows[1].Cells[3].Value = "15046352707";
            dgvClientes.Rows[1].Cells[4].Value = "fquico@gmail.com";
            dgvClientes.Rows[1].Cells[5].Value = "1189224002";
            dgvClientes.Rows[1].Cells[6].Value = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            MessageBox.Show(id);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
