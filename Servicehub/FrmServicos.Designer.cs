namespace Servicehub
{
    partial class FrmServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicos));
            checkBox1 = new CheckBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F);
            checkBox1.Location = new Point(359, 257);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 23);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.Location = new Point(74, 182);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(390, 25);
            txtDescricao.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.Location = new Point(74, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(224, 25);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.Location = new Point(74, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 25);
            txtId.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(28, 255);
            label4.Name = "label4";
            label4.Size = new Size(43, 19);
            label4.TabIndex = 12;
            label4.Text = "preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(8, 185);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 11;
            label3.Text = "descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(27, 114);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 10;
            label2.Text = "nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(20, 19);
            label1.TabIndex = 9;
            label1.Text = "id";
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
            btnAdicionar.Location = new Point(44, 314);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 62);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
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
            btnEditar.Location = new Point(304, 314);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 62);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
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
            btnPesquisar.Location = new Point(174, 314);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(101, 62);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
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
            btnExcluir.Location = new Point(434, 314);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 62);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
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
            btnCancelar.Location = new Point(553, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 62);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(90, 254);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(109, 23);
            txtPreco.TabIndex = 14;
            // 
            // FrmServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPreco);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(checkBox1);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServicos";
            Text = "ServiceHub - Serviços";
            Load += FrmServicos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtPreco;
    }
}