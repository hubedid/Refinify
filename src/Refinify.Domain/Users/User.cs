using Refinify.Domain.Abstractions;

namespace Refinify.Domain.Users;
public sealed class User : Entity 
{
    public User(Guid id, FirstName firstName, LastName lastName, Email email, Citizenship citizenship)
        : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Citizenship = citizenship;
    }

    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }
    public Citizenship Citizenship { get; private set; }

}
