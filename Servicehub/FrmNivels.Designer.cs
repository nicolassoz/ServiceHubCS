namespace Servicehub
{
    partial class FrmNivels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNivels));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            dgvNivels = new DataGridView();
            btnAdicionar = new Button();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNivels).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 60);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 60);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Sigla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 134);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 56);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 23);
            txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(272, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(595, 56);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(73, 23);
            txtSigla.TabIndex = 6;
            // 
            // dgvNivels
            // 
            dgvNivels.AllowUserToAddRows = false;
            dgvNivels.AllowUserToDeleteRows = false;
            dgvNivels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNivels.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvNivels.Location = new Point(42, 210);
            dgvNivels.Name = "dgvNivels";
            dgvNivels.ReadOnly = true;
            dgvNivels.RowHeadersVisible = false;
            dgvNivels.Size = new Size(710, 228);
            dgvNivels.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.Add;
            btnAdicionar.ImageAlign = ContentAlignment.TopCenter;
            btnAdicionar.Location = new Point(42, 134);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(79, 54);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextAlign = ContentAlignment.BottomCenter;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.Search;
            btnPesquisar.ImageAlign = ContentAlignment.TopCenter;
            btnPesquisar.Location = new Point(203, 134);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(79, 54);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextAlign = ContentAlignment.BottomCenter;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.Edit_Alt;
            btnEditar.ImageAlign = ContentAlignment.TopCenter;
            btnEditar.Location = new Point(364, 134);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 54);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "&Editar";
            btnEditar.TextAlign = ContentAlignment.BottomCenter;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.Delete;
            btnExcluir.ImageAlign = ContentAlignment.TopCenter;
            btnExcluir.Location = new Point(525, 134);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 54);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "E&xcluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(686, 134);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 54);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 580;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Sigla";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 80;
            // 
            // FrmNivels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvNivels);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNivels";
            Text = "FrmNivel";
            ((System.ComponentModel.ISupportInitialize)dgvNivels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtSigla;
        private DataGridView dgvNivels;
        private Button btnAdicionar;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}