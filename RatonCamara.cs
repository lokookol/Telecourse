using UnityEngine;

public class RatonCamara : MonoBehaviour
{
    public Vector3 PosicionPantalla;
    public Vector3 PosicionMundo;
    void Update()
    {
        PosicionPantalla = Input.mousePosition; //variable para guardar la posición del raton en la pantalla
        PosicionPantalla.z = Camera.main.nearClipPlane + 1; //ajustamos la posición z de la variable creada par que se muestre en escena

        PosicionMundo = Camera.main.ScreenToWorldPoint(PosicionPantalla);   //creamos variable para que la posición del ratón cuadre con la escena y no con la pantalla

        transform.position = PosicionMundo; //y aplicamos la posición del ratón a la escena
    }

}
