using UnityEngine;
using System.Collections;

public class EndingTrigger : MonoBehaviour
{


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
        Application.LoadLevel("sceEndingNPCCar");
       
        print("collision hit");
    }


    
    
}
