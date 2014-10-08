using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class LevelManager : MonoBehaviour {
	public static LevelManager instance;
	public static int CurrentScore;

	public GameObject ScoreSubmit;
	public Slider healthDisplay;
	public Text scoreDisplay;
	public Text scoreDisplay2;

	public float life = 100;

	private bool hasClicked;

	void Start () {
		instance = this;
		LevelManager.CurrentScore = 0;
		ScoreSubmit.SetActive(false);
	}

	void Update() {
		if(hasClicked) {
			life -= Time.deltaTime;
		}
		healthDisplay.value = life;
		scoreDisplay.text = CurrentScore + "";
		if(life <= 0) {
			OnDeath();
		}
	}

	private void OnDeath() {
		hasClicked = false;
		scoreDisplay2.text = CurrentScore + "";
		ScoreSubmit.SetActive(true);
	}

	public void OnClick () {
		CurrentScore += 1;
		hasClicked = true;
	}

	public void OnMiss () {
		life -= 10;
		hasClicked = true;
	}

	public void Reset () {
		hasClicked = false;
		CurrentScore = 0;
		life = 100;
	}
}



