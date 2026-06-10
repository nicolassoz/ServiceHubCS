namespace Servicehub
{
    partial class FrmCaixa
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
            label1 = new Label();
            dgvCaixa = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtUsuario_id = new TextBox();
            txtData_abertura = new TextBox();
            txtSalto_inicial = new TextBox();
            txtStatus = new TextBox();
            txtBusca = new TextBox();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 0;
            label1.Text = "Caixa";
            // 
            // dgvCaixa
            // 
            dgvCaixa.AllowUserToAddRows = false;
            dgvCaixa.AllowUserToDeleteRows = false;
            dgvCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaixa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvCaixa.Location = new Point(136, 220);
            dgvCaixa.Name = "dgvCaixa";
            dgvCaixa.ReadOnly = true;
            dgvCaixa.RowHeadersVisible = false;
            dgvCaixa.Size = new Size(522, 218);
            dgvCaixa.TabIndex = 1;
            dgvCaixa.CellClick += dgvCaixa_CellClick;
            dgvCaixa.SelectionChanged += dgvCaixa_SelectionChanged;
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
            Column2.HeaderText = "ID_Usuario";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Data Abertura";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 155;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Saldo_inicial";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 110;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 64);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Usuario_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 64);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Data_abertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 64);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "Saldo_inicial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(685, 64);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Status";
            // 
            // txtID
            // 
            txtID.Location = new Point(55, 61);
            txtID.Name = "txtID";
            txtID.Size = new Size(64, 23);
            txtID.TabIndex = 7;
            // 
            // txtUsuario_id
            // 
            txtUsuario_id.Location = new Point(204, 61);
            txtUsuario_id.Name = "txtUsuario_id";
            txtUsuario_id.Size = new Size(69, 23);
            txtUsuario_id.TabIndex = 8;
            // 
            // txtData_abertura
            // 
            txtData_abertura.Location = new Point(372, 61);
            txtData_abertura.Name = "txtData_abertura";
            txtData_abertura.Size = new Size(120, 23);
            txtData_abertura.TabIndex = 9;
            // 
            // txtSalto_inicial
            // 
            txtSalto_inicial.Location = new Point(584, 61);
            txtSalto_inicial.Name = "txtSalto_inicial";
            txtSalto_inicial.Size = new Size(82, 23);
            txtSalto_inicial.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(730, 61);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(58, 23);
            txtStatus.TabIndex = 11;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(136, 193);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Busca no caixa";
            txtBusca.Size = new Size(522, 23);
            txtBusca.TabIndex = 12;
            txtBusca.TextChanged += txtBusca_TextChanged;
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
            btnCancelar.Location = new Point(618, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 60);
            btnCancelar.TabIndex = 17;
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
            btnExcluir.Location = new Point(499, 115);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(87, 60);
            btnExcluir.TabIndex = 16;
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
            btnPesquisar.Location = new Point(239, 115);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(87, 60);
            btnPesquisar.TabIndex = 14;
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
            btnEditar.Location = new Point(369, 115);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 60);
            btnEditar.TabIndex = 15;
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
            btnAdicionar.Location = new Point(109, 115);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(87, 60);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // FrmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtBusca);
            Controls.Add(txtStatus);
            Controls.Add(txtSalto_inicial);
            Controls.Add(txtData_abertura);
            Controls.Add(txtUsuario_id);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCaixa);
            Controls.Add(label1);
            Name = "FrmCaixa";
            Text = "FrmCaixa";
            Load += FrmCaixa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCaixa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtUsuario_id;
        private TextBox txtData_abertura;
        private TextBox txtSalto_inicial;
        private TextBox txtStatus;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtBusca;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnAdicionar;
    }
}