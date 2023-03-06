using UnityEngine;
using UnityEngine.EventSystems;

public class fader : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static Vector3 Fader;

    public void OnBeginDrag(PointerEventData eventData) //cuando empiezes arrastrando
    {
        CorreccionMesaMezclas.tick = false; //se desactive el tick
    }

    public void OnDrag(PointerEventData eventData)  //mientras arrastres
    {
        transform.position = new Vector3(transform.position.x, Input.mousePosition.y, transform.position.z);    //que cuadre con la posici�n Y del rat�n
        if (transform.position.y < 216) //para establecer los l�mites del fader
        {
            transform.position = new Vector3(transform.position.x,216,transform.position.z);    //cuando llega abajo del todo, se limita al ultimo punto
        }
        else if (transform.position.y > 616)
        {
            transform.position = new Vector3(transform.position.x, 616, transform.position.z);  //cuando llega arriba del todo, se limita al ultimo punto
        }
        else  //y si no ha llegado a ningun l�mite
        {
            transform.position = new Vector3(transform.position.x, Input.mousePosition.y, transform.position.z); //que siga la posici�n Y del rat�n
        }
    }

    public void OnEndDrag(PointerEventData eventData)   //y que cuando se suelte
    {
        CorreccionMesaMezclas.tick = true;  //se active el tick
    }
}
