using UnityEngine;
using UnityEngine.EventSystems;

public class GP : MonoBehaviour, IPointerClickHandler
{
    public static int PP;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (transform.localEulerAngles.z > 45 & transform.localEulerAngles.z <= 315)
        {
            transform.Rotate(0, 0, 315);
            PP++;
        }
        else
        {
            transform.Rotate(0, 0, 270);
            PP = 0;
        }
    }
}
