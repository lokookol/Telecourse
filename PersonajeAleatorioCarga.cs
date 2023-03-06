using UnityEngine;

public class PersonajeAleatorioCarga : MonoBehaviour
{
    //animaciones
    private Animator animaciones;    //variable para guardar la animación del gameobject
    public GameObject[] lista_de_personajes;    //array de skins para tener personajes aleatorios
    void Start()
    {
        int personaje_actual = Random.Range(0, lista_de_personajes.Length); //que de la lista de personajes, escoja 1
        lista_de_personajes[personaje_actual].SetActive(true);  //que lo haga visible
        animaciones = lista_de_personajes[personaje_actual].GetComponent<Animator>();   //y aplique la animación de dicho personaje
    }
}
