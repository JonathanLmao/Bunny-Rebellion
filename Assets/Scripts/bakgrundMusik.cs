using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakgrundMusik : MonoBehaviour
{
    public List<AudioClip> soundtrack;
    AudioSource mySource;
    private void Awake()
    {
        //en referens till ljudkällan och vart den ska ta ljudfilen från.
        mySource = gameObject.GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Ifall en låt ska spelas så väljer den låten i listan.
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
