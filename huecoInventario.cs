using UnityEngine;
using UnityEngine.EventSystems;

public class huecoInventario : MonoBehaviour, IDropHandler  
{
    //funciona igual que la cuadrícula de domótica
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject soltado = eventData.pointerDrag;
            MovimientoObjeto MovimientoObjeto = soltado.GetComponent<MovimientoObjeto>();
            MovimientoObjeto.SiempreEncima = transform;
        }
    }
}
