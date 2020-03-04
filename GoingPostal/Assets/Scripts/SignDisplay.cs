using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj = null;
    public GameObject InteractText;

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Sign")){
            obj = collider.gameObject;
            InteractText.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collider){
        if(collider.CompareTag("Sign") && obj == collider.gameObject){
            InteractText.SetActive(false);
        }
    }

}
