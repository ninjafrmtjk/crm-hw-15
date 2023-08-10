using Crm;

public sealed class OrderService
{
    private readonly List<Order> _orders;
    public OrderService()
    {
        _orders = new();
    }
    public Order CreateOrder
    (
        int id,
        string name,
        string color,
        short price,
        string description
    )
    {
        Order newOrder = new()
        {
            Id = id,
            Name = name,
            Color = color,
            Price = price,
            Description = description
        };

        _orders.Add(newOrder);

        return newOrder;
    }

    public void ChangeOrderDescription(Order order, string newDescription)
    {
        order.Description = newDescription;
    }

    public Order? DeleteOrder(int id)
    {
        if (id < 0)
            throw new ArgumentOutOfRangeException(nameof(id));

        foreach (Order order in _orders)
        {
            _orders.RemoveAll(order => order.Id == id);

            Console.WriteLine(_orders);
        }

        return null;
    }

}