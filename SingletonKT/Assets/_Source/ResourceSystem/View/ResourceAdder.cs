using ResourceSystem.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem.View
{
    public class ResourceAdder : MonoBehaviour
    {
        [SerializeField] private TMP_InputField resourceCountInputField;
        [SerializeField] private TMP_Dropdown resourceTypeDropdown;
        [SerializeField] private Button addButton;
        
        private void Awake()
        {
            addButton.onClick.AddListener(AddResource);
        }

        private void AddResource() => ResourceBankSingleton.Instance.AddResource((ResourceType)resourceTypeDropdown.value,
            int.TryParse(resourceCountInputField.text, out var result) ? result : 1);
    }
}