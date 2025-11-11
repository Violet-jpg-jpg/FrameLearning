using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 挂载式继承Mono单例
/// </summary>
/// <typeparam name="T"></typeparam>
public class SigletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        instance = this as T;
    }
}
