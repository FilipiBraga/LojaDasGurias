using Flunt.Notifications;
using Flunt.Validations;

namespace LojaDasGurias.Domain.Entities
{
    public class Cliente : Notifiable<Notification>
    {
        public Cliente(string nome, DateTime dataDeNascimento)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;

            AddNotifications(new Contract<Cliente>()
                .Requires()
                .IsGreaterThan(DataDeNascimento, DateTime.MinValue, nameof(DataDeNascimento), "A data de nascimento é obrigatória")
                .IsNotNullOrWhiteSpace(Nome, nameof(Nome), "O nome é obrigatório"));
        }

        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string Telefone { get; private set; }    
        public string Endereco { get; private set; }    
    }
}
