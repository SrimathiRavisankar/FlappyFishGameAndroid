using UnityEngine.UI;
using UnityEngine;

using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0;

	static Score instance;

	static public void AddPoint() {
		if(instance.fish.dead)
			return;

		score++;

		if(score > highScore) {
			highScore = score;
		}
	}

	Fish fish;

	void Start() {
		instance = this;
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		if(player_go == null) {
			Debug.LogError("Could not find an object with tag 'Player'.");
		}

		fish = player_go.GetComponent<Fish>();
		score = 0;
		highScore = PlayerPrefs.GetInt("highScore", 0);
	}

	void OnDestroy() {
		instance = null;
		PlayerPrefs.SetInt("highScore", highScore);
	}

	void Update () {
	
transform.GetComponentInChildren<Text>().text = "Score: " + score + "\nHigh Score: " + highScore;


	}
}


