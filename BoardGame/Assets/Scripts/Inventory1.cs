using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory1 : MonoBehaviour {

	GameObject inventoryPanel;
	GameObject slotPanel;

	public GameObject itemSlot1;
	public GameObject itemSlot2;
	public GameObject itemSlot3;
	public GameObject itemSlot4;
	public GameObject itemSlot5;
	public GameObject itemSlot6;
	public GameObject itemSlot7;
	public GameObject itemSlot8;
	public GameObject itemSlot9;

	void Start(){
		inventoryPanel = GameObject.Find ("Inventory Panel");
		slotPanel = inventoryPanel.transform.FindChild ("Slot Panel").gameObject;
	}

	public bool AddItem(GameObject obj){

		if (itemSlot1.transform.childCount == 0) {
			Instantiate (itemSlot1, slotPanel.transform);
			return true;
		}
		if (itemSlot2.transform.childCount == 0) {
			Instantiate (itemSlot2, slotPanel.transform);
			return true;
		}

		if (itemSlot3.transform.childCount == 0) {
			Instantiate (itemSlot3, slotPanel.transform);
			return true;
		}

		if (itemSlot4.transform.childCount == 0) {
			Instantiate (itemSlot4, slotPanel.transform);
			return true;
		}

		if (itemSlot5.transform.childCount == 0) {
			Instantiate (itemSlot5, slotPanel.transform);
			return true;
		}

		if (itemSlot6.transform.childCount == 0) {
			Instantiate (itemSlot6, slotPanel.transform);
			return true;
		}

		if (itemSlot7.transform.childCount == 0) {
			Instantiate (itemSlot7, slotPanel.transform);
			return true;
		}

		if (itemSlot8.transform.childCount == 0) {
			Instantiate (itemSlot8, slotPanel.transform);
			return true;
		}

		if (itemSlot9.transform.childCount == 0) {
			Instantiate (itemSlot9, slotPanel.transform);
			return true;
		}

		return false;
	}

}
