using Refinify.Domain.Abstractions;
using Refinify.Domain.Shared;

namespace Refinify.Domain.Sellers;

public class Seller : Entity
{
    private Seller(
        Guid id, 
        Guid userId, 
        Name name, 
        Description description, 
        SellerPicture picture, 
        SellerStatus status) 
        : base(id)
    {
        UserId = userId;
        Name = name;
        Description = description;
        Picture = picture;
        Status = status;
    }

    public Guid UserId { get; private set; }
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public SellerPicture Picture { get; private set; }
    public SellerStatus Status { get; private set; }
}