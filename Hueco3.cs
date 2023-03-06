using UnityEngine;

public class Hueco3 : MonoBehaviour
{
    bool tick = false;
    private void Update()
    {
        if (transform.childCount > 0 & tick == false)
        {
            if (transform.Find("retardo"))
            {
                Correccion.celda3 = 1;
            }
            else
            {
                Correccion.celda3 = -1;
            }
            Debug.Log(Correccion.celda3);
            tick = true;
        }
        else if (transform.childCount == 0 & tick == true)
        {
            Correccion.celda3 = 0;
            tick = false;
        }
    }
}