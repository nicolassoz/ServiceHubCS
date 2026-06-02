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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Servicehub
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Produto produto = new
                (
                txtCodBarras.Text,
                txtDescricao.Text,
                (double)nudValorUnit.Value,
                txtUnidadeVenda.Text,
                Categoria.ObterPorId(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)nudEstoqueMinimo.Value,
                (double)nudClasseDesconto.Value
                );
            produto.Inserir();
            if (produto.Id > 0)
                MessageBox.Show($"Produto {produto.Descricao} gravado com sucesso!");

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Categoria.ObterLista();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";

            dgvProdutos.DataSource = Produto.ObterLista();
        }
    }
}
