using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour {
//	private LevelMangers gameLevelManager;
//
//	void Start () 
//	{
//		gameLevelManager = FindObjectOfType<LevelMangers> ();
//	}
//
//	void Update () 
//	{
//		
//	}
//
//	void OnTriggerEnter2D(Collider2D other)
//	{
//		if (other.tag == "Player") {
//			Destroy (gameObject);
//		}
//
//	}


	public int pointsToAdd;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Destroy (gameObject);
			ScoreManger.AddPoints (pointsToAdd);
		}
	}


}
