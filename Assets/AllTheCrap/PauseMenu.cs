using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public const KeyCode PAUSE_KEY = KeyCode.Escape;

	public static bool isPaused = false;
	public GameObject pauseButton;
	public GameObject pauseMenu;

	void Start() {
		if(pauseButton == null) {
			this.enabled = false;
			Debug.LogError("ERROR: pauseButton object not assigned to PauseMenu in " + gameObject.name);
		}

		if(pauseMenu == null) {
			this.enabled = false;
			Debug.LogError("ERROR: pauseMenu object not assigned to PauseMenu in " + gameObject.name);
		} else {
			pauseMenu.SetActive(false);
		}
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(PAUSE_KEY)) {
			OnButtonClick();
		}

		/*
		if(isPaused) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
		*/
	}

	public void OnButtonClick() {
		isPaused = true;
		Time.timeScale = 0;

		pauseButton.SetActive(false);
		pauseMenu.SetActive(true);
	}

	public void OnCloseMenu() {
		isPaused = false;
		Time.timeScale = 1;

		pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
	}

	public void ClickQuit() {
		Application.LoadLevel("menu");
	}

	/*
	void OnGUI() {
		//if(!isPaused) {
		//	if(GUILayout.Button("Pause")) {
		//		OnButtonClick();
		//	}
		//} else {
		if(isPaused) {
			if(GUILayout.Button("Continue")) {
				OnCloseMenu();
			}
			if(GUILayout.Button("Quit")) {
				Application.LoadLevel("menu");
			}
		}
	}
	*/
}
