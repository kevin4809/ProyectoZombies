using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombie : NPC
{
    ColorType mycolor;
    MyGustoAseessino myGusto;
    MyStruct str; //almacenamos la informacion del struct "MyStruct" en "str"
    

    
    public override void act()
    {
        base.act();
        //se adquiere un valor rando para mycolor y mygusto ademas de eso se ejecuta la corrutina MovimientoZombie 
        mycolor = (ColorType)Random.Range(0, 3);
        str.myGusto2 = (MyGustoAseessino)Random.Range(0, 5);
       
        if (mycolor == ColorType.cyan)
        {
            this.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (mycolor == ColorType.green)
        {
            this.GetComponent<Renderer>().material.color = Color.green;
        }

        if (mycolor == ColorType.magenta)
        {
            this.GetComponent<Renderer>().material.color = Color.magenta;
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ciuadano>())
        {
            Ciuadano ic = collision.gameObject.GetComponent<Ciuadano>();
            Zombie izz = ic;
        }
    }

    public MyStruct Info()
    {
        //retorna el str (MyStruct)
        return str;
        ;
        
    }
}
public enum ColorType
{
    cyan, magenta, green
}
//enum donde tenemos la parte del cuerpo que le gusta comer al zombie 
public enum MyGustoAseessino
{
    torso, mano, corazon, cerebro, pie
}


//struct donde guardamos la informacion de "ColorType, MyGustoAssesino y movimiento"
public struct MyStruct
{
    public ColorType mycolor2;
    public MyGustoAseessino myGusto2;
    public float edad;
}

