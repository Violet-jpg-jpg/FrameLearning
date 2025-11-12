using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoMgr : SingletonAuto<MonoMgr>
{
    private event UnityAction UpdateEvent;
    private event UnityAction FixedUpdateEvent;
    private event UnityAction LateUpdateEvent;

    public void AddUpdateListener(UnityAction updateFunc)
    {
        UpdateEvent += updateFunc;
    }

    public void AddFixedUpdateListener(UnityAction fixedUpdateFunc)
    {
        FixedUpdateEvent += fixedUpdateFunc;
    }

    public void AddLateUpdateListener(UnityAction lateUpdateFunc)
    {
        LateUpdateEvent += lateUpdateFunc;
    }

    public void RemoveUpdateListener(UnityAction updateFunc)
    {
        UpdateEvent -= updateFunc;
    }

    public void RemoveFixedUpdateListener(UnityAction fixedUpdateFunc)
    {
        FixedUpdateEvent -= fixedUpdateFunc;
    }

    public void RemoveLateUpdateListener(UnityAction lateUpdateFunc)
    {
        LateUpdateEvent -= lateUpdateFunc;
    }


    void Update()
    {
        UpdateEvent?.Invoke();
    }

    void FixedUpdate()
    {
        FixedUpdateEvent?.Invoke();
    }

    void LateUpdate()
    {
        LateUpdateEvent?.Invoke();
    }
}
    

