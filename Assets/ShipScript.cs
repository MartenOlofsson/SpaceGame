using UnityEngine;

namespace Assets
{
	public class ShipScript : MonoBehaviour
	{
		public float Speed = 12;
		public GameObject CollidedWith;

		void Start() { }

		void Update()
		{
			if (Input.GetAxis("Horizontal") < 0)
			{
				if (CollidedWith != null && CollidedWith.tag == "LeftWall")
				{
					return;
				}
				Move();
			}

			if (Input.GetAxis("Horizontal") > 0)
			{
				if (CollidedWith != null && CollidedWith.tag == "RightWall")
				{
					return;
				}
				Move();
			}
		}

		void Move()
		{
			var x = Input.GetAxis("Horizontal") * Time.smoothDeltaTime * Speed;
			transform.Translate(x, 0, 0, Space.Self);
		}

		void OnTriggerEnter(Collider collider)
		{
			if (collider.tag == "Enemy")
			{
				Application.LoadLevel("StartScene");
			}
			CollidedWith = collider.gameObject;
		}

		void OnTriggerExit(Collider collider)
		{
			CollidedWith = null;
		}
	}
}
