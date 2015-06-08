using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float rotationSpeed = 1000f;
	public float timePassed;
	public float maxTime = 5.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 position = this.transform.position;
			position.z++;
			this.transform.position = position;
			DirectionChange();
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 position = this.transform.position;
			position.z--;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}

	}

	void DirectionChange () {
		timePassed+=0.5f;
		Debug.Log(timePassed);
		if (timePassed >= 5) {
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
			if (timePassed >= maxTime)
			{
				timePassed = 0.0f;
				position.x--;
				this.transform.position = position;
			}
		}
	}
}
