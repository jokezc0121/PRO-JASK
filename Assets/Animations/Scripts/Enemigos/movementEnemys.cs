using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad;
    public Transform Controladorsuelo;
    public float distancia;
    public bool MoviendoDerecha;
    public LayerMask Piso;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        RaycastHit2D informacionSuelo = Physics2D.Raycast(Controladorsuelo.position, Vector2.down, distancia, Piso);

        rb.linearVelocity = new Vector2(velocidad, rb.linearVelocity.y);

        if (informacionSuelo.collider == null)
        {
            Girar();
        }
    }

    void Girar()
    {
        MoviendoDerecha = !MoviendoDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        velocidad *= -1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Controladorsuelo.position, Controladorsuelo.position + Vector3.down * distancia);
    }
}
