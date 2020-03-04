using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mail : MonoBehaviour
{
    public GameObject InteractText;
    float currentTime;

    public void Deliver(){
        InteractText.SetActive(true);
        currentTime = Time.time;
    }

    void Update(){
        if(currentTime != 0){
           if(Time.time > currentTime + 1.0f){
            InteractText.SetActive(false);
            currentTime = 0f;
            }
        }
    }

}
