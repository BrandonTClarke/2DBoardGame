using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour {

	//private Item item;
	private string data;
	private GameObject toolTipBar;

	public void Activate(Item item){
		//this.item = item;
	}

	public void TTActivate(){
		//this.item = item;
		//ConstructDataString ();
		toolTipBar.SetActive (true);
	}

	public void TTDeactivate(){

	}

	public void ConstructDataString(){
		//data = item.Title;
	}

	// Use this for initialization
	void Start () {
		toolTipBar = GameObject.Find ("Tool Tip Bar");
		toolTipBar.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
