using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SaveLoadManager : MonoBehaviour {
	public static SaveLoadManager instance = new SaveLoadManager();

	public void Save(string name, int score) {
		string[] names = GetNames();

		if(score > GetScore(name))
			PlayerPrefs.SetInt(name, score);

		string nameList = "";
		bool nameExists = false;
		foreach(string n in names) {
			nameList += n + "|";

			if(n == name)
				nameExists = true;
		}
		if(!nameExists)
			nameList += name;

		PlayerPrefs.SetString("HighscoreNames", nameList);
	}

	public List<string> GetScores() {
		List<string> scores = new List<string>();

		foreach(string s in GetNames()) {
			if(!string.IsNullOrEmpty(s))
				scores.Add(GetScore(s) + " - " + s);
		}

		scores.Sort();
		scores.Reverse();

		return scores;
	}

	string[] GetNames() {
		if(PlayerPrefs.HasKey("HighscoreNames"))
			return PlayerPrefs.GetString("HighscoreNames").Split('|');
		return new string[0];
	}
	
	int GetScore(string name) {
		if(PlayerPrefs.HasKey(name))
			return PlayerPrefs.GetInt(name);
		return -1;
	}
}
