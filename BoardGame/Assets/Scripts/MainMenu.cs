using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
	public GameObject characterBoxes;

	void start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	public void ExitPress() { //Exit Button
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress() { //If no button pressed, disapear
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void BeginGame() { //Play game BC enter scene
		SceneManager.LoadScene ("NewCharacterSelect");
	}

	public void ExitGame(){ 
		Application.Quit ();
	}
}