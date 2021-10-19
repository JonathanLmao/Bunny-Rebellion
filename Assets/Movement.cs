using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   [SerializeField]
    int maxDistance;
    [SerializeField]
    int maxSpeed;
    private Rigidbody2D rbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && rbody2D.position.x <= maxDistance)
        {
            rbody2D.AddForce(new Vector2(5, 0));
        }
        if (Input.GetKeyDown(KeyCode.A) && rbody2D.position.x >= maxDistance)
        {
            rbody2D.AddForce(new Vector2(-50, 0));
        }
    }
}
