using UnityEngine;

public class LimitadorDeFrames : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
}
