using UnityEngine;

public class FinalProfesorYTexto : MonoBehaviour
{
    public int profesor_actual = Personaje.profe_actual;
    public GameObject[] lista_de_personajes;    //array de skins para tener personajes aleatorios

    void Start()
    {
        profesor_actual = Personaje.profe_actual;
        lista_de_personajes[profesor_actual].SetActive(true);  //que lo haga visible
        if (PuntuacionFinal.notaFinalPublica < 5)   //dependiendo de si has aprobado o no, que active una frase u otra
        {
            lista_de_personajes[profesor_actual].gameObject.transform.GetChild(0).gameObject.SetActive(false);
            lista_de_personajes[profesor_actual].gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            lista_de_personajes[profesor_actual].gameObject.transform.GetChild(0).gameObject.SetActive(true);
            lista_de_personajes[profesor_actual].gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
