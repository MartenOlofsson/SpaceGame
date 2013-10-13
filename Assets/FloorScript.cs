using UnityEngine;

namespace Assets
{
	public class FloorScript : MonoBehaviour {

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
		}
	}
}
