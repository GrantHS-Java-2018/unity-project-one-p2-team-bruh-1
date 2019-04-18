using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperStar_U2 : PropertyMasterScript {
	Random rnd = new Random();

	public SuperStar_U2()
	{
		price = 150;
		purchased = false;
		mortgaged = false;
		
		
	}

	public void doThing()
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
		}

		if (purchased == true)
		{
			//int amountRolled = rnd.Next(1, 7);
			//amountRolled += rnd.Next(1, 7);
		
			if (monopoly == true)
			{
			//	int rent = amountRolled * 10;

			}
			else
			{
			//	int rent = amountRolled * 4;

			}
		}
	}
}