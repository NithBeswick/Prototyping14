using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float moveSpeed = 2;
	public float jumpPower = 5;

	private bool onGround = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		IsOnGround();

		if(!PauseMenu.isPaused) {
			Vector3 pos = transform.position;

			pos.z += Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

			if(onGround) {
				if(Input.GetAxis("Jump") >= 0.5f) {
					rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
				}
			}

			transform.position = pos;
		}
	}

	void IsOnGround() {
		Ray ray = new Ray(transform.position, Vector3.down);
		RaycastHit hit;

		if(Physics.Raycast(ray, out hit, 10.0f)) {
			float distance = Vector3.Distance(ray.origin, hit.point);
			//Debug.Log("Distance to ground = " + distance);
			onGround = distance <= 0.2f;
		} else {
			onGround = false;
		}
	}
}
