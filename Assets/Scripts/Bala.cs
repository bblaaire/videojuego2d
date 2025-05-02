using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 1;
float tiempoDestruccion = 5.0f;
float queHoraEs;
    public int potenciaArma;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");


               
        if(player.GetComponent<MovPersonaje>().direccionBalaDerecha == true){
            velocidad = velocidad*-1;
        }

        if(player.GetComponent<MovPersonaje>().direccionBalaDerecha == false){
           velocidad = velocidad*1;
        }
        queHoraEs = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time >= queHoraEs+tiempoDestruccion){
            Destroy(this.gameObject);
        }

        float velocidadFinal = velocidad * Time.deltaTime;
        transform.Translate(velocidadFinal, 0f, 0f);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.StartsWith("enemigo_fantasma")){

            Destroy(this.gameObject);

            GameManager.muertes += 1;

            Destroy(col.gameObject);
            //fantasma
            col.GetComponent<Fantasma>().vidaFantasma -= potenciaArma;
        }
    }


}
