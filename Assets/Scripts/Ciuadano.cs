using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Ciuadano : NPC
{

    MyStruct2 nam;
    Miname nombre;

   public void Start()
    {
        //se asigna un valor al azar a myName y a mi edad 
        nam.myName = (Miname)Random.Range(0, 13);
        nam.edad = Random.Range(15, 101);
        StartC();
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

