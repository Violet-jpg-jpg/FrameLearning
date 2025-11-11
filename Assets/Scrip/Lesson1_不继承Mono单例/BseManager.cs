using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 单例模式基类
/// </summary>
/// <typeparam name="T"></typeparam>
public class BaseManager<T> where T : class, new()
{
    private static T instance;
    //属性方式
    public static T Instance
    {
        get
        {
            if (instance == null)
                instance = new T();
            return instance;
        }


    }
}
