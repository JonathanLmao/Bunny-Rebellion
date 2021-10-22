using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondeSpawner : MonoBehaviour
{
    public GameObject bondePrefab;
    public Transform borderTop;
    public Transform borderBot;
    public Transform borderLeft;
    public Transform borderRight;
    public bool spawning;
    IEnumerator CreateBonde() //Kallar på SpawnBonde funktionen varje 1,5 sekunder -William
    {
        while (true)
        {
            SpawnBonde();
            yield return new WaitForSeconds(1.5f);
        }
    }
    // Start is called before the first frame update
    //Ändrar alla väggarna så att de passar kamerans höjd och bredd -William
    void Start()
    {
        Vector3 wrld = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, 0.0f));
        borderLeft.position = new Vector2(-wrld.x, 5.75f);
        borderRight.position = new Vector2(wrld.x, 5.75f);
        borderBot.position = new Vector2(0, 8);
        borderTop.position = new Vector2(0, 11);
        borderLeft.localScale = new Vector2(0.1f, Screen.height);
        borderRight.localScale = new Vector2(0.1f, Screen.height);
        borderBot.localScale = new Vector2(Screen.width, 0.1f);
        borderTop.localScale = new Vector2(Screen.width, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !spawning)
        {
            StartCoroutine(CreateBonde());
            spawning = true;
        }
    }
    void SpawnBonde() //Skapar en bonde slumpmässigt emellan de fyra väggarna -William
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBot.position.y, borderTop.position.y);
        Instantiate(bondePrefab, new Vector2(x, y), Quaternion.identity);
    }
}
