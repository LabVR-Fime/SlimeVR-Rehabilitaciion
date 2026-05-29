using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Botones : MonoBehaviour
{
    public GameObject UIPrincipal;
    public GameObject UISeleccion;

    // Aquí comienzan funciones hechas para funcionar como BOTONES DE CANVAS - - - - - - - - - - - - - - - - - -
    public void Start()
    {
        UIPrincipal.SetActive(true);
        UISeleccion.SetActive(false);
    }

    public void IniciarJuego()
    {
        UIPrincipal.SetActive(false);
        UISeleccion.SetActive(true);
    }

    public void QuitarJuego()
    {
        Application.Quit();
    }


    // Selecci�n de ejercicios
    public void Regresar()
    {
        UIPrincipal.SetActive(true);
        UISeleccion.SetActive(false);
    }


    // Aquí comienzan funciones hechas para funcionar como BOTONES DE ESCENA- - - - - - - - - - - - - - - - - -

    public void CargarRodilla1()
    {
        SceneManager.LoadScene("EjerciciosRodillas");
    }
    public void CargarHombros1()
    {
        SceneManager.LoadScene("EjerciciosHombros");
    }

}
