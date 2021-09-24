using System;
using UnityEngine;
using UnityEngine.UI;
using Yashlan.manage;

namespace Yashlan.ui
{
    public class UITime : MonoBehaviour
    {
        public Text time;

        void Update() => time.text = GetTimeString(TimeManager.Instance.GetRemainingTime() + 1);

        private string GetTimeString(float timeRemaining)
        {
            int minute = Mathf.FloorToInt(timeRemaining / 60);
            int second = Mathf.FloorToInt(timeRemaining % 60);

            return new TimeSpan(0, 0, minute, second).ToString("mm\\:ss");
        }
    }
}