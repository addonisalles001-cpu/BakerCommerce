using BakerCommerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BakerCommerce
{
    public partial class FormProdutos : Form

    {
        Model.Usuario usuario;
        int idSelecionado = 0;

        public FormProdutos(Model.Usuario usuario)

        {

            InitializeComponent();

            this.usuario = usuario;

            listarCategoriasCmb();

            Atualizardgv();

        }

        public void Atualizardgv()

        {

            Model.Produto produtos = new Model.Produto();

            dgvListaProdutos.DataSource = produtos.Listar();

        }

        public void listarCategoriasCmb()

        {

            Model.Categoria categoria = new Model.Categoria();
            // Tabela p/ receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();
            foreach (DataRow dr in tabela.Rows)

            {

                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {

            if (txbNomeCadastro.Text.Length < 2)
            {

                MessageBox.Show("O nome deve ter no minimo 2 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cmbCategoriaCadastro.Text == "")

            {

                MessageBox.Show("selecione uma categoria.",
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else

            {

                // Fazer o cadastro....
                Model.Produto ProdutoCadastar = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                ProdutoCadastar.Nome = txbNomeCadastro.Text;
                ProdutoCadastar.Preco = double.Parse(txbPrecoCadastrar.Text);
                ProdutoCadastar.IdRespCadastro = usuario.Id;
                string linha = cmbCategoriaCadastro.Text;
                string numero = linha.Split('-')[0].Trim();
                ProdutoCadastar.IdCategoria = int.Parse(numero);


                if (ProdutoCadastar.Cadastrar())

                {

                    MessageBox.Show("Produto cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dvg:

                    Atualizardgv();

                    // apagar os campos de cadastro:

                    txbNomeCadastro.Clear();
                    txbPrecoCadastrar.Clear();

                }

                else

                {

                    MessageBox.Show("Falha ao cadastrar o Produto.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 2)
            {

                MessageBox.Show("O nome deve ter no minimo 2 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (cmbCategoriaEditar.Text == "")

            {

                MessageBox.Show("Selecione uma categoria.",
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else

            {

                // Fazer o cadastro....
                Model.Produto produtoEditar = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = double.Parse(txbPrecoEditar.Text);
                produtoEditar.IdRespCadastro = usuario.Id;
                string linha = cmbCategoriaEditar.Text;
                string numero = linha.Split('-')[0].Trim();
                produtoEditar.IdCategoria = int.Parse(numero);
                produtoEditar.Id = idSelecionado;


                if (produtoEditar.Modificar())

                {

                    MessageBox.Show("Produto Editado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar o dvg:

                    Atualizardgv();

                    // apagar os campos de cadastro:

                    txbNomeCadastro.Clear();
                    txbPrecoCadastrar.Clear();

                }

                else

                {

                    MessageBox.Show("Falha ao Editar o Produto.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar esse produto?",
           "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o produto!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public void ResetarCampos()
        {

            // Atualizar o dgv:
            Atualizardgv();

            // Limpar campos de edição:
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();


            // Retornar o idSelecionado para 0
            idSelecionado = 0;

            //Retornar o texto padrão do "apagar"
            lblDescricao.Text = "Selecione o Produto que deseja apagar.";

            //Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void dgvListaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada
            int ls = dgvListaProdutos.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbx de edição:
            txbNomeEditar.Text = dgvListaProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvListaProdutos.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvListaProdutos.Rows[ls].Cells[0].Value;

            // Ativar o grvEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            lblDescricao.Text = $"Apagar: {dgvListaProdutos.Rows[ls].Cells[1].Value}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }
    }
}




