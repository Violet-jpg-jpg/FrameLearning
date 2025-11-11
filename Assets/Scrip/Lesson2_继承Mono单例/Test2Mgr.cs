using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2Mgr : SigletonMono<Test2Mgr>
{
    private int i;
    protected override void Awake()
    {
        base.Awake();

        i = 20;
    }

    public void Test2Log()
    {
        Debug.Log("Test2Mgr" + i);
    }
}
