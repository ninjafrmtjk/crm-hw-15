using Crm;

public interface IClientService
{
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
    );

    public Client? GetClient(string name, string surname);
    public Client? DeleteClient(string name, string surname);
}
