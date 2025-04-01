using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float kilosVendidos;
    string nombreAlumno;
    bool estaAprobado;

    // Start is called before the first frame update
    void Start()
    {
        cantidadAlumnos = 32;
        kilosVendidos = 23.7f;
<<<<<<< HEAD
        nombreAlumno = "tomas";
        estaAprobado = true;
=======
        nombreAlumno = "Jerónimo";
        estaAprobado = false;
>>>>>>> be4f9e356e8556acf79a79503b6c8cbf826d4424
        Debug.Log(cantidadAlumnos);
        Debug.Log(kilosVendidos);
        Debug.Log(nombreAlumno);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
