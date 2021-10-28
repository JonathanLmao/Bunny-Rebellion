using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skott : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody2D rb;
    CameraShake cs;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //N�r skottet skapas s� b�rjar den direkt �ka med konstant hastighet i en viss riktning -William
        rb.velocity = transform.up * speed;
    }
    //F�rst�r b�de sig sj�lv och objektet den tr�ffar ifall den tr�ffar en bonde -William
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bonde"))
        {
            Destroy(collision.gameObject);
            if (gameObject.CompareTag("SalladSkott"))
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 5f);
                foreach  (Collider2D nearbyObject in colliders)
                {
                    if (nearbyObject.CompareTag("Bonde"))
                    {
                        Destroy(nearbyObject.gameObject);
                    }
                }
                cs.shake(1.5f,new Vector2(3,5),new Vector2(2, 5));
            }
            Destroy(gameObject);
        }
    }
}
