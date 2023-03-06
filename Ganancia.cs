using UnityEngine;
using UnityEngine.EventSystems;

public class Ganancia : MonoBehaviour, IPointerClickHandler
{
    public static int puntosGanancia = 0;
    public void OnPointerClick(PointerEventData eventData)  //cada vez que se haga click encima del objeto
    {
        if(transform.eulerAngles.z > 135 & transform.eulerAngles.z <= 225)  //si su rotación del eje z está entre estos valores
        {
            transform.Rotate(0, 0, 270);    //que gire 90 grados
        }
        else  //si no...
        {
            transform.Rotate(0, 0, 315);    //que gire 90
        }
    }
    private void Update()
    {
        if (transform.eulerAngles.z > 135 & transform.eulerAngles.z <= 225) //si su posición es la deseada
        {
            puntosGanancia = 1; //que cuente la ganancia como buena
        }
        else  //si no...
        {
            puntosGanancia = 0; //que la detecte como mál
        }
    }
}
