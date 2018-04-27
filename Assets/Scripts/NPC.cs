using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    float speed;
    int movC;
    int altM;
    MyStruct3 mov;
    MyStruct2 nam;
    public Transform target;
    public float distance = 5;
    public infoTodo information;

    public void Start()
    {
        StartCoroutine(MovimientoCiudadano());
        information.age = Random.Range(15, 101);
        information.speed = 500f / information.age * Time.deltaTime;
        act();
        speed = Random.Range(0.5f, 4);

    } 
    public virtual void act()
    {
        
    }
    public virtual void Dinstans()
    {
        foreach (GameObject cubito in Manager.lista)
        {
            if (cubito.GetComponent<Ciuadano>() || cubito.GetComponent<Heroe>())
            {
               if( Vector3.Distance(cubito.transform.position, transform.position) < distance)
                {
                    transform.position = Vector3.MoveTowards(transform.position, cubito.transform.position, information.speed);
                    StopCoroutine(MovimientoCiudadano());
                }

            }
        }
    }

    void Update()
    {
        switch (movC)
        {
            case 1:

                transform.position += transform.forward * Time.deltaTime * speed;
                break;

            case 2:
                transform.position -= transform.forward * Time.deltaTime * speed;
                break;

            case 3:

                transform.position += transform.right * Time.deltaTime * speed;
                break;

            case 4:
                transform.position -= transform.right * Time.deltaTime * speed;
                break;

            case 5:
                transform.position += new Vector3(0, 0, 0);
                break;

            case 6:
                
                altM = Random.Range(10, 20);
                transform.Rotate(0, Time.deltaTime * altM, 0);
                break;

                case 7:
                transform.LookAt(target);
                break;
        }

        Dinstans();

    }

    public MyStruct2 info4()
    {
        return nam;
    }

    public MyStruct3 info3()
    {
        return mov;
       
    }

    public void InfoMoving()
    {
        if (mov.myMoving == MovimientoC.moving)
        {
            movC = Random.Range(1, 5);
            StartCoroutine(MovimientoCiudadano());
        }
        if(mov.myMoving == MovimientoC.idle)
        {
            movC = 5;
            StartCoroutine(MovimientoCiudadano());
        }
        if(mov.myMoving == MovimientoC.rotation)
        {
            movC = 6;
            StartCoroutine(MovimientoCiudadano());
        }
        if(mov.myMoving == MovimientoC.runing)
        {
            movC = 7;
        }
    }

   public IEnumerator MovimientoCiudadano()
    {
        yield return new WaitForSeconds(3);
        mov.myMoving = (MovimientoC)Random.Range(0, 2);
        InfoMoving();
        StartCoroutine(MovimientoCiudadano());
    }


    public infoTodo infoAll()
    {
        return information;
    }


}
public enum MovimientoC
{
    idle, moving, rotation, runing
}

public struct MyStruct3
{
    public MovimientoC myMoving;
}


public struct infoTodo
{
    public float speed;
    public float age;
}