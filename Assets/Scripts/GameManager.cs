using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    [SerializeField] ObjectPool arrowPool;
    [SerializeField] ObjectPool monsterPool;

    private Dictionary<string, ObjectPool> ObjectPools = new Dictionary<string, ObjectPool>();
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
        set
        {
            instance = value;
        }
    }

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ObjectPools["Arrow"] = arrowPool;
        ObjectPools["Monster"] = monsterPool;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
