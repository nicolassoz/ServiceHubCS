namespace Servicehub
{
    partial class ForClientes
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtDataCad = new TextBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            data_nasc = new DataGridViewTextBoxColumn();
            data_cad = new DataGridViewTextBoxColumn();
            ativo = new DataGridViewCheckBoxColumn();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtDataNasc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 32);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 11;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 71);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 71);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 15;
            label3.Text = "Cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 117);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 13;
            label4.Text = "telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 117);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 155);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 14;
            label6.Text = "Data_Nasc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 158);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 17;
            label7.Text = "Data_Cad";
            // 
            // txtId
            // 
            txtId.Location = new Point(123, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(49, 23);
            txtId.TabIndex = 20;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(123, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(333, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(531, 68);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(240, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(123, 114);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(203, 23);
            txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(418, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtDataCad
            // 
            txtDataCad.Location = new Point(485, 155);
            txtDataCad.Name = "txtDataCad";
            txtDataCad.Size = new Size(133, 23);
            txtDataCad.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(123, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, nome, cpf, telefone, email, data_nasc, data_cad, ativo });
            dataGridView1.Location = new Point(27, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1103, 262);
            dataGridView1.TabIndex = 19;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "Id";
            id.Name = "id";
            id.Width = 40;
            // 
            // nome
            // 
            nome.Frozen = true;
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.Width = 200;
            // 
            // cpf
            // 
            cpf.Frozen = true;
            cpf.HeaderText = "Cpf";
            cpf.Name = "cpf";
            cpf.Width = 150;
            // 
            // telefone
            // 
            telefone.Frozen = true;
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.Width = 150;
            // 
            // email
            // 
            email.Frozen = true;
            email.HeaderText = "Email";
            email.Name = "email";
            email.Width = 200;
            // 
            // data_nasc
            // 
            data_nasc.Frozen = true;
            data_nasc.HeaderText = "DataNasc";
            data_nasc.Name = "data_nasc";
            data_nasc.Width = 110;
            // 
            // data_cad
            // 
            data_cad.Frozen = true;
            data_cad.HeaderText = "DataCad";
            data_cad.Name = "data_cad";
            data_cad.Width = 110;
            // 
            // ativo
            // 
            ativo.Frozen = true;
            ativo.HeaderText = "Ativo";
            ativo.Name = "ativo";
            ativo.Resizable = DataGridViewTriState.True;
            ativo.SortMode = DataGridViewColumnSortMode.Automatic;
            ativo.Width = 80;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(123, 252);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(240, 252);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(357, 252);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(474, 252);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(591, 252);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "&cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(123, 152);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(192, 23);
            txtDataNasc.TabIndex = 21;
            // 
            // ForClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 620);
            Controls.Add(txtDataNasc);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAdicionar);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(txtDataCad);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForClientes";
            Text = "ForClientes";
            Load += ForClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtDataCad;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Button btnAdicionar;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtDataNasc;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn data_nasc;
        private DataGridViewTextBoxColumn data_cad;
        private DataGridViewCheckBoxColumn ativo;
    }
}