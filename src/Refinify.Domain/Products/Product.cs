using Refinify.Domain.Abstractions;
using Refinify.Domain.Shared;

namespace Refinify.Domain.Products;

public sealed class Product : Entity
{
    public Product(
        Guid id,
        Guid categoryId,
        Guid sellerId,
        Name name,
        Description description,
        ProductType type, 
        ProductStatus status, 
        Money price, 
        UnitName unitName, 
        AvailableStock availableStock, 
        Sold sold)
        : base(id)
    {
        CategoryId = categoryId;
        SellerId = sellerId;
        Name = name;
        Description = description;
        Type = type;
        Status = status;
        Price = price;
        UnitName = unitName;
        AvailableStock = availableStock;
        Sold = sold;
    }

    public Guid CategoryId { get; private set; }
    public Guid SellerId { get; private set; }
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public ProductType Type { get; private set; }
    public ProductStatus Status { get; private set; }
    public Money Price { get; private set; }
    public UnitName UnitName { get; private set; }
    public AvailableStock AvailableStock { get; private set; }
    public Sold Sold { get; private set; }
    public DateTime? LastSoldOnUtc { get; internal set; }
}