using System;
using System.Linq;
using ResourceSystem.Data;
using TMPro;
using UnityEngine;

namespace ResourceSystem.View
{
    public class ResourceTypeDropdownFiller : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown targetDropdown;

        private void Awake()
        {
            targetDropdown.AddOptions(Enum.GetNames(typeof(ResourceType)).ToList());
        }
    }
}