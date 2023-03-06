using UnityEngine;
using UnityEngine.EventSystems;

public class HuecoCuadricula : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)  //funcion que ocurre cuando se suelta el rat�n
    {
        if (transform.childCount == 0)  //si el hueco est� vacio
        {
            GameObject soltado = eventData.pointerDrag; //que guarde en la variable el arrastre
            itemArrastable itemArrastable = soltado.GetComponent<itemArrastable>(); //en otra variable el propio componente arrastrable 
            itemArrastable.SiempreEncima = transform;   //y por ultimo en otra variable la posici�n y rotaci�n de la cuadricula
        }
    }
}
