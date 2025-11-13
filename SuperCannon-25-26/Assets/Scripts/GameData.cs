using UnityEngine;

public abstract class GameData : MonoBehaviour
{

    public static Vector3 MousePos
    {
        get { return GetMousePos(); }
        
    }    

    static Vector3 GetMousePos()
    {
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 10f);
        return _mousePos;
    }
    
}
