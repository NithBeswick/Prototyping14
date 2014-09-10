using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnterHighscorePanel : MonoBehaviour {
	public Text score;
	public Text name;

	public HighscoreDisplay scoreDisplay;
	
	// Update is called once per frame
	public void ClickedOK() {
		SaveLoadManager.instance.Save(name.text, int.Parse(score.text));
		scoreDisplay.UpdateNames();
	}	
}
