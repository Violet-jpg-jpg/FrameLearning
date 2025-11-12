using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6Mgr : BaseManager<Test6Mgr>
{
    private Coroutine testCoro;
    public void AddUpdateFunc()
    {
        MonoMgr.Instance.AddUpdateListener(MyUpdate);
        testCoro = MonoMgr.Instance.StartCoroutine(TestCoro());
    }

    public void RemoveUpdateFunc()
    {
        MonoMgr.Instance.RemoveUpdateListener(MyUpdate);
        MonoMgr.Instance.StopCoroutine(testCoro);
    }

    private IEnumerator TestCoro()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("I Start Coro");
    }
    public void MyUpdate()
    {
        Debug.Log("Test6Mgr");
    }
}
