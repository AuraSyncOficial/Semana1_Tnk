using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    void Start()
    {
        int a;
        a = 5;

        if (a % 2 == 0)
        {
            Debug.Log("Par");
        }
        else
        {
            Debug.Log("Impar");
        }
    }


    void Update()
    {
        
    }
}
