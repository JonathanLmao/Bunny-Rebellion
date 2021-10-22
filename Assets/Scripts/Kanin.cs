using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Förstör objeket ifall det är en morot eller sallad -William
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Morot") || collision.gameObject.CompareTag("Sallad"))
        {
            Destroy(collision.gameObject);
        }
    }
}
