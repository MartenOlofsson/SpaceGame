using UnityEngine;

namespace Assets
{
	public class BulletCollision : MonoBehaviour
	{

		public delegate void UnitEventHandler(GameObject gameObject);
		public static event UnitEventHandler OnGameObjectShotDown;

		void Start ()
		{
		}

	
		// Update is called once per frame
		void Update () {
			var random = Random.Range(0, 100);
			Debug.Log(random);
			if (random == 5)
			{
				var enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
				enemy.collider.isTrigger = true;
				enemy.transform.position = new Vector3(Random.Range(-6, 6), 12);
				enemy.transform.tag = "Enemy";
				enemy.AddComponent<Rigidbody>();
				enemy.rigidbody.useGravity = false;
				enemy.rigidbody.AddForce(Vector3.down * 100, ForceMode.Force);
			}
		}

		void OnTriggerEnter(Collider collider)
		{
			if (collider.tag == "Enemy")
			{
				if (collider.gameObject.transform.renderer.material.color == Color.red)
				{
					OnGameObjectShotDown(collider.gameObject);
					Destroy(collider.gameObject);
				}
				else
				{
					collider.gameObject.transform.renderer.material.color = Color.red;
				}
			
			}
			Destroy(this.gameObject);
		}
	}
}
