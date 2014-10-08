using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed;
	public float lifespan;
	public GameObject explosion;

	private float life;

	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,0,speed * Time.deltaTime));

		if(life > lifespan) {
			Destroy(gameObject);
		} else {
			life += Time.deltaTime;
		}
	}

	void OnCollisionEnter2D(Collision2D c) {
		HitSomething(c.gameObject);
	}

	void OnTriggerEnter2D(Collider2D c) {
		HitSomething(c.gameObject);
	}

	void HitSomething(GameObject g) {
		g.SendMessage("Damage", SendMessageOptions.DontRequireReceiver);

		Destroy(Instantiate(explosion, this.transform.position, Quaternion.identity), 2);

		Destroy(gameObject);
	}
}
