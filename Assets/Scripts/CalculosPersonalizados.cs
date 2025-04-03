using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float num1;
    public float num2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El resultado de la suma es: " + (num1 + num2));
        Debug.Log("El resultado de la resta es: " + (num1 - num2));
        Debug.Log("El resultado de la multiplicacion es: " + (num1 * num2));
        Debug.Log("El resultado de la division es: " + (num1 / num2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
