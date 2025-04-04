using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.Mathematics;
using UnityEngine;

public class Arma : MonoBehaviour
{

    public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E)){ 
            GameObject balaClone = Instantiate(bala, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            
        }


    }
}
