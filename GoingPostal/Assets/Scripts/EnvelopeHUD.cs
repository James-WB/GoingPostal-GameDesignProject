using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvelopeHUD : MonoBehaviour
{
    // Start is called before the first frame update
    private int envelopes = 0;
    public Text envelopeText;
    // Update is called once per frame
    void Update()
    {
        envelopeText.text = "Envelopes: " + envelopes;
    }

    public void IncrementEnv(){
        envelopes++;
    }

    public void DecrementEnv(){
        envelopes--;
    }

    public int GetNumEnv(){
        return envelopes;
    }

}