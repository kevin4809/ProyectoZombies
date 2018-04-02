using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciuadano
{

    public string name; //Variable tipo string en el que colocaremos el nombre del ciudadano 
    public int hitpoint; //Variabe tipo int en el que colocaremos la edad del ciudadano 

    GameObject ciudadanoMesh; //cubo Gameobject

    public Ciuadano(string n, int edad)
    {
        name = n;
        hitpoint = edad; 
        ciudadanoMesh = GameObject.CreatePrimitive(PrimitiveType.Cube); // instancia el cubo
        //define la posicion del Gameobject
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10, 10); pos.y = 0f; pos.z = Random.Range(-10, 10);
        ciudadanoMesh.transform.position = pos;

        //escribe en la consola en nombre y la edad 
        Debug.Log("Hola mi nombre es " + name + " y tengo " + edad + " años");
    }
	
}
