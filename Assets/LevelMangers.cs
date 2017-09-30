using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMangers : MonoBehaviour {

	public static int gemValue;
	Text text;

	// Use this for initialization
//	void Start () {
//		text = GetComponent<Text> ();
//		gemValue= 0;
//
//	}

	// Update is called once per frame
	void Update () {
		if (gems < 0)
			gems = 0;

		//		text.text = "" + gemValue;	
	}


//	public static void AddPoints (int pointsToAdd) {
//		gemValue += pointsToAdd;
//	}


	public int gems;
	// Use this for initialization
	void Start () {
		gems= 0;
		
	}
	// Update is called once per frame


	public void AddGems (int numberOfGems){
		gems += numberOfGems;
	}



}
