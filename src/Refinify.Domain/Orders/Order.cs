using Refinify.Domain.Abstractions;
using Refinify.Domain.Carts;
using Refinify.Domain.Invoices;

namespace Refinify.Domain.Orders;

public sealed class Order : Entity
{
    private readonly List<Cart> _carts = new();

    private Order(
        Guid id, 
        Notes notes, 
        DeliveryPrice deliveryPrice, 
        OrderStatus orderStatus) 
        : base(id)
    {
        Notes = notes;
        DeliveryPrice = deliveryPrice;
        OrderStatus = orderStatus;
    }

    public Notes Notes { get; private set; }
    public DeliveryPrice DeliveryPrice { get; private set; }
    public OrderStatus OrderStatus { get; private set; }
    public IReadOnlyList<Cart> Carts => _carts.ToList();
    public ICollection<Invoice> Invoices { get; init; } = new List<Invoice>();

}