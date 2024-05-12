using Refinify.Domain.Abstractions;
using Refinify.Domain.Orders;

namespace Refinify.Domain.Invoices;

public sealed class Invoice : Entity
{
    private readonly List<Order> _orders = new();

    private Invoice(
        Guid id, 
        TotalPrice totalPrice, 
        PaymentId paymentId, 
        PaymentLink paymentLink, 
        InvoiceStatus status) 
        : base(id)
    {
        TotalPrice = totalPrice;
        PaymentId = paymentId;
        PaymentLink = paymentLink;
        Status = status;
    }

    public TotalPrice TotalPrice { get; private set; }
    public PaymentId PaymentId { get; private set; }
    public PaymentLink PaymentLink { get; private set; }
    public InvoiceStatus Status { get; private set; }
    public IReadOnlyList<Order> Orders => _orders.ToList();
}