namespace ResourceSystem
{
    public class ResourceBankSingleton
    {
        public static ResourceBank Instance { get; private set; }

        public ResourceBankSingleton(int startResources)
        {
            Instance ??= new ResourceBank(startResources);
        }
    }
}