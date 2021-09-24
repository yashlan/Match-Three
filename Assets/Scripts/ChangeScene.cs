using UnityEngine;
using UnityEngine.SceneManagement;

namespace Yashlan.util
{
    public class ChangeScene : MonoBehaviour
    {
        public void ChangeSceneOnClick(string name) => SceneManager.LoadScene(name);
    }
}