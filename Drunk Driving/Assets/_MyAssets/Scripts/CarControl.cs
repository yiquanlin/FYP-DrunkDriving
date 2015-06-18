using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {

    public WheelCollider WheelFL;
    public WheelCollider WheelFR;
    public WheelCollider WheelRL;
    public WheelCollider WheelRR;

    public float maxTorque = 50f;
    public float steeringForce = 25f;
	
	public float frontturningAngle = 10f;
	public float rearturningAngle = 5f;
	public float frontAngle;
	public float rearAngle;

	// Use this for initialization
	void Start () {
        Rigidbody rb = (Rigidbody)GetComponent(typeof(Rigidbody));
        Vector3 temp = rb.centerOfMass;
        temp.y = -0.1f;
        rb.centerOfMass = temp;
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
			/*Moving Backward*/	
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
		if (Input.GetKey ("space")) {
			WheelFL.motorTorque = 0;
			WheelFR.motorTorque = 0;
			WheelRL.motorTorque = 0;
			WheelRR.motorTorque = 0;
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Placeholder") {
			col.rigidbody.AddForce(Vector3.forward * 2500, ForceMode.Acceleration);
			col.rigidbody.AddTorque(Vector3.right * 1000);
			Debug.Log("Car Hit!");
		}
	}
}
