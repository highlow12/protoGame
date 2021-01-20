using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolManager : MonoBehaviour
{
    public static poolManager Instance;



    [SerializeField]

    private GameObject poolingObjectPrefab;



    Queue<man> poolingObjectQueue = new Queue<man>();



    private void Awake()

    {

        Instance = this;



        Initialize(10);

    }



    private void Initialize(int initCount)

    {

        for (int i = 0; i < initCount; i++)

        {

            poolingObjectQueue.Enqueue(CreateNewObject());

        }

    }



    private man CreateNewObject()

    {

        var newObj = Instantiate(poolingObjectPrefab).GetComponent<man>();

        newObj.gameObject.SetActive(false);

        newObj.transform.SetParent(transform);

        return newObj;

    }



    public static man GetObject()

    {

        if (Instance.poolingObjectQueue.Count > 0)

        {

            var obj = Instance.poolingObjectQueue.Dequeue();

            obj.transform.SetParent(null);

            obj.gameObject.SetActive(true);

            return obj;

        }

        else

        {

            var newObj = Instance.CreateNewObject();

            newObj.gameObject.SetActive(true);

            newObj.transform.SetParent(null);

            return newObj;

        }

    }



    public static void ReturnObject(man obj)

    {

        obj.gameObject.SetActive(false);

        obj.transform.SetParent(Instance.transform);

        Instance.poolingObjectQueue.Enqueue(obj);

    }



    
}
