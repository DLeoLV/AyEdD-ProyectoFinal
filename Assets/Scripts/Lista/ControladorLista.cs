using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorLista : MonoBehaviour
{
    public GameObject panel;
    public ListaSimple lista;
    public int posicion = 0;
    public int posicionTexto = 1;
    public Image imagen;
    public GameObject posicionObjeto;
    public TMP_Text texto;
    public Sprite Nada;
    public Sprite Pez1;
    public Sprite Pez2;
    public Sprite Pez3;
    public Sprite Pez4;
    public Sprite Pez5;
    public Sprite Pez6;
    public Sprite Pez7;
    public Sprite Pez8;
    public Sprite Pez9;
    public MonoBehaviour MovimientoFlechas;
    public MonoBehaviour LanzamientoDeCaña;
    public AlgoritmoOrdenador llamarAlgoritmo;

    void Start()
    {
        lista = FindObjectOfType<ListaSimple>();
        imagen = posicionObjeto.GetComponent<Image>();
    }

    public void ActualizarImagen()
    {
        if(lista.ListInt.GetNodeAtPosition(posicion) == 0)
        {
            imagen.sprite = Nada;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 1)
        {
            imagen.sprite = Pez1;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 2)
        {
            imagen.sprite = Pez2;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 3)
        {
            imagen.sprite = Pez3;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 4)
        {
            imagen.sprite = Pez4;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 5)
        {
            imagen.sprite = Pez5;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 6)
        {
            imagen.sprite = Pez6;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 7)
        {
            imagen.sprite = Pez7;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 8)
        {
            imagen.sprite = Pez8;
        }
        if (lista.ListInt.GetNodeAtPosition(posicion) == 9)
        {
            imagen.sprite = Pez9;
        }
    }

    public void ActualizarTexto()
    {
        texto.text = posicionTexto + " de " + lista.ListInt.GetLength();
    }

    public void MoverIzquierda()
    {
        if(posicion != 0)
        {
            posicion = posicion - 1;
            posicionTexto = posicion + 1;
            ActualizarImagen();
            ActualizarTexto();
        }
        
    }
    public void MoverDerecha()
    {
        if (posicion < lista.ListInt.GetLength() - 1)
        {
            posicion = posicion + 1;
            posicionTexto = posicion + 1;
            ActualizarImagen();
            ActualizarTexto();
        }
    }
    public void AbrirPanel()
    {
        panel.SetActive(true);
        AlgoritmoOrdenador.OrdenarListaSimple(lista.ListInt);
        ActualizarImagen();
        ActualizarTexto();
        MovimientoFlechas.enabled = false;
        LanzamientoDeCaña.enabled = false;
    }
    public void CerrarPanel()
    {
        posicion = 0;
        posicionTexto = posicion + 1;
        panel.SetActive(false);
        MovimientoFlechas.enabled = true;
        LanzamientoDeCaña.enabled = true;
    }
}
