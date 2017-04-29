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
		SceneManager.LoadScene ("Board1");
	}
}
