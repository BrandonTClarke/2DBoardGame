using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	Items database;
	GameObject equipmentPanel;
	GameObject inventoryPanel;
	GameObject equipslotpanel;
	GameObject slotPanel;
	public GameObject inventorySlot;
	public GameObject inventoryItem;
	int slotAmount;
	int equipAmount;

	public List<Item> items = new List<Item>();
	public List<GameObject> slots = new List<GameObject>();
	public List<GameObject> Eslots = new List<GameObject> ();

	void Start()
	{
		database = GetComponent<Items> ();
		slotAmount = 9;
		inventoryPanel = GameObject.Find ("Inventory Panel");
		slotPanel = inventoryPanel.transform.FindChild ("Slot Panel").gameObject;
		for (int i = 0; i < slotAmount; i++) 
		{
			slots.Add (Instantiate (inventorySlot));
			slots [i].transform.SetParent (slotPanel.transform);
			items.Add (new Item ());
			//Debug.Log ("Slot made!");
		}
		equipAmount = 3;
		equipmentPanel = GameObject.Find ("Equipment Panel");
		equipslotpanel = equipmentPanel.transform.FindChild ("Equipment Slots").gameObject;
		for (int i = 0; i < equipAmount; i++) 
		{
			Eslots.Add (Instantiate (inventorySlot));
			Eslots [i].transform.SetParent (equipslotpanel.transform);
			items.Add (new Item ());
			//Debug.Log ("Equipment slot made!");
		}

		//AddItem (2);
		//AddItem (1);
	}

	public void AddItem(int id)
	{
		Item itemToAdd = database.FetchItemByID (id);
		for (int i = 0; i < items.Count; i++) 
		{
			if (items [i].ID == -1) 
			{
				items [i] = itemToAdd;
				GameObject itemObj = Instantiate (inventoryItem);
				itemObj.GetComponent<ItemData> ().item = itemToAdd;
				itemObj.transform.SetParent (slots [i].transform);
				itemObj.transform.position = Vector2.zero;
				itemObj.GetComponent<Image> ().sprite = itemToAdd.Sprite;
				itemObj.name = itemToAdd.Title;
				break;
			}
		}
	}
}
