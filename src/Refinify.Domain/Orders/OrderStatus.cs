namespace Refinify.Domain.Orders;

public enum OrderStatus
{
    Accepted = 0,
    Processing = 1,
    Delivering = 2,
    Delivered = 3,
    Finished = 4,
    Cancelled = 5,
    Checkout = 6,
    NeedPayment = 7,
}