using UnityEngine;
using UnityEngine.EventSystems;

public class MovLNB : MonoBehaviour, IDragHandler, IEndDragHandler
{
    float posicionAnterior; //variable para saber si el raton sube o baja
    public static float valor;

    float map(float valor, float minA, float maxA, float minB, float maxB)  //funcion de mapeo
    {
        return minB + (valor - minA) * (maxB - minB) / (maxA - minA);
    }

    private void Update()
    {
        posicionAnterior = Input.mousePosition.y;   //guardamos la posición del ratón
        if (transform.localEulerAngles.z <= 360 & transform.localEulerAngles.z >= 270)  //si el giro llega a la mitad positiva...
        {
            valor = map(transform.localEulerAngles.z, 360, 270, 0, 45); //que la barra del LNB suba con un mapeo
        }
        else if (transform.localEulerAngles.z <= 270 & transform.localEulerAngles.z >= 180) //si el giro llega a la mitad negativa...
        {
            valor = map(transform.localEulerAngles.z, 270, 180, 45, 0); //que la barra del LNB baje con un mapeo
        }
    }
    public void OnDrag(PointerEventData eventData)  //funcion que se activa cuando se arrastra el raton haciendo click
    {
        if (posicionAnterior > Input.mousePosition.y)   //si la posicion del raton baja...
        {
            transform.Rotate(0, 0, -1); //se aplica una rotación negativa al LNB
        }
        else if (posicionAnterior < Input.mousePosition.y)  //si la posicion del raton sube...
        {
            transform.Rotate(0, 0, 1);  //se aplica una rotación positiva al LNB
        }

    }
    public void OnEndDrag(PointerEventData eventData)   //funcion que se activa cuando se suelta el ratón
    {
        if (CalculoGeneral.suma >= 47 & CalculoGeneral.suma <= 77)  //si la suma de dB está entre 47 y 77...
        {
            CalculoGeneral.tick = true; //que se de como completada la tarea
        }
    }
}

