using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BuyPropertyAnswer : MonoBehaviour
{

	public Button yesButton;
	public Button noButton;
	public bool answer = false; 
	
	void Start () {
		yesButton.onClick.AddListener(wantToBuy);
		noButton.onClick.AddListener(noBuy);
	}

	public void wantToBuy()
	{
		answer = true;
	}

	public void noBuy()
	{
		answer = false;
		SceneManager.LoadScene("Sample Scene");
	}

	public bool getAnswer()
	{
		return answer;
	}
}
