using UnityEngine;

/// <summary>
/// 单例模式基类
/// </summary>
public abstract class SingletonMonoAuto<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject(typeof(T).ToString());
                instance = obj.AddComponent<T>();
                DontDestroyOnLoad(obj);
            }
            return instance;
        }
    }
}
