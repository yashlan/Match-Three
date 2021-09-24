using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Yashlan.util;

namespace Yashlan.manage
{
    public class ScoreManager : Singleton<ScoreManager>
    {
        [Header("combo floating")]
        public Text comboText;

        public int tileRatio;
        public int comboRatio;

        private int highScore;
        private int currentScore;

        public int HighScore => highScore;
        public int CurrentScore => currentScore;


        void Start()
        {
            currentScore = 0;

            if (SceneManager.GetSceneByName("level 1").isLoaded)
                LoadHighScoreLevel_1();

            if (SceneManager.GetSceneByName("level 2").isLoaded)
                LoadHighScoreLevel_2();
        }

        private void LoadHighScoreLevel_1() => highScore = PlayerPrefs.GetInt("HISCORE 1");

        private void LoadHighScoreLevel_2() => highScore = PlayerPrefs.GetInt("HISCORE 2");

        public void SaveHighScore() 
        {
            if (SceneManager.GetSceneByName("level 1").isLoaded)
            {
                if (currentScore > PlayerPrefs.GetInt("HISCORE 1"))
                {
                    PlayerPrefs.SetInt("HISCORE 1", currentScore);
                    LoadHighScoreLevel_1();
                }
            }

            if (SceneManager.GetSceneByName("level 2").isLoaded)
            {
                if (currentScore > PlayerPrefs.GetInt("HISCORE 2"))
                {
                    PlayerPrefs.SetInt("HISCORE 2", currentScore);
                    LoadHighScoreLevel_2();
                }
            }
        }

        public void IncrementCurrentScore(int tileCount, int comboCount)
        {
            if (!GameFlowManager.Instance.IsGameOver)
            {
                currentScore += (tileCount * tileRatio) * (comboCount * comboRatio);

                SoundManager.Instance.PlayScore(comboCount > 1);

                if (comboCount > 1)
                    StartCoroutine(ShowFloatingComboText(comboCount));

                if(comboCount > 0)
                    TimeManager.Instance.AddDurationBonusOnCombo(2);
            }
        }

        private IEnumerator ShowFloatingComboText(int comboCount)
        {
            comboText.gameObject.SetActive(true);
            comboText.text = $"Combo {comboCount}x";
            yield return new WaitForSeconds(1f);
            comboText.gameObject.SetActive(false);
            yield break;
        }
    }
}