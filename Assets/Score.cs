using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	int currentScore = 0;
	public UnityEngine.UI.Text text;
	public GameObject victoryScreen;

	public void IncreasScore(int points){
		currentScore += points;
		text.text = currentScore.ToString ();

		if(currentScore>=5){
			victoryScreen.SetActive (true);
		}
	}
}
