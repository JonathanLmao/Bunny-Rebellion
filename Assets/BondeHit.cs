using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BondeHit : MonoBehaviour
{
    //skapar en lista i inspectorn d�r jag kan l�gga in ljudfiler
    public List<AudioClip> soundtrack;
    //En variabel f�r ljudk�llan
    AudioSource mySource;
    public Text scoretext;
    private void OnCollisionEnter(Collision collision)
    {
        scoretext.text = ("Score: " + 1);
        new Vector3(0, -50, -20);
        mySource.clip = soundtrack[1];
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
