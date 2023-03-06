using UnityEngine;

public class Dificultad : MonoBehaviour
{
    public GameObject[] dificultad; //variable array para guardar que dificultad se selecciona
    public static bool DificultadTareas;    //variable para determinar que dificultad está
    void Update()
    {
        if (dificultad[0].activeSelf)   //si se cambia a 2EIT...
        {
            DificultadTareas = true;    //que la dificultad sea facil
        }
        else if (dificultad[1].activeSelf)  //si se cambia a 2EST...
        {
            DificultadTareas = false;   //que la dificultad sea dificil
        }
    }
}
