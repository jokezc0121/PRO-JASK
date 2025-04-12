
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialogoPanel;
    public TextMeshProUGUI dialogoTexto;
    public string[] dialogue;
    private int index = 0;

    public float textoSpeed;
    public bool rango;


    void Start()
    {
        dialogoTexto.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && rango)
        {
            if (!dialogoPanel.activeInHierarchy)
            {
                dialogoPanel.SetActive(true);
                StartCoroutine(Typing());
            }
            else if (dialogoTexto.text == dialogue[index])
            {
                NextLine();
            }

        }
        if (Input.GetKeyDown(KeyCode.Q) && dialogoPanel.activeInHierarchy)
        {
            RemoveText();
        }
    }
    public void RemoveText()
    {
        dialogoTexto.text = "";
        index = 0;
        dialogoPanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogoTexto.text += letter;
            yield return new WaitForSeconds(textoSpeed);
        }
    }
    public void NextLine()
    {
        if (index < dialogue.Length - 1)
        {
            index++;
            dialogoTexto.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            RemoveText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rango = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rango = false;
            RemoveText();
        }
    }
}