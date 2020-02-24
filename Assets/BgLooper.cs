using UnityEngine;
using System.Collections;

public class BgLooper : MonoBehaviour {

	

	void Start() {

	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered: " + collider.name);

		float widthOfBGObject = ((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;
		if(collider.tag == "Pipe") {
       pos.x += 23.38f;
		}
else
{

		pos.x += 8.1642f;


}
		collider.transform.position = pos;

	}
}
