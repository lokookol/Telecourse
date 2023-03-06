using UnityEngine.SceneManagement;

public static class CargaNivel
{
    public static string siguienteNivel; //variable publica para pasar al siguiente piso

    public static void NivelCarga(string nombre)
    {
        siguienteNivel = nombre;
        SceneManager.LoadScene("Pantalla_Carga");
    }
}
