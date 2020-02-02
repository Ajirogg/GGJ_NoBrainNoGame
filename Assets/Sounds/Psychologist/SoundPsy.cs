using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPsy : MonoBehaviour
{

    public AudioSource thisone;
    public AudioClip[] clips;
    bool issound = true;
    // Start is called before the first frame update
    void Start()
    {
        thisone.volume = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if(issound == true){
        StartCoroutine(DoRandomsound(15));
        }
    }

   IEnumerator DoRandomsound(int time) 
{
        issound = false;
        int taille = clips.Length;
        yield return new WaitForSeconds(Random.Range(6,time));
        thisone.PlayOneShot(clips[Random.Range(0,taille)]);
        issound = true;
    
}
}
