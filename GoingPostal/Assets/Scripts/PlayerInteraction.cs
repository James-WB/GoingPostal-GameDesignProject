using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj = null;
    public GameObject InteractText;

    public GameObject EnvelopeHUD;

    void Update(){
        if(Input.GetButtonDown("Interact") && obj){
            InteractText.SetActive(false);
            obj.SendMessage("DoInteraction");
            EnvelopeHUD.SendMessage("IncrementEnv");
            obj = null;
        }
    }



    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Interactable")){
            obj = collider.gameObject;
            InteractText.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collider){
        if(collider.CompareTag("Interactable") && obj == collider.gameObject){
            obj = null;
            InteractText.SetActive(false);
        }
    }

}
