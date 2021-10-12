using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KotakObject : MonoBehaviour
{
    public GameObject Kotak;
    public float xMin, xMax, yMin, yMax;
    
    void Start()
    {
        // memanggil methode Spawn()
        Spawn();
    }

    void Spawn()
    {
        int penghitungObjek = Random.Range(5, 10);
        for (int i = 0; i < penghitungObjek; i++)
        {
            float randomX = Random.Range(xMin, xMax);
            float randomY = Random.Range(yMin, yMax);
            Instantiate(Kotak, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }
}
