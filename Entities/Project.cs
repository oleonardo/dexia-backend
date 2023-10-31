namespace DexiaApi.Entities
{
   public sealed class Project(string name, List<string> stacks) : Entity
   {
      private readonly IReadOnlyList<Cluster> _clusters = new List<Cluster>();

      public string Name { get; private set; } = name;
      public List<string> Stacks { get; private set; } = stacks;

      public List<Cluster> Clusters => [.. _clusters];
   }
}