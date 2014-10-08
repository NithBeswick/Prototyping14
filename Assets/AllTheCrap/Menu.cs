using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	float totalTime = 0;
	int totalFrames = 0;

	// Use this for initialization
	void Start () {
		totalTime = 0;
		totalFrames = 0;
	}
	
	// Update is called once per frame
	void Update () {
		totalFrames += 1;
		totalTime += Realtime();
	}
	
	void OnGUI() {
		//GUILayout.Label("Time: " + totalTime);
		//GUILayout.Label("Frames: " + totalFrames);

		bool button = GUILayout.Button("Play!", GUILayout.Width(300), GUILayout.Height(150));

		if(button) {
			Debug.Log("Pressed Play");
			Application.LoadLevel("scene01");
		}

		if(GUILayout.Button("Quit :'(", GUILayout.Width(300), GUILayout.Height(150))) {
			Application.Quit();
		}
	}
	
	//Example on methods with return.
	float Realtime() {
		return Time.deltaTime;
	}
}
