
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;



public class vidaUI : MonoBehaviour
{
    public List<Image> corazones;
    public GameObject corazonPrefab;
    public vida vidaPlayer;
    public int indexActual;
    public Sprite corazonLLeno;
    public Sprite corazonVacio;

    private void Awake()
    {
        vidaPlayer.cambioVida.AddListener(ActualizarCorazones);
    }

    private void ActualizarCorazones(int vidaActual)
    {
        if (corazones.Count == 0)
        {
            CrearCorazones(vidaActual);
        }
        else
        { 
            CambiarVida(vidaActual);
        }
    }
    private void CrearCorazones(int cantidadVidaMax)
    {
        for (int i = 0; i < cantidadVidaMax; i++)
        {
            GameObject Corazon = Instantiate(corazonPrefab, transform);
            corazones.Add(Corazon.GetComponent<Image>());
        }
        indexActual = cantidadVidaMax - 1;
    }

    private void CambiarVida(int vidaActual)
    {
        vidaActual = Mathf.Clamp(vidaActual, 0, corazones.Count);

        for (int i = 0; i < corazones.Count; i++)
        {
            if (i < vidaActual)
            {
                corazones[i].sprite = corazonLLeno;
            }
            else
            {
                corazones[i].sprite = corazonVacio;
            }
        }

        indexActual = vidaActual;
    }
}
