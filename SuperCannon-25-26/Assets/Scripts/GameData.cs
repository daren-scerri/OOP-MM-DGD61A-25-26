using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    public static int Score;
    public static int PlayerHealth;

    public static float XMin { 
        get
        {
            return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        }
     }

    public static float YMin
    {
        get
        {
            return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        }
    }

    public static float XMax
    {
        get
        {
            return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        }
    }

    public static float YMax
    {
        get
        {
            return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        }
    }

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
