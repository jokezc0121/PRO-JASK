using UnityEngine;

public class ContactoVida : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out vida vida))
        {
            vida.RecibirDano(damage, transform);
        }
    }
}
