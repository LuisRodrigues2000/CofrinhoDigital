using System;

namespace CofrinhoDigital.Core.Entities
{
    /// <summary>
    /// Representa a entidade principal do sistema.
    /// Responsável por gerenciar as operações financeiras do cofrinho.
    /// Contém toda a regra de negócio relacionada a saldo, depósito e saque.
    /// </summary>
    public class Cofrinho
    {
        // Valor fixo da taxa aplicada para saques acima do limite definido
        private const decimal TAXA_SAQUE = 2.50m;

        // Valor mínimo para que a taxa seja aplicada
        private const decimal LIMITE_TAXA = 200m;

        /// <summary>
        /// Saldo atual do cofrinho.
        /// O setter é privado para garantir encapsulamento.
        /// O saldo só pode ser alterado através dos métodos Depositar e Sacar.
        /// </summary>
        public decimal Saldo { get; private set; }

        /// <summary>
        /// Construtor padrão.
        /// Inicializa o cofrinho com saldo zero.
        /// </summary>
        public Cofrinho()
        {
            Saldo = 0;
        }

        /// <summary>
        /// Realiza um depósito no cofrinho.
        /// </summary>
        /// <param name="valor">Valor a ser depositado.</param>
        /// <exception cref="ArgumentException">
        /// Lançada quando o valor é menor ou igual a zero.
        /// </exception>
        public void Depositar(decimal valor)
        {
            // Validação de regra de negócio:
            // Não é permitido depositar valores zerados ou negativos.
            if (valor <= 0)
                throw new ArgumentException("O valor do depósito deve ser maior que zero.");

            // Atualiza o saldo somando o valor informado
            Saldo += valor;
        }

        /// <summary>
        /// Realiza um saque do cofrinho.
        /// Aplica taxa caso o valor seja superior ao limite definido.
        /// </summary>
        /// <param name="valor">Valor solicitado para saque.</param>
        /// <returns>Mensagem informando se houve aplicação de taxa.</returns>
        /// <exception cref="ArgumentException">
        /// Lançada quando o valor é menor ou igual a zero.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Lançada quando o saldo é insuficiente.
        /// </exception>
        public string Sacar(decimal valor)
        {
            // Validação: não permitir valores inválidos
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero.");

            decimal valorTotal = valor;

            // Regra de negócio:
            // Se o valor do saque for maior que o limite definido,
            // adiciona a taxa fixa ao valor total.
            if (valor > LIMITE_TAXA)
            {
                valorTotal += TAXA_SAQUE;
            }

            // Verificação de saldo suficiente
            if (valorTotal > Saldo)
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");

            // Atualiza o saldo subtraindo o valor total (com taxa se houver)
            Saldo -= valorTotal;

            // Retorna mensagem adequada ao usuário
            if (valor > LIMITE_TAXA)
            {
                return $"Saque realizado com sucesso! Foi aplicada uma taxa de R$ {TAXA_SAQUE:F2}.";
            }

            return "Saque realizado com sucesso!";
        }

        /// <summary>
        /// Retorna o saldo atual do cofrinho.
        /// </summary>
        /// <returns>Saldo atual.</returns>
        public decimal VerSaldo()
        {
            return Saldo;
        }
    }
}
