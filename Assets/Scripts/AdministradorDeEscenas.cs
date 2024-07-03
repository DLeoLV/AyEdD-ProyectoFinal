using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradorDeEscenas : MonoBehaviour
{
    public void CargarJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    public void CargarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void CargarAyuda()
    {
        SceneManager.LoadScene("Ayuda");
    }
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
//Las funciones se ejecutan una vez y solo cuando el usuario las llama, por ende es O(1) 