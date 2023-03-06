using UnityEngine;

public class SeguimientoDeLinea : MonoBehaviour
{
    public LineRenderer linea;
    public GameObject puntoA;
    public GameObject puntoB;
    private void Update()
    {
        linea.positionCount = 2;    //creamos 2 puntos para que una linea se cree entre ambos
        linea.SetPosition(0, new Vector3(puntoA.transform.position.x-0.5f, puntoA.transform.position.y, -13f));     //la posicion del punto A
        linea.SetPosition(1, new Vector3(puntoB.transform.position.x-0.25f, puntoB.transform.position.y, -13f));    //posición del punto B

    }
}
