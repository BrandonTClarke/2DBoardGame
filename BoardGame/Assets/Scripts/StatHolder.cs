using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatHolder {

	public static string CharacterClassName { get; set; }
	//public string CharacterClassDescription { get; set; }
	public static bool CombatStatus { get; set;}
	public static int TotalTurns { get; set; }
	public static int MovesMade { get; set; }

	public static int CurrentHealth{ get; set; }
	public static int MaxHealth { get; set; }
	public static int Muns { get; set; }
	//public int ExperiencePoints { get; set; }
	//public int Level { get; set; } 
	public static int Dice {get; set;}
	public static int Attack {get; set;}
	public static int Defense {get; set;}
	public static int Speed {get; set;}

	public static int weaponHP;
	public static int weaponAttack;
	public static int weaponDefense;
	public static int weaponSpeed;


	/*
	public static void Player1Stat(string characterClassName,int currenthp, int maxhp, int mun, int dice, int attack, int defense, int speed){
		this.CharacterClassName = characterClassName;
		this.CurrentHealth = currenthp;
		this.MaxHealth = maxhp;
		this.Muns = mun;
		this.Dice = dice;
		this.Attack = attack;
		this.Defense = defense;
		this.Speed = speed;
	}
	*/
	/*
	public void Stats () {
		string CharacterClassName = "BLANK";
		int CurrentHealth = 0;
		int Dice = 0;
		int Attack = 0;
		int Defense = 0;
		int Speed = 0;
		int Muns = 0;
		
	}
	*/

	void Start(){
		
	}

	void Update () {
		
	}
}
