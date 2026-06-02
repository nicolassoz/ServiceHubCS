namespace Servicehub
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCodBarras = new TextBox();
            txtDescricao = new TextBox();
            txtUnidadeVenda = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            button5 = new Button();
            nudValorUnit = new NumericUpDown();
            cmbCategoria = new ComboBox();
            nudClasseDesconto = new NumericUpDown();
            label7 = new Label();
            nudEstoqueMinimo = new NumericUpDown();
            panel1 = new Panel();
            chkDescontinuado = new CheckBox();
            listBox1 = new ListBox();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "CodBarras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 115);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 155);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 196);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Estoque Minimo";
            // 
            // txtCodBarras
            // 
            txtCodBarras.AccessibleDescription = "";
            txtCodBarras.AccessibleName = "";
            txtCodBarras.Location = new Point(111, 34);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "codigo de barras";
            txtCodBarras.Size = new Size(242, 23);
            txtCodBarras.TabIndex = 5;
            txtCodBarras.Tag = "";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(111, 71);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descricção";
            txtDescricao.Size = new Size(426, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(376, 113);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.PlaceholderText = "Unit. Venda";
            txtUnidadeVenda.Size = new Size(161, 23);
            txtUnidadeVenda.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 115);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 8;
            label6.Text = "Unidade Venda";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Search;
            button1.Location = new Point(417, 24);
            button1.Name = "button1";
            button1.Size = new Size(120, 41);
            button1.TabIndex = 9;
            button1.Text = "&Buscar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Save;
            button2.Location = new Point(113, 312);
            button2.Name = "button2";
            button2.Size = new Size(149, 59);
            button2.TabIndex = 10;
            button2.Text = "&Salvar";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.Edit_Alt;
            btnEditar.Location = new Point(297, 312);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(145, 59);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(477, 308);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 63);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.CD;
            button5.Location = new Point(602, 236);
            button5.Name = "button5";
            button5.Size = new Size(137, 54);
            button5.TabIndex = 13;
            button5.Text = "Carregar Imagem";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // nudValorUnit
            // 
            nudValorUnit.DecimalPlaces = 2;
            nudValorUnit.Location = new Point(111, 113);
            nudValorUnit.Name = "nudValorUnit";
            nudValorUnit.Size = new Size(108, 23);
            nudValorUnit.TabIndex = 14;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "camisa", "calça", "tenis" });
            cmbCategoria.Location = new Point(111, 152);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(426, 23);
            cmbCategoria.TabIndex = 15;
            // 
            // nudClasseDesconto
            // 
            nudClasseDesconto.DecimalPlaces = 3;
            nudClasseDesconto.Location = new Point(411, 194);
            nudClasseDesconto.Name = "nudClasseDesconto";
            nudClasseDesconto.Size = new Size(126, 23);
            nudClasseDesconto.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 196);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 17;
            label7.Text = "Classe Desconto";
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.DecimalPlaces = 3;
            nudEstoqueMinimo.Location = new Point(134, 194);
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(120, 23);
            nudEstoqueMinimo.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Location = new Point(586, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 205);
            panel1.TabIndex = 19;
            // 
            // chkDescontinuado
            // 
            chkDescontinuado.AutoSize = true;
            chkDescontinuado.Location = new Point(376, 236);
            chkDescontinuado.Name = "chkDescontinuado";
            chkDescontinuado.Size = new Size(106, 19);
            chkDescontinuado.TabIndex = 20;
            chkDescontinuado.Text = "Descontinuado";
            chkDescontinuado.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(800, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(223, 319);
            listBox1.TabIndex = 21;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 377);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(1011, 274);
            dgvProdutos.TabIndex = 22;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 663);
            Controls.Add(dgvProdutos);
            Controls.Add(listBox1);
            Controls.Add(chkDescontinuado);
            Controls.Add(panel1);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(label7);
            Controls.Add(nudClasseDesconto);
            Controls.Add(cmbCategoria);
            Controls.Add(nudValorUnit);
            Controls.Add(button5);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtUnidadeVenda);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodBarras);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)nudValorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCodBarras;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button btnEditar;
        private Button btnCancelar;
        private Button button5;
        private NumericUpDown nudValorUnit;
        private ComboBox cmbCategoria;
        private NumericUpDown nudClasseDesconto;
        private Label label7;
        private NumericUpDown nudEstoqueMinimo;
        private Panel panel1;
        private CheckBox chkDescontinuado;
        private ListBox listBox1;
        private DataGridView dgvProdutos;
    }
}