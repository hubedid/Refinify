using Refinify.Domain.Abstractions;

namespace Refinify.Domain.Addresses;

public sealed class Address : Entity
{
    private Address(
        Guid id,
        Guid userId,
        Country country,
        State state,
        ZipCode zipCode,
        City city,
        Street street,
        IsMain isMain) 
        : base(id)
    {
        UserId = userId;
        Country = country;
        State = state;
        ZipCode = zipCode;
        City = city;
        Street = street;
        IsMain = isMain;
    }

    public Guid UserId { get; private set; }
    public Country Country { get; private set; }
    public State State { get; private set; }
    public ZipCode ZipCode { get; private set; }
    public City City { get; private set; }
    public Street Street { get; private set; }
    public IsMain IsMain { get; private set; }
}