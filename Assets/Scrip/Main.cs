using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        TestMgr.Instance.TestLog();

        Test2Mgr.Instance.Test2Log();
        Test2Mgr2.Instance.Test2Log();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Test6Mgr.Instance.AddUpdateFunc();
        if (Input.GetKeyDown(KeyCode.D))
            Test6Mgr.Instance.RemoveUpdateFunc();

        if (Input.GetMouseButtonDown(0))
        {
            PoolMgr.Instance.GetObj("Cube");
        }
        if(Input.GetMouseButtonDown(1))
        {
            PoolMgr.Instance.GetObj("Sphere");
        }
    }
}
