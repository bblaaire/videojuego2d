using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    Vector3 posicionInicial;
    GameObject personaje;
    public float velocidadFantasma = 10.0f;
    public int vidaFantasma = 10;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        personaje = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaFantasma <= 0){
            Destroy(this.gameObject);
        }
    
    //Debug.Log(personaje.transform.position.x);
    float distancia = Vector3.Distance(transform.position, personaje.transform.position);
    float velocidadFinal = velocidadFantasma * Time.deltaTime;
    


    //si la distancia es mayor de 4 no me sigue
    if(distancia <= 4.1f){
        //se mueve

        transform.position = Vector3.MoveTowards(transform.position,personaje.transform.position, velocidadFinal);

    }else{
        
        transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal);

    }


    }
}
