using UnityEngine;
using System.Collections;

public class scrPedestrianAI : MonoBehaviour 
{
    public Transform[] wayPoint = new Transform[3];
    int currentWayPoint = 0;

    public float accerelate = 20.0f;


	// Use this for initialization
	void Start () 
    {
	    wayPoint[0] = GameObject.Find("Waypoint1").transform;
        wayPoint[1] = GameObject.Find("Waypoint2").transform;
        wayPoint[2] = GameObject.Find("Waypoint3").transform;
	
    }
	
	// Update is called once per frame
	void Update () 
    {
        walk();
	
	}

    void walk()
    {
        Vector3 wayPointDirection = wayPoint[currentWayPoint].position - transform.position;
        float speedElement = Vector3.Dot(wayPointDirection.normalized, transform.forward);
        float speed = accerelate + speedElement;
        transform.Translate(0, 0, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "WayPoint")
        {
            currentWayPoint++;
        }
    }
}
