using UnityEngine;

public class CorreccionMesaMezclas : MonoBehaviour
{
    public GameObject[] fader;  //hacemos un array con los distintos faders
    public int[] puntos;    //puntos de distintos faders y la ganancia
    public GameObject pantalla;
    public static bool tick = false;

    private void Update()
    {
        if (fader[0].transform.position.y == 616)   //si el fader 1 está a tope
        {
            puntos[0] = 1;  //que lo de como bien
        }
        else  //si no...
        {
            puntos[0] = 0;  //que lo cuente como mal
        }
        if (fader[1].transform.position.y == 616)   //lo mismo para el fader 2
        {
            puntos[1] = 1;
        }
        else
        {
            puntos[1] = 0;
        }
        if (fader[2].transform.position.y == 616)   //y el fader 3
        {
            puntos[2] = 1;
        }
        else
        {
            puntos[2] = 0;
        }

        if(Ganancia.puntosGanancia+puntos[0]+puntos[1]+puntos[2] == 4 & tick == true)   //si toda la puntuación suma 4 y se ha activado el tick...
        {
            Boton_BienMal.bien++;   //tarea bien hecha
            Personaje.Vel_Mov = 10; //le devuleve la velocidad al personaje
            pantalla.SetActive(false);  //y cierra la pantalla
        }
    }
}
