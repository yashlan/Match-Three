using UnityEngine;

namespace Yashlan.util
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        public static T Instance { get; protected set; }

        void Awake()
        {
            if (Instance != null && Instance != this) 
                Destroy(gameObject);
            else 
                Instance = (T)this;
        }
    }
}
