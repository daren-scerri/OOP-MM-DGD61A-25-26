using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject mycirclePrefab;
    private float xmin,ymin,xmax,ymax;
    public float padding=0.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xmin= Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x;
        ymin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).y;
        xmax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x;
        ymax = Camera.main.ViewportToWorldPoint(new Vector3(0,1,0)).y;

        Instantiate(mycirclePrefab, new Vector3(xmin + padding,ymin +padding,0), Quaternion.identity);
        Instantiate(mycirclePrefab, new Vector3(xmin + padding, ymax-padding, 0), Quaternion.identity);
        Instantiate(mycirclePrefab, new Vector3(xmax - padding, ymin +padding, 0), Quaternion.identity);
        Instantiate(mycirclePrefab, new Vector3(xmax - padding, ymax -padding, 0), Quaternion.identity);

    }

    
}
