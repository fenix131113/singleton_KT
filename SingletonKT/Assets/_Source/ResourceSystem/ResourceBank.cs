using System;
using System.Collections.Generic;
using ResourceSystem.Data;

namespace ResourceSystem
{
    public class ResourceBank
    {
        private readonly Dictionary<ResourceType, Resource> _resources = new();
        private readonly int _startResources;
        
        public event Action<ResourceType> OnResourceChanged;

        public ResourceBank(int startResources)
        {
            FillResources();
            _startResources = startResources;
        }

        private void FillResources()
        {
            for (var i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
                _resources.Add((ResourceType)i, new Resource((ResourceType)i, _startResources));
        }

        public void AddResource(ResourceType resourceType, int amount)
        {
            if (!_resources.TryGetValue(resourceType, out var resource)) return;
            
            resource.AddResource(amount);
            OnResourceChanged?.Invoke(resource.ResourceType);
        }

        public int GetAmountOfResource(ResourceType resourceType) => _resources.GetValueOrDefault(resourceType).ResourceAmount;
    }
}
