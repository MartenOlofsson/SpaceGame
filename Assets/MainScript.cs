using UnityEngine;

namespace Assets
{
	public class MainScript : MonoBehaviour
	{

		private int _score;

		void OnEnable()
		{
			BulletCollision.OnGameObjectShotDown += IncreaseScore;
		}

		public void IncreaseScore(GameObject gameObject)
		{
			_score++;
		}

		// Use this for initialization
		void Start () {
			
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

		void OnGUI()
		{
			GUI.Label(new Rect(10, 100, 100, 20), string.Format("Score {0}", _score));
		}
	}
}
