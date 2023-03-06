using UnityEngine;
using TMPro;

public class Tareas_Completadas : MonoBehaviour
{
    public int puntos = Colision_Tarea.tareas_hechas;  //variable global para guardar el total de tareas realizadas
    public static TextMeshProUGUI textoTareas;   //variable publica para asociar el texto
    public static int puntuacionP1;
    public static int puntuacionP2;
    public static int puntuacionP3;

    private void Awake()
    {
        textoTareas = GetComponent<TextMeshProUGUI>();
    }


    private void Update()
    {
        if (Personaje.planta == 1)
        {
            puntos = Boton_BienMal.bien + Boton_BienMal.mal; //que actualize la informacion del otro script en la variable puntos
            puntuacionP1 = Boton_BienMal.bien;
            textoTareas.text = "Tareas: " + puntos.ToString();
            
        }
        else if (Personaje.planta == 2)
        {
            puntos = Boton_BienMal.bien + Boton_BienMal.mal; //que actualize la informacion del otro script en la variable puntos
            puntuacionP2 = Boton_BienMal.bien;
            textoTareas.text = "Tareas: " + puntos.ToString();
        }
        else if (Personaje.planta == 3)
        {
            puntos = Boton_BienMal.bien + Boton_BienMal.mal; //que actualize la informacion del otro script en la variable puntos
            puntuacionP3 = Boton_BienMal.bien;
            textoTareas.text = "Tareas: " + puntos.ToString();
        }
    }
}
