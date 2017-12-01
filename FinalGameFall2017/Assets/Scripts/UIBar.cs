using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

    public Image bar;
    public Text endGameText;
    public Text coinNum;
    public int totalCoinValue;


    public GameObject gameOverUI;
    public float powerLevel = 0.1f;
    public float amountToAdd = 0.0f;
 public enum PowerUpType {
        PowerUp,
        PowerDown,
        Win
    }
    public PowerUpType powerUp;
	void OnTriggerEnter () {
        switch (powerUp)
        {
            case PowerUpType.PowerUp:
                StartCoroutine(PowerUpBar());
            break;

            case PowerUpType.PowerDown:
                StartCoroutine(PowerDownBar());
                break;
                case PowerUpType.Win:
                    EndGame("You Win!");
                break;
        }
	}
	  IEnumerator PowerUpBar () {
        float tempAmount = bar.fillAmount + powerLevel;
		if (tempAmount > 1) {
			tempAmount = 1;
		}
        while (bar.fillAmount < tempAmount) {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(amountToAdd);
        }
    }
    IEnumerator PowerDownBar() {
        float tempAmount = bar.fillAmount - powerLevel;
       if(tempAmount < 0) {
	   	tempAmount = 0;
	   }
	    while (bar.fillAmount > tempAmount) {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(amountToAdd);

            if (bar.fillAmount == 0) {
              EndGame("Game Over");
            }
        }
    }
    void EndGame (string _text) {
        endGameText.text = _text;
        gameOverUI.SetActive(true);
        CharacterControl.gameOver = true;
    }
}