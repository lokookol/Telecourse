using UnityEngine;

public class Hueco4 : MonoBehaviour
{
    bool tick = false;
    private void Update()
    {
        if (transform.childCount > 0 & tick == false)
        {
            if (transform.Find("Q"))
            {
                Correccion.celda4 = 1;
            }
            else
            {
                Correccion.celda4 = -1;
            }
            Debug.Log(Correccion.celda4);
            tick = true;
        }
        else if (transform.childCount == 0 & tick == true)
        {
            Correccion.celda4 = 0;
            tick = false;
        }
    }
}
