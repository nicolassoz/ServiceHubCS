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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string texto = "")
        {
            dgvUsuario.Rows.Clear();
            List<Usuario> usuarios = Usuario.ObterLista();
            foreach (var usuario in usuarios)
            {
                dgvUsuario.Rows.Add();
                dgvUsuario.Rows[dgvUsuario.Rows.Count - 1].Cells[0].Value = usuario.Id;
                dgvUsuario.Rows[dgvUsuario.Rows.Count - 1].Cells[1].Value = usuario.Nome;
                dgvUsuario.Rows[dgvUsuario.Rows.Count - 1].Cells[2].Value = usuario.Email;
                dgvUsuario.Rows[dgvUsuario.Rows.Count - 1].Cells[3].Value = usuario.Senha;
                dgvUsuario.Rows[dgvUsuario.Rows.Count - 1].Cells[4].Value = usuario.Nivel;
                dgvUsuario.Rows[dgvUsuario.Rows.Count - 1].Cells[5].Value = usuario.Ativo;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, int.Parse(txtNivelId.Text));
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                MessageBox.Show($"Usuario {usuario.Id} inserido com sucesso!");
                CarregaGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                var resposta = MessageBox.Show($"Deseja excluir o nivel {txtId.Text} - {txtNome.Text}", "Exclusão de categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    Nivel cat = new(int.Parse(txtId.Text));
                    cat.Excluir();
                    CarregaGrid();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 1)
            {
                CarregaGrid(txtBuscar.Text);
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSenha.Text = dgvUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNivelId.Text = dgvUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario cat = new(int.Parse(txtId.Text), txtNome.Text, txtEmail.Text, txtSenha.Text, int.Parse(txtNivelId.Text));
            if (cat.Atualizar())
            {
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtNivelId.Clear();
                MessageBox.Show($"Categoria {cat.Id} alterada com sucesso! \n lista Atualizada");
            }
        }

        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvUsuario.CurrentRow != null) 
            {
                txtId.Text = dgvUsuario.CurrentRow.Cells[0].Value?.ToString() ?? "";
                txtNome.Text = dgvUsuario.CurrentRow.Cells[1].Value?.ToString() ?? "";
                txtEmail.Text = dgvUsuario.CurrentRow.Cells[2].Value?.ToString() ?? "";
                txtSenha.Text = dgvUsuario.CurrentRow.Cells[3].Value?.ToString() ?? "";
                txtNivelId.Text = dgvUsuario.CurrentRow.Cells[4].Value?.ToString() ?? "";
            }
        }
    }
}
