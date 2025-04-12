using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("delete", 4f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void delete()
    {
        Destroy(gameObject);
    }
}
