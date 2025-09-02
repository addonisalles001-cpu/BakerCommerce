namespace BakerCommerce
{
    partial class FormUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomeCompletoCadastro = new System.Windows.Forms.Label();
            this.lblEmailCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtEmailCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSenhaEditar = new System.Windows.Forms.TextBox();
            this.txtEmailEditar = new System.Windows.Forms.TextBox();
            this.txtNomeEditar = new System.Windows.Forms.TextBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeCompletoEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblDescricaoApagar = new System.Windows.Forms.Label();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblDescricaoLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 145);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(776, 280);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txtSenhaCadastro);
            this.grbCadastro.Controls.Add(this.txtEmailCadastro);
            this.grbCadastro.Controls.Add(this.txtNomeCadastro);
            this.grbCadastro.Controls.Add(this.lblSenhaCadastro);
            this.grbCadastro.Controls.Add(this.lblEmailCadastro);
            this.grbCadastro.Controls.Add(this.lblNomeCompletoCadastro);
            this.grbCadastro.Location = new System.Drawing.Point(12, 431);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(354, 191);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblNomeCompletoCadastro
            // 
            this.lblNomeCompletoCadastro.AutoSize = true;
            this.lblNomeCompletoCadastro.Location = new System.Drawing.Point(7, 31);
            this.lblNomeCompletoCadastro.Name = "lblNomeCompletoCadastro";
            this.lblNomeCompletoCadastro.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCompletoCadastro.TabIndex = 0;
            this.lblNomeCompletoCadastro.Text = "Nome completo:";
            // 
            // lblEmailCadastro
            // 
            this.lblEmailCadastro.AutoSize = true;
            this.lblEmailCadastro.Location = new System.Drawing.Point(10, 64);
            this.lblEmailCadastro.Name = "lblEmailCadastro";
            this.lblEmailCadastro.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCadastro.TabIndex = 1;
            this.lblEmailCadastro.Text = "Email:";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(13, 94);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCadastro.TabIndex = 2;
            this.lblSenhaCadastro.Text = "Senha:";
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeCadastro.Location = new System.Drawing.Point(98, 31);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(186, 20);
            this.txtNomeCadastro.TabIndex = 3;
            // 
            // txtEmailCadastro
            // 
            this.txtEmailCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmailCadastro.Location = new System.Drawing.Point(98, 64);
            this.txtEmailCadastro.Name = "txtEmailCadastro";
            this.txtEmailCadastro.Size = new System.Drawing.Size(186, 20);
            this.txtEmailCadastro.TabIndex = 4;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(98, 94);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(186, 20);
            this.txtSenhaCadastro.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 120);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(324, 46);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txtSenhaEditar);
            this.grbEditar.Controls.Add(this.txtEmailEditar);
            this.grbEditar.Controls.Add(this.txtNomeEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeCompletoEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(403, 431);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(385, 191);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(15, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(349, 46);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtSenhaEditar
            // 
            this.txtSenhaEditar.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenhaEditar.Location = new System.Drawing.Point(98, 94);
            this.txtSenhaEditar.Name = "txtSenhaEditar";
            this.txtSenhaEditar.Size = new System.Drawing.Size(186, 20);
            this.txtSenhaEditar.TabIndex = 5;
            // 
            // txtEmailEditar
            // 
            this.txtEmailEditar.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmailEditar.Location = new System.Drawing.Point(98, 64);
            this.txtEmailEditar.Name = "txtEmailEditar";
            this.txtEmailEditar.Size = new System.Drawing.Size(186, 20);
            this.txtEmailEditar.TabIndex = 4;
            // 
            // txtNomeEditar
            // 
            this.txtNomeEditar.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeEditar.Location = new System.Drawing.Point(98, 31);
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.Size = new System.Drawing.Size(186, 20);
            this.txtNomeEditar.TabIndex = 3;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(13, 94);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEditar.TabIndex = 2;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(10, 64);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEditar.TabIndex = 1;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeCompletoEditar
            // 
            this.lblNomeCompletoEditar.AutoSize = true;
            this.lblNomeCompletoEditar.Location = new System.Drawing.Point(7, 31);
            this.lblNomeCompletoEditar.Name = "lblNomeCompletoEditar";
            this.lblNomeCompletoEditar.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCompletoEditar.TabIndex = 0;
            this.lblNomeCompletoEditar.Text = "Nome completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.lblDescricaoApagar);
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(22, 628);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(766, 92);
            this.grbApagar.TabIndex = 8;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(541, 19);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(157, 67);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoApagar
            // 
            this.lblDescricaoApagar.AutoSize = true;
            this.lblDescricaoApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoApagar.Location = new System.Drawing.Point(42, 46);
            this.lblDescricaoApagar.Name = "lblDescricaoApagar";
            this.lblDescricaoApagar.Size = new System.Drawing.Size(217, 16);
            this.lblDescricaoApagar.TabIndex = 1;
            this.lblDescricaoApagar.Text = "Selecione um usuário para apagar!";
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::BakerCommerce.Properties.Resources.pastry_bag;
            this.pibLogo.Location = new System.Drawing.Point(663, 26);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(125, 93);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 9;
            this.pibLogo.TabStop = false;
            // 
            // lblDescricaoLogo
            // 
            this.lblDescricaoLogo.AutoSize = true;
            this.lblDescricaoLogo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoLogo.Location = new System.Drawing.Point(144, 43);
            this.lblDescricaoLogo.Name = "lblDescricaoLogo";
            this.lblDescricaoLogo.Size = new System.Drawing.Size(513, 48);
            this.lblDescricaoLogo.TabIndex = 10;
            this.lblDescricaoLogo.Text = "Gerenciamento de Usuários";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.Controls.Add(this.lblDescricaoLogo);
            this.Controls.Add(this.pibLogo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormUsuarios";
            this.Text = "Gerenciamento de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblEmailCadastro;
        private System.Windows.Forms.Label lblNomeCompletoCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtEmailCadastro;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSenhaEditar;
        private System.Windows.Forms.TextBox txtEmailEditar;
        private System.Windows.Forms.TextBox txtNomeEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeCompletoEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label lblDescricaoApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblDescricaoLogo;
    }
}