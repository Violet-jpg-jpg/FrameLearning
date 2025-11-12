using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 自动挂载式继承Mono的单例,推荐使用
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonAuto<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject();
                obj.name = typeof(T).ToString();
                instance = obj.AddComponent<T>();
                DontDestroyOnLoad(obj);
            }
            return instance;
        }
    }
}
