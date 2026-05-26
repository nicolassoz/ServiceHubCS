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
            int numero1 = 0;
            numero1 = int.Parse(txtCodBarras.Text);

            string texto = "";
            texto = txtDescricao.Text;

            //double preco = 0.00;
            //preco = double.Parse(numericUpDown1.);

            string unVendas = "";
            unVendas = txtUnidadeVenda.Text;

            listBox1.Items.Add($"codigo de baras: {numero1}");
            listBox1.Items.Add($"descrição: {texto}");
            switch (comboBox1.SelectedIndex)
            {
                case 0: // multiplicação
                    listBox1.Items.Add("camisa");
                    break;
                case 1: // divisão
                    listBox1.Items.Add("calsa");
                    break;
                case 2: // adição
                    listBox1.Items.Add("tenis");
                    break;
            }
            //listBox1.Items.Add($"codigo de barras: {txtCodBarras}");
            //listBox1.Items.Add("a");

            //listBox1.Items.Add($"descrição: {txtDescricao}");
            //listBox1.Items.Add($"codigo de barras: {txtUnidadeVenda}");
        }
    }
}
