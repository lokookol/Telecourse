using UnityEngine;
using UnityEngine.EventSystems;

public class GirosVoltajeB : MonoBehaviour, IPointerClickHandler
{
    //esta ruleta es solo decoración, ya que no hay nada conectado al canal B
    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)
        {
            transform.Rotate(0, 0, 315);
        }
        else
        {
            transform.Rotate(0, 0, 270);
        }
    }
}
