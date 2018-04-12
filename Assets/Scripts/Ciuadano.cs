using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciuadano : MonoBehaviour
{

    MyStruct2 nam;
    Miname nombre;

    void Start()
    {
        //se asigna un valor al azar a myName y a mi edad 
        nam.myName = (Miname)Random.Range(0, 13);
        nam.edad = Random.Range(15, 101);
    }

    public MyStruct2 info2()
    {
        //returna el valor nam 
        return nam;
       
    }
   
}
//enum donde almacenamos los nombres de los ciudadanos 
public enum Miname
{
    Carlos, Santiago, Sara, Laura, Camila, Jhon, Camilo, Roberto, Goku, Riuck, superman, ComoTepiyeteparto
}

public struct MyStruct2
{ 
    // strut donde guardamos la informaciom de miname y edad 
    public Miname myName;
    public float edad;
}