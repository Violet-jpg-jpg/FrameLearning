using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolMgr : BaseManager<PoolMgr>
{
    Dictionary<string, List<GameObject>> poolDic = new Dictionary<string, List<GameObject>>();

    public GameObject GetObj(string name)
    {
        GameObject obj;
        //存在抽屉并且抽屉不为空
        if (poolDic.ContainsKey(name) && poolDic[name].Count > 0)
        {
            int lastIndex = poolDic[name].Count - 1;
            obj = poolDic[name][lastIndex];
            obj.SetActive(true);
            poolDic[name].RemoveAt(lastIndex);
        }
        else
        {
            obj = GameObject.Instantiate(Resources.Load<GameObject>(name));
        }
        return obj;
    }

    public void Push(string name, GameObject obj)
    {
        if (!poolDic.ContainsKey(name))
            poolDic.Add(name, new List<GameObject>());

        poolDic[name].Add(obj);
        obj.SetActive(false);
    }
    
    public void ClearPool()
    {
        poolDic.Clear();
    }
}
