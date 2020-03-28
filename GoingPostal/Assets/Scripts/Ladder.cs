using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Ladder : MonoBehaviour {

   void OnTriggerEnter2D (Collider2D other) {
    // Stops the player from being affected by gravity while on ladder
    if (other.CompareTag("Player")){
       other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
     }
   }

   void OnTriggerStay2D (Collider2D other) {
    if(!(other.CompareTag("Player"))){
      return;
    }

    if(Input.GetButtonDown("Vertical")){
      other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3 (0, Input.GetAxisRaw("Vertical")*10, 0));
    }
    else{
        other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
    }


 }

  void OnTriggerExit2D (Collider2D other) {
    // Stops the player from being affected by gravity while on ladder
     if (other.CompareTag("Player")){
       other.gameObject.GetComponent<Rigidbody2D> ().gravityScale = 1;
     }
  }
}
