using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighscoreDisplay : MonoBehaviour {

	public Text highscoreList;

	// Use this for initialization
	void Start () {
		highscoreList.text = "";

		foreach(string s in SaveLoadManager.instance.GetScores()) {
			highscoreList.text += s + '\n';
		}
	}

	public void UpdateNames() {
		Start();
	}
}
