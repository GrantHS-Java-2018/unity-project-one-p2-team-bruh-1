using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower_U1 : PropertyMasterScript {
	Random random = new Random();
	public FireFlower_U1()
	{
		price = 150;
		purchased = false;
		mortgaged = false;
		rentArray = new [] {0, 0, 0, 0, 0};
		
		
	}

	public void doThing(GameObject player)
	{
		int amountRolled = 0 + 0;
		
		if (purchased == false)
		{
			if (wantToBuy == true)
			{
				if (player.GetComponent<PlayerScript>().balance > 150)
				{
					
				}
			}
			//Prompt: do you want to buy this property?
			//If (wantToBuy == true){
			/* if the player has enough money to buy it{
			 * 			purchased == true
			 * 			money.activePlayer-= price
			 *	}
		}*/
			player.purchase(fireFlowerU1);
		}

		if (purchased == true)
		{
			if (monopoly == true)
			{
				player.pay(player, otherPlayer, amountRolled * 10);
			}
			else
			{
				player.pay(player, otherPlayer, amountRolled * 2);
			}
		}
	}

}
