using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAttributes : MonoBehaviour {
	public int MaxHealth;
	public int Muns;
	public int Dice;
	public int Attack;
	public int Defense;
	public int Speed;

	public void cloneAttributes(ItemAttributes attributes){
		MaxHealth = attributes.MaxHealth;
		Muns = attributes.Muns;
		Dice = attributes.Dice;
		Attack = attributes.Attack;
		Defense = attributes.Defense;
		Speed = attributes.Speed;
	}
}
