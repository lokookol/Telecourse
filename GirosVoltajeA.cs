using UnityEngine;
using UnityEngine.EventSystems;

public class GirosVoltajeA : MonoBehaviour, IPointerClickHandler
{
    public static int PuntosVoltajeA;   //variable publica para facilitar la corrección
    public void OnPointerClick(PointerEventData eventData)  //cada vez que hagas click en el objeto...
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)    //si la rotación está entre los límites...
        {
            transform.Rotate(0, 0, 315);    //que gire 45 grados
            PuntosVoltajeA++;   //y vaya sumando 1 punto a la puntuación (vá de 0 a 6)
        }
        else  //si te pasas de rosca
        {
            transform.Rotate(0, 0, 270);    //que gire 90 grados
            PuntosVoltajeA = 0; //y vuelva la puntuación a 0
        }
    }
}
