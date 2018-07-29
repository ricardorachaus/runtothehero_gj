using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	[SerializeField]
	private Player player;
	[SerializeField]
	private GameObject normalGround;
	[SerializeField]
	private GameObject alternativeGround;
	[SerializeField]
	private float reloadTime;

	[SerializeField]
	private Text menuText;
	[SerializeField]
	private GameObject menuPanel;
	[SerializeField]
	private GameObject startButton;

	private bool isNormalActive;
	private const string LoseMessage = "You Lose!";
	private const string WinMessage = "You Win!";

	private void Start() {
		Time.timeScale = 0f;
		alternativeGround.SetActive(false);
	}

	private void Update() {
		if (player.isDead) {
			ShowMenu(LoseMessage);
		}
		else if (player.won) {
			ShowMenu(WinMessage);
		}
	}

	public void Change() {
		isNormalActive = !isNormalActive;
		normalGround.SetActive(isNormalActive);
		alternativeGround.SetActive(!isNormalActive);
	}

	private void ShowMenu(string message) {
		Time.timeScale = 0f;
		menuPanel.SetActive(true);
		menuText.text = message;
	}

	public void ReloadScene() {
		var sceneName = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(sceneName);
	}

	public void StartGame() {
		Time.timeScale = 1f;
		startButton.SetActive(false);
		menuPanel.SetActive(false);
	}
	
}
