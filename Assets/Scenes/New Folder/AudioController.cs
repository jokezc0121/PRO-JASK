using JetBrains.Annotations;
using UnityEngine;


public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    private bool sonido = true;
    public float volumen = 0.3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubirVolumen()
    {
        if (sonido)
        {
            audioSource.volume += 0.1f;
            volumen = audioSource.volume;
        }
    }

    public void BajarVolumen()
    {
        if (sonido)
        {
            audioSource.volume -= 0.1f;
            volumen = audioSource.volume;
        }

    }

    public void Silenciar()
    {
        if (sonido)
        {
            sonido = false;
            audioSource.volume = 0;
            
        }
        else
        {
            sonido = true;
            audioSource.volume = volumen;
        }
    }
}
