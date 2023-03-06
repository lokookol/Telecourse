using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MovimientoObjeto : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //Funciona igual que la cuadrícula de domótica
    Vector3 PosicionPantalla;
    Vector3 PosicionMundo;

    public Image imagen;
    [HideInInspector] public Transform SiempreEncima;
    public void OnBeginDrag(PointerEventData eventData)
    {
        
        SiempreEncima = transform.parent;
        transform.SetParent(transform.parent.parent);
        transform.SetAsLastSibling();
        imagen.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        PosicionPantalla = Input.mousePosition;
        PosicionPantalla.z = Camera.main.nearClipPlane + 1;

        PosicionMundo = Camera.main.ScreenToWorldPoint(PosicionPantalla);

        transform.position = PosicionMundo;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(SiempreEncima);
        imagen.raycastTarget = true;
    }
}
