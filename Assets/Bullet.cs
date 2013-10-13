using UnityEngine;

namespace Assets
{
	public class Bullet : MonoBehaviour
	{

		// Use this for initialization
		public Rigidbody BulletPrefab;
		public float Force;
		public Transform Position;

		void Start()
		{
		}

		// Update is called once per frame
		void Update()
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				var bullet = (Rigidbody)Instantiate(BulletPrefab, new Vector3(transform.position.x, transform.position.y + 1.3f, 0), Position.rotation);
				bullet.AddForce(Position.up * Force);
			}	
		}

		
	}
}
