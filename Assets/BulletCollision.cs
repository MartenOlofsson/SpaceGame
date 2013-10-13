using UnityEngine;
using System.Collections;

public class BulletCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Enemy")
		{
			Destroy(collider.gameObject);
		}
		
		Debug.Log("collided with" + collider.tag);
		Destroy(this.gameObject);
	}
}
