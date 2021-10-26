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
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tid.x += Time.deltaTime;
        tid.y += Time.deltaTime;
        
    }
}
