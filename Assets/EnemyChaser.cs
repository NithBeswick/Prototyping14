using UnityEngine;
using System.Collections;

public class EnemyChaser : MonoBehaviour {
	public int health;
	public Transform player;
	public float speed = 0.05f;

	// Use this for initialization
	void Start () {
		player = ShooterPlayer.instance.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player);
		transform.Translate(Vector3.forward * speed);	
	}

	public void Damage() {
		health -= 1;

		if(health <= 0) {
			Destroy(gameObject);
		}
	}
}
