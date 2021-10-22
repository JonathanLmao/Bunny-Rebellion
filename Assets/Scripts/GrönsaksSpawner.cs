using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrönsaksSpawner : MonoBehaviour
{
    public GameObject morotPrefab;
    public GameObject salladPrefab;
    Transform tf;
    //Spawnar en morot 5 sekunder efter funktionen blir kallad på vid objektets position -William
    IEnumerator CreateMorot()
    {
        yield return new WaitForSeconds(5);
        Instantiate(morotPrefab, tf.position, Quaternion.identity);
    }
    //Spawnar en sallad 15 sekunder efter funktionen blir kallad på vid objektets position -William
    IEnumerator CreateSallad()
    {
        yield return new WaitForSeconds(10);
        Instantiate(salladPrefab, tf.position, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        //Spawnar den grönsak som objektet ska spawna så att det finns en grönsak från början av spelet -William
        if (gameObject.CompareTag("MorotSpawner"))
        {
            Instantiate(morotPrefab, tf.position, Quaternion.identity);
        }
        else if (gameObject.CompareTag("SalladSpawner"))
        {
            Instantiate(salladPrefab, tf.position, Quaternion.identity);
        }
    }
    //När grönsaken despawnar kallar den på coroutine-funktionen för samma sorts grönsak som despawnade -William
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Morot"))
        {
            StartCoroutine(CreateMorot());
        }
        else if (collision.gameObject.CompareTag("Sallad"))
        {
            StartCoroutine(CreateSallad());
        }
    }
}
