using UnityEngine;

public class Hueco1 : MonoBehaviour
{
    bool tick = false;  //variable para que no se ejecute el código constantemente
    private void Update()
    {
        if(transform.childCount > 0 & tick == false)    //si el hueco está lleno...
        {
            if (transform.Find("I"))    //y tiene como hijo a un componente con el nombre "I"...
            {
                Correccion.celda1 = 1;  //que lo ponga como bien colocado
            }
            else  //sino...
            {
                Correccion.celda1 = -1; //que lo ponga como mál colocado
            }
            tick = true;    //que se active la variable para que no haga un bucle
        }
        else if (transform.childCount == 0 & tick == true)  //y si vuelve a estar vacio el hueco
        {
            Correccion.celda1 = 0; //que no lo considere ni como bueno ni como malo
            tick = false;
        }
}
}
