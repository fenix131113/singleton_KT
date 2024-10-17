using System;
using System.Collections.Generic;
using ResourceSystem.Data;
using TMPro;
using UnityEngine;

namespace ResourceSystem.View
{
    public class ResourcesAmountView : MonoBehaviour
    {
        [SerializeField] private TMP_Text resourceItemPrefab;
        [SerializeField] private Transform spawnContainer;

        private readonly Dictionary<ResourceType, TMP_Text> _resourceItems = new();

        private void Start()
        {
            SpawnResourceItems();
            Bind();
        }

        private void SpawnResourceItems()
        {
            for (var i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
            {
                var spawned = Instantiate(resourceItemPrefab, spawnContainer);
                spawned.text =
                    $"{Enum.GetValues(typeof(ResourceType)).GetValue(i)}: {ResourceBankSingleton.Instance.GetAmountOfResource((ResourceType)i)}";

                _resourceItems.Add((ResourceType)Enum.GetValues(typeof(ResourceType)).GetValue(i), spawned);
            }
        }

        private void RedrawLabels(ResourceType resourceType)
        {
            _resourceItems[resourceType].text =
                $"{resourceType}: {ResourceBankSingleton.Instance.GetAmountOfResource(resourceType)}";
        }

        private void Bind() => ResourceBankSingleton.Instance.OnResourceChanged += RedrawLabels;

        private void Expose() => ResourceBankSingleton.Instance.OnResourceChanged -= RedrawLabels;

        private void OnDestroy() => Expose();
    }
}