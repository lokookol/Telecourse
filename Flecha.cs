using UnityEngine;

public class Flecha : MonoBehaviour
{
    public Animator Animacion_Flecha;    //obtenemos el componente imagen del objeto
    public bool encendido;
    public int puntos = Colision_Tarea.tareas_hechas;  //variable de otro script guardado en este
    public int num_tareas_P1 = Personaje.numeroDeTareas_P1;   //variable de otro script guardado en este
    public int num_tareas_P2 = Personaje.numeroDeTareas_P2;
    public int num_tareas_P3 = Personaje.numeroDeTareas_P3;
    public int num_tareas_PT = Personaje.numeroDeTareas_PT;
    public int piso = Personaje.planta; //variable para saber en que planta está el jugador
    public GameObject conos_P1;     //componente para cada fila de conos en cada planta
    public GameObject conos_P2;
    public GameObject conos_P3;
    public GameObject conos_PT;     //tutorial


    private void Update()
    {
        puntos = Boton_BienMal.bien + Boton_BienMal.mal;//Colision_Tarea.tareas_hechas;  //actualización de las variables
        num_tareas_P1 = Personaje.numeroDeTareas_P1; 
        num_tareas_P2 = Personaje.numeroDeTareas_P2;
        num_tareas_P3 = Personaje.numeroDeTareas_P3;
        num_tareas_PT = Personaje.numeroDeTareas_PT;
        piso = Personaje.planta;


        if ((puntos >= num_tareas_PT) && (piso == 0))
        {
            Animacion_Flecha.SetBool("encendido", true);
            conos_PT.SetActive(false);
        }
        else if ((puntos <= num_tareas_PT) && (piso == 0))
        {
            Animacion_Flecha.SetBool("encendido", false);
        }

            if ((puntos >= num_tareas_P1) && (piso == 1))  //si se han completado las tareas y estas en el primer piso...
        {
            Animacion_Flecha.SetBool("encendido", true);  //que se muestre la animación de la flecha
            conos_P1.SetActive(false);  //y que se quiten los conos
        }
        else if ((puntos <= num_tareas_P1) && (piso == 1))  //si no se han completado...
        {
            Animacion_Flecha.SetBool("encendido", false); //pues se queda apagada la flecha
            conos_P1.SetActive(true);   //que vuelvan a mostrarse
        }


        if ((puntos >= num_tareas_P2) && (piso == 2))
        {
            Animacion_Flecha.SetBool("encendido", true);
            conos_P2.SetActive(false);
        }
        else if ((puntos <= num_tareas_P2) && (piso == 2))
        {
            Animacion_Flecha.SetBool("encendido", false);
            conos_P2.SetActive(true);
        }


        if ((puntos >= num_tareas_P3) && (piso == 3))
        {
            Animacion_Flecha.SetBool("encendido", true);
            conos_P3.SetActive(false);
        }
        else if ((puntos <= num_tareas_P3) && (piso == 3))
        {
            Animacion_Flecha.SetBool("encendido", false);
            conos_P3.SetActive(true);
        }

        if (piso == 4)
        {
            Animacion_Flecha.SetBool("encendido", false);
        }
    }
}

