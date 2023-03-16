using UnityEngine;

/// <summary>
/// 单例模式基类
/// </summary>
public abstract class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;
    public static T Instance => instance;
    protected virtual void Awake()
    {
        if (instance == null)
            instance = this as T;
        else if (instance != this as T)
            Destroy(gameObject);
    }
}
