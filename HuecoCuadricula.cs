using UnityEngine;
using UnityEngine.EventSystems;

public class HuecoCuadricula : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)  //funcion que ocurre cuando se suelta el ratón
    {
        if (transform.childCount == 0)  //si el hueco está vacio
        {
            GameObject soltado = eventData.pointerDrag; //que guarde en la variable el arrastre
            itemArrastable itemArrastable = soltado.GetComponent<itemArrastable>(); //en otra variable el propio componente arrastrable 
            itemArrastable.SiempreEncima = transform;   //y por ultimo en otra variable la posición y rotación de la cuadricula
        }
    }
}
