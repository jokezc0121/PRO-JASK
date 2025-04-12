using UnityEngine;

public class uvi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vida vidaJugador = collision.GetComponent<vida>();
            if (vidaJugador != null)
            {
                vidaJugador.CurarVida(1); // Cura 1 punto de vida al jugador
            }

            Destroy(gameObject); // Destruye el objeto al recolectarlo
        }
    }
}
