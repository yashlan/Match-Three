using UnityEngine;
using UnityEngine.SceneManagement;
using Yashlan.util;

namespace Yashlan.manage
{
    public class BgmManager : Singleton<BgmManager>
    {
        public AudioSource audioSource;

        void Start() => DontDestroyOnLoad(gameObject);

        private void Update()
        {
            if (SceneManager.GetSceneByName("menu").isLoaded)
            {
                if (!audioSource.isPlaying) audioSource.Play();
            }
        }

        public void StopBGM() => audioSource.Stop();
    }
}
