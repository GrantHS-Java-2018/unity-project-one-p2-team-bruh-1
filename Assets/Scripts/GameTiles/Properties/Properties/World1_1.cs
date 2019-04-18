using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World1_1 : PropertyMasterScript
{
	public World1_1()
	{
		price = 60;
		hotels = 0;
		purchased = false;
		mortgaged = false;
		rentArray = new int[5] {0, 0, 0, 0, 0};

	}

	
	
	
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
					
				}
			
			
			
		}

		else if (purchased == true)
		{
			
			
			
			GetComponent<P1Script>().setBalance(-(rentArray[hotels]));
			GetComponent<P2Script>().setBalance(rentArray[hotels]);
			
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
