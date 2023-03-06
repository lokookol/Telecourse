using UnityEngine;
using UnityEngine.EventSystems;

public class GirosVoltajeA : MonoBehaviour, IPointerClickHandler
{
    public static int PuntosVoltajeA;   //variable publica para facilitar la correcci�n
    public void OnPointerClick(PointerEventData eventData)  //cada vez que hagas click en el objeto...
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)    //si la rotaci�n est� entre los l�mites...
        {
            transform.Rotate(0, 0, 315);    //que gire 45 grados
            PuntosVoltajeA++;   //y vaya sumando 1 punto a la puntuaci�n (v� de 0 a 6)
        }
        else  //si te pasas de rosca
        {
            transform.Rotate(0, 0, 270);    //que gire 90 grados
            PuntosVoltajeA = 0; //y vuelva la puntuaci�n a 0
        }
    }
}
