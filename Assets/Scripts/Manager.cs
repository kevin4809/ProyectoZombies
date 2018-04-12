using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    int nC; //variable tipo int donde colocaremos el numero de instancias 
    public GameObject player; //player 
    GameObject zombieMesh;
    int randomZC;
    
    void Start()
    {
        //instanciamos player
        Instantiate(player);

        //nc toma un valor entre 5 y 10 
        nC = Random.Range(5, 10);
    
        for (int i = 0; i < nC; i++)
        {
            randomZC = Random.Range(1, 3);
            if(randomZC == 1)
            {
                zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube); //Instancia el cubo 
                zombieMesh.tag = "Zombie";
                //define la posicion del GameObject 
                Vector3 pos = new Vector3();
                pos.x = Random.Range(-10, 10); pos.y = 0f; pos.z = Random.Range(-10, 10);
                zombieMesh.transform.position = pos;
                zombieMesh.AddComponent<Zombie>();
            }
            else
            {
                zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube); //Instancia el cubo 
                zombieMesh.tag = "Zombie";
                //define la posicion del GameObject 
                Vector3 pos = new Vector3();
                pos.x = Random.Range(-10, 10); pos.y = 0f; pos.z = Random.Range(-10, 10);
                zombieMesh.transform.position = pos;
                zombieMesh.AddComponent<Ciuadano>();
            }
          
          

        }

    }

}
