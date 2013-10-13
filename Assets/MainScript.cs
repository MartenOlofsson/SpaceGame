using UnityEngine;

namespace Assets
{
	public class MainScript : MonoBehaviour {

		// Use this for initialization
		void Start () {
	
		}
	
		// Update is called once per frame
		void Update ()
		{

			var random = Random.Range(0, 100);
			if (random == 5)
			{
				var enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);

				enemy.collider.isTrigger = true;
				enemy.transform.position = new Vector3(Random.Range(-6, 6), 7);
				enemy.transform.tag = "Enemy";
			
				enemy.AddComponent<Rigidbody>();
				enemy.rigidbody.useGravity = false;
				enemy.rigidbody.AddForce(Vector3.down * 100, ForceMode.Force);
			
			}
		
		}

	
	
	}
}
