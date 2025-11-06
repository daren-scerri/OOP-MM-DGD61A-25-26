using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ShapeSpawner : MonoBehaviour
{
    public List<ShapeScriptableObject> shapesList;

    private List<GameObject> spawnedShapes = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnShapes();
    }

   void SpawnShapes()
    {
        foreach (var shape in shapesList) 
        {
            GameObject spawned = Instantiate(shape.shapePrefab, new Vector3(shape.startXPos, shape.startYPos, 0f), Quaternion.identity);
            
            spawnedShapes.Add(spawned);
        }
    }
}
