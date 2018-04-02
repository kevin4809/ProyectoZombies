using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    int nZ; //variable tipo int en donde escojeres si lo que instanciamos es ciudadano o zombie 
    int nC; //variable tipo int donde colocaremos el numero de instancias 
    public GameObject player; //player 

    
    void Start()
    {
        //instanciamos player
        Instantiate(player);

        //array donde almacenamos los nombres de los ciudadanos 
        string[] names = new string[]
        {
         "Carlos", "Santiago", "Sara","Laura","Camila","Jhon","Camilo","Roberto","Goku","Riuck",
         "superman", "ComoTepiyeteparto"

        };

        //nc toma un valor entre 5 y 10 
        nC = Random.Range(5, 10);
    
        for (int i = 0; i < nC; i++)
        {
            //nZ toma un valor entre 1 y 3 
            nZ = Random.Range(1, 3);
            //si nz es igual a 1 intanciaremos un ciudadano con un nombre aleatorio y una edad aleatoria 
            //si nz no es igual a 1 se instanciara un zombie 
            if (nZ == 1)
            {
                int j = Random.Range(0, names.Length);
                Ciuadano c = new Ciuadano(names[j], Random.Range(10, 100));

            }
            else
            {
                  Zombie z = new Zombie();
            }


        }
    }


}
