using UnityEngine;

public class Correccion : MonoBehaviour
{
    public GameObject pantallaTarea;

    public static int celda1=0;
    public static int celda2=0;
    public static int celda3=0;
    public static int celda4=0;

    private void Update()
    {
       if(Mathf.Abs(celda1)+ Mathf.Abs(celda2)+ Mathf.Abs(celda3)+ Mathf.Abs(celda4) == 4)  //si se colocan todos los cuadros
        {
            if(celda1+celda2+celda3+celda4 == 4)    //y estan bien...
            {
                Boton_BienMal.bien++;   //se suma 1 punto
                Personaje.Vel_Mov = 10; //y se le devuelve la velocidad al personaje
            }
            else  //si no está bien colocado
            {
                Boton_BienMal.mal++;    //se le suma 1 a las tareas mal hechas
                Personaje.Vel_Mov = 10; //y se le deuveulve la velocidad al personaje
            }
            pantallaTarea.SetActive(false); //y se desactiva la pantalla
        }
    }
}
