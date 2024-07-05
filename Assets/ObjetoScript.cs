using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoScript : MonoBehaviour
{
    public int precio;
    void Start()
    {
        precio = Random.Range(1, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
