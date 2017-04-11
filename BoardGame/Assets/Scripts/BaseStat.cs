using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStat{

	public string CharacterClassName { get; set; }
	//public string CharacterClassDescription { get; set; }

	public int CurrentHealth{ get; set; }
	public int MaxHealth { get; set; }
	public int Muns { get; set; }
	//public int ExperiencePoints { get; set; }
	//public int Level { get; set; }
	public int Dice {get; set;}
	public int Attack {get; set;}
	public int Defense {get; set;}
	public int Speed {get; set;}

	public void Player1Stat(string characterClassName,int currenthp, int maxhp, int mun, int dice, int attack, int defense, int speed){
		this.CharacterClassName = characterClassName;
		this.CurrentHealth = currenthp;
		this.MaxHealth = maxhp;
		this.Muns = mun;
		this.Dice = dice;
		this.Attack = attack;
		this.Defense = defense;
		this.Speed = speed;
	}

}
