using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataqueE : MonoBehaviour
{
    public GameObject bala;
    public Transform posicion1;
    public Transform posicion2;
    public Transform posicion3;
    public Transform posicion4;
    public Transform posicion5;
    public Transform posicion6;
    public Transform posicion7;
    public Transform posicion8;
    public int numero;
    void Start()
    {
        InvokeRepeating("ataque", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ataque()
    {
        numero = UnityEngine.Random.Range(1, 3);
        switch (numero)
        {
            case 1:
                Instantiate(bala, posicion1.position, posicion1.rotation);
                Instantiate(bala, posicion3.position, posicion3.rotation);
                Instantiate(bala, posicion5.position, posicion5.rotation);
                Instantiate(bala, posicion7.position, posicion7.rotation);
                break;
            case 2:
                Instantiate(bala, posicion2.position, posicion2.rotation);
                Instantiate(bala, posicion4.position, posicion4.rotation);
                Instantiate(bala, posicion6.position, posicion6.rotation);
                Instantiate(bala, posicion8.position, posicion8.rotation);
                break;

        }
        Instantiate(bala, posicion1.position, posicion1.rotation);
    }
    public void ataque2()
    {
        
    }
}
