using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class datosjugador : MonoBehaviour
{
    public string nombre;
    public string tiempo;
    public string estrellas;
    public string manzanas;

    public datosjugador(string nombre, string tiempo, string estrellas, string manzanas)
    {
        this.nombre = nombre;
        this.tiempo = tiempo;
        this.estrellas = estrellas;
        this.manzanas = manzanas;
    }

}
