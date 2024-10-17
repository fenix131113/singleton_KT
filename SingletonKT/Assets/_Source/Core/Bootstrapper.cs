using ResourceSystem;
using ResourceSystem.View;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private int startResources;
        [SerializeField] private ResourceAdder resourceAdderView;

        private ResourceBank _resourceBank;

        private void Awake()
        {
            SetupAll();
        }

        private void SetupAll()
        {
            _resourceBank = new ResourceBank(startResources);
            resourceAdderView.Construct(_resourceBank);
        }
    }
}
