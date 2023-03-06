using UnityEngine;

public class DificultadJuego : MonoBehaviour
{
    public GameObject[] tareas; //variable array para guardar las tareas a ocultar dependiendo de la dificultad
    private void Start()
    {
        if (Dificultad.DificultadTareas == true)
        {
            tareas[0].SetActive(false);
            tareas[1].SetActive(false);
        }
        else if (Dificultad.DificultadTareas == false)
        {
            tareas[0].SetActive(true);
            tareas[1].SetActive(true);
        }
    }
}
