using UnityEngine;

public class BallDrag : MonoBehaviour
{
    Vector3 mousePos, mousePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnMouseDrag()
    {
        //rend.material.color -= Color.white * Time.deltaTime;
        mousePos = Input.mousePosition;
        mousePoint = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0f) + new Vector3(0f, 0f, 10f));
        this.gameObject.transform.position = mousePoint;
    }
}
