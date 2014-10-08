using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonClicker : MonoBehaviour {
	public Text text;
	public int initialNumber = 3;

	public void Start() {
		initialNumber = Random.Range(1,4);
		text.text = initialNumber + "";
	}

	public void OnClick() {
		initialNumber -= 1;
		text.text = initialNumber + "";

		//tell manager to create new button, AND increase score by 1
		LevelManager.instance.OnClick();

		if(initialNumber <= 0) {
			Destroy(gameObject);
		}
	}
}
