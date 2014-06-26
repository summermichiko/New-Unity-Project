using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed = 40;
	public CharacterController cController;
	public GameObject bullet;
	public int enemiesHit = 0;C

	// Use this for initialization
	void Start () {
		//prints "CUBE!" to the console
		Debug.Log ("CUBE!");
		cController = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//can't be dEbUg.lOg();
		Debug.Log ("CUUUUBE!");

		if (Input.GetButton ("Right")) {
			cController.Move (new Vector3(speed, 0, 0)  * Time.deltaTime);
		}

		if (Input.GetButton ("Left")) {
			cController.Move (new Vector3(-speed, 0, 0)  * Time.deltaTime);
		}

		cController.Move (new Vector3(0, -9.81f, 0)  * Time.deltaTime);

		if (Input.GetButton ("Jump")) {
			cController.Move (new Vector3(0, speed, 0)  * Time.deltaTime);
		}

		if (Input.GetButton ("Shoot")) {
			Instantiate(bullet, transform.position, Quaternion.identity);
		}
	}

}
