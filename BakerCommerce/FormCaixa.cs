using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class caixaBaker : Form
    {
        Model.Usuario usuario;
        public caixaBaker(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo está vazio
            if (txtComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);

                // Tabela para receber o resultado da consulta SELECT
                DataTable resultado = ordemComanda.BuscarPorFicha();

                // Verificar se existem linhas em "resultado":
                if(resultado.Rows.Count > 0)
                {
                    //Mostra no dgv:
                    dgvComanda.DataSource = resultado;
                    // Calcular o total e mostrar o lblTotal:
                    lblTotal.Text = "R$" + resultado.Compute("Sum(Total_Item)", "True").ToString();
                }
                else
                {
                    // Limpar dgv:
                    dgvComanda.DataSource = null;
                    // Mostrar menssagem de erro:
                    MessageBox.Show("Não existem lançamentos nessa comanda!", "Atenção",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void cxbPagamentoRecebido_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = cxbPagamentoRecebido.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa comanda?",
                "Atenção!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                // Encerrar a comanda:
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txtComanda.Text);

                // Executar o update para encerrar a comanda:
                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerrada!", "Show",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    // Resetar os campos:
                    txtComanda.Clear();
                    dgvComanda.DataSource = null;
                    cxbPagamentoRecebido.Checked = false;
                    btnEncerrar.Enabled = false;
                    lblTotal.Text = "R$   - ";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar comanda!", "Erro",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
    }
}
