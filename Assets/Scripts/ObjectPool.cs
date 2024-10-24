using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        // �̸� poolSize��ŭ ���ӿ�����Ʈ�� �����Ѵ�.
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
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
    }

    public void Release(GameObject obj)
    {
        obj?.SetActive(false);
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
    }
}