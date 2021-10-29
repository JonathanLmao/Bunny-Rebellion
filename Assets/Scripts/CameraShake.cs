using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Vector2 amplitude;
    public Vector2 frequency;
    public Vector2 tid = Vector2.zero;
    static bool shouldShake;
    static float shakeTime;
    // Update is called once per frame
    //Skakar kameran -William
    void Update()
    {
        tid.x += Time.deltaTime * frequency.x;
        tid.y += Time.deltaTime * frequency.y;
        shakeTime -= Time.deltaTime;
        if (shakeTime > 0)
        {
            shouldShake = true;
        }
        else
        {
            shouldShake = false;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (shouldShake)
        {
            Vector3 shakePos = transform.localPosition;
            shakePos.x = Mathf.Sin(tid.x) * amplitude.x;
            shakePos.y = Mathf.Sin(tid.y) * amplitude.y;
            transform.localPosition = shakePos;
        }
    }
    public void shake(float sekunder, Vector2 frekvens, Vector2 amp)
    {
        shakeTime = sekunder;
        frequency = frekvens;
        amplitude = amp;
    }
}
