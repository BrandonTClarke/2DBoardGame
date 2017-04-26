using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemOptions: MonoBehaviour, IPointerEnterHandler {

	GameObject inventoryPanel;
	GameObject thisItem;
	public static GameObject options;
	public static GameObject option1;
	public static GameObject option2;

	public float StatsUIOffsetY = 60;
	public float StatsUIOffsetX = 60;

	public void OnPointerEnter(PointerEventData eventData){
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


	}

	// Use this for initialization
	void Start () {
		inventoryPanel = GameObject.Find ("Inventory Panel");
		thisItem = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
