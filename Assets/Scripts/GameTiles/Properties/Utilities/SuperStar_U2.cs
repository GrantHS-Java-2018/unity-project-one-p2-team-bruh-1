using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SuperStar_U2 : PropertyMasterScript {
	System.Random rnd = new System.Random();

	public SuperStar_U2()
	{
		price = 150;
		purchased = false;
		mortgaged = false;
		rentArray[0] = (rnd.Next(2, 12)) * 2;
        rentArray[1] = (rnd.Next(2, 12)) * 10;
	}

	
		
}