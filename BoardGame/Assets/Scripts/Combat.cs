using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combat : MonoBehaviour {

	public GameObject combatArea;

	public Text left1;
	public Text left2;
	public Text left3;
	public Text left4;
	public Text left5;

	public Text right1;
	public Text right2;
	public Text right3;
	public Text right4;
	public Text right5;

	int currentEnemyHealthMax;
	int currentEnemyHealth;
	int currentEnemyAttack;
	int currentEnemyDefense;
	int currentEnemySpeed;
	string currentEnemyName;

	int damageDone;

	public Text combatLog1;
	public Text combatLog2;
	public Text combatLog3;

	public GameObject music;

	public GameObject currentEnemy;
	public GameObject enemyImage;

	public AudioSource combatMusic;
	public AudioSource defaultMusic;

	public void combatStart(){
		combatArea.SetActive (true);
		left1.text = StatHolder.CharacterClassName;
		left2.text = "Health: " + StatHolder.CurrentHealth + " / " + StatHolder.MaxHealth;
		left3.text = "Attack: " + StatHolder.Attack;
		left4.text = "Defense: " + StatHolder.Defense;
		left5.text = "Speed: " + StatHolder.Speed;

		GameObject currentEnemy = Instantiate (Resources.Load("Enemy Stick"), enemyImage.transform) as GameObject;

		currentEnemyName = currentEnemy.GetComponent<EnemyAttributes> ().Name;
		currentEnemyHealthMax = currentEnemy.GetComponent<EnemyAttributes> ().MaxHealth;
		currentEnemyHealth = currentEnemy.GetComponent<EnemyAttributes> ().CurrentHealth;
		currentEnemyAttack = currentEnemy.GetComponent<EnemyAttributes> ().Attack;
		currentEnemyDefense = currentEnemy.GetComponent<EnemyAttributes> ().Defense;
		currentEnemySpeed = currentEnemy.GetComponent<EnemyAttributes> ().Speed;

		right1.text = currentEnemyName;
		right2.text = "Health: " + currentEnemyHealth + " / " + currentEnemyHealthMax;
		right3.text = "Attack: " + currentEnemyAttack;
		right4.text = "Defense: " + currentEnemyDefense;
		right5.text = "Speed: " + currentEnemySpeed;

		defaultMusic.Stop ();
		combatMusic.Play ();

	}

	public void attackStart(){

		if(StatHolder.Speed >= currentEnemySpeed){
			damageDone = StatHolder.Attack - currentEnemyDefense;
			currentEnemyHealth = currentEnemyHealth - damageDone;
			combatLog2.text = "You did " + damageDone + " damage!";
			right2.text =  "Health: " + currentEnemyHealth + " / " + currentEnemyHealthMax;
			if (currentEnemyHealth <= 0) {
				combatLog1.text = "YOU BEAT THE " + currentEnemyName;
				StartCoroutine (wait ());
				combatEnd ();
			} else if (currentEnemyHealth > 0) {
				damageDone = StatHolder.Defense - currentEnemyAttack;
				StatHolder.CurrentHealth = StatHolder.CurrentHealth - damageDone;
				combatLog3.text = "OUCH, you took " + damageDone + " damage!";
				left2.text = "Health: " + StatHolder.CurrentHealth + " / " + StatHolder.MaxHealth;
			}
		}
		else if(StatHolder.Speed < currentEnemySpeed){
			
		}
	}


	public void combatEnd(){
		//Resources.UnloadAsset (currentEnemy);
		combatArea.SetActive (false);
		combatMusic.Stop ();
		defaultMusic.Play ();
	}

	IEnumerator wait(){
		yield return new WaitForSecondsRealtime (100);
	}

	// Use this for initialization
	void Start () {
		combatArea.SetActive (false);
		defaultMusic.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
