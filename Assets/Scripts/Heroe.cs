using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour
{   
    public string n;
    MyStruct zombieInfo; //struc donde tenemos guardado toda la informacion
    MyStruct2 ciudadanoInfo; // struc donde tenemos guardado toda la informacion

    //si el heroe toca al el zombie o el ciudadano se ejecuta el mensaje correspondiente 
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Zombie>())
        {
            zombieInfo = collision.gameObject.GetComponent<Zombie>().Info();
            Debug.Log("awrrr quiero comer tu " + zombieInfo.myGusto2); //Se ejecuta el mensaje 
        }

        if (collision.gameObject.GetComponent<Ciuadano>())
        {
            ciudadanoInfo = collision.gameObject.GetComponent<Ciuadano>().info2();
            Debug.Log("Hola soy " + ciudadanoInfo.myName + " y tengo " + ciudadanoInfo.edad);
        }
    }
}
