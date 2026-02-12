using System;
using System.Windows.Forms;
using CofrinhoDigital.Core.Entities;

namespace CofrinhoDigital.UI
{
    /// <summary>
    /// Camada de Interface (UI).
    /// Responsável apenas pela interação com o usuário.
    /// Não contém regra de negócio.
    /// </summary>
    public partial class Form1 : Form
    {
        // Instância da classe de regra de negócio (Core)
        // A UI depende da Core, mas a Core não depende da UI.
        private Cofrinho _cofrinho;

        /// <summary>
        /// Construtor do formulário.
        /// Inicializa os componentes visuais e a instância do cofrinho.
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
            _cofrinho = new Cofrinho(); // Cria uma nova instância da regra de negócio
        }

        /// <summary>
        /// Evento acionado ao clicar no botão Depositar.
        /// Responsável por capturar o valor digitado e chamar a regra de negócio.
        /// </summary>
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conversão do valor digitado no TextBox para decimal
                decimal valor = Convert.ToDecimal(txtValor.Text);

                // Chamada da camada Core
                _cofrinho.Depositar(valor);

                // Feedback ao usuário
                MessageBox.Show("Depósito realizado com sucesso!");

                // Atualiza o saldo exibido na tela
                AtualizarSaldo();

                // Limpa o campo após operação
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                // Captura qualquer exceção lançada pela Core
                // Exemplo: valor inválido ou negativo
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão Sacar.
        /// Responsável por capturar o valor e chamar a regra de saque.
        /// </summary>
        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                // Conversão do valor informado
                decimal valor = Convert.ToDecimal(txtValor.Text);

                // Chamada da regra de negócio
                string mensagem = _cofrinho.Sacar(valor);

                // Exibe mensagem retornada (incluindo informação de taxa, se houver)
                MessageBox.Show(mensagem);

                // Atualiza saldo na interface
                AtualizarSaldo();

                // Limpa campo
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                // Exibe erro caso saldo seja insuficiente ou valor inválido
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão Ver Saldo.
        /// Apenas atualiza a exibição do saldo.
        /// </summary>
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            AtualizarSaldo();
        }

        /// <summary>
        /// Método auxiliar responsável por atualizar o saldo exibido na interface.
        /// </summary>
        private void AtualizarSaldo()
        {
            // Formatação com duas casas decimais
            lblSaldo.Text = $"Saldo atual: R$ {_cofrinho.VerSaldo():F2}";
        }
    }
}
