using UnityEngine;
using System.Collections;

public class scrEndingPedestrian : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);

        //gameOver = true;
        Application.LoadLevel("sceEndingPedestrian");

        print("Ending pedestrian");
    }


}
