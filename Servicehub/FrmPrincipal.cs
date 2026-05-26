namespace Servicehub
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadasdrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar uma instância do formulário Listar Clientes
            FrmListraClientes listraClientes = new();

            //associando o form listrar clientes como filho do principal
            listraClientes.MdiParent = this;

            // chamar o form de clientes
            listraClientes.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar uma instância do formulário novo Clientes
            FrmNovoCliente novoCliente = new();

            //associando o form novo clientes como filho do principal
            novoCliente.MdiParent = this;

            // chamar o form de clientes
            novoCliente.Show();
        }
    }
}
