using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ItemAttributes : MonoBehaviour, IPointerEnterHandler {
	public int MaxHealth;
	public int Muns;
	public int Dice;
	public int Attack;
	public int Defense;
	public int Speed;

	public string Info;

	public ItemType itemType;

	public void cloneAttributes(ItemAttributes attributes){
		MaxHealth = attributes.MaxHealth;
		Muns = attributes.Muns;
		Dice = attributes.Dice;
		Attack = attributes.Attack;
		Defense = attributes.Defense;
		Speed = attributes.Speed;
	}

	public void OnPointerEnter(PointerEventData eventData){
		//Debug.Log ("MOUSE OVER");
		ItemOptions.thisItem = this.gameObject;
		ItemOptions.itemOptionsPopUP ();
	}
}
