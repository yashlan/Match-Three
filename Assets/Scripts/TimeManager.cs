using UnityEngine;
using Yashlan.util;

namespace Yashlan.manage
{
    public class TimeManager : Singleton<TimeManager>
    {
        public int duration;

        private float time;

        void Start() => time = 0;

        void Update()
        {
            if (GameFlowManager.Instance.IsGameOver) return;

            if (time > duration)
            {
                GameFlowManager.Instance.GameOver();
                return;
            }

            time += Time.deltaTime;
        }

        public float GetRemainingTime() => duration - time;

        public int AddDurationBonusOnCombo(int durationBonus) => duration += durationBonus;
    }
}