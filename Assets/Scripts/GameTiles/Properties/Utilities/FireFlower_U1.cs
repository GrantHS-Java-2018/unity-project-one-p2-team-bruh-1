using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower_U1 : PropertyMasterScript {

	public FireFlower_U1()
	{
		price = 150;
		purchased = false;
		mortgaged = false;
		h0rent = 0;
		
		
	}

	public override void doThing()
	{
		if (purchased == false)
		{
			//Prompt: do you want to buy this property?
			//If (wantToBuy == true){
			/* if the player has enough money to buy it{
			 * 			purchased == true
			 * 			money.activePlayer-= price
			 *	}
		}*/	
		}

		if (purchased == true)
		{
			if (monopoly == true)
			{
				
			}
			else
			{
				
			}
		}
	}

}
