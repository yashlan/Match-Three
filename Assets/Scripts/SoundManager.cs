using UnityEngine;
using Yashlan.util;

namespace Yashlan.manage
{
    public class SoundManager : Singleton<SoundManager>
    {
        public AudioClip gameOver;
        public AudioClip scoreNormal;
        public AudioClip scoreCombo;
        public AudioClip wrongMove;
        public AudioClip tap;

        private AudioSource player;

        void Start() => player = GetComponent<AudioSource>();
        public void PlayWrong() => player.PlayOneShot(wrongMove);
        public void PlayTap() => player.PlayOneShot(tap);
        public void PlayGameOver() => player.PlayOneShot(gameOver);
        public void PlayScore(bool isCombo)
        {
            if (isCombo) 
                player.PlayOneShot(scoreCombo);
            else 
                player.PlayOneShot(scoreNormal);
        }
    }
}