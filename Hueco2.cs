using UnityEngine;

public class Hueco2 : MonoBehaviour
{
    bool tick = false;
    private void Update()
    {
        if (transform.childCount > 0 & tick == false)
        {
            if (transform.Find("telerruptor"))
            {
                Correccion.celda2 = 1;
            }
            else
            {
                Correccion.celda2 = -1;
            }
            Debug.Log(Correccion.celda2);
            tick = true;
        }
        else if (transform.childCount == 0 & tick == true)
        {
            Correccion.celda2 = 0;
            tick = false;
        }
    }
}
