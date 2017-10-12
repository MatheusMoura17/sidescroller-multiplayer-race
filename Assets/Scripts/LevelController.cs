using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

	public static LevelController instance;

	public GameObject winnerPanel;
	public Text winnerText;

	void Awake(){
		instance = this;
	}

	public void Retry(){
		SceneManager.LoadScene ("Game");
	}

	public void SetWinner(int winner){
		winnerPanel.SetActive(true);
		winnerText.text="Player "+winner+" venceu!";
	}
}
