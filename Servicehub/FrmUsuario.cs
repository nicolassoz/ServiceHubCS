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
            Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text);
        }
    }
}
