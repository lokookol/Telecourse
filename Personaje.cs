using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    //jugador
    public Rigidbody2D rb;  //se obtiene el componente Rigid body 2D
    private Vector2 Mov_Dir;    //variable de 3 ejes (x,y)
    public static float Vel_Mov = 10;  //variable PUBLICA para la velocidad de movimiento

    //animaciones
    public Transform posicion;  //esta variable es para invertir la posicion del personaje cuando cambia de dirección
    private Animator animaciones;    //variable para guardar la animación del gameobject
    private float velocidad;    //variable para saber cuando tiene que moverse la animación del personaje
    public GameObject[] lista_de_personajes;    //array de skins para tener personajes aleatorios
    public static int profe_actual;


    //escaleras
    public Transform player;    //obtenemos el componente "Transform" del jugador (la posicion, rotación y escala)
    public static int planta;   //variable para saber en que planta está el jugador
    public int puntos = Colision_Tarea.tareas_hechas;  //variable global para guardar el total de tareas realizadas
    public static int numeroDeTareas_P1; //variable para guardar el numero de tareas por planta
    public static int numeroDeTareas_P2;
    public static int numeroDeTareas_P3;
    public static int numeroDeTareas_PT = 3;    //variable fija de tareas a hacer en la escena de tutorial

    public GameObject[] plantas;    //variable para guardar las plantas y hacer que aparezcan para que no haya lag
    public Animator Animacion_Texto_Planta;
    public TextMeshProUGUI Texto_Planta;
    public GameObject menuDeVuelta;


    //tareas
    public static int BP1; //variable para guardar resultado de la planta 1
    public static int BP2; //variable para guardar resultado de la planta 2
    public static int BP3; //variable para guardar resultado de la planta 3
    public static int BT;  //variable para guardar resultado total
    public int TBien = Boton_BienMal.bien; 
    public int TMal = Boton_BienMal.mal;

    private void Start()
    {
        //variable de en que piso estamos dependiendo de la escena
        Scene escenaActual = SceneManager.GetActiveScene();
        if(escenaActual.name == "Tutorial")
        {
            planta = 0;
        }
        if(escenaActual.name == "Pantalla_Juego")
        {
            planta = 1;

            Texto_Planta.text = "Planta 1"; //que se cambie el texto dependiendo del piso
            Animacion_Texto_Planta.SetTrigger("aparicion");   //aparece el texto de en que planta estás  
        }

        //tareas
        numeroDeTareas_P1 = GameObject.FindGameObjectsWithTag("T_N1").Length;  //numero de tareas = total de tareas en la planta
        Debug.Log("El numero de tareas a completar son: " + numeroDeTareas_P1 + " en la planta 1");



        //animaciones
        int personaje_actual = Random.Range(0, lista_de_personajes.Length); //que de la lista de personajes, escoja 1
        lista_de_personajes[personaje_actual].SetActive(true);  //que lo haga visible
        profe_actual = personaje_actual;
        animaciones = lista_de_personajes[personaje_actual].GetComponent<Animator>();   //y aplique la animación de dicho personaje

    }

    private void Update()   //el void loop de toda la vida
    {
        float MovX = 0f;    //valor float para la velocidad del eje X
        float MovY = 0f;    //valor float para la velocidad del eje y

        if (Input.GetKey(KeyCode.W))    //si se lee la tecla "W"
        {
            MovY = +1f; //que añada velocidad positiva al eje Y
        }
        if (Input.GetKey(KeyCode.A))    //si se lee la tecla "A"...
        {
            MovX = -1f;
            posicion.localScale = new Vector3(0.34f, 0.34f, 0.34f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovY = -1f;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovX = +1f;
            posicion.localScale = new Vector3(-0.34f, 0.34f, 0.34f);
        }
        Mov_Dir = new Vector2(MovX, MovY).normalized;
        /*en la variable de 2 ejes se crea un nuevo vector
        con la velocidad pero se normaliza, para que la
        velocidad en diaglonal no sea superior*/

        velocidad = Mathf.Abs(MovX) + Mathf.Abs(MovY);  //se suma el valor absoluto del movimiento
        animaciones.SetFloat("movimiento", velocidad);  //y se pasa el valor a la ventana de animaciones

        //escaleras
        puntos = Colision_Tarea.tareas_hechas; //que actualize la informacion del otro script en la variable puntos
    }
    private void FixedUpdate()  //void especifico para aplicar físicas
    {
        rb.velocity = Mov_Dir * Vel_Mov;
        //que la velocidad del Rigid body 2D sea la velocidad por la dirección
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((puntos >= numeroDeTareas_P1) ||
            (puntos >= numeroDeTareas_P2) ||
            (puntos >= numeroDeTareas_P3) ||   //cuando todas las tareas estén hechas
            (puntos >= numeroDeTareas_PT))
        {
            if (collision.name == "Escaleras1")   //si el personaje entra en contacto con las escaleras
            {
                player.position = new Vector2(90, 0);    //que se teletransporte a la sigueinte sala
                Colision_Tarea.tareas_hechas = 0;  //ponga al 0 la variable de tareas realizadas
                Debug.Log("Siguiente planta");
                planta = 2;

                plantas[0].SetActive(false);
                plantas[1].SetActive(true);     //se muestra solo la segunda planta
                plantas[2].SetActive(false);

                Texto_Planta.text = "Planta 2"; //que se cambie el texto dependiendo del piso
                Animacion_Texto_Planta.SetTrigger("aparicion");   //aparece el texto de en que planta estás  

                numeroDeTareas_P2 = GameObject.FindGameObjectsWithTag("T_N2").Length;
                Debug.Log("El numero de tareas a completar son: " + numeroDeTareas_P2 + " en la planta 2");

                Boton_BienMal.bien = 0;
                Boton_BienMal.mal = 0;
            }
            if (collision.name == "Escaleras2")   //si el personaje entra en contacto con las escaleras...
            {
                player.position = new Vector2(167, 0);
                Colision_Tarea.tareas_hechas = 0;
                planta = 3;

                plantas[0].SetActive(false);
                plantas[1].SetActive(false);
                plantas[2].SetActive(true);

                Texto_Planta.text = "Planta 3";
                Animacion_Texto_Planta.SetTrigger("aparicion");    //aparece el texto de en que planta estás

                numeroDeTareas_P3 = GameObject.FindGameObjectsWithTag("T_N3").Length;
                Debug.Log("El numero de tareas a completar son: " + numeroDeTareas_P3 + " en la planta 3");

                Boton_BienMal.bien = 0;
                Boton_BienMal.mal = 0;
            }

            if (collision.name == "Escaleras3")
            {
                player.position = new Vector2(0, 0);
                Colision_Tarea.tareas_hechas = 0;
                planta = 4;
                plantas[0].SetActive(true);
                plantas[1].SetActive(false);
                plantas[2].SetActive(false);

                SceneManager.LoadScene("Pantalla_Final"); //Para abrir la escena final

                Boton_BienMal.bien = 0;
                Boton_BienMal.mal = 0;
            }
            if (collision.name == "EscalerasTutorial")  //escaleras para el tutorial
            {
                player.position = new Vector2(0, 0);
                Colision_Tarea.tareas_hechas = 0;
                menuDeVuelta.SetActive(true);
            }
        }
    }

}