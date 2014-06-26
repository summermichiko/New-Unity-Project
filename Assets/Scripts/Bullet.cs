using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float deathTimer;
	
	// Use this for initialization
	void Start () {
		deathTimer = 5f;
	}
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (10f, 0, 0) * Time.deltaTime);
		if (deathTimer > 0) {
			deathTimer = deathTimer - Time.deltaTime;
		}
		if (deathTimer < 0) {
			Destroy(gameObject);		
		}
	}
}
