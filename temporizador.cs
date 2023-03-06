using UnityEngine;
using TMPro;    //añadir libreria para el texto

public class temporizador : MonoBehaviour
{
    public TextMeshProUGUI texto;   //variable publica para asociar el texto
    public float cronometro = 0.0f;  //variable tipo float (porque el tiempo es float)
    public static double segundos;
    public static float minutos;
    public static string tiempo;
    public static float tiempoEnSegundos;

    void Update()
    {
        cronometro += Time.deltaTime;   //que se le vaya sumando el tiempo entre frame y frame
        //(time.deltaTime es el tiempo que transcurre entre frame y frame
        //por ejemplo sirve para que en todos los ordenadores vaya el tiempo sincronizado
        //sin tener en cuenta las caracteristicas del ordenador)
        segundos = Mathf.FloorToInt(cronometro);    //convertimos cronometro a int
        if (segundos >= 60) //y si llega o se pasa de 60 segundos
        {
            minutos++;  //que se añada un minuto
            cronometro = 0; //y que los segundos del cronometro vuelva a 0
        }
        texto.text = minutos.ToString("00") + ":" + segundos.ToString("00");
        tiempo = minutos.ToString("00") + ":" + segundos.ToString("00");
        tiempoEnSegundos = (minutos * 60) + (float)segundos;
        //que el texto sea formato "00:00" y que sea una string
    }
}
