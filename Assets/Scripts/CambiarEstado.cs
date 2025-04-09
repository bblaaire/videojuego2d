using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarEstado : MonoBehaviour
{

    private GameObject miPanel;


    // Start is called before the first frame update
    void Start()
    {
        miPanel = GameObject.Find("Panel");
        miPanel.SetActive(false);
    }


    public void ActivaPanel(){
        if(miPanel.activeSelf == true){
            miPanel.SetActive(false);
        }else{
            miPanel.SetActive(true);
        }
        miPanel.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
