using UnityEngine;

public class RatonCamara : MonoBehaviour
{
    public Vector3 PosicionPantalla;
    public Vector3 PosicionMundo;
    void Update()
    {
        PosicionPantalla = Input.mousePosition; //variable para guardar la posici�n del raton en la pantalla
        PosicionPantalla.z = Camera.main.nearClipPlane + 1; //ajustamos la posici�n z de la variable creada par que se muestre en escena

        PosicionMundo = Camera.main.ScreenToWorldPoint(PosicionPantalla);   //creamos variable para que la posici�n del rat�n cuadre con la escena y no con la pantalla

        transform.position = PosicionMundo; //y aplicamos la posici�n del rat�n a la escena
    }

}
