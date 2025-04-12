using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierj : MonoBehaviour
{
    public AudioSource fuenteAudio;
    public AudioClip n;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Cambiar canción
            if (fuenteAudio != null && n != null)
            {
                fuenteAudio.clip = n;
                fuenteAudio.Play();
            }

            // Activar objeto con tag "jefe"
            
        }
    }
}