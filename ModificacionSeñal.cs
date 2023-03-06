using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ModificacionSeñal : MonoBehaviour
{
    //obtenemos todas las puntuaciones de todos los objetos
    public static int canal;
    float A1 = GirosVoltajeA.PuntosVoltajeA;
    float A2 = GVAR.PVA;
    float A3 = GiroTiempo.PuntosTiempo;
    float A4 = GTR.PTR;
    float A5 = GP.PP;

    //creamos variables para el mapeo
    float B1;
    float B2;
    float B3;
    float B4;
    float B5;

    public GameObject pantalla;


    float map(float valor, float minA, float maxA, float minB, float maxB)  //funcion de mapeo
    {
        return minB + (valor - minA) * (maxB - minB) / (maxA - minA);
    }

    private void Update()
    {
        if (canal != 1) //si no se activa el canal A
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);   //se oculta la señal
        }
        else  //si se escoge el canal A
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);    //que se muestre en pantalla la señal
        }

        B1 = map(GirosVoltajeA.PuntosVoltajeA, 0, 6, 0.1f, 2.5f);   //aplicamos el mapeo a las ruletas de voltaje A
        B2 = map(GVAR.PVA, 0, 6, 0, 0.6f);
        transform.localScale = new Vector3(transform.localScale.x,B1+B2, transform.localScale.z);   //y aplicamos una escala en el eje Y de la señal

        B3 = map(GiroTiempo.PuntosTiempo, 0, 6, 0.1f, 1.1f);    //aplicamos el mapeo a la ruleta del tiempo
        B4 = map(GTR.PTR, 0, 6, 0, 1.2f);
        transform.localScale = new Vector3(B3 + B4, transform.localScale.y, transform.localScale.z);    //y aplicamos una escala en el eje X de la señal

        B5 = map(GP.PP, 0, 6, 0, -288); //aplicamos el mapeo a la ruleta de la posición
        transform.localPosition = new Vector3(B5, transform.localPosition.y, transform.localPosition.z);    //y aplicamos un desplazamiento horizontal a la señal

        if (transform.localScale.y == 1     //si todo está bien cuadrado
            &transform.localScale.x == 1
            & transform.localPosition.x == -144
            & canal == 1
            )
        {
            Boton_BienMal.bien++;   //que sume 1 punto
            Personaje.Vel_Mov = 10; //que devuelva la velocidad al personaje
            pantalla.SetActive(false); //y se cierre la pantalla
        }
    }
}
