using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManger : MonoBehaviour {

	public static int score;
	Text text;

	void Start(){
		text = GetComponent<Text> ();
		score = 0;
	}

	void Update(){
		if (score < 0)
			score = 0;
		text.text = "" + score;

		if (score >= 100000)
			SceneManager.LoadScene (2);
	}

	public static void AddPoints (int pointsToAdd){
		score += pointsToAdd;
		
	}
	public static void Reset(){
		score = 0;
	}

}
