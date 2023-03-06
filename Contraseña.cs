using UnityEngine;

public class Contraseña : MonoBehaviour
{

    public void ComprobarContraseña(string cont)
    {
        switch (cont) //Si el texto del TextBox coincide con...
        {
            case "667203":
                CargaNivel.NivelCarga("Pantalla_Juego"); //Se accede al juego
                break;
        }
    }
}
