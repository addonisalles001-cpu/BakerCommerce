namespace BakerCommerce
{
    partial class FormComandas
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
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLancamento = new System.Windows.Forms.Label();
            this.lblProdutoLancamento = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.BackColor = System.Drawing.Color.Silver;
            this.grbInformacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(16, 107);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(355, 212);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(147)))), ((int)(((byte)(117)))));
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(60, 165);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(202, 41);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(169, 97);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(174, 62);
            this.txbCodProduto.TabIndex = 3;
            // 
            // txbComanda
            // 
            this.txbComanda.BackColor = System.Drawing.SystemColors.Menu;
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(169, 20);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(174, 62);
            this.txbComanda.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 114);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(157, 25);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Cod. Produto:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(8, 53);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(131, 29);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.BackColor = System.Drawing.Color.Silver;
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.txbProduto);
            this.grbLancamento.Controls.Add(this.lblQuantidadeLancamento);
            this.grbLancamento.Controls.Add(this.lblProdutoLancamento);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Location = new System.Drawing.Point(16, 343);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(355, 265);
            this.grbLancamento.TabIndex = 5;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(147)))), ((int)(((byte)(117)))));
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(60, 163);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(202, 41);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.BackColor = System.Drawing.SystemColors.Menu;
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(163, 97);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(180, 62);
            this.txbQuantidade.TabIndex = 3;
            // 
            // txbProduto
            // 
            this.txbProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.txbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(163, 29);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.ReadOnly = true;
            this.txbProduto.Size = new System.Drawing.Size(180, 62);
            this.txbProduto.TabIndex = 2;
            // 
            // lblQuantidadeLancamento
            // 
            this.lblQuantidadeLancamento.AutoSize = true;
            this.lblQuantidadeLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLancamento.Location = new System.Drawing.Point(6, 110);
            this.lblQuantidadeLancamento.Name = "lblQuantidadeLancamento";
            this.lblQuantidadeLancamento.Size = new System.Drawing.Size(140, 25);
            this.lblQuantidadeLancamento.TabIndex = 1;
            this.lblQuantidadeLancamento.Text = "Quantidade:";
            // 
            // lblProdutoLancamento
            // 
            this.lblProdutoLancamento.AutoSize = true;
            this.lblProdutoLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLancamento.Location = new System.Drawing.Point(27, 53);
            this.lblProdutoLancamento.Name = "lblProdutoLancamento";
            this.lblProdutoLancamento.Size = new System.Drawing.Size(112, 29);
            this.lblProdutoLancamento.TabIndex = 0;
            this.lblProdutoLancamento.Text = "Produto:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdutos.Location = new System.Drawing.Point(393, 117);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(385, 436);
            this.dgvProdutos.TabIndex = 6;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(292, 31);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(360, 31);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Lançamento de Comandas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.qr_code;
            this.pictureBox1.Location = new System.Drawing.Point(678, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Location = new System.Drawing.Point(60, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(202, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(188)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComandas";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Label lblQuantidadeLancamento;
        private System.Windows.Forms.Label lblProdutoLancamento;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
    }
}