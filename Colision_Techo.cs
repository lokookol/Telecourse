using UnityEngine;

public class Colision_Techo : MonoBehaviour
{

    public SpriteRenderer SR;   //se obtiene el componente Sprite Renderer (lo que genera la imagen)

    private void OnTriggerEnter2D(Collider2D collision) //void que se ejecuta cuando un colider entra en contacto
    {
       if(collision.tag == "Personaje") //en este caso, si un objeto con la etiqueta "Personaje" lo toca
        {
            SR.enabled =false;  //se oculta SOLO la imagen del objeto
        }
    }
    private void OnTriggerExit2D(Collider2D collision)  //void para cuando un colider sale del objeto
    {
        if (collision.tag == "Personaje")
        {
            SR.enabled = true;
        }
    }

}
