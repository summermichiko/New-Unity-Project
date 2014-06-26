using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider other) {
		other.gameObject.GetComponent<Player>().enemiesHit++;
		Destroy (gameObject);
	}
}
