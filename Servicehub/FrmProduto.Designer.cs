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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            nudClasseDesconto = new NumericUpDown();
            label7 = new Label();
            nudEstoqueMinimo = new NumericUpDown();
            panel1 = new Panel();
            chkDescontinuado = new CheckBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
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
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.Edit_Alt;
            button3.Location = new Point(297, 312);
            button3.Name = "button3";
            button3.Size = new Size(145, 59);
            button3.TabIndex = 11;
            button3.Text = "&Editar";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.Cancel;
            button4.Location = new Point(477, 308);
            button4.Name = "button4";
            button4.Size = new Size(141, 63);
            button4.TabIndex = 12;
            button4.Text = "&Cancelar";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.CD;
            button5.Location = new Point(604, 248);
            button5.Name = "button5";
            button5.Size = new Size(131, 40);
            button5.TabIndex = 13;
            button5.Text = "Carregar Imagem";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(111, 113);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(108, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "camisa", "calça", "tenis" });
            comboBox1.Location = new Point(111, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(426, 23);
            comboBox1.TabIndex = 15;
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
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 663);
            Controls.Add(listBox1);
            Controls.Add(chkDescontinuado);
            Controls.Add(panel1);
            Controls.Add(nudEstoqueMinimo);
            Controls.Add(label7);
            Controls.Add(nudClasseDesconto);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudClasseDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
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
        private Button button3;
        private Button button4;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private NumericUpDown nudClasseDesconto;
        private Label label7;
        private NumericUpDown nudEstoqueMinimo;
        private Panel panel1;
        private CheckBox chkDescontinuado;
        private ListBox listBox1;
    }
}