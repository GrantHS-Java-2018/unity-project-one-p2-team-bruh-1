using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropertyMasterScript : GameTilesMasterScript
{

	public int price;
	public int hotels;
	
	public bool purchased;
	public bool mortgaged;
	public bool monopoly;

	public int[] rentArray = new int[5];

	public virtual void rent()
	{
		
	}

}
