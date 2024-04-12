namespace Paragon.Domain.Entity;

public abstract class Entity<TId>
{
    public TId Id { get; init;}

    public Entity(TId id)
    {
        Id = id;
    }
}