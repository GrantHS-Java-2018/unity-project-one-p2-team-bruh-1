using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World1_1 : PropertyMasterScript
{

	public World1_1()
	{
		price = 60;
		hotels = 0;
	}
	
	public override void MakeSound()
	{
		Debug.Log("woof");
	}
}
