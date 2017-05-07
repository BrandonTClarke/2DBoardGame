using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB {

	//public GameObject[] Items;
	public static List<GameObject> ItemList = new List<GameObject>();

	public static int itemNum;
	public static GameObject newItem;

	public static void randomItemForInventory(){
		ItemDB.itemNum = Random.Range (0, ItemList.Count - 1);
		//ItemDB.newItem = new GameObject (ItemDB.ItemList [ItemDB.itemNum]) as GameObject;

		/*
		ItemNum = Random.Range (0, Items.Length);
		Items [ItemNum] = ItemDB.newItem;
		*/
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
