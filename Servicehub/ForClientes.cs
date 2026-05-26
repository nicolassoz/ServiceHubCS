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
    public partial class ForClientes : Form
    {
        public ForClientes()
        {
            InitializeComponent();
        }

        private void ForClientes_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            
            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert clientes (nome, cpf, telefone, email, data_nasc) values ('{nome}','{cpf}','{telefone}','{email}')";
            if (cmd.ExecuteNonQuery() > 0) ;
            {
                cmd.CommandText = "select last_insert_id()";
                txtId.Text = cmd.ExecuteScalar().ToString();
                btnAdicionar.Enabled = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnPesquisar.Text == "&Pesquisar")
            {
                txtId.ReadOnly = false;
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtTelefone.ReadOnly = true;
                txtEmail.ReadOnly = true;

                txtDataCad.ReadOnly = false;
                checkBox1.Enabled = false;
                txtId.Focus();
                btnPesquisar.Text = "buscar";
            }
            else if (btnPesquisar.Text == "buscar")
            {
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from clientes where id = {txtId.Text}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNome.Text = dr.GetString(1);
                    txtCpf.Text = dr.GetString(2);
                    txtTelefone.Text = dr.GetString(3);
                    txtEmail.Text = dr.GetString(4);
                    checkBox1.Checked = dr.GetBoolean(5);
                }
                btnPesquisar.Text = "&Pesquisar";
                txtId.ReadOnly = true;


            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "&Editar")
            {
                txtNome.ReadOnly = false;
                txtCpf.ReadOnly = false;
                txtTelefone.ReadOnly = false;
                txtEmail.ReadOnly = false;
                checkBox1.Enabled = true;
                btnEditar.Text = "salva";
            }
            else
            {
                string ativo = checkBox1.Checked ? "1" : "0";
                string nome = txtNome.Text;
                string cpf = txtCpf.Text;
                string telefone = txtTelefone.Text;
                string email = txtEmail.Text;

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from clientes where id = {txtId.Text}";
            if (cmd.ExecuteNonQuery() > 0) 
            {
                btnExcluir.Enabled = false;
            }
        }


        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
