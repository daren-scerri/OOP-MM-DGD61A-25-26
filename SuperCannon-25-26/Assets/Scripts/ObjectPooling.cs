using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ObjectPooling : MonoBehaviour
{
    public GameObject ObjectToPool;
    public int PoolSize;
    private List<GameObject> pooledObjects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;

        for(int i = 0; i < PoolSize; i++) 
        { 
            tmp=Instantiate(ObjectToPool);
            tmp.SetActive(false);
            tmp.transform.SetParent(this.transform);  //put the pooled objects as a child in hierarchy to the objectpool itself 
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < PoolSize; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

}
