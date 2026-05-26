namespace Servicehub
{
    partial class FrmComponente
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            dgvServicos = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnPreco = new DataGridViewTextBoxColumn();
            clnDescontinuado = new DataGridViewTextBoxColumn();
            dgvUsuario = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvNome = new DataGridViewTextBoxColumn();
            dgvEmail = new DataGridViewTextBoxColumn();
            dgvSolicitacoes = new DataGridView();
            button3 = new Button();
            id = new DataGridViewTextBoxColumn();
            problema = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 95);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite o(s) numero(s)";
            label1.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(245, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 184);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(120, 173);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Tabuada", "Radiciação" });
            comboBox1.Location = new Point(47, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 41);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Operação";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 23);
            textBox2.TabIndex = 1;
            textBox2.Visible = false;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnDescricao, clnPreco, clnDescontinuado });
            dgvServicos.Location = new Point(47, 215);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.Size = new Size(661, 148);
            dgvServicos.TabIndex = 6;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 200;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 206;
            // 
            // clnPreco
            // 
            clnPreco.Frozen = true;
            clnPreco.HeaderText = "Preço";
            clnPreco.Name = "clnPreco";
            clnPreco.ReadOnly = true;
            // 
            // clnDescontinuado
            // 
            clnDescontinuado.Frozen = true;
            clnDescontinuado.HeaderText = "Descontinuado";
            clnDescontinuado.Name = "clnDescontinuado";
            clnDescontinuado.ReadOnly = true;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvNome, dgvEmail });
            dgvUsuario.Location = new Point(47, 402);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowHeadersVisible = false;
            dgvUsuario.Size = new Size(483, 150);
            dgvUsuario.TabIndex = 7;
            // 
            // dgvID
            // 
            dgvID.Frozen = true;
            dgvID.HeaderText = "ID";
            dgvID.Name = "dgvID";
            dgvID.Width = 60;
            // 
            // dgvNome
            // 
            dgvNome.Frozen = true;
            dgvNome.HeaderText = "Nome";
            dgvNome.Name = "dgvNome";
            dgvNome.Width = 200;
            // 
            // dgvEmail
            // 
            dgvEmail.Frozen = true;
            dgvEmail.HeaderText = "Email";
            dgvEmail.Name = "dgvEmail";
            dgvEmail.Width = 200;
            // 
            // dgvSolicitacoes
            // 
            dgvSolicitacoes.AllowUserToAddRows = false;
            dgvSolicitacoes.AllowUserToDeleteRows = false;
            dgvSolicitacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitacoes.Columns.AddRange(new DataGridViewColumn[] { id, problema });
            dgvSolicitacoes.Location = new Point(380, 27);
            dgvSolicitacoes.Name = "dgvSolicitacoes";
            dgvSolicitacoes.ReadOnly = true;
            dgvSolicitacoes.RowHeadersVisible = false;
            dgvSolicitacoes.Size = new Size(468, 153);
            dgvSolicitacoes.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(854, 157);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Procurar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 40;
            // 
            // problema
            // 
            problema.Frozen = true;
            problema.HeaderText = "Descrição do problema";
            problema.Name = "problema";
            problema.ReadOnly = true;
            problema.Width = 400;
            // 
            // FrmComponente
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(941, 573);
            Controls.Add(button3);
            Controls.Add(dgvSolicitacoes);
            Controls.Add(dgvUsuario);
            Controls.Add(dgvServicos);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmComponente";
            Text = "FrmComponente";
            Load += FrmComponente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dgvServicos;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnPreco;
        private DataGridViewTextBoxColumn clnDescontinuado;
        private DataGridView dgvUsuario;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvNome;
        private DataGridViewTextBoxColumn dgvEmail;
        private DataGridView dgvSolicitacoes;
        private Button button3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn problema;
    }
}