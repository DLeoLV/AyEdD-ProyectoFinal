using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PezDeteccion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pesca"))
        {
            Debug.Log("Iniciar Minijuego");
        }
    }
}
