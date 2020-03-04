using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mailbox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj = null;
    public GameObject gemObj = null;
    public GameObject InteractText;

    public GameObject EnvelopeHUD;
    public GameObject PointsHUD;

    void Update(){
        if(Input.GetButtonDown("Deliver") && obj && EnvelopeHUD.GetComponent<EnvelopeHUD>().GetNumEnv() > 0){
            InteractText.SetActive(false);
            obj.SendMessage("Deliver");
            EnvelopeHUD.SendMessage("DecrementEnv");
            PointsHUD.SendMessage("IncrementMail");
            obj.GetComponent<BoxCollider2D>().enabled = false;
            obj = null;
        }
    }



    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("House")){
            obj = collider.gameObject;
            InteractText.SetActive(true);
        }

        if(collider.CompareTag("Gem")){
            gemObj = collider.gameObject;
            gemObj.SetActive(false);
            PointsHUD.SendMessage("IncrementGems");
            obj.SendMessage("Deliver");
            obj = null;
        }

    }

    void OnTriggerExit2D(Collider2D collider){
        if(collider.CompareTag("House") && obj == collider.gameObject){
            obj = null;
            InteractText.SetActive(false);
        }
    }

}
