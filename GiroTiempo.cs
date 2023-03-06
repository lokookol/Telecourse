using UnityEngine;
using UnityEngine.EventSystems;

public class GiroTiempo : MonoBehaviour, IPointerClickHandler
{
    public static int PuntosTiempo;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)
        {
            transform.Rotate(0, 0, 315);
            PuntosTiempo++;
        }
        else
        {
            transform.Rotate(0, 0, 270);
            PuntosTiempo = 0;
        }
    }
}
