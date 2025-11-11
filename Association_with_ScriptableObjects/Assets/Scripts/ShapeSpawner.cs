using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ShapeSpawner : MonoBehaviour
{
    //public List<ShapeScriptableObject> shapesList;

    //private List<GameObject> spawnedShapes = new List<GameObject>();

    public ShapeScriptableObject circleObject;
    public ShapeScriptableObject squareObject;

    GameObject my_circle, my_square;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnShapes();
    }

   void SpawnShapes()
    {
        if (circleObject != null)
        {
            my_circle = Instantiate(circleObject.shapePrefab, new Vector3(circleObject.startXPos, circleObject.startYPos, 0f), Quaternion.identity);
            my_circle.GetComponent<ShapeMovement>().my_keycode = circleObject.forcekey;
        }

        if (squareObject != null)
        {
            my_square = Instantiate(squareObject.shapePrefab, new Vector3(squareObject.startXPos, squareObject.startYPos, 0f), Quaternion.identity);
            my_square.GetComponent<ShapeMovement>().my_keycode = squareObject.forcekey;
        }

    }
}
