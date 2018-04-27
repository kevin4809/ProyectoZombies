using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Ciuadano : NPC
{

    MyStruct2 nam;
    Miname nombre;

    public override void act()
    {
        base.act();
        //se asigna un valor al azar a myName y a mi edad 
        nam.myName = (Miname)Random.Range(0, 13);
    }

   public MyStruct2 info2()
    {
        return nam;
    }


    public override void Dinstans()
    {
        foreach (GameObject cubito in Manager.lista)
        {
            if (cubito.GetComponent<Zombie>())
            {
                if (Vector3.Distance(cubito.transform.position, transform.position) < distance)
                {
                    transform.position = Vector3.MoveTowards(transform.position, cubito.transform.position, - information.speed);
                    StopCoroutine(MovimientoCiudadano());
                }

            }
        }
    }



    public static implicit operator Zombie(Ciuadano aldeano)
    {
        Zombie iz = aldeano.gameObject.AddComponent<Zombie>();
        iz.information.age = aldeano.information.age;
        Destroy(aldeano);
        return iz;
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
 
}

