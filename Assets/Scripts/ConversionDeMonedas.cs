using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{

    //1# Declaracion de variables
    public float montoAConvertir;
    public string codigoDeMoneda;
    private float dineroConvertido;
    private float cotizacionMonedaElegida;


    // Start is called before the first frame update
    void Start()
    {
        //2# Ingreso y validacion de datos

        if (montoAConvertir >= 1000) {
            Debug.Log("El monto debe ser mayor a $1000.");
            return;
        }

        if (codigoDeMoneda == "D")  
            cotizacionMonedaElegida = 1134.5f;
        }

        else if (codigoDeMoneda == "E") {
            cotizacionMonedaElegida = 1397.16f;
        }
    
        else if (codigoDeMoneda == "R") {
            cotizacionMonedaElegida = 211.1f;
        }
        
        else {
            Debug.log("Por favor selecciona una moneda valida.");
        }

        
    
            //Debug.Log("Tus $" + montoAConvertir + " pesos, se convirtieron a $" + (montoAConvertir / 1350 + " Dolares");


        // Update is called once per frame
        void Update()
    {
        
    }
}
