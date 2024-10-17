using UnityEngine;

namespace AudioPlayer
{
    public class AudioPlayerSingleton : MonoBehaviour
    {
        public static AudioPlayerSingleton Instance { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                return;
            }
        
            Destroy(gameObject);
        }
    }
}