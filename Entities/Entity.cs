namespace DexiaApi.Entities;

public abstract class Entity
{
   public Guid Id { get; } = Guid.NewGuid();
}