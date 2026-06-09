namespace Servicehub
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtNivelId = new TextBox();
            dgvUsuario = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtBuscar = new TextBox();
            label5 = new Label();
            txtSenha = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 80);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 11;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 123);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 123);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 15;
            label4.Text = "Nivel Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(51, 77);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(68, 23);
            txtId.TabIndex = 17;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(188, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(519, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(51, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(511, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNivelId
            // 
            txtNivelId.Location = new Point(632, 120);
            txtNivelId.Name = "txtNivelId";
            txtNivelId.Size = new Size(51, 23);
            txtNivelId.TabIndex = 2;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4, Column5 });
            dgvUsuario.Location = new Point(12, 309);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.Size = new Size(853, 271);
            dgvUsuario.TabIndex = 10;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            dgvUsuario.SelectionChanged += dgvUsuario_SelectionChanged;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Id";
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
            Column2.Width = 210;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 210;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "senha";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Nivel";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Ativo";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            Column5.Width = 55;
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
            btnCancelar.Location = new Point(606, 201);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 62);
            btnCancelar.TabIndex = 8;
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
            btnExcluir.Location = new Point(487, 201);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 62);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
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
            btnPesquisar.Location = new Point(227, 201);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 62);
            btnPesquisar.TabIndex = 5;
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
            btnEditar.Location = new Point(357, 201);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 62);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            btnAdicionar.Location = new Point(97, 201);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 62);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 269);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Busca Usuario";
            txtBuscar.Size = new Size(853, 23);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 163);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(53, 160);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(445, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(381, 23);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 18;
            label6.Text = "Usuario";
            label6.Click += label6_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 592);
            Controls.Add(label6);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvUsuario);
            Controls.Add(txtNivelId);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtNivelId;
        private DataGridView dgvUsuario;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdicionar;
        private TextBox txtBuscar;
        private Label label5;
        private TextBox txtSenha;
        protected TextBox txtId;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column5;
    }
}