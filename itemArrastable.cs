using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class itemArrastable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image imagen;
    [HideInInspector] public Transform SiempreEncima;
    public void OnBeginDrag(PointerEventData eventData) //cuando comienzas a arrastrar...
    {
        SiempreEncima = transform.parent;   //que la variable sea la transformación del padre (la celda)
        transform.SetParent(transform.parent.parent);   //metodo para que el item actual pase por encima de todos los objetos
        transform.SetAsLastSibling();   //se coloca el ultimo en el lienzo
        imagen.raycastTarget = false;   //y se desactiva el raycast de la imagen
    }

    public void OnDrag(PointerEventData eventData)  //cuando se arrastra
    {
        transform.position = Input.mousePosition;   //que cuadre con la posicion del ratón
    }

    public void OnEndDrag(PointerEventData eventData)   //y que cuando se suelte
    {
        transform.SetParent(SiempreEncima); //se ponga en el transform anteriormente guardado
        imagen.raycastTarget = true;    //pero que al activar el raycast detecte su nuevo hueco en otra celda
    }
}
