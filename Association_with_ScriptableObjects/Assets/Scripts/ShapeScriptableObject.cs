using UnityEngine;

[CreateAssetMenu(fileName = "ShapeData", menuName = "Scriptable Objects/ShapeData")]
public class ShapeScriptableObject : ScriptableObject
{
    public GameObject shapePrefab;
    public float startXPos;
    public float startYPos;
    public float velocity;
    public KeyCode forcekey;
}
