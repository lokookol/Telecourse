using UnityEngine;

public class Colision_Tarea : MonoBehaviour
{
    public SpriteRenderer SR;   //obtenemos el componente Sprite Renderer
    public GameObject interaccion;  //obtenemos el componente Game Object
    public static int tareas_hechas;   //creamos una variable global (que puedas acceder a ella desde otros scripts)
    public GameObject ActivarDesactivar; //SSS obtenemos el componente AD

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Radio")   //si el radio del personaje entra en colisión
        {
            SR.enabled = true;  //que se muestre el bordeado
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Radio")   //si el radio del personaje sale de la colisíón
        {
            SR.enabled = false; //que se oculte ekl bordeado
        }
    }
    private void Update()
    {

        if (SR.enabled == true) //si el bordeado se ve
        {
            if (Input.GetKeyDown(KeyCode.E))    //y presionamos la tecla "E"
            {
                SR.color = Color.green; //que el bordeado se ponga de color verde
                tareas_hechas++;  //que aumente la variable global de tareas
                ActivarDesactivar.SetActive(true);  //SSS Aparecerá la pantalla de la tarea
                Debug.Log("Has realizado " + tareas_hechas + " tareas");
                Personaje.Vel_Mov = 0;
            }
            if (Input.GetKeyUp(KeyCode.E))  //y si levantamos la tecla "E"
            {
                SR.color = new Color(255, 255, 0, 1);   //que vuelva a ser un color amarillo
                interaccion.SetActive(false);   //y que se oculte el objeto entero para no poder interactuar con el
            }
        }
    }
}
