using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;

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
		if (playerMovingHere.Equals(player1))
		{
			if (purchased == false) //If it's purchased
            		{
            			if (GetComponent<Button>().answer == true) //If the player wants to buy it
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
			if (purchased == false) //If it's purchased
			{
				if (GetComponent<Button>().answer == true) //If the player wants to buy it
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

	
	

}
