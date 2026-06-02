using ServiceHubClass;
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
    public partial class FrmNivels : Form
    {
        public FrmNivels()
        {
            InitializeComponent();
        }

        private void FrmNivels_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Nivel nivel = new(txtNome.Text, txtSigla.Text);
            nivel.Inserir();
            if (Categoria.ObterPorId>0)
            {
                MessageBox.Show($"Nivel {nivel.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }

        private void CarregaGrid(string texto = "")
        {
            dgvNiveis.Rows.Clear();
            List<Nivel> niveis = Nivel.ObterLista(texto);
            foreach (var nivel in niveis)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[dgvNiveis.Rows.Count - 1].Cells[0].Value = nivel.Id;
                dgvNiveis.Rows[dgvNiveis.Rows.Count - 1].Cells[1].Value = nivel.Nome;
                dgvNiveis.Rows[dgvNiveis.Rows.Count - 1].Cells[2].Value = nivel.Sigla;
            }
        }
    }
}
