namespace Crm;

public readonly struct ClientInfo
{
    public readonly string FirstName { get; init; }
    public readonly string LastName { get; init; }
    public readonly string MiddleName { get; init; }
    public readonly string PhoneNumber { get; init; }
    public readonly string Email { get; init; }
    public readonly string Password { get; init; }
    public readonly short Age { get; init; }
    public readonly string PassportNumber { get; init; }
    public readonly string Gender { get; init; }
}