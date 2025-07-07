namespace TarefasApp.Domain.Entities.UserContext;

public sealed class User : BaseEntity
{
    public User() { }

    public User(string nome, string email, string senha)
    {
        Nome = nome;
        Email = email;
        SenhaHash = senha;
    }

    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string SenhaHash { get; private set; }
}