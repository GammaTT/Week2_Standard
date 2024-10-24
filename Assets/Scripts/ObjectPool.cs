using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        pool = new List<GameObject>(poolSize);

        for(int i = 0; i < poolSize; i++)
        {
            GameObject go = Instantiate(prefab);
            go.gameObject.SetActive(false);
            pool.Add(go);
        }
    }

    public GameObject Get()
    {
        foreach (var obj in pool)
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        return null;
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
    }

    public void Release(GameObject obj)
    {
        obj?.SetActive(false);
        // 게임오브젝트를 deactive한다.
    }
}