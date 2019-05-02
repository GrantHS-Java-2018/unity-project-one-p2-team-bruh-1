using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class PropertyMasterScript : GameTilesMasterScript
{

	public GameObject player1, player2;

	public int price;
	public int hotels;

	public bool purchased;
	public bool mortgaged;
	public bool monopoly;

	public int[] rentArray = new int[5];

	public bool wantToBuy()
	{
		SceneManager.LoadScene("BuyProperty", LoadSceneMode.Additive);
		if(GetComponent<Button>().answer == true)
		{
			return true;
		}
		else
		{
			SceneManager.LoadScene("Sample Scene", LoadSceneMode.Single);
			return false;
		}
		
	}
	


	void Update()
	{
		if (player1.GetComponent<FollowingPath>().waypointIndex == PlayerMasterScript.properties[])
		{
			doThing(player1);
		}
		if (player2.GetComponent<FollowingPath>().waypointIndex == PlayerMasterScript.properties[])
		{
			doThing(player2);
		}
	}

	public override void doThing(GameObject playerMovingHere)
	{

		if (playerMovingHere.Equals(player1))
		{
			if (purchased == false) //If it's not purchased
			{
				
				if (wantToBuy() == true) //If the player wants to buy it
					if (playerMovingHere.GetComponent<PlayerMasterScript>().getBalance() >= price) //If the player has enough money to buy it
					{
						purchased = true;
						GetComponent<P1Script>().setBalance(-(this.price));
						GetComponent<P2Script>().setBalance(this.price);
					}
            			
			}
            
			else if (purchased == true)
			{
				GetComponent<P1Script>().setBalance(-(rentArray[hotels]));
				GetComponent<P2Script>().setBalance(rentArray[hotels]);
			}
		}
		else if (playerMovingHere.Equals(player2))
		{
			
			playerMovingHere.GetComponent<PlayerMasterScript>().setBalance(-(rentArray[hotels]));
			if (playerMovingHere.Equals(player1))
			{
				if (wantToBuy() == true) //If the player wants to buy it
					if (playerMovingHere.GetComponent<PlayerMasterScript>().getBalance() >= price) //If the player has enough money to buy it
					{
						purchased = true;
						GetComponent<P2Script>().setBalance(-(this.price));
						GetComponent<P1Script>().setBalance(this.price);
					}
            			
			}
            
			else if (purchased == true)
			{
				GetComponent<P2Script>().setBalance(-(rentArray[hotels]));
				GetComponent<P1Script>().setBalance(rentArray[hotels]);
			}
		}
		else
		{
			Debug.Log("It did not recognize which player landed on this space");
		}
		
		
	}


public int rent(int hotels)
	{
		switch (hotels)
		{
			case 0:
				return rentArray[0];
			case 1:
				return rentArray[1];
			case 2:
				return rentArray[2];
			case 3:
				return rentArray[3];
			case 4:
				return rentArray[4];
		}
		return 0;
	}

	
}
