using Crm;
public sealed class ClientService : IClientService
{
    private readonly List<Client> _clients;
    public ClientService()
    {
        _clients = new();
    }
    public Client CreateClient
    (
        string firstName,
        string lastName,
        string middleName,
        string phoneNumber,
        string email,
        string password,
        short age,
        string passportNumber,
        string gender
    )
    {
        Client newClient = new()
        {
            FirstName = firstName,
            LastName = lastName,
            MiddleName = middleName,
            PhoneNumber = phoneNumber,
            Email = email,
            Password = password,
            Age = age,
            PassportNumber = passportNumber,
            Gender = gender
        };

        _clients.Add(newClient);

        return newClient;
    }

    public Client? GetClient(string name, string surname)
    {
        if (name is not { Length: > 0 })
            throw new ArgumentOutOfRangeException(nameof(name));

        if (surname is not { Length: > 0 })
            throw new ArgumentOutOfRangeException(nameof(surname));

        foreach (Client client in _clients)
        {
            if (client.FirstName.Equals(name) && client.LastName.Equals(surname))
                return client;
        }

        return null;
    }

    public Client? DeleteClient(string name, string surname)
    {
        if (name is not { Length: > 0 })
            throw new ArgumentOutOfRangeException(nameof(name));

        if (surname is not { Length: > 0 })
            throw new ArgumentOutOfRangeException(nameof(surname));

        foreach (Client client in _clients)
        {
            _clients.RemoveAll(client => client.FirstName == name && client.LastName == surname);

            Console.WriteLine(_clients);
        }

        return null;
    }

    public void ChangeClientName(Client client, string newFirstName, string newLastName)
    {
        client.FirstName = newFirstName;
        client.LastName = newLastName;
    }

    internal Client CreateClient(string? firstName, string? lastName, string? middleName, short age, string? passportNumber, string? gender)
    {
        throw new NotImplementedException();
    }

}