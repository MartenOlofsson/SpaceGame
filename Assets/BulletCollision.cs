using UnityEngine;

namespace Assets
{
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
				if (collider.gameObject.transform.renderer.material.color == Color.red)
				{
					Destroy(collider.gameObject);
				}
				else
				{
					collider.gameObject.transform.renderer.material.color = Color.red;
				}
			
			}
		
			Debug.Log("collided with" + collider.tag);
			Destroy(this.gameObject);
		}
	}
}
