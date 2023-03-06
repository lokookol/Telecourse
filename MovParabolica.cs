using UnityEngine;
using UnityEngine.EventSystems;

public class MovParabolica : MonoBehaviour, IDragHandler, IEndDragHandler
{
    float posicionAnterior;
    public static float valor;

    float map(float valor, float minA, float maxA, float minB, float maxB)
    {
        return minB + (valor - minA) * (maxB - minB) / (maxA - minA);
    }

    private void Update()
    {
        posicionAnterior = Input.mousePosition.y;
        if(transform.localEulerAngles.z <= 360 & transform.localEulerAngles.z >= 270) 
        {
            valor = map(transform.localEulerAngles.z, 360, 270, 0, 45);
        }
        else if (transform.localEulerAngles.z <= 270 & transform.localEulerAngles.z >= 180)
        {
            valor = map(transform.localEulerAngles.z, 270, 180, 45, 0);
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(posicionAnterior > Input.mousePosition.y)
        {
            transform.Rotate(0, 0, -1);
        }
        else if (posicionAnterior < Input.mousePosition.y)
        {
            transform.Rotate(0, 0, 1);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (CalculoGeneral.suma >= 47 & CalculoGeneral.suma <= 77)
        {
            CalculoGeneral.tick = true;
        }
    }
}
