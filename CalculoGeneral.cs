using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculoGeneral : MonoBehaviour
{
    public static float suma;   //variable publica para saber la suma de grados de la antena
    public GameObject barra;    //obtenemos el componente GameObject de la barra que sube y baja
    float valor;
    public TextMeshProUGUI texto;   //el objeto para escribir los decibelios que está recibiendo la antena
    public static bool tick = false;    //variable para saber cuando se ha terminado la tarea
    public GameObject pantalla; //objeto para cerrar la pantalla una vez termina la tarea

    float map(float valor, float minA, float maxA, float minB, float maxB)  //mapeo de unidades
    {
        return minB + (valor - minA) * (maxB - minB) / (maxA - minA);
    }

    void Update()
    {
        texto.text = ((int)suma).ToString();    //escribimos la variable suma en el texto (la convertimos a string)
        suma = MovLNB.valor + MovParabolica.valor;  //aplicamos la suma
        valor = map(suma, 0, 90, 69, 145);  //aplicamos el mapeo
        barra.transform.localPosition = new Vector3(0, valor, 0);   //le decimos que el valor es el angulo de grados
        if (tick == true)   //si se ha terminado la tarea
        {
            Boton_BienMal.bien++;   //que se sume 1 punto
            Personaje.Vel_Mov = 10; //que se pueda volver a mover el personaje
            pantalla.SetActive(false);  //y que desactive la pantalla de la tarea
        }
    }
}
