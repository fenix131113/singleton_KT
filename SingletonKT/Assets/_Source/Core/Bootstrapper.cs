using ResourceSystem;
using ResourceSystem.View;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private int startResources;
        [SerializeField] private ResourceAdder resourceAdderView;
        

        private void Awake()
        {
            SetupAll();
        }

        private void SetupAll()
        {
            _ = new ResourceBankSingleton(startResources);
        }
    }
}
