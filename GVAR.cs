using UnityEngine;
using UnityEngine.EventSystems;

public class GVAR : MonoBehaviour, IPointerClickHandler
{
    public static int PVA;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)
        {
            transform.Rotate(0, 0, 315);
            PVA++;
        }
        else
        {
            transform.Rotate(0, 0, 270);
            PVA = 0;
        }
    }
}
