namespace Servicehub
{
    partial class frmCategorias
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
            dgvCategorias = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtId = new Label();
            Nome = new Label();
            lSigla = new Label();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            txtBuscar = new TextBox();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            label1 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCategorias.Location = new Point(12, 221);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.Size = new Size(719, 217);
            dgvCategorias.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 552;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 84;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(12, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(18, 15);
            txtId.TabIndex = 1;
            txtId.Text = "ID";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(89, 66);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 2;
            Nome.Text = "Nome";
            // 
            // lSigla
            // 
            lSigla.AutoSize = true;
            lSigla.Location = new Point(644, 68);
            lSigla.Name = "lSigla";
            lSigla.Size = new Size(31, 15);
            lSigla.TabIndex = 3;
            lSigla.Text = "sigla";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(89, 83);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(541, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(636, 83);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(89, 23);
            txtSigla.TabIndex = 6;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 192);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Categoria";
            txtBuscar.Size = new Size(719, 23);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Bahnschrift", 10F);
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.Location = new Point(574, 124);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 62);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Bahnschrift", 10F);
            btnExcluir.ForeColor = SystemColors.ControlText;
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.Location = new Point(455, 124);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 62);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Bahnschrift", 10F);
            btnPesquisar.ForeColor = SystemColors.ControlText;
            btnPesquisar.Image = Properties.Resources.Search;
            btnPesquisar.Location = new Point(195, 124);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 62);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 255);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Bahnschrift", 10F);
            btnEditar.ForeColor = SystemColors.ControlText;
            btnEditar.Image = Properties.Resources.Edit_Alt;
            btnEditar.Location = new Point(325, 124);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 62);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Bahnschrift", 10F);
            btnAdicionar.ForeColor = SystemColors.ControlText;
            btnAdicionar.Image = Properties.Resources.Add;
            btnAdicionar.Location = new Point(65, 124);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 62);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 37);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 14;
            label1.Text = "Cadastro de Categorias";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.Location = new Point(12, 81);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(71, 25);
            textBox5.TabIndex = 15;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 450);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtBuscar);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(lSigla);
            Controls.Add(Nome);
            Controls.Add(txtId);
            Controls.Add(dgvCategorias);
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategorias;
        private Label txtId;
        private Label Nome;
        private Label lSigla;
        private TextBox txtNome;
        private TextBox txtSigla;
        private TextBox txtBuscar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Label label1;
        protected TextBox textBox5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}