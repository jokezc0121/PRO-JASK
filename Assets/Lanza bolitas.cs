using UnityEngine;

public class LanzarHaciaJugador : MonoBehaviour
{
    public GameObject bolitaPrefab;
    public Transform jugador;
    public float intervalo = 1.5f;
    public float fuerzaMin = 3f;
    public float fuerzaMax = 6f;
    public Vector2 areaSpawn = new Vector2(10, 5); 

    void Start()
    {
        InvokeRepeating("LanzarBolita", 1f, intervalo);
    }

    void LanzarBolita()
    {
       
        Vector3 spawnPos = new Vector3(
            Random.Range(-areaSpawn.x / 2, areaSpawn.x / 2),
            Random.Range(-areaSpawn.y / 2, areaSpawn.y / 2),
            0);

        spawnPos += jugador.position;

        GameObject bolita = Instantiate(bolitaPrefab, spawnPos, Quaternion.identity);

        Vector2 direccion = (jugador.position - spawnPos).normalized;

        Rigidbody2D rb = bolita.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            float fuerza = Random.Range(fuerzaMin, fuerzaMax);
            rb.AddForce(direccion * fuerza, ForceMode2D.Impulse);
        }
    }
}
