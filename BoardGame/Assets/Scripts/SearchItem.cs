using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchItem : MonoBehaviour {

	public GameObject slotPanel1;
	public GameObject slotPanel2;
	public GameObject slotPanel3;
	public GameObject slotPanel4;
	public GameObject slotPanel5;
	public GameObject slotPanel6;
	public GameObject slotPanel7;
	public GameObject slotPanel8;
	public GameObject slotPanel9;

	GameObject Item1;
	GameObject Item2;
	GameObject Item3;
	GameObject Item4;
	GameObject Item5;
	GameObject Item6;
	GameObject Item7;
	GameObject Item8;
	GameObject Item9;

	public int itemSearchRNG;
	public string ItemToGet;

	public void SearchSquare(){

		if (slotPanel1.transform.childCount < 1) {
			GameObject Item1 = Instantiate (Resources.Load("Wooden Bow"), slotPanel1.transform) as GameObject;
		}
		else if (slotPanel2.transform.childCount < 1) {
			GameObject Item2 = Instantiate (Resources.Load("Wooden Dagger"), slotPanel2.transform) as GameObject;
		}
		else if (slotPanel3.transform.childCount < 1) {
			GameObject Item3 = Instantiate (Resources.Load("Wooden Sword"), slotPanel3.transform) as GameObject;
		}
		else if (slotPanel4.transform.childCount < 1) {
			GameObject Item4 = Instantiate (Resources.Load("Wooden Bow"), slotPanel4.transform) as GameObject;
		}
		else if (slotPanel5.transform.childCount < 1) {
			GameObject Item5 = Instantiate (Resources.Load("Wooden Bow"), slotPanel5.transform) as GameObject;
		}
		else if (slotPanel6.transform.childCount < 1) {
			GameObject Item6 = Instantiate (Resources.Load("Wooden Bow"), slotPanel6.transform) as GameObject;
		}
		else if (slotPanel7.transform.childCount < 1) {
			GameObject Item7 = Instantiate (Resources.Load("Wooden Bow"), slotPanel7.transform) as GameObject;
		}
		else if (slotPanel8.transform.childCount < 1) {
			GameObject Item8 = Instantiate (Resources.Load("Wooden Bow"), slotPanel8.transform) as GameObject;
		}
		else if (slotPanel9.transform.childCount < 1) {
			GameObject Item9 = Instantiate (Resources.Load("Wooden Bow"), slotPanel9.transform) as GameObject;
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
