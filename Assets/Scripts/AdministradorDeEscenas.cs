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
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
