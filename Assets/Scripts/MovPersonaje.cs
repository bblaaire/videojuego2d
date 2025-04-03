using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    
    public float multiplicador = 5f;

    public float multiplicadorSalto = 5f;

    private bool puedoSaltar = true;

    private Rigidbody2D rb;

    private Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        animatorController = GetComponent<Animator>();

        transform.position = new Vector3(-7.1f, -1.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        //movimiento
        float movTeclas = Input.GetAxis("Horizontal");

        float miDeltaTime = Time.deltaTime;

        Debug.Log(Time.deltaTime);

       // transform.Translate(
          // movTeclas*(Time.deltaTime*multiplicador),
           // 0,
          //  0
        //);

        rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

        //flip izq
        if(movTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
        }else if (movTeclas > 0){
        //dcha
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        //Animacion walking
        if(movTeclas != 0){
            animatorController.SetBool("activaCamina", true);
        }else{
            animatorController.SetBool("activaCamina", false);
        }


        //salto
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        
        if(hit){
            puedoSaltar = true;
            Debug.Log(hit.collider.name);
        }else{
            puedoSaltar = false;
        }


    
        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
            rb.AddForce(
                new Vector2(0,multiplicadorSalto), 
                ForceMode2D.Impulse
            );
            //puedoSaltar = false;
        }
    }
    //void OnCollisionEnter2D(){
        //puedoSaltar = true;
        //Debug.Log("Collision");
        //}
}
