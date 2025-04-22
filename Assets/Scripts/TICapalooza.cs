using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    public int entradasCampo = 0;
    public int entradasPlatea = 0;
    private int precioCampo = 1200;
    private int precioPlatea = 2000;
    private int capacidadMaxCampo = 20400;
    private int capacidadMaxPlatea = 16200;
    // Start is called before the first frame updated 
    void Start()
    {
        if (entradasCampo <= 0 || + entradasPlatea <= 0 || entradasCampo + entradasPlatea > capacidadMaxCampo + capacidadMaxPlatea) {
            Debug.Log("Por favor ingrese una cantidad de entradas valida");

        }
        
        else {
        Debug.Log("Dinero recaudado con las entradas de campo: $"+ entradasCampo * precioCampo);
        Debug.Log("Dinero recaudado con las entradas de platea: $"+ entradasPlatea * precioPlatea);
        
        if (entradasCampo > capacidadMaxCampo && entradasPlatea  > capacidadMaxPlatea) {
            Debug.Log("Sold Out!");
            return;
        }

        else {
            Debug.Log("Quedan " + (capacidadMaxCampo - entradasCampo) + " entradas de campo y " + (capacidadMaxPlatea - entradasPlatea) + " de platea.");
        }

        if (entradasCampo + entradasPlatea > (capacidadMaxCampo + capacidadMaxCampo) / 2) {
            Debug.Log("El festival fue un éxito!");
            return;
        }

        else {
            Debug.Log("Debemos mejorar la convocatoria");
        }
        return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
