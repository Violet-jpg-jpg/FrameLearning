using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        TestMgr.Instance.TestLog();

        Test2Mgr.Instance.Test2Log();
        Test2Mgr2.Instance.Test2Log();
    }
}
