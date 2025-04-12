using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 5f;
    public float distanciaMinima = 1.5f;
    public float distanciaMaxima = 5f;
    public bool MoviendoDerecha = true;

    void Update()
    {
        if (objetivo == null) return;

        
        Vector3 direccion = objetivo.position - transform.position;
        float distancia = direccion.magnitude;

        if ((direccion.x > 0 && !MoviendoDerecha) || (direccion.x < 0 && MoviendoDerecha))
        {
            Girar();
        }

        if(distancia > distanciaMinima && distancia < distanciaMaxima)
        {
            Vector3 direccionNormalizada = direccion.normalized;
            transform.position += direccionNormalizada * velocidad * Time.deltaTime;
        }
    }

    void Girar()
    {
        MoviendoDerecha = !MoviendoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }


}
