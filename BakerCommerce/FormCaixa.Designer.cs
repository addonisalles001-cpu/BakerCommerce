namespace BakerCommerce
{
    partial class caixaBaker
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
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cxbPagamentoRecebido = new System.Windows.Forms.CheckBox();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComanda
            // 
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComanda.Location = new System.Drawing.Point(12, 76);
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.Size = new System.Drawing.Size(776, 222);
            this.dgvComanda.TabIndex = 0;
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComanda.Location = new System.Drawing.Point(38, 37);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(200, 33);
            this.lblNumeroComanda.TabIndex = 1;
            this.lblNumeroComanda.Text = "Nº Comanda:";
            // 
            // txtComanda
            // 
            this.txtComanda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComanda.Location = new System.Drawing.Point(244, 30);
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(130, 40);
            this.txtComanda.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnListar.Location = new System.Drawing.Point(380, 30);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 40);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(522, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 31);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "R$    -";
            // 
            // cxbPagamentoRecebido
            // 
            this.cxbPagamentoRecebido.AutoSize = true;
            this.cxbPagamentoRecebido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cxbPagamentoRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxbPagamentoRecebido.Location = new System.Drawing.Point(528, 371);
            this.cxbPagamentoRecebido.Name = "cxbPagamentoRecebido";
            this.cxbPagamentoRecebido.Size = new System.Drawing.Size(270, 28);
            this.cxbPagamentoRecebido.TabIndex = 5;
            this.cxbPagamentoRecebido.Text = "PAGAMENTO RECEBIDO";
            this.cxbPagamentoRecebido.UseVisualStyleBackColor = false;
            this.cxbPagamentoRecebido.CheckedChanged += new System.EventHandler(this.cxbPagamentoRecebido_CheckedChanged);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrar.ForeColor = System.Drawing.Color.Red;
            this.btnEncerrar.Location = new System.Drawing.Point(528, 406);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(269, 43);
            this.btnEncerrar.TabIndex = 6;
            this.btnEncerrar.Text = "ENCERRAR COMANDA";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BakerCommerce.Properties.Resources.caixa_Regitradora;
            this.pictureBox1.Location = new System.Drawing.Point(194, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(69, 383);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(90, 33);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Caixa";
            // 
            // caixaBaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(163)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.cxbPagamentoRecebido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtComanda);
            this.Controls.Add(this.lblNumeroComanda);
            this.Controls.Add(this.dgvComanda);
            this.Name = "caixaBaker";
            this.Text = "BakerCommerce";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox cxbPagamentoRecebido;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDescricao;
    }
}