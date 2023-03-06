using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void BotonJugar() {
        CargaNivel.NivelCarga("Pantalla_Juego");
        //SceneManager.LoadScene("Pantalla_Juego"); //Para abrir la siguiente escena
    }
    public void BotonTutorial()
    {
        SceneManager.LoadScene("Tutorial"); //Para abrir el tutorial
    }
    public void BotonFinal()
    {
        SceneManager.LoadScene("Pantalla_Final"); //Para abrir la escena final
    }
    public void BotonMenuPrincipal()
    {
        SceneManager.LoadScene("Menú_Inicio"); //Para abrir el menu principal
    }
    public void BotonSalir() {
        Application.Quit(); //Para cerrar la aplicación (no emulable)
    }
}
