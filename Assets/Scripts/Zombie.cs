using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie
{
    GameObject zombieMesh; //Cubo 

    public Zombie()
    {

        zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube); //Instancia el cubo 
        //define la posicion del GameObject 
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10, 10); pos.y = 0f; pos.z = Random.Range(-10, 10);
        zombieMesh.transform.position = pos;

        //numero randon entre 1 y 3
       int alt = Random.Range(1, 4); 

        //dependiendo del valor que nos de alt se escojera alguno de de los 3 casos 
        //los casos cambian de colro el cubo y le cambia el nombre del Gameobject 
        if (alt == 2)
        {
            zombieMesh.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            zombieMesh.name = "Hola soy un Zombie y soy de color VERDE ";
            Debug.Log("Soy un Zombie color VERDE ");
        }

        if(alt == 3)
        {
            zombieMesh.GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
            zombieMesh.name = "Hola soy un Zombie y soy de color MAGENTA ";
            Debug.Log("Soy un Zombie color MAGENTA ");
        }

        if(alt == 1)
        {
            zombieMesh.GetComponent<Renderer>().material.SetColor("_Color", Color.cyan);
            zombieMesh.name = "Hola soy un Zombie y soy de color CYAN ";
            Debug.Log("Soy un Zombie color CYAN ");
        }
      
       
    }

}
