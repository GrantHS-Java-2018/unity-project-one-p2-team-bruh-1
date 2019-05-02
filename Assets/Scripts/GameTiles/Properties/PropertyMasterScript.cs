using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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


	void Update()
	{
		if (player1.GetComponent<FollowingPath>().waypointIndex == PlayerMasterScript.properties)
		{
			doThing(player1);
		}
		if (player2.GetComponent<FollowingPath>().waypointIndex == PlayerMasterScript.properties)
		{
			doThing(player2);
		}
	}

	public override void doThing(GameObject playerMovingHere)
	{
		if (purchased == false)
		{
			SceneManager.LoadScene("BuyProperty", LoadSceneMode.Additive);

			if (GetComponent<Button>().answer == true)
			{

				if (playerMovingHere.GetComponent<PlayerMasterScript>().getBalance() >= price)
				{
					this.purchased = true;
					playerMovingHere.GetComponent<PlayerMasterScript>().setBalance(this.price);
				}
			}
		}

		else if (purchased == true)
		{

			playerMovingHere.GetComponent<PlayerMasterScript>().setBalance(-(rentArray[hotels]));
			if (playerMovingHere.Equals(player1))
			{
				player2.GetComponent<PlayerMasterScript>().setBalance(rentArray[hotels]);
			}
			else if (playerMovingHere.Equals(player2))
			{
				player1.GetComponent<PlayerMasterScript>().setBalance(rentArray[hotels]);
			}
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
