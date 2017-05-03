using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter1 : MonoBehaviour {
	public Transform character0;
	public Transform character1;
	public Transform character2;

	public Button button1;
	public Button button2;
	public Button button3;

	//private StatHolder Stats;

	// Use this for initialization
	void Start () {
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
		
	// Update is called once per frame
	void Update () {
		
	}
}
