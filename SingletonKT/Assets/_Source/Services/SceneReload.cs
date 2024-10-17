using UnityEngine.SceneManagement;

namespace Services
{
    public static class SceneReload
    {
        public static void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}