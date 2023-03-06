using UnityEngine;

public class CorreccionRJ45 : MonoBehaviour
{
    //variables de array para guardar cada cable
    public bool[] tick;
    public GameObject[] padres; //los huecos
    public GameObject[] hijos;  //los cables vivos
    public int[] puntuacion;


    public GameObject pantalla;
    public GameObject personaje;

    private void Awake()
    {
        transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y, -11) ; //activamos la pantalla enfrente del personaje, ya que esta pantalla es distinta
    }
    private void Update()
    {
        if ((Mathf.Abs(puntuacion[0])+ Mathf.Abs(puntuacion[1])+ Mathf.Abs(puntuacion[2])+  //si todos los cables se han colocado
            Mathf.Abs(puntuacion[3])+ Mathf.Abs(puntuacion[4])+ Mathf.Abs(puntuacion[5])+
            Mathf.Abs(puntuacion[6])+ Mathf.Abs(puntuacion[7])) == 8)
        {
            if(puntuacion[0]+ puntuacion[1] + puntuacion[2] + puntuacion[3] + puntuacion[4] +
               puntuacion[5] + puntuacion[6] + puntuacion[7] == 8)  //y se han colocado bien...
            {
                Boton_BienMal.bien++;   //que sume 1 punto
                Personaje.Vel_Mov = 10; //que devuelva la velocidad al personaje
                pantalla.SetActive(false);  //y que se desactive la pantalla de la tarea
            }
            else  //y si no...
            {
                Boton_BienMal.mal++;    //que sume 1 tarea mál hecha
                Personaje.Vel_Mov = 10;
                pantalla.SetActive(false);
            }
        }






        if (padres[0].transform.childCount > 0 & tick[0] == false)  //si el hueco está ocupado
        {
            if (padres[0].transform.Find(hijos[0].name))    //y el hijo se llama como el cable correspondiente
            {
                puntuacion[0] = 1;  //que lo tome como bueno
            }
            else  //y si no...
            {
                puntuacion[0] = -1; //que lo tome como malo
            }
            tick[0] = true;
        }
        else if (padres[0].transform.childCount == 0 & tick[0] == true)
        {
            puntuacion[0] = 0;
            tick[0] = false;
        }


        if (padres[1].transform.childCount > 0 & tick[1] == false)
        {
            if (padres[1].transform.Find(hijos[1].name))
            {
                puntuacion[1] = 1;
            }
            else
            {
                puntuacion[1] = -1;
            }
            tick[1] = true;
        }
        else if (padres[1].transform.childCount == 0 & tick[1] == true)
        {
            puntuacion[1] = 0;
            tick[1] = false;
        }


        if (padres[2].transform.childCount > 0 & tick[2] == false)
        {
            if (padres[2].transform.Find(hijos[2].name))
            {
                puntuacion[2] = 1;
            }
            else
            {
                puntuacion[2] = -1;
            }
            tick[2] = true;
        }
        else if (padres[2].transform.childCount == 0 & tick[2] == true)
        {
            puntuacion[2] = 0;
            tick[2] = false;
        }


        if (padres[3].transform.childCount > 0 & tick[3] == false)
        {
            if (padres[3].transform.Find(hijos[3].name))
            {
                puntuacion[3] = 1;
            }
            else
            {
                puntuacion[3] = -1;
            }
            tick[3] = true;
        }
        else if (padres[3].transform.childCount == 0 & tick[3] == true)
        {
            puntuacion[3] = 0;
            tick[3] = false;
        }


        if (padres[4].transform.childCount > 0 & tick[4] == false)
        {
            if (padres[4].transform.Find(hijos[4].name))
            {
                puntuacion[4] = 1;
            }
            else
            {
                puntuacion[4] = -1;
            }
            tick[4] = true;
        }
        else if (padres[4].transform.childCount == 0 & tick[4] == true)
        {
            puntuacion[4] = 0;
            tick[4] = false;
        }


        if (padres[5].transform.childCount > 0 & tick[5] == false)
        {
            if (padres[5].transform.Find(hijos[5].name))
            {
                puntuacion[5] = 1;
            }
            else
            {
                puntuacion[5] = -1;
            }
            tick[5] = true;
        }
        else if (padres[5].transform.childCount == 0 & tick[5] == true)
        {
            puntuacion[5] = 0;
            tick[5] = false;
        }


        if (padres[6].transform.childCount > 0 & tick[6] == false)
        {
            if (padres[6].transform.Find(hijos[6].name))
            {
                puntuacion[6] = 1;
            }
            else
            {
                puntuacion[6] = -1;
            }
            tick[6] = true;
        }
        else if (padres[6].transform.childCount == 0 & tick[6] == true)
        {
            puntuacion[6] = 0;
            tick[6] = false;
        }


        if (padres[7].transform.childCount > 0 & tick[7] == false)
        {
            if (padres[7].transform.Find(hijos[7].name))
            {
                puntuacion[7] = 1;
            }
            else
            {
                puntuacion[7] = -1;
            }
            tick[7] = true;
        }
        else if (padres[7].transform.childCount == 0 & tick[7] == true)
        {
            puntuacion[7] = 0;
            tick[7] = false;
        }
    }
}