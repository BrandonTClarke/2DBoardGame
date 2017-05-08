﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOptions : MonoBehaviour {

	public GameObject slotPanel1;
	public GameObject slotPanel2;
	public GameObject slotPanel3;
	public GameObject slotPanel4;
	public GameObject slotPanel5;
	public GameObject slotPanel6;
	public GameObject slotPanel7;
	public GameObject slotPanel8;
	public GameObject slotPanel9;

	public GameObject weaponSlot;
	public GameObject armorSlot;
	public GameObject accessorySlot;

	public GameObject infoBox;

	public int itemSearchRNG;
	public string ItemToGet;
	public Text infoText;

	public static string infoToDisplay;

	public GameObject itemsInInventory;

	public void SearchSquare(){

		if (slotPanel1.transform.childCount < 1) {
			ItemDB.randomItemForInventory();
			GameObject itemsInInventory = Instantiate(Resources.Load("Bag Of Coins"), slotPanel1.transform) as GameObject;
			Debug.Log("itemnum is...." + ItemDB.itemNum);

		}
		else if (slotPanel2.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Dagger"), slotPanel2.transform) as GameObject;
		}
		else if (slotPanel3.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Sword"), slotPanel3.transform) as GameObject;
		}
		else if (slotPanel4.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Bow"), slotPanel4.transform) as GameObject;
		}
		else if (slotPanel5.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Bow"), slotPanel5.transform) as GameObject;
		}
		else if (slotPanel6.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Bow"), slotPanel6.transform) as GameObject;
		}
		else if (slotPanel7.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Bow"), slotPanel7.transform) as GameObject;
		}
		else if (slotPanel8.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Bow"), slotPanel8.transform) as GameObject;
		}
		else if (slotPanel9.transform.childCount < 1) {
			GameObject itemsInInventory = Instantiate (Resources.Load("Wooden Bow"), slotPanel9.transform) as GameObject;
		}

		StatHolder.MovesMade = 0;
		StatHolder.TotalTurns++;
		Debug.Log ("total turns are: " + StatHolder.TotalTurns);
	}

	public void infoButton(){
		infoBox.SetActive (true);
		infoText.text = ItemOptions.thisItem.GetComponent<ItemAttributes> ().Info;
	}

	public void killInfo(){
		infoBox.SetActive (false);
	}

	public void equipWeapon(Transform weaponSlot){
		ItemOptions.thisItem.transform.SetParent (weaponSlot);
		StatHolder.weaponHP = ItemOptions.thisItem.GetComponent<ItemAttributes> ().MaxHealth;
		StatHolder.weaponAttack = ItemOptions.thisItem.GetComponent<ItemAttributes> ().Attack;
		StatHolder.weaponDefense = ItemOptions.thisItem.GetComponent<ItemAttributes> ().Defense;
		StatHolder.weaponSpeed = ItemOptions.thisItem.GetComponent<ItemAttributes> ().Speed;
		UpdateStats.UpdateWeaponStats ();
		infoBox.SetActive (false);
		ItemOptions.closePanel ();
	}

	public void equipArmor(Transform armorSlot){
		ItemOptions.thisItem.transform.SetParent (armorSlot);
	}

	public void equipAccessory(Transform accessorySlot){
		ItemOptions.thisItem.transform.SetParent (accessorySlot);
	}

	// Use this for initialization
	void Start () {
		infoBox = GameObject.Find ("Info Box");
		infoBox.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
