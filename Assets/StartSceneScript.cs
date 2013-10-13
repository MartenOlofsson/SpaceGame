using UnityEngine;

namespace Assets
{
	public class StartSceneScript : MonoBehaviour {

	
		void Start () {
	
		}
	
		// Update is called once per frame
		void Update () {
			
			
		}

		void OnGUI()
		{
			if (GUI.Button(new Rect(100, 100, 100, 100), "Start game"))
				Application.LoadLevel("GameScene");
		}
	}
}
