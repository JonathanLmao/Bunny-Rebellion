using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //inte klar
   [SerializeField]
   int maxDistance;
   private Rigidbody2D rbody2D;
   void Start()
   {
        rbody2D = GetComponent<Rigidbody2D>();
   }

   void Update()
   {
       if (Input.GetKey(KeyCode.D) && rbody2D.position.x <= maxDistance)
       {
            rbody2D.AddForce(new Vector2(50, 0));
       }
       if (Input.GetKey(KeyCode.A) && rbody2D.position.x >= -maxDistance)
       {
            rbody2D.AddForce(new Vector2(-50, 0));
       }
   }
}

