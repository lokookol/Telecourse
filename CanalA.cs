using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CanalA : MonoBehaviour, IPointerClickHandler
{
    public Image[] imagen;  //guardamos en un array todas las imagenes de los botones

    public void OnPointerClick(PointerEventData eventData)  //y si se hace click en el bot�n A
    {
        imagen[0].color = new Color32(171, 171, 171, 255);  //que se vea como si est� presionado
        imagen[1].color = new Color32(255, 255, 255, 255);  //y que los otros 2, se vean que no est�n presionados
        imagen[2].color = new Color32(255, 255, 255, 255);
        ModificacionSe�al.canal = 1;    //ponemos en la variable que se est� usando el canal A
    }

}
