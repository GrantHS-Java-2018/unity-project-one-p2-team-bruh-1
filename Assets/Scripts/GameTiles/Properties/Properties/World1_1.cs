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
		h0rent = 0;
		h1rent = 0;
		h2rent = 0;
		h3rent = 0;
		h4rent = 0;
		
	}

	public override void doThing()
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
			//ActivePlayer.pay(nonActivePlayer, rent(hotels));
		}
	}

	public int rent(int hotels)
	{
		switch (hotels)
		{
			case 0:
				return h0rent;
			case 1:
				return h1rent;
			case 2:
				return h2rent;
			case 3:
				return h3rent;
			case 4:
				return h4rent;
		}
		return 0;
	}
	
	
	

}
