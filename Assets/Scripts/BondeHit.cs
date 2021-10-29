using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BondeHit : MonoBehaviour
{
    //skapar en lista i inspectorn där jag kan lägga in ljudfiler
    public List<AudioClip> soundtrack;
    //En variabel för ljudkällan
    AudioSource mySource;
    //En variabel som låter oss göra text i canvasen till poängvärdet
    public Text scoretext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MorotSkott") || collision.gameObject.CompareTag("SalladSkott"));
        {
            scoretext.text = ("Score: " + 1);
            new Vector3(0, -50, -20);
            mySource.clip = soundtrack[1];
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
