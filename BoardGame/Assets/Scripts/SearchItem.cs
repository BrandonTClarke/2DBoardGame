using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchItem : MonoBehaviour {

	public int itemSearchRNG;

	public void SearchSquare(){
		int itemSearchRNG = Random.Range(0,2);
		if (itemSearchRNG == 1) {
			
		}
		StatHolder.MovesMade = 0;
		StatHolder.TotalTurns++;
		Debug.Log ("total turns are: " + StatHolder.TotalTurns);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
