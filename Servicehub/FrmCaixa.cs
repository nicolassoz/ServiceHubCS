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
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string texto = "")
        {
            dgvCaixa.Rows.Add();
            List<Caixa> caixas = Caixa.ObetrLista(texto);
            foreach (var caixa in caixas)
            {
                dgvCaixa.Rows.Add();
                dgvCaixa.Rows[dgvCaixa.Rows.Count - 1].Cells[0].Value = caixa.Id;
                dgvCaixa.Rows[dgvCaixa.Rows.Count - 1].Cells[1].Value = caixa.Usuario_Id;
                dgvCaixa.Rows[dgvCaixa.Rows.Count - 1].Cells[2].Value = caixa.Data_abertura;
                dgvCaixa.Rows[dgvCaixa.Rows.Count - 1].Cells[3].Value = caixa.Saldo_Inicial;
                dgvCaixa.Rows[dgvCaixa.Rows.Count - 1].Cells[4].Value = caixa.Status;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Caixa caixa = new(int.Parse(txtUsuario_id.Text), DateTime.Parse(txtData_abertura.Text), decimal.Parse(txtSalto_inicial.Text), char.Parse(txtStatus.Text));
            caixa.Inserir();
            if (caixa.Id > 0)
            {
                MessageBox.Show($"caixa {caixa.Id} inserido com sucesso!");
                CarregaGrid();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 1)
            {
                CarregaGrid(txtBusca.Text);
            }
        }

        private void dgvCaixa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvCaixa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario_id.Text = dgvCaixa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtData_abertura.Text = dgvCaixa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSalto_inicial.Text = dgvCaixa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtStatus.Text = dgvCaixa.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Caixa cat = new(int.Parse(txtID.Text), int.Parse(txtUsuario_id.Text), DateTime.Parse(txtData_abertura.Text), decimal.Parse(txtSalto_inicial.Text), char.Parse(txtStatus.Text));
            if (cat.Atualizar())
            {
                txtID.Clear();
                txtUsuario_id.Clear();
                txtData_abertura.Clear();
                txtSalto_inicial.Clear();
                txtStatus.Clear();
                MessageBox.Show($"caixa {cat.Id} alterado com sucesso! \n Lista Atualizada");
                CarregaGrid();
            }
        }

        private void dgvCaixa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCaixa.CurrentRow != null) 
            {
                txtID.Text = dgvCaixa.CurrentRow.Cells[0].Value?.ToString() ?? "";
                txtUsuario_id.Text = dgvCaixa.CurrentRow.Cells[1].Value?.ToString() ?? "";
                txtData_abertura.Text = dgvCaixa.CurrentRow.Cells[2].Value?.ToString() ?? "";
                txtSalto_inicial.Text = dgvCaixa.CurrentRow.Cells[3].Value?.ToString() ?? "";
                txtStatus.Text = dgvCaixa.CurrentRow.Cells[4].Value?.ToString() ?? "";
            }
        }
    }
}
