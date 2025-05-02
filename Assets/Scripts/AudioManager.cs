using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip bandaSonora;
    public AudioClip fxButton;
    public AudioClip fxCoin;
    public AudioClip fxDead;
    public AudioClip fxFire;
    public AudioClip fxGhost;
    public AudioClip fxHeartBeat;

    AudioSource _audioSource;

    public static AudioManager Instance;

    // Start is called before the first frame update

    void Awake(){

        if(Instance != null && Instance != this){
            Destroy(this.gameObject);
        }else{
            Instance = this;
             DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
        _audioSource.clip = bandaSonora;
        _audioSource.loop = true;
        _audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Hace sonar clips
    public void SonarClipUnaVez(AudioClip ac){

        _audioSource.PlayOneShot(ac);
    }

}
