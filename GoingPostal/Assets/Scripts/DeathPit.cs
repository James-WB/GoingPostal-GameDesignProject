using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPit : MonoBehaviour
{

    public Transform startPos;
    public GameObject gameO;

    public Animator animator;

    void OnTriggerEnter2D(Collider2D collider){

        gameO.transform.position = startPos.transform.position;
    }
}
