using Services;
using UnityEngine;

namespace InputSystem
{
    public class PlayerInput : MonoBehaviour
    {
        private void Update()
        {
            ReadSceneReloadInput();
        }

        private static void ReadSceneReloadInput()
        {
            if(Input.GetKeyDown(KeyCode.R))
                SceneReload.ReloadScene();
        }
    }
}