using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Cargando : MonoBehaviour
{
    public TextMeshProUGUI texto;

    private void Start()
    {
        string nivelACargar = CargaNivel.siguienteNivel;
        StartCoroutine(IniciarCarga(nivelACargar));

    }

    IEnumerator IniciarCarga(string nivel)
    {
        yield return new WaitForSeconds(1f);
        AsyncOperation operacion = SceneManager.LoadSceneAsync(nivel);
        operacion.allowSceneActivation = false;

        while(!operacion.isDone)
        {
            if(operacion.progress >= 0.9f)
            {
                texto.text = "CLICK PARA CONTINUAR";
                if(Input.anyKey)
                {
                    operacion.allowSceneActivation = true;
                }
            }

            yield return null;
        }
    }
}
