using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValorDePez : MonoBehaviour
{
    public ListaSimple lista;
    public string MiRareza;
    public int IDpez;

    void Start()
    {
        lista = FindObjectOfType<ListaSimple>();

        float randomVal = Random.Range(0f, 100f);
        if (randomVal < 75f)
        {
            MiRareza = "Comun";
            Debug.Log("Comun");
        }
        else if (75f < randomVal && randomVal < 95f)
        {
            MiRareza = "Raro";
            Debug.Log("Raro");
        }
        else if (95f < randomVal)
        {
            MiRareza = "Muy Raro";
            Debug.Log("Muy Raro");
        }
        AgregarID();
    }
    void AgregarID()
    {
        if(MiRareza == "Comun")
        {
            IDpez = Random.Range(1, 4);
        }
        if (MiRareza == "Raro")
        {
            IDpez = Random.Range(4, 7);
        }
        if (MiRareza == "Muy Raro")
        {
            IDpez = Random.Range(7, 10);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Caña")
        {
            Debug.Log("Mi rareza es: " + MiRareza);
            Debug.Log("Mi ID es: " + IDpez);
            lista.ListInt.InsertAtStart(IDpez);
            lista.ListInt.MostrarValores();

            Destroy(this.gameObject);
        }
    }
}
