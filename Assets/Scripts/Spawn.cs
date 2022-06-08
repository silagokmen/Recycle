using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
   
    public GameObject[] dönüşümObjeleri;
    private float starDelay = 0;
    

    void Start()
    {
        InvokeRepeating("GeriDönüşümObjeleri", starDelay, Random.Range(2, 4));
        //InvokeRepeating("GeriDönüşümObjeleri", starDelay,Random.Range(1,3));
     
    }

    void GeriDönüşümObjeleri()
    {
        int dönüşümIndex = Random.Range(0, dönüşümObjeleri.Length);
        Instantiate(dönüşümObjeleri[dönüşümIndex], new Vector3(21.5f, 16f, -36.9f), dönüşümObjeleri[dönüşümIndex].transform.rotation);

    }
}
