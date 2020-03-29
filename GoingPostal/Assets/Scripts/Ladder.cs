using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Ladder : MonoBehaviour {
    public float ladderSpeed;
    public GameObject obj;
    public float oldGrav;

    void OnTriggerStay2D (Collider2D other) {
        obj = other.gameObject;
        
        other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.5f;

        if (Input.GetKey(KeyCode.W) && other.CompareTag("Player")){
           other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,ladderSpeed);
        }
        else if (Input.GetKey(KeyCode.S) && other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -ladderSpeed);
        }
        else
        {
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }





    }

    void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 3;
    }

}
