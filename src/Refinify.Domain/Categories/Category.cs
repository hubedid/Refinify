using Refinify.Domain.Abstractions;
using Refinify.Domain.Shared;

namespace Refinify.Domain.Categories;

public sealed class Category : Entity
{
    private Category(
        Guid id, 
        Name name, 
        Description description, 
        CategoryImage image) 
        : base(id)
    {
        Name = name;
        Description = description;
        Image = image;
    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public CategoryImage Image { get; private set; }
}