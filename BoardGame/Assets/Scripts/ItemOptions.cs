using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemOptions: MonoBehaviour {

	GameObject inventoryPanel;
	public static GameObject options;
	public static GameObject option1;
	public static GameObject option2;
	public static GameObject option3;
	public static GameObject option12;
	public static GameObject option13;
	public static GameObject option14;
	public static GameObject option15;
	public static GameObject option16;

	public static GameObject thisItem;

	public float StatsUIOffsetY = 60;
	public float StatsUIOffsetX = 60;

	public static void itemOptionsPopUP(){
		if (options.activeInHierarchy == false) {
			options.SetActive (true);
			option2.SetActive (true);
			option3.SetActive (true);
			options.transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y);

			if (ItemOptions.thisItem.GetComponent<ItemAttributes> ().itemType == ItemType.Weapon && StatHolder.isWeaponEquip == false) {
				option1.SetActive (true);
			}
			if (ItemOptions.thisItem.GetComponent<ItemAttributes> ().itemType == ItemType.Armor && StatHolder.isArmorEquip == false ) {
				option12.SetActive (true);
			}
			if (ItemOptions.thisItem.GetComponent<ItemAttributes> ().itemType == ItemType.Accessory && StatHolder.isAccessoryEquip == false) {
				option13.SetActive (true);
			}
		}


		/*
		if (inventoryPanel.transform.FindChild ("Option Panel(Clone)") == null) {
			GameObject options = Instantiate (Resources.Load ("Option Panel"), Input.mousePosition, Quaternion.identity, inventoryPanel.transform) as GameObject;
			if (thisItem.GetComponent<ItemAttributes> ().itemType == ItemType.Weapon) {
				GameObject option1 = Instantiate(Resources.Load("Option Button Equip"), options.transform) as GameObject;
			}
			else if (thisItem.GetComponent<ItemAttributes> ().itemType == ItemType.Armor) {
				GameObject option1 = Instantiate(Resources.Load("Option Button Equip"), options.transform) as GameObject;
			}
			else if (thisItem.GetComponent<ItemAttributes> ().itemType == ItemType.Accessory) {
				GameObject option1 = Instantiate(Resources.Load("Option Button Equip"), options.transform) as GameObject;
			}
			GameObject option2 = Instantiate(Resources.Load("Option Button Close"), options.transform) as GameObject;
		}
		*/
	}

	public void closePanel1(){
		ItemOptions.closePanel ();
	}

	public static void closePanel(){
		options.SetActive (false);
		option1.SetActive (false);
		option12.SetActive (false);
		option13.SetActive (false);
		option2.SetActive (false);
		option3.SetActive (false);

	}

	// Use this for initialization
	void Start () {
		inventoryPanel = GameObject.Find ("Inventory Panel");
		options = GameObject.Find ("Option Panel");
		option1 = GameObject.Find ("Option Button Equip Weapon");
		option12 = GameObject.Find ("Option Button Equip Armor");
		option13 = GameObject.Find ("Option Button Equip Accessory");
		option14 = GameObject.Find ("Option Button Unequip Weapon");
		option15 = GameObject.Find ("Option Button Unequip Armor");
		option16 = GameObject.Find ("Option Button Unequip Accessory");
		option2 = GameObject.Find ("Option Button Info");
		option3 = GameObject.Find ("Option Button Close");
		options.SetActive (false);
		option1.SetActive (false);
		option12.SetActive (false);
		option13.SetActive (false);
		option14.SetActive (false);
		option15.SetActive (false);
		option16.SetActive (false);
		option2.SetActive (false);
		option3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
