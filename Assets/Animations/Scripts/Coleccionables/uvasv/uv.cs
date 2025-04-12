using UnityEngine;

public class uv : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Accede al script Movement del jugador
            Movement movimiento = collision.GetComponent<Movement>();
            if (movimiento != null)
            {
                movimiento.speed += 2f; // Aumenta la velocidad en 2
            }

            Destroy(gameObject); // Elimina el objeto del juego tras recolectarse
        }
    }
}