using UnityEngine;
using System.Collections;

public class MiniVanController : MonoBehaviour {

	public WheelCollider WheelFL;
	public WheelCollider WheelFR;
	public WheelCollider WheelRL;
	public WheelCollider WheelRR;


	public float maxTorque = 15f;
	public float steeringForce = 30f;

	public float frontturningAngle = 10f;
	public float rearturningAngle = 5f;
	public float frontAngle;
	public float rearAngle;


	// Use this for initialization
	void Start () {
	
		Rigidbody rB = (Rigidbody)GetComponent (typeof(Rigidbody));
		Vector3 temp = rB.centerOfMass;
		temp.y = -0.1f;
		rB.centerOfMass = temp;
	}
	
	// Update is called once per frame
	void Update () {
		frontAngle = frontturningAngle * (Time.deltaTime);
		rearAngle = rearturningAngle * (Time.deltaTime);

		if (Input.GetKey (KeyCode.UpArrow)) {
			/*Moving Forward*/
			WheelFL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelFR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			/*Moving Forward*/
			WheelFL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelFR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRL.motorTorque = maxTorque * Input.GetAxis ("Vertical");
			WheelRR.motorTorque = maxTorque * Input.GetAxis ("Vertical");
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			/*Turning Left*/
			WheelFL.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
			WheelFR.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
			/*Setting the rotation of the wheel according to where it turns to*/
			WheelFL.transform.Rotate (new Vector3 (0, 1, 0), -frontAngle);
			WheelFR.transform.Rotate (new Vector3 (0, 1, 0), -frontAngle);
			WheelRL.transform.Rotate (new Vector3 (0, 1, 0), -rearAngle);
			WheelRR.transform.Rotate (new Vector3 (0, 1, 0), -rearAngle);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			/*Turning Right*/
			WheelFL.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
			WheelFR.steerAngle = steeringForce * Input.GetAxis ("Horizontal");
			/*Setting the rotation of the wheel according to where it turns to*/
			WheelFL.transform.Rotate (new Vector3 (0, 1, 0), frontAngle);
			WheelFR.transform.Rotate (new Vector3 (0, 1, 0), frontAngle);
			WheelRL.transform.Rotate (new Vector3 (0, 1, 0), rearAngle);
			WheelRR.transform.Rotate (new Vector3 (0, 1, 0), rearAngle);
		}

	}

	void Drifting () {
	}
}
