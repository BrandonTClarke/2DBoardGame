using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatHolder : MonoBehaviour {

	public Button button1;
	public Button button2;
	public Button button3;

	public string Type = "BLANK";
	public int Dice = 0;
	public int MaxHealth = 0;
	public int CurrentHealth = 0;
	public int Attack = 0;
	public int Defense = 0;
	public int Speed = 0;

	public Text textStats;
	public Text textType;

	/*
	public void InitStatsForCharacterType(CharacterType type){
		switch (type) {
		case CharacterType.Warrior :
			SetDefaultStatsForWarrior ();
			break;
		case CharacterType.Archer :
			SetDefaultStatsForArcher ();
			break;
		case CharacterType.Thief :
			SetDefaultStatsForThief ();
			break;
		default:
			break;
		}
	}
	*/

	public void SetDefaultStatsForWarrior(){
		Type = "Warrior";
		Dice = 3;
		MaxHealth = 12;
		CurrentHealth = 12;
		Attack = 2;
		Defense = 4;
		Speed = 2;
		SceneManager.LoadScene ("Board1");
		textStats = GameObject.Find ("Stats Box").GetComponent<Text> ();
	}

	public void SetDefaultStatsForArcher(){
		Type = "Archer";
		Dice = 3;
		MaxHealth = 10;
		CurrentHealth = 10;
		Attack = 3;
		Defense = 2;
		Speed = 3;
		SceneManager.LoadScene ("Board1");
		textStats = GameObject.Find ("Stats Box").GetComponent<Text> ();
	}

	public void SetDefaultStatsForThief(){
		Type = "Thief";
		Dice = 3;
		MaxHealth = 8;
		CurrentHealth = 8;
		Attack = 4;
		Defense = 2;
		Speed = 3;
		SceneManager.LoadScene ("Board1");
		textStats = GameObject.Find ("Stats Box").GetComponent<Text> ();
	}


	public void UpdateStatsUI(){

		//textType = Type.ToString();
		textStats.text = 
			"Dice: " + Dice.ToString() +
			"Attack: " + Attack.ToString() +
			"Defense: " + Defense.ToString() +
			"Speed: " + Speed.ToString();
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
