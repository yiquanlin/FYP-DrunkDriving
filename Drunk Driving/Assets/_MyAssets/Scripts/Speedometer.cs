using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speedometer : MonoBehaviour
{

    public Text text;
    private int speed;

    private Vector3 startingPosition, speedVector;
    GameObject speedoMeter;
    Text speedoMeterText;

    float updateDelay;


    void Start()
    {
        startingPosition = transform.position;
        speedoMeter = GameObject.Find("Speedometer");
        speedoMeterText = speedoMeter.GetComponent<Text>();
        updateDelay = 0.1f;
    }

    void FixedUpdate()
    {
        speedVector = (transform.position - startingPosition) / Time.deltaTime;
        speed = (int)((speedVector.magnitude) * 3.6);

        startingPosition = transform.position;
        //text.text = speed + "km/h";
        if (updateDelay < 0)
        {
            updateDelay = 0;
        }
        if (updateDelay == 0)
        {
            speedoMeterText.text = speed.ToString();
            updateDelay = 10;
        }
        updateDelay -= 1;

    }

    Vector3 speedvector
    {
        get { return this.speedvector; }
    }
}
