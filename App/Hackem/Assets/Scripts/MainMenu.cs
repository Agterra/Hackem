using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture imgTitre;
	public Texture imgJouerS;
	public Texture imgJouerNS;
	public Texture imgDifficulteS;
	public Texture imgDifficulteNS;
	public Texture imgOptionsS;
	public Texture imgOptionsNS;
	public Texture imgQuitterS;
	public Texture imgQuitterNS;

	void onGui(){

		const int buttonWidth = 50;
		const int buttonHeight = 10; 
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 5) - (buttonHeight / 2), buttonWidth, buttonHeight), "Jouer")) {
		}
			
	}
}
