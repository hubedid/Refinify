using Refinify.Domain.Abstractions;
using Refinify.Domain.Orders;

namespace Refinify.Domain.Carts;

public sealed class Cart : Entity 
{
    private Cart(
        Guid id, 
        Guid productId, 
        Guid userId, 
        Amount amount) 
        : base(id)
    {
        ProductId = productId;
        UserId = userId;
        Amount = amount;
    }

    public Guid ProductId { get; private set; }
    public Guid UserId { get; private set; }
    public Amount Amount { get; private set; }
    public ICollection<Order> Orders { get; init; } = new List<Order>();
}