using UnityEngine;

public class Boton_BienMal : MonoBehaviour
{
    public static int bien = 0; //variables publicas para saber las tareas bien hechas o las tareas mal hechas
    public static int mal = 0;

    public void SumarBien()
    {
        bien++;
        Personaje.Vel_Mov = 10;
    }
    public void SumarMal()
    {
        mal++;
        Personaje.Vel_Mov = 10;
    }
}
