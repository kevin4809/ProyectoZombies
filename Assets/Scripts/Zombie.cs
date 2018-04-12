using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    ColorType mycolor;
    MyGustoAseessino myGusto;
    GameObject zombieMesh;
    public static int valor;
    MyStruct str;
    float speed = 10;
    int mov;

    void Start()
    {
        mycolor = (ColorType)Random.Range(0, 3);
        str.myGusto2 = (MyGustoAseessino)Random.Range(0, 5);
        StartCoroutine(MovimientoZombie());
    }

    void Update()
    {
        if (mycolor == ColorType.cyan)
        {
            this.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if(mycolor == ColorType.green)
        {
            this.GetComponent<Renderer>().material.color = Color.green;
        }

        if (mycolor == ColorType.magenta)
        {
            this.GetComponent<Renderer>().material.color = Color.magenta;
        }

        switch (mov)
        {
            case 1:

                transform.position += transform.forward * Time.deltaTime;

                break;

            case 2:
                transform.position -= transform.forward * Time.deltaTime;

                break;

                case 3:

                transform.position += transform.right * Time.deltaTime;
                break;

            case 4:
                transform.position -= transform.right * Time.deltaTime;

                break;

            case 5:
                transform.position += new Vector3(0, 0, 0);
                break;

        }



    }

    public void InfoMove()
    {
        if (str.myMovimiento == Movimiento.moving)
        {
            mov = Random.Range(1,5);
            StartCoroutine(MovimientoZombie());
        }
        else
        {
            mov = 5;
            StartCoroutine(MovimientoZombie());
        }
    }

    public MyStruct Info()
    {
        return str;
        
    }
    IEnumerator MovimientoZombie ()
    {

        yield return new WaitForSeconds(5);
        str.myMovimiento = (Movimiento)Random.Range(0, 2);
        InfoMove();
        StartCoroutine(MovimientoZombie());
 
    }

   
}

public enum Movimiento
{
    idle,moving
}

public enum ColorType
{
    cyan, magenta, green
}

public enum MyGustoAseessino
{
    torso, mano, corazon, cerebro, pie
}



public struct MyStruct
{
    public ColorType mycolor2;
    public MyGustoAseessino myGusto2;
    public Movimiento myMovimiento;
}

