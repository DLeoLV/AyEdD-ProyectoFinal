using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPeces : MonoBehaviour
{
    public GameObject Pez;
    void Start()
    {
        InvokeRepeating("GenerarPez", 0f, 7.5f);
    }

    void GenerarPez()
    {
        Instantiate(Pez, transform.position, Quaternion.identity);
    }
}
