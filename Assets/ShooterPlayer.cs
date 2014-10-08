using UnityEngine;
using System.Collections;

public class ShooterPlayer : MonoBehaviour {
	public static GameObject instance;

	public float speed = 0.25f;
	public Vector3 mousePoint;
	public Vector3 lookPoint;

	public AudioSource aSource;

	public GameObject bullet;

	// Use this for initialization
	void Awake () {
		instance = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		Shooting();
	}

	void Movement ()
	{
		mousePoint = Input.mousePosition;
		mousePoint.z = Mathf.Abs (Camera.main.transform.position.z);
		lookPoint = Camera.main.ScreenToWorldPoint (mousePoint);
		transform.LookAt (lookPoint);

		transform.position += new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0) * speed;
	}

	void Shooting () {
		if(Input.GetMouseButtonDown(0)) {
			aSource.Play();
			GameObject copy = (GameObject)Instantiate(bullet);
			copy.transform.position = this.transform.position;
			copy.transform.rotation = this.transform.rotation;
		}
	}
}
