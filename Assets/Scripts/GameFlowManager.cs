using UnityEngine;
using Yashlan.ui;
using Yashlan.util;

namespace Yashlan.manage
{
    public class GameFlowManager : Singleton<GameFlowManager>
    {
        [Header("UI")]
        public UIGameOver GameOverUI;

        public bool IsGameOver => isGameOver;

        private bool isGameOver = false;

        void Start() => isGameOver = false;

        public void GameOver()
        {
            isGameOver = true;
            BgmManager.Instance.StopBGM();
            SoundManager.Instance.PlayGameOver();
            ScoreManager.Instance.SaveHighScore();
            GameOverUI.Show();
        }
    }
}