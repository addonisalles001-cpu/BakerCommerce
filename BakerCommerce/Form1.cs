using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

         
        // Verificar se a pessoa digitou o email e senha:
            if (txbEmail.Text.Length< 6)
            {
                MessageBox.Show("Digite um email válido!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Digite um email válido!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                // Colocar os valores dos campos nos atributos do usuário:
                usuario.Email =txbEmail.Text;
                usuario.Senha =txbSenha.Text;

                // Tabela que vai receber o resultado do SELECT (Logar)
                DataTable resultado = usuario.Logar();

                // Verificar se acertou o email e senha:
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Email e/ou senha inválidos!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Armazenar as infos vindas do bd no objeto "usuário"
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();

                    // Mudar para o MenuPrincipal:
                    MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                    Hide(); // esconder a janela atual
                    menuPrincipal.ShowDialog(); // Mostra o MenuPrincipal

                    Show(); // Mostrar a tela de login ao sair do menu principal
                }

            }




        }

        private void txbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbSenha.Focus();
            }
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
