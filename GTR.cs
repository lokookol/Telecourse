using UnityEngine;
using UnityEngine.EventSystems;

public class GTR : MonoBehaviour, IPointerClickHandler
{
    public static int PTR;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)
        {
            transform.Rotate(0, 0, 315);
            PTR++;
        }
        else
        {
            transform.Rotate(0, 0, 270);
            PTR = 0;
        }
    }
}
