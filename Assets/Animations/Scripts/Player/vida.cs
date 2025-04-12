using System.Collections;
using UnityEngine;
using UnityEngine.Events;
    
public class vida : MonoBehaviour
{
    public int vidaActual;
    public int vidaMaxima = 3;
    public UnityEvent<int> cambioVida;

    public float fuerzaRebote = 5f;
    Rigidbody2D rb;
    Animator animator;

    public GameObject panelFinJuego;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        vidaActual = vidaMaxima;
        cambioVida.Invoke(vidaActual);
    }

    public void RecibirDano (int cantidadDano, Transform origenDano)
    {
        int vidaTemporal = vidaActual - cantidadDano;

        if (vidaTemporal < 0)
        {
            vidaActual = 0;
        }
        else
        {
            vidaActual = vidaTemporal;
        }

        cambioVida.Invoke(vidaActual);

        if (animator != null)
        {
            animator.SetBool("Golpe", true);
            StartCoroutine(DesactivarAnimacionDano());
        }   

        Vector2 direccionRebote = (transform.position - origenDano.position).normalized;
        rb.AddForce(direccionRebote * fuerzaRebote, ForceMode2D.Impulse);

        if (vidaActual <= 0)
        {
            if (panelFinJuego != null)
            {
                panelFinJuego.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    
    }

    private IEnumerator DesactivarAnimacionDano()
    {
        yield return new WaitForSeconds(0.3f);
        animator.SetBool("Golpe", false);
    }

    public void CurarVida(int cantidadCuracion)
    {
        int vidaTemporal = vidaActual + cantidadCuracion;

        if (vidaTemporal > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
        else
        {
            vidaActual = vidaTemporal;
        }

        cambioVida.Invoke(vidaActual);
    }

}
