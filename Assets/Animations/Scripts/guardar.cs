using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class guardar : MonoBehaviour
{
    public TextMeshPro manzanas;
    public TextMeshPro estrellas;
    public TextMeshPro time;
    public InputField nombre;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Save()
    {
        datosjugador obj = new datosjugador(nombre.ToString(), time.ToString(), estrellas.ToString(), manzanas.ToString());
        string json = JsonUtility.ToJson(obj, true);
        string rutaArchivo = Application.persistentDataPath + "/jugador.json";
        System.IO.File.WriteAllText(rutaArchivo, json);
    }
}
