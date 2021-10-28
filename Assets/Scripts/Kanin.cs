using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanin : MonoBehaviour
{
    public GameObject morotSkottPrefab;
    public GameObject salladSkottPrefab;
    public Transform firePoint;
    // Update is called once per frame
    void Update()
    {
        //Ifall du klickar på musknapp 1 och du har nog med ammo så skapas ett morotskott vid firepointen -William
        if (Input.GetKeyDown(KeyCode.Mouse0)) //&& morotAmmo >= 1)
        {
            Instantiate(morotSkottPrefab, firePoint.position, firePoint.rotation);
            //salladAmmo--;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1)) //&& salladAmmo >= 1)
        {
            Instantiate(salladSkottPrefab, firePoint.position, firePoint.rotation);
            //salladAmmoo--;
        }
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
