using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyMasterScript : GameTilesMasterScript
{

	public GameObject player1, player2;
	
	public int price;
	public int hotels;
	
	public bool purchased;
	public bool mortgaged;
	public bool monopoly;
	
	public int[] rentArray = new int[5];
	

	public override void doThing(GameObject playerMovingHere)
	{

		
		if (purchased == false)
		{
			//Prompt: do you want to buy this property?
			//If (wantToBuy == true){
			/* if the player has enough money to buy it{
			 * 			purchased == true
			 * 			money.player-= price
			 *	}
		}*/
			if (playerMovingHere.GetComponent<PlayerMasterScript>().getBalance() >= price)
			{
				this.purchased = true;
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
