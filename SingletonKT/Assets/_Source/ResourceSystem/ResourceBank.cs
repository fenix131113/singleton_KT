using System;
using System.Collections.Generic;
using ResourceSystem.Data;
using UnityEngine;

namespace ResourceSystem
{
    public class ResourceBank
    {
        private readonly Dictionary<ResourceType, Resource> _resources = new();
        private readonly int _startResources;

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
            if (_resources.TryGetValue(resourceType, out var resource))
                resource.AddResource(amount);
            
            Debug.Log($"Added {amount} to \"{resourceType}\"");
        }

        public int GetAmountOfResource(ResourceType resourceType) => _resources.GetValueOrDefault(resourceType).ResourceAmount;
    }
}
