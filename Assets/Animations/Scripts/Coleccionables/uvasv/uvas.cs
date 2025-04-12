using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class  uvas : MonoBehaviour
{

    [SerializeField] private GameObject gemaPrefabv;
    [SerializeField] private int cantidadGemasv = 5;
    [SerializeField] private List<GameObject> puntosDeSpawnv;

    //float x = 12f;
    //float y = 45f;
    Vector2 nombreVector = new Vector2(12f, 45f);
    Vector2 nombreVector1 = Vector2.down;
    //Vector3


    // Start is called before the first frame update
    void Start()
    {
        GenerarManzanav();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerarManzanav()
    {
        if (puntosDeSpawnv.Count == 0)
        {
            Debug.LogWarning("No hay puntos de spawn asignados.");
            return;
        }

        // Si hay menos puntos que la cantidad de gemas, ajustamos
        int ManzanasRojAGenerar = Mathf.Min(cantidadGemasv, puntosDeSpawnv.Count);

        List<GameObject> puntosDisponibles = new List<GameObject>(puntosDeSpawnv);

        for (int i = 0; i < ManzanasRojAGenerar; i++)
        {
            if (puntosDisponibles.Count == 0) break;

            int indiceAleatorio = Random.Range(0, puntosDisponibles.Count);
            GameObject puntoSeleccionado = puntosDisponibles[indiceAleatorio];

            Instantiate(gemaPrefabv, puntoSeleccionado.transform.position, puntoSeleccionado.transform.rotation);

            puntosDisponibles.RemoveAt(indiceAleatorio);
        }

    }


}