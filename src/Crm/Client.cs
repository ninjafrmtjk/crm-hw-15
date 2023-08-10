namespace Crm;

public sealed class Client
{
    string? firstName;
    string? lastName;
    string? middleName;
    string? phoneNumber;
    string? email;
    string? password;
    short age;
    string? passportNumber;
    string? gender;
    //test
    public required string FirstName
    {
        get => firstName ?? string.Empty;
        set => firstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string LastName 
    { 
        get => lastName ?? string.Empty;
        set => lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string MiddleName 
    {
        get => middleName ?? string.Empty;
        init => middleName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string PhoneNumber
    {
        get => phoneNumber ?? string.Empty;
        init => phoneNumber = value is { Length: >0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Email 
    {
        get => email ?? string.Empty;
        init => email = value is { Length: >0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Password 
    {
        get => password ?? string.Empty;
        init => password = value is { Length: >0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required short Age 
    { 
        get => age;
        init => age = value >= 18 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string PassportNumber 
    { 
        init => passportNumber = value is { Length: >= 8 } ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
    }
    public required string Gender 
    { 
        get => gender ?? string.Empty;
        init => gender = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public Client(
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
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        PhoneNumber = phoneNumber;
        Email = email;
        Password = password;
        Age = age;
        PassportNumber = passportNumber;
        Gender = gender;
    }

    public Client()
    {
    }
}
