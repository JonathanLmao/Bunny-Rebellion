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
        cs = FindObjectOfType<CameraShake>();
        rb = GetComponent<Rigidbody2D>();
        //När skottet skapas så börjar den direkt åka med konstant hastighet i en viss riktning -William
        rb.velocity = transform.up * speed;
    }
    //Förstör både sig själv och objektet den träffar ifall den träffar en bonde -William
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bonde"))
        {
            Destroy(collision.gameObject);
            //Förstör även närliggande bönder ifall man träffar med ett salladskott -William
            if (gameObject.CompareTag("SalladSkott"))
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 5f);
                foreach (Collider2D nearbyObject in colliders)
                {
                    if (nearbyObject.CompareTag("Bonde"))
                    {
                        Destroy(nearbyObject.gameObject);
                    }
                }
                cs.shake(0.3f, new Vector2(25, 30), new Vector2(0.3f, 0.3f));
            }
            else if (gameObject.CompareTag("MorotSkott")) 
            {
                cs.shake(0.1f, new Vector2(20, 20), new Vector2(0.25f, 0.25f));
            }
            Destroy(gameObject);
        }
    }
}
