using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaRecolected3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.SumValues2(1);
            Destroy(gameObject);
        }
    }


}