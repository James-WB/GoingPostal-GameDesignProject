using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHUD : MonoBehaviour
{
    // Start is called before the first frame update
    private int points = 0;
    private int mailDelivered = 0;
    private int gems = 0;
    public Text pointsText;
    // Update is called once per frame
    void Update()
    {
        points = (mailDelivered * 10) + (gems * 10);
        pointsText.text = "Points: " + points;
    }

    public void IncrementMail(){
        mailDelivered++;
    }

    public void IncrementGems(){
        gems++;
    }

}