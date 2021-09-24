using UnityEngine;
using UnityEngine.UI;
using Yashlan.manage;

namespace Yashlan.ui
{
    public class UIScore : MonoBehaviour
    {
        public Text highScore;
        public Text currentScore;

        void Update()
        {
            currentScore.text = $"SCORE : {ScoreManager.Instance.CurrentScore}";
            highScore.text = $"HISCORE : {ScoreManager.Instance.HighScore}";
        }
    }
}