using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El resultado de la suma es: " + (num1 + num2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
