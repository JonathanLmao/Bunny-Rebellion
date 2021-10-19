using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakgrundMusik : MonoBehaviour
{
    public List<AudioClip> soundtrack;
    AudioSource mySource;
    private void Awake()
    {
        //en referens till ljudk�llan och vart den ska ta ljudfilen fr�n.
        mySource = gameObject.GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Ifall en l�t ska spelas s� v�ljer den l�ten i listan.
        if (!mySource.playOnAwake)
        {
            mySource.clip = soundtrack[1];
            mySource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
