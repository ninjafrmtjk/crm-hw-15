using Crm;

Console.WriteLine("Choose operation: 1 - Create client, 2 - Create Order,");
Console.Write("3 - Found client, 4 - Delete client, 0 - Break operation: ");
short s = short.Parse(Console.ReadLine());

IClientService clientService = new ClientService();
OrderService orderService = new();

switch (s)
{
    case 1:
        CreateClient();
        break;
    case 2:
        CreateOrder();
        break;
    case 3:
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        clientService.GetClient(firstName, lastName);
        break;
    case 4:
        string firstName1 = Console.ReadLine();
        string lastName1 = Console.ReadLine();
        clientService.DeleteClient(firstName1, lastName1);
        break;
    case 0:
        Console.WriteLine("Breaking operation...");
        break;
    default:
        Console.WriteLine("Input isn't correct, please try again");
        break;
}


void CreateClient()
{
    Console.Write("Input name: ");
    string firstName = Console.ReadLine();
    Console.Write("Input last name: ");
    string lastName = Console.ReadLine();
    Console.Write("Input middle name: ");
    string middleName = Console.ReadLine();
    Console.Write("Input age: ");
    short age = short.Parse(Console.ReadLine());
    Console.Write("Input passport number: ");
    string passportNumber = Console.ReadLine();
    Console.Write("Input gender: ");
    string gender = Console.ReadLine();

    // Client newClient = clientService.CreateClient(
    //     firstName,
    //     lastName,
    //     middleName,
    //     age,
    //     passportNumber,
    //     gender
    // );

    Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
    Console.WriteLine("Age: {0}", age);
    Console.WriteLine("Passport Number: {0}", passportNumber);
    Console.WriteLine("Gender: {0}", gender);
}

void CreateOrder()
{
    string name = Console.ReadLine();
    string color = Console.ReadLine();
    int id = int.Parse(Console.ReadLine());
    short price = short.Parse(Console.ReadLine());

    // Order newOrder = orderService.CreateOrder(
    //     Id = id,
    //     Name = name,
    //     Color = color,
    //     Price = price
    // );

    Console.WriteLine("ID: {0}", id);
    Console.WriteLine("Name: {0}", name);
    Console.WriteLine("Color: {0}", color);
    Console.WriteLine("Price: {0}", price);
}