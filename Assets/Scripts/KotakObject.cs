using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KotakObject : MonoBehaviour
{
    public GameObject Kotak;
    public float xMin, xMax, yMin, yMax;
    public static float prevx, prevy = 0;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
        StartCoroutine(SpawnKotak());
    }

    void Spawn()
    {
        int penghitungObjek = Random.Range(5, 10);
        for (int i = 0; i < penghitungObjek; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);

            if (prevx < 0 && randomX < 0)
            {
                randomX = Mathf.Abs(randomX);
                prevx = 0 - randomX;
                prevy = randomY;
            }
            if (prevy < 0 && randomY < 0)
            {
                randomY = Mathf.Abs(randomY);
                prevx = randomX;
                prevy = 0 - randomY;
            }
            if (prevy > 0 && randomY > 0)
            {
                randomY = 0 - randomY;
                prevx = randomX;
                prevy = Mathf.Abs(randomY);
            }
            if (prevx > 0 && randomX > 0)
            {
                randomX = 0 - randomX;
                prevx = Mathf.Abs(randomX);
                prevy = randomY;
            }
            Instantiate(Kotak, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }

    IEnumerator SpawnKotak()
    {
        while (true)
        {
            if (transform.childCount < 10)
            {
                float randomX = Random.Range(xMin, xMax);
                float randomY = Random.Range(yMin, yMax);

                Instantiate(Kotak, new Vector2(randomX, randomY), Quaternion.identity);

            }
            yield return new WaitForSeconds(3);
        }
    }
}
