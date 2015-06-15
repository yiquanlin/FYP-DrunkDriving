using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {

    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelRL;
    public WheelCollider WheelRR;

    public float maxTorque = 100f;
    public float steeringForce = 25f;

	// Use this for initialization
	void Start () {
        //Vector3 temp = rigidbody.centerOfMass;
        //temp.y = -0.9f;
        //rigidbody.centerOfMass = temp;

        Rigidbody rb = (Rigidbody)GetComponent(typeof(Rigidbody));
        Vector3 temp = rb.centerOfMass;
        temp.y = -0.1f; //the f indicates that this is a floating point variable, original: -0.9
        rb.centerOfMass = temp;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			WheelFL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelFR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
		}
		if (Input.GetKey (KeyCode.S)) {
			WheelFL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelFR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
		}
		if (Input.GetKey (KeyCode.A)) {
			WheelFL.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
			WheelFR.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
		}
		if (Input.GetKey (KeyCode.D)) {
			WheelFL.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
			WheelFR.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
		}
	
	}
}
