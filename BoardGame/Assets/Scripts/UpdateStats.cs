using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateStats : MonoBehaviour {

	public Text textStats;
	public Text textType;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		UpdateStatsUI ();
	}
		
	public void UpdateStatsUI(){
		textType.text = StatHolder.CharacterClassName;
		textStats.text = 
			"Dice: " +
			"" + StatHolder.Dice.ToString() +
			"Attack: " +
			"" + StatHolder.Attack.ToString() +
			"Defense: " +
			"" + StatHolder.Defense.ToString() +
			"Speed: " +
			"" + StatHolder.Speed.ToString();
	}
}
