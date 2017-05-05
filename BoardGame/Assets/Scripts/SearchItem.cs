using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchItem : MonoBehaviour {

	/*public GameObject slotPanel1;
	public GameObject slotPanel2;
	public GameObject slotPanel3;
	public GameObject slotPanel4;
	public GameObject slotPanel5;
	public GameObject slotPanel6;
	public GameObject slotPanel7;
	public GameObject slotPanel8;
	public GameObject slotPanel9;

	public int itemSearchRNG;
	public string ItemToGet;

	public GameObject itemsInInventory;

	private ItemDB itemForInventory;

	public void SearchSquare(){

		if (slotPanel1.transform.childCount < 1) {
			itemForInventory.randomItemForInventory();
			GameObject itemsInInventory = Instantiate (Resources.Load(ItemDB.ItemList[ItemDB.itemNum]), slotPanel1.transform);


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


	// Use this for initialization
	void Start () {

		itemForInventory = new ItemDB ();
		ItemDB.ItemList.Add(GameObject.FindGameObjectWithTag ("Item"));
		//Items = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/


	/*///////////////////////////////////////
	using System.Collections;
	using UnityEngine.SceneManagement;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	public class CharacterSelection : MonoBehaviour {
		public Button button1;
		public Button button2;
		public Button button3;

		public List<GameObject> characterList;
		public int index = 0;

		void Start () {
			GameObject[] characters = Resources.LoadAll<GameObject> ("Prefab");
			foreach (GameObject c in characters){

				GameObject _char = Instantiate(c) as GameObject;
				_char.transform.SetParent(GameObject.Find("CharacterList").transform);

				characterList.Add(_char);
				_char.SetActive (false);
				characterList [index].SetActive (true);
			}

		}

		public void Next() {
			characterList [index].SetActive(false);
			if(index == characterList.Count - 1){
				index = 0;
			} else {
				index++;
			}
			characterList [index].SetActive (true);
		}

		public void Previous() {
			characterList [index].SetActive(false);
			if(index == 0){
				index = characterList.Count-1;
			} else {
				index--;
			}
			characterList [index].SetActive (true);
		} 

		void Update() {
			characterList [index].transform.Rotate(0,0.5f,0);
		}

		public void SetDefaultStatsForWarrior(){
			StatHolder.CharacterClassName = "Warrior";
			StatHolder.Dice = 3;
			StatHolder.MaxHealth = 12;
			StatHolder.CurrentHealth = 12;
			StatHolder.Attack = 2;
			StatHolder.Defense = 4;
			StatHolder.Speed = 2;
			StatHolder.Muns = 20;
			characterList [index].SetActive (true);
			SceneManager.LoadScene ("Board1");
		}

		public void SetDefaultStatsForArcher(){
			StatHolder.CharacterClassName = "Archer";
			StatHolder.Dice = 3;
			StatHolder.MaxHealth = 10;
			StatHolder.CurrentHealth = 10;
			StatHolder.Attack = 3;
			StatHolder.Defense = 2;
			StatHolder.Speed = 3;
			StatHolder.Muns = 20;
			characterList [index].SetActive (true);
			SceneManager.LoadScene ("Board1");
		}

		public void SetDefaultStatsForThief(){
			StatHolder.CharacterClassName = "Thief";
			StatHolder.Dice = 3;
			StatHolder.MaxHealth = 8;
			StatHolder.CurrentHealth = 8;
			StatHolder.Attack = 4;
			StatHolder.Defense = 2;
			StatHolder.Speed = 3;
			StatHolder.Muns = 20;
			characterList [index].SetActive (true);
			SceneManager.LoadScene ("Board1");
		}
	}


	*/
}
