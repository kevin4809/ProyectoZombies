using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed = 4;
    int movC;
    int altM;
    MyStruct3 mov;
    MyStruct2 nam;
    public Transform target;
    public float distance = 5;
    public void StartC()
    {   
        StartCoroutine(MovimientoCiudadano());
    
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

    }

    public MyStruct2 info2()
    {
        return nam;
    }

    public MyStruct3 info3()
    {
        return mov;
       
    }

    virtual public void Dinstans()
    {
        foreach(GameObject cubito in Manager.lista)
        {
            if (Vector3.Distance(target.transform.position, transform.position) < distance)
            {
                mov.myMoving = MovimientoC.runing;
                InfoMoving();
            }
        }
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

    IEnumerator MovimientoCiudadano()
    {
        yield return new WaitForSeconds(3);
        mov.myMoving = (MovimientoC)Random.Range(0, 2);
        InfoMoving();
        StartCoroutine(MovimientoCiudadano());
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
