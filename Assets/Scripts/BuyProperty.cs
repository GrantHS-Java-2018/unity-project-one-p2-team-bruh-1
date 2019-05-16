using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyProperty : MonoBehaviour
{

	public Button yesButton;
	public Button noButton;
	public bool answer; 
	
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
		
	}
	
}
