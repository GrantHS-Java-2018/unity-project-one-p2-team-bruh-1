using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackedByABulletBill : GameTilesMasterScript {
	public override void doThing(GameObject playerMovingHere)
	{
		if (GetComponent<GameControl>().player2.GetComponent<FollowingPath>().moveAllowed == false)
		{
			GetComponent<P1Script>().setBalance(-100);
		}
		else
		{
			GetComponent<P2Script>().setBalance(-100);
		}	
	}
}
