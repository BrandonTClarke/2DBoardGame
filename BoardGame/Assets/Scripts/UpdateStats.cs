using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateStats : MonoBehaviour {

	public Text textType;
	public Text diceStats;
	public Text attackStats;
	public Text defenseStats;
	public Text speedStats;
	public Text hpStats;
	public Text munsStats;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		UpdateStatsUI ();
	}
		
	public void UpdateStatsUI(){
		textType.text = StatHolder.CharacterClassName;
		hpStats.text = StatHolder.CurrentHealth.ToString () + " / " + StatHolder.MaxHealth.ToString ();
		diceStats.text = "Dice: " + StatHolder.Dice.ToString ();
		attackStats.text = "Attack: " + StatHolder.Attack.ToString ();
		defenseStats.text = "Defense: " + StatHolder.Defense.ToString ();
		speedStats.text = "Speed: " + StatHolder.Speed.ToString ();
		munsStats.text = StatHolder.Muns.ToString ();

	}
}
