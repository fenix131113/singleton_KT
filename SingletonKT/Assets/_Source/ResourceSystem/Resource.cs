using ResourceSystem.Data;

namespace ResourceSystem
{
    public class Resource
    {
        public int ResourceAmount { get; private set; }
        public ResourceType ResourceType { get; private set; }

        public Resource(ResourceType resourceType, int startAmount)
        {
            ResourceType = resourceType;
            ResourceAmount = startAmount;
        }

        public void AddResource(int amount) => ResourceAmount += amount;
    }
}
