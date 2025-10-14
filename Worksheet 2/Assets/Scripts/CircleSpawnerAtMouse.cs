using System.Drawing;
using UnityEngine;

public class CircleSpawnerAtMouse : MonoBehaviour
{
    public GameObject BallPrefab;
    Vector3 mousePos, mousePoint;
    int ballcount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
              
        if (Input.GetMouseButtonDown(0) && ballcount<5)
        {
            mousePos = Input.mousePosition;
            mousePoint = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0f) + new Vector3(0f,0f, 10f));
            Instantiate(BallPrefab, mousePoint, Quaternion.identity);
            ballcount++;
            Debug.Log(mousePos + " >>>> " + mousePoint);
        }

    }
}
