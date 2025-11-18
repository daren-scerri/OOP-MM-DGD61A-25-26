using UnityEngine;

public class CannonController : MonoBehaviour
{
    Quaternion clampRotationLow, clampRotationHigh;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      clampRotationLow = Quaternion.Euler(0, 0, -70f);
      clampRotationHigh = Quaternion.Euler(0, 0, +70f);
    }

    // Update is called once per frame
    void Update()
    {

        PointAtMouse();
    }

    private void PointAtMouse()
    {
        Vector3 _mousePos = GameData.MousePos;
        Vector3 relativePos = this.transform.position - GameData.MousePos;
        Quaternion newrotation = Quaternion.LookRotation(relativePos, Vector3.forward);
        newrotation.x = 0;
        newrotation.y = 0;
        newrotation.z = Mathf.Clamp(newrotation.z,clampRotationLow.z,clampRotationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w,clampRotationLow.w,clampRotationHigh.w);
        Debug.Log(newrotation);
        // this.transform.rotation = newrotation;   //NO SLERP
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3f);
    }


}
