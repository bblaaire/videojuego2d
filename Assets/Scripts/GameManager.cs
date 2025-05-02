using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static int vidas = 3;
    public static int marcador = 0;
    public static int puntos = 0;
    public static int muertes = 0;
    GameObject vidasText;
    public static bool estoyMuerto = false;

    

    // Start is called before the first frame update
    void Start()
    {
        vidasText = GameObject.Find("VidasText");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Puntos:"+puntos);

        if( vidas <= 0){
            estoyMuerto = true;
        }
        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
    }
}
