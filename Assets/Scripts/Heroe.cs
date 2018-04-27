using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heroe : MonoBehaviour
{   
    public string n;
    MyStruct zombieInfo; //struc donde tenemos guardado toda la informacion
    MyStruct2 ciudadanoInfo; // struc donde tenemos guardado toda la informacion
    infoTodo information;
    float distancia = 5;
    float dins;

    public Text infoZombie;
    public Text infoCitycen;
    public Button exit;

    void Start()
    {
        infoZombie = GameObject.Find("InfoZombie").GetComponent<Text>();
        infoCitycen = GameObject.Find("InfoCiudadano").GetComponent<Text>();
        exit = GameObject.Find("Salida").GetComponent<Button>();


       
        infoZombie.gameObject.SetActive(false);
        infoCitycen.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
       
    }

    //si el heroe toca al el zombie o el ciudadano se ejecuta el mensaje correspondiente 
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ciuadano>())
        {
            ciudadanoInfo = collision.gameObject.GetComponent<Ciuadano>().info2();
            information = collision.gameObject.GetComponent<Ciuadano>().infoAll();
            infoCitycen.text = ("Hola soy " + ciudadanoInfo.myName + " y tengo " + information.age);
            infoZombie.gameObject.SetActive(false);
            infoCitycen.gameObject.SetActive(true);
            exit.gameObject.SetActive(true);
         
        }
    }

    void Update()
    {
        foreach(GameObject npc in Manager.lista)
        {
           if(npc.GetComponent<Zombie>() && Vector3.Distance(npc.transform.position, transform.position) < distancia)
            {
                zombieInfo = npc.gameObject.GetComponent<Zombie>().Info();
                Debug.Log("awrrr quiero comer tu " + zombieInfo.myGusto2);
                infoZombie.text = "awrrr quiero comer tu " + zombieInfo.myGusto2;
                infoZombie.gameObject.SetActive(true);
                infoCitycen.gameObject.SetActive(false);
                exit.gameObject.SetActive(true);
             
            }
        }


        if(Manager.acti == true)
        {
            infoZombie.gameObject.SetActive(false);
            infoCitycen.gameObject.SetActive(false);
            exit.gameObject.SetActive(false);
        }
    }
}
