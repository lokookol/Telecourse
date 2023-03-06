using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class CanalAB : MonoBehaviour, IPointerClickHandler
{
    public Image[] imagen;

    public void OnPointerClick(PointerEventData eventData)
    {
        imagen[2].color = new Color32(171, 171, 171, 255);
        imagen[1].color = new Color32(255, 255, 255, 255);
        imagen[0].color = new Color32(255, 255, 255, 255);
        ModificacionSeņal.canal = 3;
    }
}
