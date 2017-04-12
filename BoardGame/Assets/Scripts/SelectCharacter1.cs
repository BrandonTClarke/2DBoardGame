using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter1 : MonoBehaviour {

	public Button button1;
	public Button button2;
	public Button button3;

	// Use this for initialization
	void Start () {
		
	}
		
	public void OnPressWarrior(){
		//SetDefaultStatsForWarrior ();
		SceneManager.LoadScene ("Board1");
	}

	public void OnPressArcher(){
		//SetDefaultStatsForArcher ();
		SceneManager.LoadScene ("Board1");
	}

	public void OnPressThief(){
		//SetDefaultStatsForThief ();
		SceneManager.LoadScene ("Board1");
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
