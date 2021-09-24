using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yashlan.ui
{
    public class UIGameOver : MonoBehaviour
    {
        void Awake() => Hide();

        void Update()
        {
            if (Input.GetMouseButtonDown(0)) SceneManager.LoadScene("menu");
        }

        public void Show() => gameObject.SetActive(true);

        private void Hide() => gameObject.SetActive(false);
    }
}