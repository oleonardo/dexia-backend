namespace DexiaApi.Entities
{
   public sealed class Cluster(string name, string description, string manager) : Entity
   {
      public string Name { get; private set; } = name;

      public string Description { get; private set; } = description;

      public string Manager { get; private set; } = manager;
   }
}