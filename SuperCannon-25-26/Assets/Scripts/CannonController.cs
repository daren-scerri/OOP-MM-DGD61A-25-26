using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class CannonController : MonoBehaviour
{
    Quaternion clampRotationLow, clampRotationHigh;
    public Transform cannonTipTransform;
    public GameObject cannonBallPrefab, smallBulletPrefab;

    Coroutine firingCoroutine1, firingCoroutine2;

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

        if (Input.GetMouseButtonDown(0))
        {
            firingCoroutine1 = StartCoroutine(FireContinuously(cannonBallPrefab));
        }

        if (Input.GetMouseButtonDown(1))
        {
            firingCoroutine2 = StartCoroutine(FireContinuously(smallBulletPrefab));
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (firingCoroutine1 != null) StopCoroutine(firingCoroutine1);
            firingCoroutine1 = null;
        }

        if (Input.GetMouseButtonUp(1))
        {
            if (firingCoroutine2 != null) StopCoroutine(firingCoroutine2);
            firingCoroutine2 = null;
        }
    }

        IEnumerator FireContinuously(GameObject bulletPrefab)
    {
        GameObject mybullet;
        float _firingRate;
        while (true)
        {
            mybullet = Instantiate(bulletPrefab, cannonTipTransform.position, Quaternion.identity);
            _firingRate = mybullet.GetComponent<DefaultBullet>().firingRate;
            mybullet.GetComponent<DefaultBullet>().Shoot(cannonTipTransform.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(_firingRate);
        }
        
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
