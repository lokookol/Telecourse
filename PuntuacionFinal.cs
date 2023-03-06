using UnityEngine;
using TMPro;

public class PuntuacionFinal : MonoBehaviour
{
    public TextMeshProUGUI Bien1;
    public TextMeshProUGUI Bien2;
    public TextMeshProUGUI Bien3;
    public TextMeshProUGUI Tiempo;
    public TextMeshProUGUI NotaFinal;

    float suma;
    float nota;
    public static float notaFinalPublica; 

    float map(float valor, float minA, float maxA, float minB, float maxB)
    {
        return minB + (valor - minA) * (maxB - minB) / (maxA - minA);
    }
    void Start()
    {
        Bien1.text = Tareas_Completadas.puntuacionP1.ToString();    //convertimos la puntuación a string para poder escribirla
        Bien2.text = Tareas_Completadas.puntuacionP2.ToString();
        Bien3.text = Tareas_Completadas.puntuacionP3.ToString();
        Tiempo.text = temporizador.minutos.ToString("00") + ":" + temporizador.segundos.ToString("00");
        suma = (Tareas_Completadas.puntuacionP1 + Tareas_Completadas.puntuacionP2 + Tareas_Completadas.puntuacionP3);
        if (temporizador.tiempoEnSegundos <= 180)   //si has tardado menos de 3 minutos en terminar el juego...
        {
            nota = 1;   //tienes un punto entero de tiempo
            notaFinalPublica = suma + nota;

        }
        else if(temporizador.tiempoEnSegundos >= 300)   //si tardas más de 5 minutos
        {
            nota = 0;   //tienes un 0 en nota de tiempo
            notaFinalPublica = suma + nota;
        }
        else  //y si estás entre medias
        {
            nota = Mathf.Round(map(temporizador.tiempoEnSegundos, 180, 300, 0.99f, 0.01f) * 100f) / 100f;   //se hace un mapeo
            notaFinalPublica = suma + nota;
            
        }
        NotaFinal.text = (notaFinalPublica).ToString();
    }
}
